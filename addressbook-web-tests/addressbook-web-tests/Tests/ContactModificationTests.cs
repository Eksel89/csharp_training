using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{

    [TestFixture]

    class ContactModificationTests : TestBase
    {

        [Test]

        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("vvv");
            newData.Firstname = "rew";
            newData.Lastname = "vfc";

            app.Contacts.Modify(2, newData);
            
        }

    }
}
