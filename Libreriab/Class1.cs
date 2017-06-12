using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// para uso del data set
using System.Data.SqlClient;// para el uso de de consulta de sql o crear la cadena de conexion 


namespace Libreriab
{
    public class Utileria 
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection ConnetiongString = new SqlConnection("Data Source=.;Initial Catalog=saewin;Integrated Security=True");
            ConnetiongString.Open(); // Este hace la conexion con la base de dato de SQL

            DataSet DS = new DataSet();//Este Metodo sirve para hacer las consultas y guardarlos 
            SqlDataAdapter DP = new SqlDataAdapter(cmd,ConnetiongString); //Esto sirver para adaptar los  datos que trae la consulta al DataSet

            DP.Fill(DS);// Esto rellena el DataSet que se le paso por parametro

            ConnetiongString.Close();// finaliza la conexion

            return DS;//devuelve el DataSet
        }

      

    }
}
