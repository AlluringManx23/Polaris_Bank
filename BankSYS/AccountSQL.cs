using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSYS
{
    class AccountSQL
    {
        public static int GetNextId()
        {
            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(Accountid) FROM Accounts";

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

        public static void AddAccount(Data d)
        {
            d.id = GetNextId();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "INSERT INTO accounts(accountid,first_name,last_name,pps_number,country_code,phone_number,date_of_birth,address_line_1,address_line_2,address_line_3,town,county,eircode,date_created) " +
            "VALUES(" + d.id + ", '" + d.fname + " ', '" + d.lname + "', '" + d.ppsno + "', '" + d.countrycode + "', '" + d.phoneno + "', TO_DATE('" + d.dob + "', 'DD/MM/YYYY'), '" + d.addressl1 + "', '" + d.addressl2 + "', '" + d.addressl3 + "', '" + d.town + "', '" + d.county + "', '" + d.eir + "', TO_DATE('" + d.datecreated + "', 'DD/MM/YYYY'))";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getCustomer()
        {
            //define Sql Query
            String strSQL = "SELECT accountid, first_name, last_name,date_of_birth FROM Accounts";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "WS");

            //Close database connection
            conn.Close();

            return ds;
        }

    }
}
