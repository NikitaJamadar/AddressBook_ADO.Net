using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook_ADO.Net;
namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        AddressBook addressBook = new AddressBook();
        AddressBookModel model = new AddressBookModel();

        [TestMethod]
        public void AddingContactShouldReturnTrue()
        {
            model.FirstName = "Nikita";
            model.LastName = "Jamadar";
            model.Address = "Mulaj ";
            model.City = "Omerga";
            model.State = "Maharashtra";
            model.ZipCode = "908384";
            model.PhoneNumber = "69999999999";
            model.EmailId = "nikita@gmail.com";

            var result = addressBook.AddContacts(model);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void UpdatingContactShouldReturnTrue()
        {
            model.FirstName = "Nikita";
            model.LastName = "Auston";
            model.Address = "6 North Kirkland Rd";
            model.City = "New york";
            model.State = "New york";
            model.ZipCode = "668899";
            model.PhoneNumber = "6789025352";
            model.EmailId = "aaaa@xyz.com";

            var result = addressBook.EditContact(model);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DelectingContactShouldReturnTrue()
        {
            model.FirstName = "Nikita";
            model.LastName = "Jamadar";
            model.Address = "Mulaj ";
            model.City = "Omerga";
            model.State = "Maharashtra";
            model.ZipCode = "908384";
            model.PhoneNumber = "69999999999";
            model.EmailId = "nikita@gmail.com";
            var result = addressBook.DeleteContact(model);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenCityOrStateShouldReturnDataIfFound()
        {
            var result = addressBook.DisplayByCityOrState(model);
            Assert.IsNotNull(result);
        }

    }
}
