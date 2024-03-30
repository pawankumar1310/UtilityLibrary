namespace Constants.Otp
{
    public class Otp
    {
        public async Task<int> OtpService()
        {
            Random random = new();
            return random.Next(100000, 999999);

        }
    }
}
