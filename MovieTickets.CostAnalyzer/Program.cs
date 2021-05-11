using MovieTickets.CostAnalyzer.Service;
using System;
using System.Collections.Generic;
using System.IO;

namespace MovieTickets.CostAnalyzer
{
    class Program
    {
        static void Main()
        {
            Program Program = new Program();
            MovieTicketsService _movieTicketsService = new MovieTicketsService();
            var transactionList = Program.ReadJson();

            foreach (var t in transactionList)
            {
                var wholeTransaction = _movieTicketsService.ProcessTransaction(t);
                _movieTicketsService.Display(wholeTransaction);
            }
            Console.ReadLine();
        }
        public List<Transaction> ReadJson()
        {
            string jsonPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\\transactions.json"));
            var jsonString = System.IO.File.ReadAllText(jsonPath);
            var transactionList = new List<Transaction>();

            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
            foreach (var json in jsonObj)
            {
                var tran = new Transaction
                {
                    transactionId = json["TransactionId"],
                    customers = json["Customers"].ToObject<List<Customers>>()
                };
                transactionList.Add(tran);
            }
            return transactionList;
        }
    }
}
