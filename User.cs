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
    public partial class EmployeeForm : Form
    {
        List<Employee> instant = new List<Employee>();

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
        public static void WriteXML<T>(string path, List<T> list, List<T>copy)
        {
            copy = ReadXML<T>(path);
            for (int i = 0; i < copy.Count;i++ )
            {
                list.Add(copy.ElementAt(i));
            }
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

        string userpath = "..\\..\\UserProfile.xml";
        List<Employee> People = new List<Employee>();
        bool valid1 = false, valid2 = false;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            instant = EmployeeForm.ReadXML<Employee>(userpath);
            for (int i = 0; i < instant.Count; i++)
            {
                if (usernameUserTB.Text.ToUpper() == instant.ElementAt(i).username.ToUpper()) { valid1 = true; }
                if (passwordUserTB.Text.ToUpper() == instant.ElementAt(i).password.ToUpper()) { valid2 = true; }
                if (valid1 && valid2)
                {
                    i = instant.Count;
                    EmployeePortal employeeportal = new EmployeePortal();
                    employeeportal.ShowDialog();
                    this.Close();
                }
            }
            if (!(valid1)) { userLoginError.Text = "***Unrecognizable username***"; } else { userLoginError.Text = ""; valid1 = false; }
            if (!(valid2)) { userLoginError.Text += "**invalid password***"; } else { userLoginError.Text += ""; valid2 = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUser_click(object sender, EventArgs e)
        {
            CreateEmployee createuser = new CreateEmployee();
            createuser.ShowDialog();
        }
    }
}
