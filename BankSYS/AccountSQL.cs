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
            A.AccountId = ReusableSQL.GetNextId(Acc).ToString("D9");

            String CustSQL = "INSERT INTO Account(AccountID,Customerid,name,type,Date_created) " +
            "VALUES('" + A.AccountId + "', '" + Customer.CustomerId + "', '" + A.Name + "', '" + A.Type + "', TO_DATE('" + A.Creation + "', 'DD/MM/YYYY'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int FindAccounts()
        {
            //define Sql Query
            String strSQL = "SELECT COUNT(*) FROM Account WHERE Customerid = " + Customer.CustomerId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            
            dr.Read();
            int count = Int16.Parse(dr[0].ToString());
            conn.Close();
            return count;

        }


    }
}
