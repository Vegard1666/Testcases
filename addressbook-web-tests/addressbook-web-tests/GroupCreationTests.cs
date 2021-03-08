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
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            GroupData group = new GroupData("3");
            group.Header = "2";
            group.Footer = "1";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigationHelper.ReturnToGroupPage();
            loginHelper.Logout();
        }        
    }
}

