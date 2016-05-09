using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    public class Credit: Account
    {
        
        private double limit;
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
        public Credit(string id,string pwd,double money,double limit):base(id,pwd,money)
        {
            this.limit = limit;
        }
        private bool updateCredit(bool flag)
        {
            if (flag)
            {
                Limit = Money + 1500;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool SaveMoney(double money)
        {
            bool result=base.SaveMoney(money);
            return updateCredit(result);
        }
        public override bool WithdrawMoney(double money)
        {
            bool result= base.WithdrawMoney(money);
            return updateCredit(result);
        }
    }
}
