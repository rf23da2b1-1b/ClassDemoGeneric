using ClassDemoGeneric.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoGeneric.DrinkKort
{
    public class Kort
    {
        private List<Drink> _drinks;

        public Kort()
        {
            _drinks = new List<Drink>();
        }

        public List<Drink> Drinks()
        {
            return new List<Drink>(_drinks);
        }

        public void InsertFirst(Drink drink)
        {
            _drinks.Insert(0, drink);
        }
    }
}
