using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno
{
    internal class Conexao
    {
        public static string ConnectionString { get; private set; }

        static Conexao()
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                ConnectionString = config.GetConnectionString("MySqlConnection")!;

                if (string.IsNullOrEmpty(ConnectionString))
                    throw new Exception("ConnectionString não foi carregada.");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inicializar a classe Conexao", ex);
            }
        }
    }
}
