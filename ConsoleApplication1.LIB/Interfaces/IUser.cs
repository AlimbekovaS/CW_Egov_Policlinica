using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LIB.Interfaces
{
    interface IUser
    {
        int UserId { get; set; }
        string login { get; set; }
        string password { get; set; }
        int role { get; set; }
        DateTime CreateDate { get; set; }
        string WhoCreate { get; set; }
        bool IsBlock { get; set; }
        void BlockUser(bool status);


    }
}
