using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.DataAccesss.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }
    }
}
