using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSYS
{
    class FillfromDB
    {
        /*fillcbo uses parameters to pull multiple columnes for any table
         *How to use:
         *Fill array with columns you want
         *last entery into the array is the table you want to pull data from
        */
        public static DataSet dsfromsql(string[] s)
        {
            //define Sql Query
            String strSQL = "SELECT";

            int l = s.Length;
            l = l - 1;
            int i = 0;
            while(i<(l-1))
            {
                strSQL = strSQL + " " + s[i] + ",";
                i++;
            }

            strSQL = strSQL + " " + s[i];

            strSQL = strSQL + " FROM " + s[l];

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "FS");

            //Close database connection
            conn.Close();

            return ds;
        }
    }
}
