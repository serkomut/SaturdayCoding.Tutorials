using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Example.Driver.Property
{
    public class Users
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual int UserType { get; set; }
    }

    public class UserInfo
    {
        public virtual int InfoId { get; set; }
        public virtual int InfoType { get; set; }
        public virtual string InfoText { get; set; }
        public virtual Users UserId { get; set; }
    }
}
