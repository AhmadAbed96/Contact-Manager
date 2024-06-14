using Xunit;
using System.Runtime.CompilerServices;
using ContactManager;

namespace Contact_Manger_test
{
    public class UnitTest1
    {
        [Fact]
        public void AddContact()
        {
            // Add
            string name = "Ahmad";
            List<string> list = new List<string>();

            // Arrange
            List<string> result = Program.AddContact(list,name);

            // Assart
            Assert.Contains("Ahmad", list);
        }

        [Fact]
        public void RemoveContact()
        {
            // Add
            string name = "Ahmad";
            string name1 = "Abed";

            List<string> list = new List<string>();

            // Arrange
            List<string> result = Program.AddContact(list, name);
            result = Program.AddContact(list, name1);
            result = Program.RemoveContact(list, name);


            // Assart
            Assert.Equal( 1,list.Count);
        }

        [Fact]
        public void ViewAllContact()
        {
            // Add
            string name = "Ahmad";
            string name1 = "Abed";
            string name2 = "Samer";


            List<string> list = new List<string>();

            // Arrange
            List<string> result = Program.AddContact(list, name);
            result = Program.AddContact(list, name1);
            result = Program.AddContact(list, name2);
            result = Program.ViewAllContact(list);
            int i = list.Count;
            // Assart
            Assert.Equal(3, i);
        }

        [Fact]
        public void DublicateContact()
        {
            // Add
            string name = "Ahmad";
            string name1 = "Abed";
            string name2 = "Ahmad";


            List<string> list = new List<string>();

            // Arrange
            List<string> result = Program.AddContact(list, name);
            result = Program.AddContact(list, name1);
            result = Program.AddContact(list, name2);
            int i = list.Count;


            // Assart
            Assert.Equal(2, i);
        }

    }
}