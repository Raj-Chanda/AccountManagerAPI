namespace AccountManagement.API.Constants
{
    public static class TransferModes
    {
        public const string ImmediatePaymentService = "IMPS";
        public const string NationalElectronicFundsTransfer = "NEFT";
        public const string RealTimeGrossSettlement = "RTGS";
        public const string UnifiedPaymentInterface = "UPI";
    }
    public static class TransferStatus
    {
        public const string Pending = "PENDING";
        public const string Success = "SUCCESS";
        public const string Failed = "FAILED";
        public const string Reversed = "REVERSED";
    }
}
