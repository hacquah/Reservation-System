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
    public partial class Theater1 : Form
    {
        Button[] buttonArray = new Button[63];
        int numberofseats = 0, INDEX = 0;
        public string tab1path = "..\\..\\schedule.xml";
        public string tab2path = "..\\..\\schedule2.xml";
        public string tab3path = "..\\..\\schedule3.xml";
        public List<Show> listShows = new List<Show>();
        public Customer CUSTOMER;
        public Show SHOW;
        public int THEATER = 0;
        bool AlreadyReservedShow = false;

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

        public Theater1()
        {
            InitializeComponent();
        }
        public Theater1(Show show, Customer customer, int theater)
        {
            InitializeComponent();
            switch (THEATER)
            {
                case 1: listShows = Theater1.ReadXML<Show>(tab1path); break;    //get shows information
                case 2: listShows = Theater1.ReadXML<Show>(tab2path); break;    //get shows information
                case 3: listShows = Theater1.ReadXML<Show>(tab3path); break;   //get shows informationbreak;
            }
            int inde = 0; for (int i = 0; i < listShows.Count; i++) { if (listShows.ElementAt(i).Name == show.Name) { inde = i; i = listShows.Count; } } //gets index
            //all global vars for a particular customer
            INDEX = inde;  //passing the index of the  show in the list of showws
            CUSTOMER = customer;  //passing who the customer is
            SHOW = show;  //passing show selected info
            THEATER = theater;
        }

        private void Theater1_Load(object sender, EventArgs e)
        {
            AlreadyReservedShow = false;   
            CreateButtons();
            switch(THEATER)
            {
                case 1: listShows = Theater1.ReadXML<Show>(tab1path); break;    //get shows information
                case 2: listShows = Theater1.ReadXML<Show>(tab2path); break;    //get shows information
                case 3: listShows = Theater1.ReadXML<Show>(tab3path); break;   //get shows informationbreak;
            }
            foreach (Button a in buttonArray)    //for the whole theater seats
            {
                foreach (Viewer b in listShows.ElementAt(INDEX).viewers)   //check everyone in the show, all the viewers
                {
                    foreach (string c in b.Seating)    //if their seats 
                    {
                        if (a.Text == c)     //match up with the button
                        {
                            a.BackColor = Color.Red;  //then turn it red indicate taken
                            a.Enabled = false;       //disable reserved seats
                            if ((b.Firstname == CUSTOMER.Firstname) && (b.Lastname==CUSTOMER.Lastname))    //checks to see if the vewer matches with the customer
                            { AlreadyReservedShow = true; }   // bool indicating person already in show
                        }
                    }
                }
            }
        }

        private void buttonArray_click(object sender, MouseEventArgs mea /* EventArgs e*/)  // this function just created by typing it
        {
            //  MouseEventArgs mea = (MouseEventArgs) e;      // you may use EventArgs above and then typecast
            if (sender.GetType() == typeof(System.Windows.Forms.Button))
            {
                int tag = (int)((System.Windows.Forms.Button)sender).Tag;       // tag is a programmer usable field
                int r = tag / 7;                                                // the index was put in this field by CreateButtons() below
                int c = tag % 7;
                int index = r * 7 + c;
                if (buttonArray[index].BackColor == Color.Green)
                    buttonArray[index].BackColor = Color.Yellow;
                else if (buttonArray[index].BackColor == Color.Yellow)
                {
                    buttonArray[index].BackColor = Color.Green; //numberofseats--;
                }
                label1.Text = "You clicked the button in Row " + r + ", Col " + c + " (zero based)";
                label2.Text = "Otherwise known as seat " + buttonArray[index].Text;
            }
            foreach (Button t in buttonArray)
            {
                if (t.BackColor == Color.Yellow)
                {
                    numberofseats++;
                }
            }
            numSeatsTB.Text = numberofseats.ToString();
            totalTB.Text = "$" + (numberofseats * 20).ToString();
            numberofseats = 0;
        }

        private void CreateButtons()
        {
            string[] rowLetterString = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            string rowDesignation;
            int seatDesignation;
            int horizotal = 210;
            int vertical = 35;

            for (int i = 0; i < buttonArray.Length; i++)
            {

                rowDesignation = SHOW.code + rowLetterString[i / 7];
                seatDesignation = (i % 7) + 1;
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(75, 35);
                buttonArray[i].Location = new Point(horizotal, vertical);
                buttonArray[i].Text = rowDesignation + seatDesignation.ToString();
                buttonArray[i].MouseUp += buttonArray_click;
                buttonArray[i].BackColor = Color.Green;
                buttonArray[i].Tag = i;
                if ((i + 1) % 7 == 0)
                {
                    vertical += 35;
                    horizotal = 210;
                }
                else
                {
                    horizotal += 75;
                }
                this.Controls.Add(buttonArray[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool AtLeast1Picked = false;
            //List<Customer> custXML = Theater1.ReadXML<Customer>("..\\..\\Customer.xml"); //get all the customers info

            if (!(AlreadyReservedShow))
            {
                //if he isn't in the list of viewers add them
                Viewer currentcustomer = new Viewer(CUSTOMER.Firstname, CUSTOMER.Lastname, CUSTOMER.Seats);
                listShows.ElementAt(INDEX).viewers.Add(currentcustomer);//access current show in list of shows and adding customer to that show
            }
            else
            {
                
                Viewer oldcust = new Viewer();
                foreach(Viewer t in listShows.ElementAt(INDEX).viewers)
                {
                    if((t.Firstname==CUSTOMER.Firstname)&&(t.Lastname==CUSTOMER.Lastname))
                    {
                        oldcust=t;
                    }
                }
                listShows.ElementAt(INDEX).viewers.Remove(oldcust);
                listShows.ElementAt(INDEX).viewers.Add(oldcust); //to put them at the end
            }
            
            foreach (Button p in buttonArray)
            {
                if (p.BackColor == Color.Yellow)
                {
                    //add the yellow seats selected to persons listing
                    int count = listShows.ElementAt(INDEX).viewers.Count;
                    listShows.ElementAt(INDEX).viewers.ElementAt(count - 1).Seating.Add(p.Text); //add to the viewers seating list
                    AtLeast1Picked = true; //make it true indicate person picked at least one
                }
            }

            if (AtLeast1Picked)
            {
                foreach (Button reserve in buttonArray)
                {
                    if (reserve.BackColor == Color.Yellow)
                    {
                        reserve.BackColor = Color.Red;
                        reserve.Enabled = false;
                    }
                }
                /*Customer cust = new Customer();

                foreach (Customer a in custXML)
                {
                    if (a.Firstname == CUSTOMER.Firstname)
                    {
                        cust = a;
                    }
                }
                custXML.Remove(cust);
                custXML.Add(CUSTOMER);
                Theater1.WriteXML<Customer>("..\\..\\Customer.xml", custXML);*/
                switch(THEATER)
                {
                    case 1: Theater1.WriteXML<Show>(tab1path, listShows); break;
                    case 2: Theater1.WriteXML<Show>(tab2path, listShows); break;
                    case 3: Theater1.WriteXML<Show>(tab3path, listShows); break;
                }
                AtLeast1Picked = false;
                MessageBox.Show("Seats successfully reserved.");
            }
            else { MessageBox.Show("Please select at least 1 seat."); }
        }

        #region useless functions that cannot be removed for the sake of the design program not crashing
        private void CancelTicket_Clicked(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Theater1.WriteXML<Schedule>(tab1path, refresh);
            //this.Close();
        }
        #endregion

        private void exitBN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
          /*  bool AtLeast1Picked = false;
            List<Customer> custXML = Theater1.ReadXML<Customer>("..\\..\\Customer.xml");
            if (!(AlreadyReservedShow))
            {
                Viewer currentcustomer = new Viewer(CUSTOMER.Firstname, CUSTOMER.Lastname, CUSTOMER.Seats);
                listShows.ElementAt(INDEX).viewers.Add(currentcustomer);//access current show in list of shows and adding customer to that show
            }
            foreach (Button a in buttonArray)
            {
                if (a.Text == CancelTB.Text)
                {
                    a.BackColor = Color.Green;
                    a.Enabled = true;
                }

            }
            foreach (string cancelled in listShows.ElementAt(INDEX).viewers.ElementAt(INDEX).Seating)
            {
                if (cancelled == CancelTB.Text)
                {
                    listShows.ElementAt(INDEX).viewers.ElementAt(INDEX).Seating.Remove(cancelled);
                }
            }
            Customer cust = new Customer();
            foreach (Customer a in custXML)
            {
                if (a.Firstname == CUSTOMER.Firstname)
                {
                    cust = a;
                }
            }
            custXML.Remove(cust);
            custXML.Add(CUSTOMER);
            Theater1.WriteXML<Customer>("..\\..\\Customer.xml", custXML);
            Theater1.WriteXML<Show>(tab1path, listShows);
            AtLeast1Picked = false;
            MessageBox.Show("Seats successfully cancelled.");*/

        }
    }
}
