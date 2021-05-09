using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace BankSYS
{
    class CustomerSQL
    {
        public static void AddUser()
        {
            string[] Cust = { "Customerid", "Customer" };
            string[] Log = { "Loginid", "Login" };
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            Customer.CustomerId = Reusable.GetNextId(Cust).ToString("D8");
            
            String CustSQL = "INSERT INTO Customer(Customerid,first_name,last_name,pps_number,country_code,phone_number,date_of_birth,address_line_1,address_line_2,address_line_3,town,county,eircode,date_created) " +
            "VALUES('" + Customer.CustomerId + "', '" + Customer.Fname + "', '" + Customer.Lname + "', '" + Customer.PPSNo + "', '" + Customer.CountryCode + "', '" + Customer.PhoneNo + "', TO_DATE('" + Customer.DOB + "', 'DD/MM/YYYY'), '" + Customer.AddressL1 + "', '" + Customer.AddressL2 + "', '" + Customer.AddressL3 + "', '" + Customer.Town + "', '" + Customer.County + "', '" + Customer.Eir + "', TO_DATE('" + Customer.DateCreated + "', 'DD/MM/YYYY'))";

            OracleCommand Custcmd = new OracleCommand(CustSQL, conn);
            Custcmd.ExecuteNonQuery();

            string LogId = Reusable.GetNextId(Log).ToString("D8");

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
                    GetCustInfo();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static void GetCustInfo()
        {
            //define Sql Query
            String strSQL = "SELECT C.First_name, C.Last_name, C.PPS_Number, P.Code, C.Phone_number, C.Date_Of_Birth, C.Address_line_1, C.Address_line_2, C.Address_line_3, C.town, L.County, C.eircode, C.Date_Created FROM Customer C INNER JOIN Country_Code P ON C.COUNTRY_CODE = P.CountryID INNER JOIN County L ON C.county = L.CountyID  where CustomerID = " + Customer.CustomerId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            Customer.Fname = dr[0].ToString();
            Customer.Lname = dr[1].ToString();
            Customer.PPSNo = dr[2].ToString();
            Customer.CountryCode = dr[3].ToString();
            Customer.PhoneNo = dr[4].ToString();
            Customer.DOB = dr[5].ToString().Substring(0,10);
            Customer.AddressL1 = dr[6].ToString();
            Customer.AddressL2 = dr[7].ToString();
            Customer.AddressL3 = dr[8].ToString();
            Customer.Town = dr[9].ToString();
            Customer.County = dr[10].ToString();
            Customer.Eir = dr[11].ToString();
            Customer.DateCreated = dr[12].ToString().Substring(0, 10);
            conn.Close();

        }
        public static void UpdateInfo()
        {
            //define Sql Query
            String strSQL = "Update Customer SET First_Name = '" + Customer.Fname + "', Last_Name = '" + Customer.Lname + "',Country_Code = " + Customer.CountryCode + ",Phone_Number = " + Customer.PhoneNo + ", Address_Line_1 = '" + Customer.AddressL1 + "', Address_Line_2 = '" + Customer.AddressL2 + "', Address_Line_3 = '" + Customer.AddressL3 + "', Town = '" + Customer.Town + "', County = " + Customer.County + ", EirCode = '" + Customer.Eir + "' Where CustomerID = " + Customer.CustomerId;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            
            //Close database connection
            conn.Close();
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
            if (dr.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public static void TerminateAccount(string s)
        {
            //define Sql Query
            String DeleteLogin = "Delete FROM Login where CustomerID = '" + s + "'";
            String TerminateAccount = "Update Customer SET Status = 'T' WHERE CustomerID = '" + s + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand Deletecmd = new OracleCommand(DeleteLogin, conn);
            Deletecmd.ExecuteNonQuery();

            OracleCommand Terminatecmd = new OracleCommand(TerminateAccount, conn);
            Terminatecmd.ExecuteNonQuery();

            conn.Close();

        }

    }
}
