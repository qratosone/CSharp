using System;
using System.Collections;
using System.Collections.Generic;
using BankSystem;
public class Bank {
    public void Show(string msg)
    {
        Console.WriteLine(msg);
    }
    public string GetInput()
    {
        return Console.ReadLine();// 输入字符
    }
    List<Account> accounts = new List<Account>();
    public Account FindAccount()
    {
        Show("input your account ID ");
        string id_close = GetInput();
        Show("input your password");
        string pwd_close = GetInput();
        Account find = FindAccount(id_close, pwd_close);
        return find;
    }
	public void init()
    {
        Show("1: open account; 2: close account; 3: find account;4: open credit account");
        string op = GetInput();
        if (op == "1")
        {
            string input_id;
            string input_pwd;
            string input_money;
            Show("input your id");
            input_id = GetInput();
            Show("input your password");
            input_pwd = GetInput();
            Show("input your money");
            input_money = GetInput();
            double money = Convert.ToDouble(input_money);
            Show("press c to open an credit card,or press any key to go on");
            bool credit = false;
            string opCredit = GetInput();//在这里添加了建立信用卡的选项
            if (opCredit=="c")
            {
                credit = true;
            }
            if (OpenAccount(input_id,input_pwd,money,credit)!=null)
            {
                Show("open succeed!");
            }
            else
            {
                Show("Failed!");
            }
        }
        else if (op == "2")
        {
            Account close = FindAccount();
            if (close!=null)
            {
                Show("your account found, confirm closing? Press y to confirm");
                string confirm = GetInput();
                if (confirm=="y")
                {
                    if (CloseAccount(close))
                    {
                        Show("close succeed!");
                    }
                    else
                    {
                        Show("close failed!");
                    }
                }
            }
            else
            {
                Show("invalid account!");
            }
        }
        else if (op == "3")
        {
            Account find = FindAccount();
            if (find!=null)
            {
                Show("succeed!");

            }
            else
            {
                Show("invalid account!");
            }

        }

    }
	public Account OpenAccount(string id, string pwd, double money,bool credit)
	{
        Account ac;
        if (credit)
        {
            ac = new Credit(id, pwd, money, 1500);
        }
        else
        {
           ac = new Account(id, pwd, money);
        }
		
		accounts.Add( ac );
		return ac;
	}
	
	public bool CloseAccount( Account account) 
	{
		int idx = accounts.IndexOf(account);
		if( idx<0 )return false;
		accounts.Remove(account);
		return true;		
	}
	
	public Account FindAccount(string id, string pwd)
	{
		foreach(Account account in accounts)
		{
			if( account.IsMatch(id, pwd))
			{
				return account;
			}
		}
        //for (int i = 0; i < accounts.Count; i++)
        //{
        //    Account account = accounts[i];

        //    if( account.IsMatch(id, pwd))
        //    {
        //        return account;
        //    }
        //}

		return null;
	}
	
}
