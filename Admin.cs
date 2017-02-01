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
    public partial class Admin : Form
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

        string path = "..\\..\\AdminProfile.xml";
        List<Manager> People = new List<Manager>();
        bool valid1 = false, valid2 = false, manage1=true;

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            People = Admin.ReadXML<Manager>(path);
            for (int i = 0; i < People.Count;i++ )
            {
                if (usernameAdminTB.Text.ToUpper() == People.ElementAt(i).username.ToUpper()) { valid1 = true; }
                if (passwordAdminTB.Text.ToUpper() == People.ElementAt(i).password.ToUpper()) { valid2 = true; }
                if (valid1 && valid2)
                {
                    i = People.Count;
                    EmployeePortal managerportal = new EmployeePortal(manage1);
                    managerportal.Name = "Manager Portal";
                    managerportal.ShowDialog();
                    this.Close();
                }
            }
            if (!(valid1)) { adminLoginError.Text = "***Unrecognizable username***"; } else { adminLoginError.Text = ""; valid1 = false; }
            if (!(valid2)) { adminLoginError.Text += "**invalid password***"; } else { adminLoginError.Text += ""; valid2 = false; }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }
    }
}
