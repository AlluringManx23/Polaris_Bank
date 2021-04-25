using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace BankSYS
{
    class ReusableSQL
    {
        /*GetNextId Optimised for reuse.
         *How to use:
         *Create array where first index is the ID column
         *and second is the table name.
         *pass array into GetNextId, get NextID as int
         */
        public static int GetNextId(string[] s)
        {
            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(" + s[0] + ") FROM " + s[1];

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr[0] == DBNull.Value)
                last = 1;
            else
                last = Convert.ToInt32(dr[0]) + 1;
            conn.Close();

            return last;
        }

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
            while (i < (l - 1))
            {
                strSQL = strSQL + " " + s[i] + ",";
                i++;
            }

            strSQL = strSQL + " " + s[i];

            strSQL = strSQL + " FROM " + s[l];

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "FS");

            conn.Close();

            return ds;
        }
    }
}
