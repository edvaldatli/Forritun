using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greidslukort
{
    public class CreditCard
    {
        private string number;
        private string name;
        private string bank;
        private double balance;
        private double limit;
        private double heildarupphaed;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Bank
        {
            get
            {
                return bank;
            }
            set
            {
                bank = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public double Limit
        {
            get
            {
                return limit;
            }
            set
            {
                limit = value;
            }
        }
        public void kortagreiðsla (double upphæð)
        {
            if (balance < upphæð)
            {
                Console.WriteLine();
                Console.WriteLine("Ekki nóg inn á kortinu");
            }
            else if (limit < upphæð)
            {
                Console.WriteLine();
                Console.WriteLine("Þú hefur ekki heimild til að taka svona háa upphæð af kortinu!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(upphæð + "Kr hafa verið tekið af kortinu.");
                balance -= upphæð;
                Console.WriteLine("Inneign korts: " + balance);
                Console.WriteLine();
            }
        }
        public void upplysingar()
        {
            Console.WriteLine("Card Number: " + number);
            Console.WriteLine("Cardholders Name: " + name);
            Console.WriteLine("Bank: " + bank);
            Console.WriteLine("Balance of card: " + balance);
            Console.WriteLine("Withdrawal limit: " + limit);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            int onoff = 1;
            double userInput;

            CreditCard CC = new CreditCard();
            CC.Number = "1234-1234-1234-1234";
            CC.Name = "Magnús Trausti Valgarðsson";
            CC.Bank = "Arion Banki";
            CC.Balance = 321334;
            CC.Limit = 25000;

            CC.upplysingar();

            while(onoff == 1)
            {
                Console.WriteLine("Hvað viltu taka háa upphæð af kortinu?");
                Console.WriteLine("Sláðu inn 0 til að hætta");
                userInput = Convert.ToDouble(Console.ReadLine());
                CC.kortagreiðsla(userInput);
                Console.WriteLine();
                if (userInput == 0)
                {
                    onoff = 0;
                }
            }
        }
    }

    
}
