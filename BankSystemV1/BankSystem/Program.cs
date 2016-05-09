using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    class Program
    {
        
         static void Main(string[] args)
        {
            Bank bk = new Bank();
            string output = "Press 0 to use the ATM, press 1 to manage your account,press n to exit";
            while (true)
            {
                Show(output);
                string op = GetInput();
                if (op=="n")
                {
                    break;
                }
                switch (op)
                {
                    case ("0"):
                        {
                            string op_atm;
                            ATM atm = new ATM(bk);
                            while (true)
                            {
                                Show("input any key to use ATM or Press n to exit");
                                op_atm = GetInput();
                                if (op_atm == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    atm.Transaction();
                                }
                            }
                        }
                        break;//ATM
                    case ("1"):
                        {
                            string op_bank;
                            while (true)
                            {
                                Show("input any key to manage your account or Press n to exit");
                                op_bank = GetInput();
                                if (op_bank == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    bk.init();
                                }
                            }
                        }
                        break;//Bank
                    default:
                        break;
                }
            }
        }
        public static void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string GetInput()
        {
            return Console.ReadLine();// 输入字符
        }
    }
}
