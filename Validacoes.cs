using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvpoo
{
    public static class  Validacoes
    {
        public static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            if (cpf.Length != 11) return false;

            // Valida 1º e 2º dígitos
            return ValidarDigito(cpf, 9) && ValidarDigito(cpf, 10);
        }
        private static bool ValidarDigito(string cpf, int indice)
        {
            int soma = 0;
            int peso = indice == 9 ? 10 : 11;

            for (int i = 0; i < indice; i++)
                soma += int.Parse(cpf[i].ToString()) * (peso - i);

            int resto = soma % 11;
            int digito = resto < 2 ? 0 : 11 - resto;

            return digito.ToString() == cpf[indice].ToString();
        }

        public static bool ValidaRG(string rg)
        {
            rg = rg.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            if (rg.Length != 9) return false;

            int soma = 0;
            for (int i = 0; i < 8; i++)
                soma += int.Parse(rg[i].ToString()) * (2 + i);

            int resto = soma % 11;
            string digito = resto == 10 ? "X" : (resto == 0 ? "0" : (11 - resto).ToString());

            return digito == rg[8].ToString();
        }
        public static bool ValidaProntuario (string prontuario)
        {
            if (prontuario.Length != 9) return false;
            string numeros = prontuario.Substring(2, 6);
            string digito = prontuario.Substring(8, 1).ToUpper();

            int soma = 0;
            int[] pesos = { 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < pesos.Length; i++)
                soma += int.Parse(numeros[i].ToString()) * pesos[i];

            int resto = soma % 11;
            string digitocalculado = (11 - resto) switch
            {
                10 => "X",
                11 => "1",
                _ => (11 - resto).ToString()
            };

            return digito == digitocalculado;
        }

    }
}
