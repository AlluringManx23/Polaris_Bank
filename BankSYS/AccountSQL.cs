using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace BankSYS
{
    class AccountSQL
    {
        public static void AddAccount(ref Account A)
        {
            string[] Acc = { "Accountid", "Account" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            A.AccountId = Reusable.GetNextId(Acc).ToString("D9");

            String CustSQL = "INSERT INTO Account(AccountID,Customerid,name,type,Date_created) " +
            "VALUES('" + A.AccountId + "', '" + Customer.CustomerId + "', '" + A.Name + "', '" + A.Type + "', TO_DATE('" + A.Creation + "', 'DD/MM/YYYY'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int FindActiveAccounts()
        {
            //define Sql Query
            String strSQL = "SELECT COUNT(*) FROM Account WHERE status = 'A' AND Customerid = " + Customer.CustomerId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();


            dr.Read();
            int count = Int16.Parse(dr[0].ToString());
            conn.Close();
            return count;

        }

        public static bool AccountNameExists(string s)
        {
            bool exists = true;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String CustSQL = "Select Accountid FROM Account WHERE Status = 'A' AND Name = '" + s + "'";

            OracleCommand cmd = new OracleCommand(CustSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
                exists = true;
            else
                exists = false;
            conn.Close();

            return exists;

        }

        public static bool AccountExists(string s)
        {
            bool exists;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String CustSQL = "Select Accountid FROM Account WHERE Status = 'A' AND Accountid = '" + s + "'";

            OracleCommand cmd = new OracleCommand(CustSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
                exists = true;
            else
                exists = false;
            conn.Close();

            return exists;

        }

        public static void CloseAccount(string s)
        {
            //define Sql Query
            String strSQL = "update Account set status = 'C', Date_Closed = TO_DATE('" + DateTime.Now.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY') WHERE Accountid = " + s;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool AllBalanceEmpty()
        {
            //define Sql Query
            bool exists;

            String strSQL = "Select * From Account WHERE NOT BALANCE = '0.00' AND CustomerID = " + Customer.CustomerId;
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
                exists = false;
            else
                exists = true;
            conn.Close();

            return exists;
        }

        public static void CloseCustAccounts()
        {
            //define Sql Query
            String strSQL = "update Account set status = 'C', date_closed = TO_DATE('" + DateTime.Now.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY') WHERE CustomerID = " + Customer.CustomerId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
