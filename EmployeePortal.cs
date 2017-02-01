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
    public partial class EmployeePortal : Form
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
        string Custpath = "..\\..\\Customer.xml";
        List<Customer> instant2 = new List<Customer>();
        bool ok = false;
        bool Manage = false;
        public Customer viewer;
        List<Customer> updatecustomer = new List<Customer>();

        public EmployeePortal()
        {
            InitializeComponent();
        }
        public EmployeePortal(bool manage)
        {
            InitializeComponent();
            Manage = manage;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCinfo(object sender, EventArgs e)
        {
            if ((FirstnameTBE.Text != "") && (LastnameTB.Text != ""))
            {
                FirstnameTBE.Text = SpaceStripper(FirstnameTBE.Text);
                LastnameTB.Text = SpaceStripper(LastnameTB.Text);
            }
            instant2 = EmployeePortal.ReadXML<Customer>(Custpath);
            int index = 0;
            foreach(Customer p in instant2)
            {
                if (FirstnameTBE.Text.ToUpper() == p.Firstname.ToUpper() && LastnameTB.Text.ToUpper()==p.Lastname.ToUpper())
                { index = instant2.IndexOf(p); ok= true; }
            }
            if (ok)
            {
                CustomerInfo customerinfo = new CustomerInfo(FirstnameTBE.Text,LastnameTB.Text,true,index);
                customerinfo.ShowDialog();
            }
            else { MessageBox.Show("Customer is not in directory."); }
        }

        private void EmployeePortal_Load(object sender, EventArgs e)
        {
            #region customer instantiations
            /*Customer Harden = new Customer("James", "Harden", "26", "11 Billy Ave", "222-666-4444", "jamesharden", "5665-5555-4444-6666", "01/28", "254", "AmericanExpress");
            updatecustomer.Add(Harden);
            CustomerInfo.WriteXML<Customer>(Custpath, updatecustomer);*/
            #endregion
            adminBN.Visible = Manage;
        }

        private void SellTickets_Click(object sender, EventArgs e)
        {
            //FirstnameTBE.Text = SpaceStripper(FirstnameTBE.Text);
            //LastnameTB.Text = SpaceStripper(LastnameTB.Text);
            instant2 = EmployeePortal.ReadXML<Customer>(Custpath);
            int index = 0;
            foreach (Customer p in instant2)
            {
                if (FirstnameTBE.Text.ToUpper() == p.Firstname.ToUpper() && LastnameTB.Text.ToUpper() == p.Lastname.ToUpper())
                { index = instant2.IndexOf(p); ok = true; viewer=p; }
            }
            if (ok)
            {
                EmployeeSellTickets employeeselltickets = new EmployeeSellTickets(false, false, false, viewer);
                employeeselltickets.ShowDialog();
                ok = false;
            }
            else
            {
                if(FirstnameTBE.Text == "") 
                { MessageBox.Show("Please fill in customer Firstname"); }
                else if (LastnameTB.Text == "")
                { MessageBox.Show("Please fill in customer Lastname"); }
                else
                {
                    MessageBox.Show("Customer is not in directory.");
                }
            }
        }

        private void createCustomer_Click(object sender, EventArgs e)
        {
            FirstnameTBE.Text = SpaceStripper(FirstnameTBE.Text);
            LastnameTB.Text = SpaceStripper(LastnameTB.Text);
            CustomerInfo customerinfo = new CustomerInfo(FirstnameTBE.Text,LastnameTB.Text,false,0);
            customerinfo.ShowDialog();
        }

        private void AddEdit_click(object sender, EventArgs e)
        {
            if ((FirstnameTBE.Text != "") && (LastnameTB.Text != ""))
            {
                EmployeeSellTickets employeeeselltickets = new EmployeeSellTickets();
                employeeeselltickets.ShowDialog();
            }
            else 
            {
                EmployeeSellTickets employeeeselltickets = new EmployeeSellTickets(false);
                employeeeselltickets.ShowDialog();
            }
        }
        public string SpaceStripper(string Name)
        {
            string new1;
            int x = Name.Count();
            new1 = Name;
            if (Name[x-1] == ' ')
            {
                new1 = Name.Remove(x - 1);
            }
            
            return new1;
            

        }
    }
}
