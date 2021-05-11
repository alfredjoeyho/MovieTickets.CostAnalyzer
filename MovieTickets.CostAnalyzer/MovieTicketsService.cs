using System;
namespace MovieTickets.CostAnalyzer.Service
{
    public class MovieTicketsService
    {
        const double SENIOR_DISCOUNT = 0.7;
        const double CHILDREN_FOR_THREE_DISCOUNT = 0.75;
        const int ADULT_TEEN_ = 11;
        const int ADULT_AGE_MIN = 18;
        const int ADULT_AGE_MAX = 65;
        const int NUM_CHILD_GET_DISCOUNT = 3;
        const double CHILD_PRICE = 5;
        const double TEEN_PRICE = 12;
        const double ADULT_PRICE = 25;

        public WholeTransaction ProcessTransaction(Transaction t)
        {
                var num = new Number();
                var customers = t.customers;
                double childTotal = 0;
                foreach (var customer in customers)
                {
                    if (customer.age >= ADULT_AGE_MIN && customer.age < ADULT_AGE_MAX)
                    {
                        num.adult += 1;
                    }
                    else if (customer.age >= ADULT_AGE_MAX)
                    {
                        num.senior += 1;
                    }
                    else if (customer.age >= ADULT_TEEN_ && customer.age < ADULT_AGE_MIN)
                    {
                        num.teen += 1;
                    }
                    else
                    {
                        num.children += 1;
                    }
                }
                var wholeTransaction = new WholeTransaction();
                wholeTransaction.childTotal = childTotal;
                wholeTransaction.Transaction = t;
                wholeTransaction.num = num;
                return wholeTransaction;
        }
        public void Display(WholeTransaction wholeTransaction)
        {
            Console.WriteLine("## TransactionId " + wholeTransaction.Transaction.transactionId + " ##");
            if (wholeTransaction.num.children > 0)
            {
                wholeTransaction.childTotal = wholeTransaction.num.children >= NUM_CHILD_GET_DISCOUNT ? wholeTransaction.num.children * CHILD_PRICE * CHILDREN_FOR_THREE_DISCOUNT : wholeTransaction.num.children * CHILD_PRICE;
                Console.WriteLine("Children ticket x " + wholeTransaction.num.children + ": $" + wholeTransaction.childTotal);
            }

            if (wholeTransaction.num.adult > 0)
            {
                Console.WriteLine("Adult ticket x " + wholeTransaction.num.adult + ": $" + wholeTransaction.num.adult * ADULT_PRICE);
            }

            if (wholeTransaction.num.teen > 0)
            {
                Console.WriteLine("Teen ticket x " + wholeTransaction.num.teen + ": $" + wholeTransaction.num.teen * TEEN_PRICE);
            }

            if (wholeTransaction.num.senior > 0)
            {
                Console.WriteLine("Senior ticket x " + wholeTransaction.num.senior + ": $" + wholeTransaction.num.senior * ADULT_PRICE * SENIOR_DISCOUNT);
            }
            double total = wholeTransaction.num.adult * ADULT_PRICE + wholeTransaction.childTotal + wholeTransaction.num.teen * TEEN_PRICE + wholeTransaction.num.senior * ADULT_PRICE * SENIOR_DISCOUNT;
            Console.WriteLine("Projected total cost: $" + total);
            Console.WriteLine();
        }
    }
}
