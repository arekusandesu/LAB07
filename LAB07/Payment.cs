using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Payment : Document
    {
        public decimal Amount { get; set; }
        public string ServiceType { get; set; }
        public string Payee { get; set; }
        public Payment(string title, DateTime registrationDate, DateTime executionDate, string status,
            decimal amount, string serviceType, string payee) : base(title, registrationDate, executionDate, status)
        {
            Amount = amount;
            ServiceType = serviceType;
            Payee = payee;
        }
        public override int GetPriority()
        {
            int basePriority = base.GetPriority();

            if (Amount > 1000 && basePriority < 4)
            {
                return basePriority + 1;
            }
            else return basePriority;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nСумма оплаты: {Amount}\n" +
                $"Вид услуги: {ServiceType}\n" +
                $"Получатель платежа: {Payee}";
        }
    }
}
