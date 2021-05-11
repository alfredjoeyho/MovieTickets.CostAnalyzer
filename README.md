# MovieTickets.CostAnalyzer
# Sportsbet Risk and Trading Platforms .NET Coding Test: Movie Tickets - Cost Analyser

## Overview
In a world of Netflicks, Hoolu, Amayzon Prime and other video streaming services, movie watching customers are dwindling. The powers that be have decided to slash movie ticket prices to entice customers back into cinemas. We have been tasked to build an application that reports the projected cost of movie tickets from historical customer transactions to inform decision making around ticket pricing.

## Requirements

* There are four types of movie tickets
  * **Adult**: For customers 18 years and older but less than 65 years old. Costs $25.
  * **Senior**: For customers 65 years and older. 30% cheaper than Adult tickets
  * **Teen**: For customers 11 years and older but less than 18 years old. Costs $12
  * **Children**: For customers less than 11 years of age. Costs $5.
* If there are 3 or more **Children**'s tickets in a transaction, there's a 25% discount applied to the cost of **Children**'s tickets

Your task is to implement a .NET Core console application which for each transaction in `src/MovieTickets.CostAnalyzer/transactions.json`, prints to the console the following
* The ID of the transaction
* Each individual type of movie ticket present in that transaction, ordered alphabetically, and it's quantity and total cost
* The total cost of all movie tickets for that transaction

Ensure any domain logic has associated unit tests.

## Sample input and output
For this given input in `transactions.json`,
```
[
    {
        "TransactionId": 1,
        "Customers": [
            {
                "Name": "John Smith",
                "Age": 70
            },
            {
                "Name": "Jane Doe",
                "Age": 5
            },
            {
                "Name": "Bob Doe",
                "Age": 6
            }
        ]
    },
    {
        "TransactionId": 2,
        "Customers": [
            {
                "Name": "Billy Kidd",
                "Age": 36
            },
            {
                "Name": "Zoe Daniels",
                "Age": 3
            },
            {
                "Name": "George White",
                "Age": 8
            },
            {
                "Name": "Tommy Anderson",
                "Age": 9
            },
            {
                "Name": "Joe Smith",
                "Age": 17
            }
        ]
    },
    {
        "TransactionId": 3,
        "Customers": [
            {
                "Name": "Jesse James",
                "Age": 36
            },
            {
                "Name": "Daniel Anderson",
                "Age": 95
            },
            {
                "Name": "Mary Jones",
                "Age": 15
            },
            {
                "Name": "Michelle Parker",
                "Age": 10
            }
        ]
    }
]
```
the expected console output would be
```
## Transaction 1 ##
Children ticket x 2: $10
Senior ticket x 1: $17.50

Projected total cost: $27.50

## Transaction 2 ##
Adult ticket x 1: $25.00
Children ticket x 3: $11.25
Teen ticket x 1: $12.00

Projected total cost: $48.25

## Transaction 3 ##
Adult ticket x 1: $25.00
Children ticket x 1: $5
Senior ticket x 1: $17.50
Teen ticket x 1: $12.00

Projected total cost: $59.50
```

You're free to use whatever development tools and libraries you want to implement the above requirements. You're also free to add any additional files or projects as you see fit.

## Dependencies
* Requires the .NET Core 3.1 SDK to build, test and run code. It can be downloaded here at https://dotnet.microsoft.com/download/dotnet-core/3.1
