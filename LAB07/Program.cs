using LAB07;

Document[] documents =
{
    new Order("Приказ о приеме", new DateTime(2026, 11, 1), new DateTime(2026, 11, 6), "Зарегистрирован", "Директор", "Принять на работу"),
    new Letter("Коммерческое", new DateTime(2026, 10, 25), new DateTime(2026, 11, 12), "В работе", "ООО Ромашка", "Наша фирма", "Срочно: обсудить контракт"),
    new Payment("Оплата интернета", new DateTime(2026, 11, 1), new DateTime(2026, 11, 21), "Зарегистрирован", 15000m, "Интернет", "Провайдер"),
    new Transfer("Передача ноутбука", new DateTime(2026, 11, 5), new DateTime(2026, 11, 8), "Выполнен", "Иванов", "Петров", "Ноутбук", 1),
    new Order("Приказ о премии", new DateTime(2026, 10, 20), new DateTime(2026, 12, 10), "Зарегистрирован", "Директор", "Выплатить премию"),
    new Letter("Служебная записка", new DateTime(2026, 10, 15), new DateTime(2027, 1, 15), "В работе", "Начальник отдела", "Директор", "Запрос на отпуск"),
    new Payment("Оплата канцтоваров", new DateTime(2026, 11, 6), new DateTime(2026, 11, 10), "Зарегистрирован", 500m, "Канцтовары", "Магазин"),
    new Transfer("Передача документов", new DateTime(2026, 10, 30), new DateTime(2026, 11, 14), "Отменен", "Секретарь", "Архив", "Папка с договорами", 100),
    new Order("Приказ об увольнении", new DateTime(2026, 10, 15), new DateTime(2026, 10, 28), "В работе", "Директор", "Уволить сотрудника"),
    new Letter("Уведомление от налоговой", new DateTime(2026, 9, 1), new DateTime(2027, 5, 1), "Зарегистрирован", "Налоговая", "Наша фирма", "Требование о предоставлении документов")
};

foreach (var doc in documents)
{
    Console.WriteLine(doc);
    Console.WriteLine();
}

int maxPriority = documents[0].Priority;
for (int i = 1; i < documents.Length; i++)
{
    if (documents[i].Priority > maxPriority)
    {
        maxPriority = documents[i].Priority;
    }
}
Console.WriteLine($"\nНаивысший приоритет у документов:");
for (int i = 0; i < documents.Length; i++)
{
    if (documents[i].Priority == maxPriority)
    {
        Console.WriteLine($"{documents[i].Title}");
    }
}


int minExecution = documents[0].DaysToExecution;
for (int i = 1; i < documents.Length; i++)
{
    if (documents[i].DaysToExecution < minExecution)
    {
        minExecution = documents[i].DaysToExecution;
    }
}
Console.WriteLine($"\nНаименьший срок до исполнения ({minExecution}) у документов: ");
for (int i = 0; i < documents.Length; i++)
{
    if (documents[i].DaysToExecution == minExecution)
    {
        Console.WriteLine($"{documents[i].Title}");
    }
}