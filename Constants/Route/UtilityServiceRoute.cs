namespace Constants.Route
{
    public static class UtilityServiceRoute
    {
        
        public const string GetLocationInfoByZipCodeID  = URL.UtilityService + "ZipCode/GetLocationInfoByZipCodeID";
        public const string GetZipCodeIDByZipCode  = URL.UtilityService + "ZipCode/GetZipCodeIDByZipCode";
        
        public const string GenerateOTP = URL.UtilityService + "OTP/GenerateOTP";
        public const string GenerateSalt = URL.UtilityService + "Salt/GenerateSalt";


        public const string GetPhoneCode = URL.UtilityService + "PhoneCode/GetPhoneCode";
        public const string GetAllPhoneCodes = URL.UtilityService + "PhoneCode/GetAllPhoneCodes";


        public const string GetAllZipCodes = URL.UtilityService + "ZipCode/GetAllZipCodes";
        public const string GetZipCode = URL.UtilityService + "ZipCode/GetZipCode";
        public const string GetZipCodeDetails = URL.UtilityService + "ZipCode/GetZipCodeDetails";
        public const string GetZipCodes = URL.UtilityService + "ZipCode/GetZipCodes";


        public const string GetCity = URL.UtilityService + "City/GetCity";
        public const string GetAllCities = URL.UtilityService + "City/GetAllCities";
        public const string GetCities = URL.UtilityService + "City/GetCities";


        public const string GetStates = URL.UtilityService + "State/GetStates";
        public const string GetAllStates = URL.UtilityService + "State/GetAllStates";


        public const string GetCountry = URL.UtilityService + "Country/GetCountry";
        public const string GetAllCountries = URL.UtilityService + "Country/GetAllCountries";


        public const string GetTableDetails = URL.UtilityService + "Table/GetTableDetails";
        public const string GetAllTableDetails = URL.UtilityService + "Table/GetAllTableDetails";
    }
}