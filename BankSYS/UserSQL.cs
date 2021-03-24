using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSYS
{
    class UserSQL
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

            String strSQL = "SELECT MAX(" + s[0] + ") FROM "+ s[1];

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

        public static void AddUser()
        {
            string[] Cust = { "Customerid", "Customer" };
            string[] Log = { "Loginid", "Login" };
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            Data.Id = GetNextId(Cust).ToString("D8");
            
            String CustSQL = "INSERT INTO Customer(Customerid,first_name,last_name,pps_number,country_code,phone_number,date_of_birth,address_line_1,address_line_2,address_line_3,town,county,eircode,date_created) " +
            "VALUES('" + Data.Id + "', '" + Data.Fname + "', '" + Data.Lname + "', '" + Data.PPSNo + "', '" + Data.CountryCode + "', '" + Data.PhoneNo + "', TO_DATE('" + Data.DOB + "', 'DD/MM/YYYY'), '" + Data.AddressL1 + "', '" + Data.AddressL2 + "', '" + Data.AddressL3 + "', '" + Data.Town + "', '" + Data.County + "', '" + Data.Eir + "', TO_DATE('" + Data.DateCreated + "', 'DD/MM/YYYY'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            string LogId = GetNextId(Log).ToString("D8");

            String LogSQL = "INSERT INTO Login(Loginid,Customerid,pac) " +
            "VALUES('" + LogId + "', '" + Data.Id + "', '" + Data.pac + "')";

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet GetUser()
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

        public static bool IsInUse(string s)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Customer where pps_number = '" + s + "'";
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if(dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
