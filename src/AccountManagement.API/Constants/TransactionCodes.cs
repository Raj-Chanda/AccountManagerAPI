namespace AccountManagement.API.Constants
{
    public static class TransactionCodes
    {
        public const string Credit = "Cr";
        public const string Debit = "Dr";
        public const string Transfer = "TRF";
        public const string Withdrawl = "WDL";
        public const string Cheque = "CHQ";
        public const string Cash = "CSH";
        public const string CashCredit = "CC";
        public const string CreditCard = "Cr_Cd";
    }

    public static class TransferLimits
    {
        public const decimal DailyLimit = 100000m;
        public const decimal SingleTransferLimit = 50000m;
    }

    public static class TransactionDescriptions
    {
        public const string Salary = "Salary Credit";
        public const string BillPayment = "Bill Payment";
        public const string Refund = "RFD";
        public const string Balance = "Bal";
        public const string Interest = "Int";
        public const string KnowYourCustomer = "KYC";
        public const string AutomatedTellerMacheine = "ATM";
        public const string Charges = "CHG";
        public const string Deposit = "DEP";

    }
}
