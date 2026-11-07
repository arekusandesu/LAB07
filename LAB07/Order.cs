using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Order : Document
    {
        public string Issuer { get; set; }
        public string Subject { get; set; }
        public Order(string title, DateTime registrationDate, DateTime executionDate, string status,
            string issuer, string subject) : base(title, registrationDate, executionDate, status)
        {
            Issuer = issuer;
            Subject = subject;
        }
        public override int GetPriority()
        {
            int basePriority = base.GetPriority();

            if (basePriority < 4)
            {
                return basePriority + 1;
            }
            else return basePriority;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nКем выдано: {Issuer}\n" +
                $"Предмет распоряжения: {Subject}";
        }
    }
}
