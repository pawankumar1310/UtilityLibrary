namespace Constants.Route
{
    public static class UserServiceRoute
    {
        public const string CheckUserStatus = URL.UserService + "UserLogin/checkUserStatus";
        public const string RegisterUser = URL.UserService + "UserRegistration/RegisterUser";
        public const string InsertUrl = URL.UserService + "Url/InsertUrl";
        public const string UpdateUserWithUrls = URL.UserService + "UserRegistration/UpdateUserWithUrls";
        public const string GetUserWithUrls = URL.UserService + "UserRegistration/GetUserWithUrls";
        public const string GetUsersAddtionalAddress = URL.UserService + "UserRegistration/GetUsersAddtionalAddress";
        public const string UpdateUserAdditionalAddress = URL.UserService + "UserRegistration/UpdateUserAdditionalAddress";
        public const string AddInstituteAndGetID = URL.UserService + "AddInstitute/ ";
        public const string AddInstituteAddress = URL.UserService + "AddInstitute/AddInstituteAddress";
        public const string AddInstituteOwnerShip = URL.UserService + "AddInstitute/AddInstituteOwnership";
        public const string AddInstituteHead = URL.UserService + "AddInstitute/AddInstituteHead";
        public const string AddInstituteTempData = URL.UserService + "AddInstitute/AddInstituteTempData";
        public const string GetOwnerShip = URL.UserService + "AddInstitute/GetOwnership";
        public const string GetGovernance = URL.UserService + "AddInstitute/GetGovernance";

        public const string GetFacility = URL.UserService + "AddInstitute/GetFacilitie";
        public const string AddUserInstitute = URL.UserService + "AddInstitute/AddUserInstitute";

        public const string AddLyceeEGovInsCode = URL.UserService + "AddInstitute/AddInstituteCode";
        public const string GetCategories = URL.UserService + "AddInstitute/GetCategories";
        public const string GetLevel = URL.UserService + "AddInstitute/GetLevel";

        public const string GetCourses = URL.UserService + "AddInstitute/GetCourses";

        public const string GetManagement = URL.UserService + "AddInstitute/GetManagement";

        public const string GetAssociation = URL.UserService + "AddInstitute/GetAssociation";
        public const string GetUserInstitute = URL.UserService + "AddInstitute/GetUserInstitution";



        public const string GetUserIdByEmail = URL.UserService +"UserLogin/GetUserIdByEmail";
        public const string GetAllUrlLabels = URL.UserService + "Url/GetAllUrlLabels";
        
        public const string UpdateInstitute = URL.UserService + "AddInstitute/UpdateInstitute";



    }
}