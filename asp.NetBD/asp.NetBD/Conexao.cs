using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.NetBD
{
    public class Conexao
    {
        #region Parâmetros de Conexão
        private static string Server = "localhost";
        private static string Database = "web_cliente";
        private static string User = "root";
        private static string Password = "654321";
        private static string connectionString = $@"Server={Server};Database={Database};Uid={User};Pwd={Password};
                                                 SslMode=none;Charset=utf8;";
        #endregion

        //Trazer a biblioteca do MySQL Cinnector
        public static MySqlConnection Connection = new MySqlConnection(connectionString);

        #region Conectar
        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        #endregion

        #region Desconectar
        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        #endregion
    }
}