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
    public partial class EmployeeSellTickets : Form
    {
        public List<Show> sched;
        Show[] time= new Show[] {};
        public Customer CUSTOMER;
        public string tab1path = "..\\..\\schedule.xml";
        public string tab2path = "..\\..\\schedule2.xml";
        public string tab3path = "..\\..\\schedule3.xml";

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

        public EmployeeSellTickets()
        {
            InitializeComponent();
            schedLB.HorizontalScrollbar = true;
            schedLB2.HorizontalScrollbar = true;
            schedLB3.HorizontalScrollbar = true;
        }

        public EmployeeSellTickets(bool visible)
        {
            InitializeComponent();
            schedLB.HorizontalScrollbar = true;
            schedLB2.HorizontalScrollbar = true;
            schedLB3.HorizontalScrollbar = true;
            button5.Visible = visible; //this is to disable the select a seat button if the administrator does not enter a firstname or lastname
        }

        public EmployeeSellTickets(bool add, bool edit, bool remove, Customer custmer)
        {
            InitializeComponent();
            addBN.Visible = add;
            editBN.Visible = edit;
            removeBN.Visible = remove;
            add2BN.Visible = add;
            edit2BN.Visible = edit;
            remove2BN.Visible = remove;
            add3BN.Visible = add;
            edit3BN.Visible = edit;
            remove3BN.Visible = remove;
            CUSTOMER=custmer;
        }
        private void schedMC_selected(object sender, DateRangeEventArgs e)
        {
            schedLB.Enabled = true;//avoids exception error on day not being selected first
            schedLB2.Enabled = true;//avoids exception error on day not being selected first
            schedLB3.Enabled = true;//avoids exception error on day not being selected first
            MonthCalendar mc = sender as MonthCalendar;
            List<Show> sss = new List<Show>();
            switch (TicketsTab.SelectedTab.Name)
            {
                case "Tab1":
                    foreach(Show s in sched)
                    {
                        if (s.Info.Date == mc.SelectionStart)
                            sss.Add(s);
                    }
                    Show[] l = sss.ToArray();
                    schedLB.Items.Clear();
                    schedLB.Items.AddRange(l);
                    schedLB.DisplayMember = "Name";
                    time = l; break;
                case "Tab2":
                    foreach (Show s in sched)
                    {
                        if (s.Info.Date == mc.SelectionStart)
                            sss.Add(s);
                    }
                    Show[] ll = sss.ToArray();
                    schedLB2.Items.Clear();
                    schedLB2.Items.AddRange(ll);
                    schedLB2.DisplayMember = "Name";
                    time = ll; break;
                case "Tab3":
                    foreach (Show s in sched)
                    {
                        if (s.Info.Date == mc.SelectionStart)
                            sss.Add(s);
                    }
                    Show[] lll = sss.ToArray();
                    schedLB3.Items.Clear();
                    schedLB3.Items.AddRange(lll);
                    schedLB3.DisplayMember = "Name";
                    time = lll; break;
            }
        }

        private void EmployeeSellTickets_Load(object sender, EventArgs e)
        {
            schedLB.Enabled = false; //avoids exception error on day not being selected first
            schedLB2.Enabled = false;//avoids exception error on day not being selected first
            schedLB3.Enabled = false;//avoids exception error on day not being selected first
            #region instantiate schedule.xml
            /*DateTime dt1 = new DateTime(2015, 5, 5, 15, 30, 00);
            DateTime dt2 = new DateTime(2015, 5, 10, 17, 00, 00);
            DateTime dt3 = new DateTime(2015, 5, 15, 20, 30, 00);
            DateTime dt4 = new DateTime(2015, 5, 20, 10, 00, 00);
            DateTime dt5 = new DateTime(2015, 5, 25, 12, 30, 00);
            Show tab1sched1 = new Show(dt1, "Eragon","1");
            Show tab1sched2 = new Show(dt2, "Die by Fire","2");
            Show tab1sched3 = new Show(dt3, "The visit","3");
            Show tab1sched4 = new Show(dt4, "Wicked","4");
            Show tab1sched5 = new Show(dt5, "Something Rotten","5");
            List<Show> instant1 = new List<Show>();
            instant1.Add(tab1sched1);
            instant1.Add(tab1sched2);
            instant1.Add(tab1sched3);
            instant1.Add(tab1sched4);
            instant1.Add(tab1sched5);
            EmployeeSellTickets.WriteXML<Show>("..\\..\\schedule.xml", instant1);*/
            #endregion
            sched = EmployeeSellTickets.ReadXML<Show>("..\\..\\schedule.xml"); //default tab 1 reading
        }

        private void addBN_Click(object sender, EventArgs e)
        {
            switch (TicketsTab.SelectedTab.Name)
            {
                case "Tab1":
                    ScheduleEditor scheduleEditor = new ScheduleEditor(schedMC.SelectionStart, sched, 1);
                    scheduleEditor.ShowDialog(); break;
                case "Tab2":
                    ScheduleEditor scheduleEditor2 = new ScheduleEditor(schedMC2.SelectionStart, sched,2);
                    scheduleEditor2.ShowDialog(); break;
                case "Tab3":
                    ScheduleEditor scheduleEditor3 = new ScheduleEditor(schedMC3.SelectionStart, sched,3);
                    scheduleEditor3.ShowDialog(); break;
            }
        }

        private void editBN_click(object sender, EventArgs e)
        {
            switch (TicketsTab.SelectedTab.Name)
            {
                case "Tab1":
                    if (schedLB.SelectedItem == null)
                    {
                        MessageBox.Show("Select an event from this date.");
                    }
                    else
                    {
                        ScheduleEditor edit = new ScheduleEditor(sched, schedLB.SelectedItem as Show,1);
                        edit.ShowDialog();
                    } break;
                case "Tab2":
                    if (schedLB2.SelectedItem == null)
                    {
                        MessageBox.Show("Select an event from this date.");
                    }
                    else
                    {
                        ScheduleEditor edit2 = new ScheduleEditor(sched, schedLB2.SelectedItem as Show,2);
                        edit2.ShowDialog();
                    } break;
                case "Tab3":
                    if (schedLB3.SelectedItem == null)
                    {
                        MessageBox.Show("Select an event from this date.");
                    }
                    else
                    {
                        ScheduleEditor edit3 = new ScheduleEditor(sched, schedLB3.SelectedItem as Show,3);
                        edit3.ShowDialog();
                    } break;
            }
        }
        private void ShowTime(object sender, MouseEventArgs e)
        {
            switch(TicketsTab.SelectedTab.Name)
            {
                case "Tab1": int ind = schedLB.SelectedIndex;
                    if(schedLB.SelectedItem!=null)
                    { timeLBL.Text = time[ind].Info.TimeOfDay.ToString(); }break; 
                case "Tab2": int ind2 = schedLB2.SelectedIndex;
                    if (schedLB2.SelectedItem != null)
                    {timeLBL2.Text = time[ind2].Info.TimeOfDay.ToString();} break;
                case "Tab3": int ind3 = schedLB3.SelectedIndex;
                    if(schedLB3.SelectedItem!=null)
                    { timeLBL3.Text = time[ind3].Info.TimeOfDay.ToString(); } break;
            }
        }

        private void Tab3_Click(object sender, MouseEventArgs e)
        {
            switch(TicketsTab.SelectedTab.Name)
            {
                case "Tab1": sched = EmployeeSellTickets.ReadXML<Show>(tab1path); break; 
                case "Tab2": sched = EmployeeSellTickets.ReadXML<Show>(tab2path); break;
                case "Tab3": sched = EmployeeSellTickets.ReadXML<Show>(tab3path); break;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            List<Show> NewSchedule = new List<Show>();

            if (schedLB.SelectedItem != null || schedLB2.SelectedItem != null || schedLB3.SelectedItem != null)
            {
                switch (TicketsTab.SelectedTab.Name)
                {
                    case "Tab2":
                        NewSchedule = EmployeeSellTickets.ReadXML<Show>(tab2path);
                          Show tab2= (Show)schedLB2.SelectedItem;
                        int index = 0; for( int a=0; a<NewSchedule.Count;a++) {if(NewSchedule.ElementAt(a).Name==tab2.Name) a=NewSchedule.Count(); index++;}
                        NewSchedule.Remove(NewSchedule.ElementAt(index));
                        EmployeeSellTickets.WriteXML<Show>(tab2path, NewSchedule); break;
                    case "Tab3":
                        NewSchedule = EmployeeSellTickets.ReadXML<Show>(tab3path);
                        Show tab3= (Show)schedLB3.SelectedItem;
                        int ind = 0; for( int a=0; a<NewSchedule.Count;a++) {if(NewSchedule.ElementAt(a).Name==tab3.Name) a=NewSchedule.Count(); ind++;}
                        NewSchedule.Remove(NewSchedule.ElementAt(ind));
                        EmployeeSellTickets.WriteXML<Show>(tab3path, NewSchedule); break;
                    default:
                        NewSchedule = EmployeeSellTickets.ReadXML<Show>(tab1path);
                      Show tab= (Show)schedLB.SelectedItem;//NewSchedule.ElementAt(schedLB.SelectedIndex);
                        int inde = 0; for( int a=0; a<NewSchedule.Count;a++) {if(NewSchedule.ElementAt(a).Name==tab.Name) a=NewSchedule.Count(); inde++;}
                        NewSchedule.Remove(NewSchedule.ElementAt(inde-1));
                        EmployeeSellTickets.WriteXML<Show>(tab1path, NewSchedule); break;
                }
                MessageBox.Show("Show has been removed.");
                switch(TicketsTab.SelectedTab.Name)
                {
                    case "Tab2": sched = EmployeeSellTickets.ReadXML<Show>(tab2path); break;
                    case "Tab3": sched = EmployeeSellTickets.ReadXML<Show>(tab3path); break;
                    default: sched = EmployeeSellTickets.ReadXML<Show>(tab1path); break;
                }
                
            }
            else { MessageBox.Show("Please selected an item."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (TicketsTab.SelectedTab.Name)
            {
                case "Tab2":
                    sched = EmployeeSellTickets.ReadXML<Show>(tab2path);
                    if (schedLB2.SelectedItem != null)
                    {
                        Show selectedshow = (Show)schedLB2.SelectedItem;
                        Theater1 theater1 = new Theater1(selectedshow,CUSTOMER,2);
                        theater1.ShowDialog();
                    }
                    else
                    {      
                        MessageBox.Show("Select a show please");
                    } break;
                case "Tab3":
                    sched = EmployeeSellTickets.ReadXML<Show>(tab3path);
                    if (schedLB3.SelectedItem != null)
                    {
                        Show selectedshow = (Show)schedLB3.SelectedItem;
                        Theater1 theater1 = new Theater1(selectedshow,CUSTOMER,3);
                        theater1.ShowDialog();
                    }
                    else
                    {      
                        MessageBox.Show("Select a show please");
                    } break;
                default:
                    sched = EmployeeSellTickets.ReadXML<Show>(tab1path);
                    if (schedLB.SelectedItem != null)
                    {
                        Show selectedshow = (Show)schedLB.SelectedItem;
                        Theater1 theater1 = new Theater1(selectedshow,CUSTOMER,1);
                        theater1.ShowDialog();
                    }
                    else
                    {      
                        MessageBox.Show("Select a show please");
                    } break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
