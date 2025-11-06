using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvpoo
{
    internal class Aluno
    {
        private string? prontuario;
        private string? nome;
        private string? cpf ;
        private string? rg;
        private string? email;

        // GET E SET 

        public string Prontuario
        {
            get { return prontuario!; }
            set {
                if (!Validacoes.ValidaProntuario(value))
                    throw new Exception("Prontuário Inválido! " + value);
                else
                    prontuario = value;
            }
        }
        public string Nome
        {
            get { return nome!; }
            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get { return cpf!; }
            set {
                if (!Validacoes.ValidaCPF(value))
                    throw new Exception("Cpf Inválido! " + value);
                else
                    cpf = value;
                
            }
        }

        public string Rg
        {
            get { return rg!; }
            set
            {
                if (!Validacoes.ValidaRG(value))
                    throw new Exception("Rg Inválido! " + value);
                else 
                   rg = value;
            }
        }

        public string Email
        {
            get { return email!; }
            set { email = value; }

        }
        
    }
}
