namespace BankSYS
{
    public static class Customer
    {
        public static string CustomerId { get; set; }
        public static string PAC { get; set; }
        public static string Fname { get; set; }
        public static string Lname { get; set; }
        public static string PPSNo { get; set; }
        public static string DOB { get; set; }
        public static string CountryCode { get; set; }
        public static string PhoneNo { get; set; }
        public static string AddressL1 { get; set; }
        public static string AddressL2 { get; set; }
        public static string AddressL3 { get; set; }
        public static string Town { get; set; }
        public static string County { get; set; }
        public static string Eir { get; set; }
        public static string DateCreated { get; set; }

        public static void Clear()
        {
            CustomerId = "";
            PAC = "";
            Fname = "";
            Lname = "";
            PPSNo = "";
            DOB = "";
            CountryCode = "";
            PhoneNo = "";
            AddressL1 = "";
            AddressL2 = "";
            AddressL3 = "";
            Town = "";
            County = "";
            Eir = "";
            DateCreated = "";
        }
    }
}
