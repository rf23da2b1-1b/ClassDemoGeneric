using ClassDemoGeneric.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoGeneric.DrinkKort
{
    public class KortGeneric<T>
    {

        private List<T> _items;

        public KortGeneric()
        {
            _items = new List<T>();
        }

        public List<T> AllItems()
        {
            return new List<T>(_items);
        }

        public void InsertFirst(T item)
        {
            _items.Insert(0, item);
        }
    }
}
