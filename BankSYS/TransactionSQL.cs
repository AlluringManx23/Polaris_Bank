using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
namespace BankSYS
{
    class TransactionSQL
    {
        public static void Deposit(ref Transaction T)
        {
            string[] Transaction = { "transactionid ", "Transaction" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            T.id = Reusable.GetNextId(Transaction).ToString("D14");
            T.timestamp = DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");

            String CustSQL = "INSERT INTO Transaction(transactionid,accountid,Type,amount,note,timestamp) " +
            "VALUES('" + T.id + "', '" + T.account + "', '" + T.type + "', '" + T.amount + "', '" + T.note + "', TO_DATE('" + T.timestamp + "', 'DD/MM/YYYY HH24:MI:SS'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();


            string[] findbalance = { "balance", "account where accountid = " + T.account };
            string balance = Reusable.stringfromDB(findbalance);
            decimal d1 = decimal.Parse(balance);
            decimal d2 = decimal.Parse(T.amount);
            string newbalance = (d1 + d2).ToString("F2");

            String LogSQL = "UPDATE Account SET BALANCE = '" + newbalance + "' where accountid = " + T.account;

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void Withdraw(ref Transaction T)
        {
            string[] Transaction = { "transactionid ", "Transaction" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            T.id = Reusable.GetNextId(Transaction).ToString("D14");
            T.timestamp = DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");

            String CustSQL = "INSERT INTO Transaction(transactionid,accountid,Type,amount,note,timestamp) " +
            "VALUES('" + T.id + "', '" + T.account + "', '" + T.type + "', '" + T.amount + "', '" + T.note + "', TO_DATE('" + T.timestamp + "', 'DD/MM/YYYY HH24:MI:SS'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            string[] findbalance = { "balance", "account where accountid = " + T.account };
            string balance = Reusable.stringfromDB(findbalance);
            decimal d1 = decimal.Parse(balance);
            decimal d2 = decimal.Parse(T.amount);

            string newbalance = (d1 - d2).ToString("F2");

            String LogSQL = "UPDATE Account SET BALANCE = '" + newbalance + "' where accountid = " + T.account;

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool CheckBalance(ref Transaction T)
        {
            string[] Checkbalance = { "balance", "account where accountid = " + T.account };
            
            string balance = Reusable.stringfromDB(Checkbalance);
            
            decimal d1 = decimal.Parse(balance);
            decimal d2 = decimal.Parse(T.amount);
            
            if (d1 >= d2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Transfer(ref Transaction T)
        {
            string[] Transaction = { "transactionid ", "Transaction" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            T.id = Reusable.GetNextId(Transaction).ToString("D14");
            T.timestamp = DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");

            String transferSQL = "INSERT INTO Transaction(transactionid,accountid,Type,amount,note,timestamp) " +
            "VALUES('" + T.id + "', '" + T.account + "', '" + T.type + "', '" + T.amount + "', '" + T.note + "', TO_DATE('" + T.timestamp + "', 'DD/MM/YYYY HH24:MI:SS'))";

            OracleCommand Transfercmd = new OracleCommand(transferSQL, conn);
            Transfercmd.ExecuteNonQuery();

            string[] creditorarr = { "balance", "account where accountid = " + T.account };
            string[] debtorarr = { "balance", "account where accountid = " + T.debtor };
            string creditorbal = Reusable.stringfromDB(creditorarr);
            string debtorbal = Reusable.stringfromDB(debtorarr);
            
            decimal Cbal = decimal.Parse(creditorbal);
            decimal amount = decimal.Parse(T.amount);
            decimal Dbal = decimal.Parse(debtorbal);
            
            string newCreditorbal = (Cbal - amount).ToString("F2");
            string newDebtorbal = (Dbal + amount).ToString("F2");

            String removebal = "UPDATE Account SET BALANCE = '" + newCreditorbal + "' where accountid = " + T.account;
            String addbal = "UPDATE Account SET BALANCE = '" + newDebtorbal + "' where accountid = " + T.debtor;

            OracleCommand removebalance = new OracleCommand(removebal, conn);
            removebalance.ExecuteNonQuery();

            OracleCommand addbalance = new OracleCommand(addbal, conn);
            addbalance.ExecuteNonQuery();

            conn.Close();
        }

        public static void Pay(ref Transaction T)
        {
            string[] Transaction = { "transactionid ", "Transaction" };

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            T.id = Reusable.GetNextId(Transaction).ToString("D14");
            T.timestamp = DateTime.Now.ToString("dd/MM/yyyy/HH:mm:ss");

            String CustSQL = "INSERT INTO Transaction(transactionid,accountid,Type,amount,note,timestamp) " +
            "VALUES('" + T.id + "', '" + T.account + "', '" + T.type + "', '" + T.amount + "', '" + T.note + ",'" + T.debtor + "', TO_DATE('" + T.timestamp + "', 'DD/MM/YYYY HH24:MI:SS'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            string[] findbalance = { "balance", "account where accountid = " + T.account };
            string balance = Reusable.stringfromDB(findbalance);
            decimal d1 = decimal.Parse(balance);
            decimal d2 = decimal.Parse(T.amount);

            string newbalance = (d1 - d2).ToString("F2");

            String LogSQL = "UPDATE Account SET BALANCE = '" + newbalance + "' where accountid = " + T.account;

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
