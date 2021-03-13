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
            GroupData group = new GroupData("3");
            group.Header = "2";
            group.Footer = "1";
            
            app.Groups.Create(group);
            app.Navigator.ReturnToGroupsPage();
            app.Auth.Logout();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Groups.Create(group);
            app.Navigator.ReturnToGroupsPage();
            app.Auth.Logout();
        }
    }
}

