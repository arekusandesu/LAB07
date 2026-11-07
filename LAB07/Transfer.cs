using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07
{
    public class Transfer : Document
    {
        public string From { get; set; }
        public string To { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Transfer(string title, DateTime registrationDate, DateTime executionDate, string status,
            string from, string to, string itemName, int quantity) : base(title, registrationDate, executionDate, status)
        {
            From = from;
            To = to;
            ItemName = itemName;
            Quantity = quantity;
        }
        public override int GetPriority()
        {
            int basePriority = base.GetPriority();

            if (Quantity > 50 && basePriority < 4)
            {
                return basePriority + 1;
            }
            else return basePriority;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nОт кого: {From}\n" +
                $"Кому: {To}\n" +
                $"Наименование ценностей: {ItemName}\n" +
                $"Количество: {Quantity}";
        }
    }
}
