using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
namespace BankSYS
{
    class TransactionSQL
    {
        public static void Deposit(ref Transaction T)
        {
            string[] Transaction = { "transactionid ", "Transactions" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            T.id = ReusableSQL.GetNextId(Transaction).ToString("D14");
            T.timestamp = DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");

            String CustSQL = "INSERT INTO Transaction(transactionid,account,Type,amount,note,timestamp) " +
            "VALUES('" + T.id + "', '" + T.account + "', '" + T.type + "', '" + T.amount + "', '" + T.note + "', TO_DATE('" + T.timestamp + "', 'DD/MM/YYYY HH24:MI:SS'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            String LogSQL = "UPDATE Account(Balance) " +
            "VALUES('" + 1234.00 + "') where accountid = " + T.account;

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
