using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Calender_Projects.AccountManagement
{
    public class AccountDatabase
    {
        private FileStream fs; 
            private List<String> account = new List<String>();

            public AccountDatabase()
            {

            }

            public void AddAccount()
            {
            fs = new FileStream("cds.txt", FileMode.Open);
                bool keepGoing = true;
                while (keepGoing)
                {
                    try
                    {
                        //Reads the File Database//

                        IFormatter formatter = new BinaryFormatter();
                        Account d = (Account)formatter.Deserialize(fs);
                        String tre = d.ToString();
                        account.Add(tre);
                        
                    }
                    catch (SerializationException)
                    {
             
                        keepGoing = false;
                     }
                }
                //Request for Registry//
                bool isNotValid = true;
                Console.Write("Enter Username: ");
                String username = Console.ReadLine();
                //Checks for the Validity of the Username//
                while (isNotValid)
                {
                    if (account.Contains(username))
                    {
                        Console.WriteLine("Username Already Taken");
                    }
                    else
                    {
                        isNotValid = false;
                    }
                }
                Console.Write("Enter Password: ");
                String password = Console.ReadLine();
                Account newA = new Account(username, password);
                //Adds new Account to the Database
                MemoryStream stream = SerializeToStream(newA);
                byte[] Mem = stream.ToArray();
                fs.Seek(fs.Length, SeekOrigin.Begin);
                fs.Write(Mem, 0, Mem.Length);


            }


            public static MemoryStream SerializeToStream(Account o)
            {
                MemoryStream stream = new MemoryStream();
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, o);
                Console.WriteLine(stream);
                return stream;
            }
    }
}
