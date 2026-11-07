using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Letter : Document
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        private string subject;
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Тема письма не может быть пустой");
                }
                subject = value;
            }
        }
        public Letter(string title, DateTime registrationDate, DateTime executionDate, string status,
            string sender, string recipient, string subject) : base(title, registrationDate, executionDate, status)
        {
            Sender = sender;
            Recipient = recipient;
            Subject = subject;
        }
        public override int GetPriority()
        {
            int basePriority = base.GetPriority();

            if (Subject.Contains("срочно") && basePriority < 4)
            {
                return basePriority + 1;
            }
            else return basePriority;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nОтправитель: {Sender}\n" +
                $"Получатель: {Recipient}\n" +
                $"Тема письма: {Subject}";
        }
    }
}
