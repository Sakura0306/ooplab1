using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1 {
    class Transaction {
        public Human seller;
        public Human buyer;
        public decimal price;
        public DateTime date;

        public Transaction(Human seller, Human buyer, decimal price, DateTime date) {
            this.seller = seller;
            this.buyer = buyer;
            this.price = price;
            this.date = date;
        }

        public void printTransaction() {
            Console.WriteLine(seller.name + " sold to " + buyer.name + " at " + date + " for " + price);
        }
    }
}
