using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace AddressbookWebTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("3");
            group.Header = "2";
            group.Footer = "1";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Navigator.ReturnToGroupPage();
            app.Auth.Logout();
        }        
    }
}

