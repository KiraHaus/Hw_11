using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Hw_11
{
    internal class Consultant
    {
        protected string name;

        public string Name { get { return name; } }

        /// <summary>
        /// Консультант с именем
        /// </summary>
        /// <param name="name"></param>
        public Consultant (string name)
        {
            this.name = name;
        }

        public string ClientName(Client name)
        {
            string client = name.ShowInfoConsult();
            return client;
        }

        public void SetPhoneClient(Client name, string number)
        {
            name.Phone = number;

        }
    }
}
