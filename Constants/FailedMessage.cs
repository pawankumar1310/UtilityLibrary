namespace Constants
{
    public static class FailedMessage
    {
        public const string UserNotExists = "User not available";
        public const string UserIdNotFound = "User Id Not Found";
        public const string GetUserIdFailed = "Failed to get UserID";

        public const string UserStatusCheckFailed = "Failed to check User Status";

        //Notification Service Message
        public const string SendOtpFailed = "Failed to send Otp";
        public const string EmailNotFoundToDelete = "Email not found to delete otp";
        public const string EmailNotFoundToValidate = "Email not found to Validate Otp";

        public const string DeleteOtpFailed = "Failed to Delete Otp";
        public const string ValidateOtpFailed = "Failed to Validate Otp";


        //Solution Service Messages
        public const string GroupNotFound="User Group Not Found";

        public const string ErrorImageUpload="Error Uploading Image";
        public const string ErrorUpdateImage="Error Updating Image";
        public const string ImageNotFound="Error Image Not Found";
        public const string DefaultFailedMessage="Not Found";
        public const string FailedEntityGroupCreated="Error Creating User Group";
    }
}