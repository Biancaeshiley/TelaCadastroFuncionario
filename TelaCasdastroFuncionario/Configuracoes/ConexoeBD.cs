using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaCasdastroFuncionario.Configuracoes
{
    internal class ConexoeBD
    {
        private string _servidor = "localhost";

        private string _porta = "3360";

        private string _usuario = "root";

        private string _senha = "root";

        private string _bancoDadosNome = "empresa_x2A_bd";

        private MySqlConnection connection;

        private MySqlCommand command;

        public ConexoeBD() 
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta};user={_usuario};password={_senha}");
                connection.Open();
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = comando;

                return command;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

    }
}
