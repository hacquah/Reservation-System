using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    public class Customer
    {
        public string Firstname;
        public string Lastname;
        public string Age;
        public string Address;
        public string PhoneNumber;
        public string NameOnCard;
        public string CardNumber;
        public string CardExpiration;
        public string SecurityCode;
        public string TypeofCard;
        public List<string> Seats= new List<string>();
        public List<string> reservedShows = new List<string>();

        public Customer()
        {
            Firstname = "";
            Lastname = "";
            Age = "";
            Address = "";
            PhoneNumber = "";
            NameOnCard = "";
            CardNumber = "";
            CardExpiration = "";
            SecurityCode = "";
            TypeofCard = "";
            Seats = null;
            reservedShows = null;
        }

        public Customer(string firstname, string lastname, string age, string address, string phonenumber, string nameoncard, string cardnumber, string cardexpiration, string securitycode, string typeofcard)
        {
            Firstname = firstname; Lastname = lastname; Age = age; Address = address; PhoneNumber = phonenumber; NameOnCard = nameoncard; CardNumber = cardnumber; CardExpiration = cardexpiration; SecurityCode = securitycode; TypeofCard = typeofcard; Seats = null; reservedShows = null;
        }

    }

    public class Employee
    {
        public string username;
        public string password;

        public Employee()
        {
            username = "";
            password = "";
        }

        public Employee(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }

    public class Manager:Employee
    {
        public Manager()
        {
            username="";
            password = "";
        }

        public Manager(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }

    public class  Viewer
    {
        public string Firstname;
        public string Lastname;
        public List<string> Seating;
        public Viewer()
        {
            Firstname="";
            Lastname="";
            Seating = null;
        }
        public Viewer(string firstname, string lastname, List<string> seating)
        {
            Firstname = firstname;
            Lastname = lastname;
            Seating = seating;
        }

    }
}
