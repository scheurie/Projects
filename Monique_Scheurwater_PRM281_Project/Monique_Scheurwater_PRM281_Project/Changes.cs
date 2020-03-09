using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monique_Scheurwater_PRM281_Project
{
    public class Changes
    {
        private string  full, changetype;
        
        public string Full
        {
            get { return full; }
            set { full = value; }
        }
        public string Changetype
        {
            get { return changetype; }
            set { changetype = value; }
        }
        public Changes(string full, string changetype)
        {
            this.full = full;
            this.changetype = changetype;
        }
        public Changes()
        {}
        
        public override string ToString()
        {
            return string.Format(full + "#" + changetype);
        }
    }
}
