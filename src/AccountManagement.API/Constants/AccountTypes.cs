namespace AccountManagement.API.Constants
{
    public static class AccountTypes
    {
        public const string Saving = "SB";
        public const string Current = "CA";
        public const string CashCredit = "CC";
    }

    public static class AccountStatus
    {
        public const string Active = "ACTIVE";
        public const string Inactive = "INACTIVE";
        public const string Closed = "CLOSED";
        public const string Frozen = "FROZEN";
    }

    public static class AccountDefaults
    {
        public const decimal MinimumBalanceSaving = 1000m;
        public const decimal MinimumBalanceCurrent = 5000m;
    }
}
