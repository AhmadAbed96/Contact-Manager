using System.Numerics;
using System.Threading.Channels;

namespace ContactManager
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContactManger();
        }
        public static void ContactManger()
            
        {
            Console.WriteLine("If you want to start the operation on the contact, please type the name of the operation\n");

            string operationName = Console.ReadLine().ToUpper();

            string start = "START";

            List<string> contactList = new List<string>(); 

            while (start == "START" || start == "Y" )
            {

                switch(operationName)
                {
                    case "ADD":
                        Console.WriteLine("Please enter the name you want to add\n");
                        string name = Console.ReadLine().ToUpper();
                        if (contactList.Contains(name))
                        {
                            Console.WriteLine("The name is already exist");
                        }
                        List<string> addContactList =  AddContact(contactList, name);
                        foreach (var contactName in addContactList)
                        {
                            Console.WriteLine($"[{contactName}]");
                        }
                        

                        Console.WriteLine("If you want to continue press Y, if you want to end press any thing\n");
                        start = Console.ReadLine().ToUpper();

                        if (start == "START" || start == "Y")
                        {
                            Console.WriteLine("please type the name of the operation\n");

                            operationName = Console.ReadLine().ToUpper();
                        };

                        break;
                    
                    case "REMOVE":
                        Console.WriteLine("Please enter the name you want to remove\n");
                        
                        name = Console.ReadLine().ToUpper();
                        
                        List<string> removeContactList = RemoveContact(contactList,name);
                        
                        foreach (var contactName in removeContactList)
                        {
                            Console.WriteLine($"[{contactName}]");
                        };

                        Console.WriteLine("If you want to continue Y, if you want to end press any thing\n");
                        start = Console.ReadLine().ToUpper();

                        if (start == "START" || start == "Y")
                        {
                            Console.WriteLine("please type the name of the operation\n");

                            operationName = Console.ReadLine().ToUpper();
                        }

                        break;

                    case "VIEW":
                       
                        List<string> viewContactList = ViewAllContact(contactList);
                        Console.WriteLine("This is the contacts list");
                        foreach (var contactName in viewContactList)
                        { 
                            Console.WriteLine($"The contact list: [{contactName}]");

                        }
                        
                        Console.WriteLine("If you want to continues Y, if you want to end press any thing\n");
                        start = Console.ReadLine().ToUpper();
                                              
                        if (start == "START" || start == "Y")
                        {
                            Console.WriteLine("please type the name of the operation\n");

                            operationName = Console.ReadLine().ToUpper();
                        };  
                            break;

                        default: 
                            Console.WriteLine("The operation name is incorrect.\nif you want to statr again please, press start.\nif you want to close press any thing");
                            start = Console.ReadLine().ToUpper();
                            if (start == "START" || start == "Y")
                            {
                                Console.WriteLine("please type the name of the operation\n");

                                operationName = Console.ReadLine().ToUpper();
                            }
                        
                        break;
                                                             
                }

            }
                       
        }
       public static List<string> AddContact(List<string> contactList , string name)
       {
            if(contactList.Contains(name)) 
            {
                return contactList;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                return contactList;
            }
            contactList.Add(name);
            return contactList;
        }

       public static List<string> RemoveContact(List<string> contactList, string name)
        {

            contactList.Remove(name);

            return contactList;
        }

        public static List<string> ViewAllContact(List<string> contactList)
        {
            return contactList;

        }

    }
}

