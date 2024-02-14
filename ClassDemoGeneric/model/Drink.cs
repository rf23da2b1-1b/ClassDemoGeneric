using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassDemoGeneric.model
{
    public class Drink
    {
		private int _id;
		private string _name;
		private string _description;
		

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
        public string Name
        {
            get { return _name; }
            set { _name = value; }
            
            
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Drink()//:this(0,"","")
        {
            Id = 0;
            Name = "";
            Description = "";
        }

        public Drink(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}}}";
        }
    }
}
