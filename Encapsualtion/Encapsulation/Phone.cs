using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation;

public class Phone : Product
{
    
    private int _ram;
    private string _color;
    private decimal _balance;

    public Phone(string brandName, string model, int price, int cost, int count, int ram, string color, decimal balance) : base(brandName, model, price, cost, count)
    {
        Ram = ram;
        Color = "black";
        Balance = balance;



    }
   public decimal Call(int seconds, decimal balance)
    {
        if (balance <= 0)
        {
            Console.WriteLine("balansınızı artırın ");
        }
        else
        {

        Console.WriteLine("zeng edildi");
            for (int i = 1; i <= seconds; i++)
            {
                balance -= 0.1m;
            if (balance <= 0)
            {
                Console.WriteLine($"{i} ci saniyede balansınız bitdi ");
                    break;
                
            }
            }
               
        }
        return balance;
    }

    public int Ram
    {
        get { return _ram; }
        set
        {
            if (value > 0) 
            {
                _ram = value;
            }
            else
            {
                Console.WriteLine("RAM must be greater than 0."); 
            }
        }
    }

    public string Color
    {
        get { return _color; }
        set
        {
            if (!string.IsNullOrEmpty(value)) 
            {
                _color = value;
            }
            else
            {
                Console.WriteLine("Color cannot be empty."); 
            }
        }
    }

    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0) 
            {
                _balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative."); 
            }
        }
    }



}
