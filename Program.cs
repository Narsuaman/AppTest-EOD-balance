using System;
using Newtonsoft.Json;
using System.IO;
using System.Security.Principal;

public class account
{
    public string accountId { get; set; }
    public balances balances { get; set; }
    public transaction[] transactions { get; set; }
}

public class balances
{
    public current current { get; set; }
    public available available { get; set; }
}

public class current
{
    public decimal amount { get; set; }
    public string creditDebitIndicator { get; set; }
}

public class available
{
    public decimal amount { get; set; }
    public string creditDebitIndicator { get; set; }
}

public class transaction
{
    public string transactionId { get; set; }
    public string description { get; set; }
    public decimal amount { get; set; }
    public string creditDebitIndicator { get; set; }
    public string status { get; set; }
}


class AccountBalance
{
    public AccountBalance(decimal TotalDebit, decimal TotalCredit, decimal EndOfDayBalance)
    {
       Console.WriteLine(" Credit "+TotalCredit+" Debit "+TotalDebit+" EOD "+EndOfDayBalance);    }


    public AccountBalance CalculateEndOfDayBalance(string accountJson)
    {
        var account = JsonConvert.DeserializeObject<account>(accountJson);
        var totalDebit = 0M;//This is a type decimal
        var totalCredit = 0M;//This is a type decimal
        foreach (var transaction in account.transactions)
        {
            if (transaction.creditDebitIndicator == "Debit") { totalDebit += transaction.amount; }
            else { totalCredit += transaction.amount; }
        }
        var endOfDayBalance = account.balances.current.amount - totalDebit + totalCredit;

        return new  AccountBalance ( totalDebit, totalCredit, endOfDayBalance);


    }
}


public class MainProgram
{
    public static void Main()
    {

        string fileName = "TestJsn.json";
        string jsonString = File.ReadAllText(fileName);//loading the file located in the bin
        decimal a=0.00M, b = 0.00M, c = 0.00M;
        AccountBalance accountBalance = new AccountBalance(a, b, c);
        accountBalance.CalculateEndOfDayBalance(jsonString);
        Console.ReadLine();
    }

}


