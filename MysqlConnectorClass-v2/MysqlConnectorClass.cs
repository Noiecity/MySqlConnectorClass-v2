using MySql.Data.MySqlClient;
using System.Data;


namespace MysqlConnectorClass_v2
{
    public class ConexiónMysql
    {
        //Para usar Mysql y bases de datos no relacionales (noSql) en conjunto.
        /* 
        public string SERVIDORMYSQL = Properties.Settings.Default.SERVIDORMYSQL;
        public string BASEDEDATOSMYSQL = Properties.Settings.Default.BASEDEDATOSMYSQL;
        public string USUARIOMYSQL = Properties.Settings.Default.USUARIOMYSQL;
        public string CONTRASEÑAMYSQL = Properties.Settings.Default.CONTRASEÑAMYSQL;
        */
        
        public string SERVIDORMYSQL = "localhost";
        public string BASEDEDATOSMYSQL = "db";
        public string USUARIOMYSQL = "usuario";
        public string CONTRASEÑAMYSQL = "contraseña";
        public string sql
        {
            get
            {
                return "SELECT * FROM `frutango`.`nombres`";
            }
        }
        public DataTable dt { get { return new DataTable(); } }

        public string StringConexiónMysql
        {
            get
            {
                return "SERVER=" + SERVIDORMYSQL + ";" + "DATABASE=" + BASEDEDATOSMYSQL + ";" + "UID=" + USUARIOMYSQL + ";" + "PASSWORD=" + CONTRASEÑAMYSQL + ";";
            }
        }
        public MySqlConnection NuevaConexiónMysql
        {
            get
            {
                return new MySqlConnection(StringConexiónMysql);
            }
        }


        public bool AbrirConexión()
        {
            try
            {
                NuevaConexiónMysql.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public bool CerrarConexión()
        {
            try
            {
                NuevaConexiónMysql.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
    }
}
