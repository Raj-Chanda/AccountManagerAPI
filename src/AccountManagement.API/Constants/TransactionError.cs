namespace AccountManagement.API.Constants
{
    public static class Transaction
    {
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 100;
    }

    public static class ErrorMessages
    {
        public const string InsufficientBalance = "Insufficient balance.";
        public const string AccountNotFound = "Account not found.";
        public const string UnauthorizedAccess = "Unauthorized access.";
        public const string LimitReached = "Limit Exceeded";
    }
}
