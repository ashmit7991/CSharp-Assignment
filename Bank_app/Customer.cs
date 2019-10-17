using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app
{
    class Customer
    {
        public int id;
        public string name;
        public float opening_balance;

        public Customer(int id, string name, float opening_balance)
        {
            this.id = id;
            this.name = name;
            this.opening_balance = opening_balance;
        }

        public void deposite(float amount)
        {
            opening_balance = opening_balance + amount;
        }
        public void withdrawn(float amount)
        {
            opening_balance = opening_balance - amount;
        }
    }
}

