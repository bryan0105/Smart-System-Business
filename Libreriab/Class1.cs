using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Libreriab
{
    public class Utileria 
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection ConnetiongString = new SqlConnection("Data Source=.;Initial Catalog=saewin;Integrated Security=True");
            ConnetiongString.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd,ConnetiongString);

            DP.Fill(DS);

            ConnetiongString.Close();

            return DS;
        }
    }
}
