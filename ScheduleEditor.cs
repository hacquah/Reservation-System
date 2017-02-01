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
    public partial class ScheduleEditor : Form
    {
        public List<Show> schedule;
        private bool newEvent= true;
        int cnt;

        public int THEATRE = 0;
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

        public ScheduleEditor()
        {
            InitializeComponent();
        }

        public ScheduleEditor(DateTime dt, List<Show> sched, int theatre)
        {
            InitializeComponent();
            schedDTP.Value = dt;
            this.schedule = sched;
            newEvent = true;
            THEATRE = theatre;
        }

        public ScheduleEditor(List<Show> schedule, Show sched, int theatre)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.cnt = schedule.IndexOf(sched);
            newEvent = false;

            schedDTP.Value = sched.Info;
            descriptionTB.Text = sched.Name;
            codeTB.Text = sched.code;
            THEATRE = theatre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeTB.Text.Length < 4)
            {
                if (newEvent)
                {
                    schedule.Add(new Show());
                    cnt = schedule.Count() - 1;
                }
                schedule.ElementAt(cnt).Info = schedDTP.Value;
                schedule.ElementAt(cnt).Name = descriptionTB.Text;
                schedule.ElementAt(cnt).code = codeTB.Text;
                switch(THEATRE)
                {
                    case 1: ScheduleEditor.WriteXML<Show>("..\\..\\schedule.xml", schedule); break;
                    case 2: ScheduleEditor.WriteXML<Show>("..\\..\\schedule2.xml", schedule); break;
                    case 3: ScheduleEditor.WriteXML<Show>("..\\..\\schedule3.xml", schedule); break;
                }
                this.Close();
            }
            else { MessageBox.Show("Please enter a 3 digit code"); }
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
