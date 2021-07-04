
using UserAndAwards.BLL;
using UserAndAwards.BLL.Interface;
using UsersAndAwards.DAL;
using UsersAndAwards.DAL.Interface;

namespace UsersAndAwards.Dependencies
{
    public class DependencyResolver
    {
        #region user
        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new
            UserDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new
            UserLogic(UserDao));
        #endregion

        #region award
        private static IAwardDao _awardDao;

        public static IAwardDao AwardDao => _awardDao ?? (_awardDao = new
            AwardDao());

        private static IAwardLogic _awardLogic;

        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new
            AwardLogic(AwardDao));
        #endregion
    }
}
