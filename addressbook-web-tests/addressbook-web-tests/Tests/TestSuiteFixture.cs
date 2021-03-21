using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressbookWebTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {       

        [SetUp]
        public void InitAppManager()
        {
            AppManager app = AppManager.GetInstance();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
