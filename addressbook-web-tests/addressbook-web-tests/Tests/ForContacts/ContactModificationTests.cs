using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace AddressbookWebTests
{
    [TestFixture]
    class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("321");
            newData.Middlename = "321";
            newData.Lastname = "321";
            newData.Nickname = "321";
            newData.Title = "111";
            newData.Company = "444444444444444444444";
            newData.Address = "555555555555555555555";
            newData.Home = "66666666666666";
            newData.Mobile = "77777777777";
            newData.Work = "9999999999";
            newData.Fax = "Какой-то факс";
            newData.Email = "456789@email.org";
            newData.Byear = "1245";
            newData.Ayear = "1999";
            newData.Address2 = "Какой-то второй адресс";
            newData.Notes = "Хз что тут должно быть";

            app.Contacts.Modify(2, newData);
        }

    }
}
