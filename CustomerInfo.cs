using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;  

namespace Reservation_System
{
    public partial class CustomerInfo : Form
    {
        #region read and write xml functions
        // Read XML file into a list of objects
        public static List<T> ReadXML<T>(string path)
        {
            List<T> list = new List<T>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    list = serializer.Deserialize(sr) as List<T>;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Reading File.");
            }

            return list;
        }

        // Writing a list of objects into an XML file
        public static void WriteXML<T>(string path, List<T> list)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    serializer.Serialize(sw, list);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Writing File");
            }
        }

        #endregion
        string Custpath = "..\\..\\customer.xml";
        //bool exists = false;
        List<Customer> updatecustomer = new List<Customer>();
        public CustomerInfo()
        {
            InitializeComponent();
        }
        int i;

        public CustomerInfo(string firstname,string lastname, bool fill, int index)
        {
            InitializeComponent();
            i = index;
            updatecustomer = CustomerInfo.ReadXML<Customer>(Custpath);
            if (fill)
            {
                FirstNameTB.Text = updatecustomer.ElementAt(i).Firstname;
                LastNameTB.Text = updatecustomer.ElementAt(i).Lastname;
                AgeTB.Text = updatecustomer.ElementAt(i).Age;
                AddressTB.Text = updatecustomer.ElementAt(i).Address;
                PhoneNumberTB.Text = updatecustomer.ElementAt(i).PhoneNumber;
                CardNameTB.Text = updatecustomer.ElementAt(i).NameOnCard;
                CardNumberTB.Text = updatecustomer.ElementAt(i).CardNumber;
                CardExpirationTB.Text = updatecustomer.ElementAt(i).CardExpiration;
                SecurityCodeTB.Text = updatecustomer.ElementAt(i).SecurityCode;
                TypeofCardTB.Text = updatecustomer.ElementAt(i).TypeofCard; /*check drop list*/
                updatecustomer.Remove(updatecustomer.ElementAt(i));
            }
            else
            {
                FirstNameTB.Text = firstname;
                LastNameTB.Text = lastname;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer current = new Customer(FirstNameTB.Text, LastNameTB.Text, AgeTB.Text, AddressTB.Text, PhoneNumberTB.Text, CardNameTB.Text, CardNumberTB.Text, CardExpirationTB.Text, SecurityCodeTB.Text, TypeofCardTB.Text);
            updatecustomer.Add(current);
            CustomerInfo.WriteXML<Customer>(Custpath, updatecustomer);
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeePortal empportal = new EmployeePortal();
            empportal.ShowDialog();
        }
    }
}
