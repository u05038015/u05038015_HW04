using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u05038015_HW04.Models
{
    public abstract class Organisation
    {
        public string _Name { get; set; }
        public string _NPO { get; set; }
        

        public Organisation(string name, string npo)
        {
            _Name = name;
            _NPO = npo;
        }

        public virtual string getName()
        {
            return _Name;
        }

        public virtual string getNPO()
        {
            return _NPO;
        }

        public abstract string PassInfo();
    }
}