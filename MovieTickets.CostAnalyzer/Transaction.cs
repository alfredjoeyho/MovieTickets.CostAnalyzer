using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTickets.CostAnalyzer
{
    public class Transaction
    {
        public int transactionId { get; set; }
        public List<Customers> customers { get; set; }
    }

    public class Customers
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    public class Number {
        public int adult { get; set; }
        public int teen { get; set; }
        public int senior { get; set; }
        public int children { get; set; }
    }

    public class WholeTransaction
    {
        public Transaction Transaction { get; set; }
        public Number num { get; set; }
        public double childTotal { get; set; }
    }
}

