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
    public partial class CreateEmployee : Form
    {
        string createpath = "..\\..\\UserProfile.xml";
        List<Employee> People = new List<Employee>();

        #region write and read xmls
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

        // Writing a list of objects into an XML file
        public static void WriteXML<T>(string path, List<T> list, List<T> copy)
        {
            copy = ReadXML<T>(path);
            for (int i = 0; i < copy.Count; i++)
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
        #endregion

        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee newperson= new Employee(createUsernameTB.Text,createPasswordTB.Text);
            People.Add(newperson);
            CreateEmployee.WriteXML<Employee>(createpath, People);
            MessageBox.Show("Successfully added new Client");
            this.Close();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            People = CreateEmployee.ReadXML<Employee>(createpath);
        }
    }
}
