using FluentNHibernate.Mapping;
using NHibernate.Example.Driver.Property;

namespace NHibernate.Example.Driver.Mapping
{
    public class UsersMap:ClassMap<Users>
    {
        public UsersMap()
        {
            Id(x => x.Id);
            Map(x => x.UserName);
            Map(x => x.Email);
            Map(x => x.Password);
            Map(x => x.UserType);
        }
    }

    public class UserInfoMap : ClassMap<UserInfo>
    {
        public UserInfoMap()
        {
            Id(x => x.InfoId);
            References(x => x.UserId).Cascade.All().Not.Nullable();
            Map(x => x.InfoType);
            Map(x => x.InfoText);
        }
    }
}
