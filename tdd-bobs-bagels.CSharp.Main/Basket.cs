using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int _capacity;

        public Basket(int capacity) => this._capacity = capacity;

        public bool Add(string name)
        {
            return false;
        }

        public bool changeCapacity(int new_capasity)
        {
            return false;
        }

        public bool Remove(string name)
        {
            return false;
        }
    }
}
