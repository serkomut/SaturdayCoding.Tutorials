using NHibernate.Example.Driver.Property;
using NUnit.Framework;

namespace NHibernate.Example.Driver.Test
{
    [TestFixture]
    class NHibernateFixture
    {
        [Test]
        public void NHibernate_Build()
        {
            using (var session = NHibernateConnection.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    var user = new Users()
                    {
                        UserName = "Serol Güzel",
                        Email = "serkomut@gmail.com",
                        Password = "hadiordan",
                        UserType = 1
                    };
                    var userinfo = new UserInfo()
                    {
                        InfoType = 1,
                        InfoText = "Bu bir adrestir.",
                        UserId = user
                    };
                    session.Save(user);
                    session.Save(userinfo);
                    trans.Commit();
                }
            }
        }
    }
}
