using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3.DAL
{
    public class Database
    {


        public static string getStrconnection()
        {
            return Settings.Default.empleadosConnectionString;
                }
        public SqlConnection GetConnection()
        { 
         SqlConnection Con = new SqlConnection(getStrconnection());
            return Con;
}
