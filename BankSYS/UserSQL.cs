﻿using Oracle.ManagedDataAccess.Client;
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
            Customer.CustomerId = GetNextId(Cust).ToString("D8");
            
            String CustSQL = "INSERT INTO Customer(Customerid,first_name,last_name,pps_number,country_code,phone_number,date_of_birth,address_line_1,address_line_2,address_line_3,town,county,eircode,date_created) " +
            "VALUES('" + Customer.CustomerId + "', '" + Customer.Fname + "', '" + Customer.Lname + "', '" + Customer.PPSNo + "', '" + Customer.CountryCode + "', '" + Customer.PhoneNo + "', TO_DATE('" + Customer.DOB + "', 'DD/MM/YYYY'), '" + Customer.AddressL1 + "', '" + Customer.AddressL2 + "', '" + Customer.AddressL3 + "', '" + Customer.Town + "', '" + Customer.County + "', '" + Customer.Eir + "', TO_DATE('" + Customer.DateCreated + "', 'DD/MM/YYYY'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            string LogId = GetNextId(Log).ToString("D8");

            String LogSQL = "INSERT INTO Login(Loginid,Customerid,pac) " +
            "VALUES('" + LogId + "', '" + Customer.CustomerId + "', '" + Customer.PAC + "')";

            OracleCommand Logcmd = new OracleCommand(LogSQL, conn);
            Logcmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool Login(string s, string k)
        {
            //define Sql Query
            String strSQL = "SELECT Customerid,pac FROM Login where CustomerID = " + s;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
            {
                if (dr[1].Equals(k))
                {
                    GetCustName(s);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void GetCustName(string s)
        {
            //define Sql Query
            String strSQL = "SELECT first_name,last_name FROM Customer where CustomerID = " + s;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            Customer.Fname = dr[0].ToString();
            Customer.Lname = dr[1].ToString();

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
