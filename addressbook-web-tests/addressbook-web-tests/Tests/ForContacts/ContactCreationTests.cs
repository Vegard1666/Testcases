using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace AddressbookWebTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Пупок", "Пупк0ff");
            contact.Middlename = "Pupkevich";            
            contact.Nickname = "§╝╝╝╝╝┼";
            contact.Title = "Что-то написано";
            contact.Company = "Суперкомпания";
            contact.Address = "Какой-то адресс";
            contact.Home = "8442 77 22 11";
            contact.Mobile = "9 999 99 99 99";
            contact.Work = "8 888 88 88 88";
            contact.Fax = "Какой-то факс";
            contact.Email = "456789@email.org";
            contact.Byear = "1245";
            contact.Ayear = "1999";
            contact.Address2 = "Какой-то второй адресс";
            contact.Notes = "Хз что тут должно быть";

            app.Contacts.Create(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("", "");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "";
            contact.Home = "";
            contact.Mobile = "";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Byear = "";
            contact.Ayear = "";
            contact.Address2 = "";
            contact.Notes = "";

            app.Contacts.Create(contact);
        }
    }
}
