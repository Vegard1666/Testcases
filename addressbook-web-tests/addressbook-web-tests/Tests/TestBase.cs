using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressbookWebTests
{
    public class TestBase
    {
        protected AppManager app;
        
        [SetUp]
        public void SetupAppManager()
        {
            app = AppManager.GetInstance();            
        }                          
    }
}
