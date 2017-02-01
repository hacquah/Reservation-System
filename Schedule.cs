using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    public class Show
    {
        private DateTime info;
        private string name;
        public List<Viewer> viewers;
        public string code;

        public DateTime Info
        {
            get { return info; }
            set { info = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Show() 
        {
            viewers = null;
        }

        public Show(DateTime datetime, string NAME,string Code)
        {
            Info = datetime;
            name = NAME;
            viewers = null;
            code = Code;
        }
    }
}
