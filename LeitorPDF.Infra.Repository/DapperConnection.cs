using System.Configuration;
using System.Data.SqlClient;


namespace LeitorPDF.Infra.Repository
{
    public class DapperConnection
    {
        public static SqlConnection ConTeste
        {
            get { return new SqlConnection(ConfigurationManager.ConnectionStrings["KurierTeste"].ConnectionString); }
        }

        public static SqlConnection Con
        {
            get { return new SqlConnection(ConfigurationManager.ConnectionStrings["Kurier"].ConnectionString); }
        }

      
    }
}
