using Constants;

namespace Constants.Route
{
    public static class NotificationServiceRoute
    {
        public const string InsertOrUpdateOtp = URL.NotificationService + "OTP/InsertOrUpdateOtp";
        public const string SendOTP = URL.NotificationService + "Sms/SendOTP";
        public const string ValidateOTP = URL.NotificationService + "OTP/ValidateOtp";
        public const string DeleteOTP = URL.NotificationService + "OTP/DeleteOtp";
        public const string CheckExistingOtpForEmail = URL.NotificationService + "OTP/CheckExistingOtpForEmail";

    }
}
