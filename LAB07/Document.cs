using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Document
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Наименование документа не может быть пустым");
                }
                title = value;
            }
        }
        public DateTime RegistrationDate { get; set; } 
        public DateTime ExecutionDate { get; set; } 
        public string Status { get; set; }
        public int Priority { get; set; }
        public Document(string title, DateTime registrationDate, DateTime executionDate, string status)
        {
            Title = title;
            RegistrationDate = registrationDate;
            ExecutionDate = executionDate;
            Status = status;                                                                                 
        }
        public virtual TimeSpan GetDaysToExecution()
        {
            return ExecutionDate - DateTime.Now;
        }
        public int DaysToExecution
        {
            get
            {
                return GetDaysToExecution().Days;
            }
        }
        public virtual int GetPriority()
        {
            int days = DaysToExecution;
            if (days <= 2) Priority = 4;
            else if (days > 2 && days <= 7) Priority = 3;
            else if (days > 7 && days <= 30) Priority = 2;
            else Priority = 1;

            return Priority;
        }
        public override string ToString()
        {
            return $"Наименование документа: {Title}\n" +
                $"Дата регистрации: {RegistrationDate}\n" +
                $"Срок исполнения: {DaysToExecution} дней\n" +
                $"Статус документа: {Status}\n" +
                $"Приоритет: {GetPriority()}";
        }
    }
}
