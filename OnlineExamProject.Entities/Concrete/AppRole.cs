using Microsoft.AspNetCore.Identity;
using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Entities.Concrete
{
    public class AppRole : IdentityRole<int>, ITable
    {
    }
}
