using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_11
{
    internal class Client
    {
        private string name;
        private string surname;
        private string fname;
        private string phone;
        private string password;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != string.Empty)
                {
                    phone = value;
                }
            }
        }

        public string Password { get; set; }

        /// <summary>
        /// Конструктор стандартный
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="fname"></param>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        public Client(string name, string surname, string fname, string phone, string password)
        {
            this.name = name;
            this.surname = surname;
            this.fname = fname;
            this.phone = phone;
            this.password = password;
        }

        /// <summary>
        /// Констурктор без телефона
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="fname"></param>
        /// <param name="password"></param>
        public Client(string name, string surname, string fname, string password):
            this (name, surname,fname, String.Empty, password)
        {

        }

        /// <summary>
        /// проверка личная
        /// </summary>
        public string ShowInfo()
        {
            return $"Клиент: {Surname} {Name} {FName}; Номер телефона: {Phone}; Серия и номер паспорта: {Password} ";
        }

        public string ShowInfoConsult()
        {
            return ($"Клиент: {Surname} {Name} {FName}; Номер телефона: {Phone}; Серия и номер паспорта: **** ****** ");
        }
    }
}
