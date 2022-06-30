using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_11
{
    internal class Manager : Consultant
    {

        public Manager (string name)
            :base(name)
        {
       
        }

        public new string ClientName(Client client)
        {
            return client.ShowInfo();
        }

        public void ChangeClientName (Client client, string firstName, string secondName, string thirdName)
        {
            client.Name = firstName;
            client.Surname = secondName;
            client.FName = thirdName;
        }

        public void ChangeClientPhone (Client client, string phone)
        {
            client.Phone = phone;
        }

        public void ChangeClientPassport (Client client, string passport)
        {
            client.Password = passport;
        }
    }
}
