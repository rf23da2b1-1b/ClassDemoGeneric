using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoGeneric.model
{
    public class Kage
    {
        private int _id;
        private string _name;
        private double _price;


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
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Kage() : this(0, "", 0)
        {
        }

        public Kage(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
