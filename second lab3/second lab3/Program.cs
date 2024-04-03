using System;
class Worker
{
    private string Name { get; }
    private string Surname { get; }
    private double Rate { get; }
    private int Days { get; }
    
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
    
    public string GetName()
    {
        return Name;
    }

    public string GetSurname()
    {
        return Surname;
    }

    public double GetRate()
    {
        return Rate;
    }

    public int GetDays()
    {
        return Days;
    }
    
    public void GetSalary()
    {
        double salary = Rate * Days;
        Console.WriteLine($"Зарплата работника {Name} {Surname} за {Days} дней работы составляет: {salary}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        string surname = Console.ReadLine();

        Console.WriteLine("Введите ставку за день работы:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите количество отработанных дней:");
        int days = Convert.ToInt32(Console.ReadLine());
        
        Worker worker = new Worker(name, surname, rate, days);
        
        Console.WriteLine($"Имя: {worker.GetName()}");
        Console.WriteLine($"Фамилия: {worker.GetSurname()}");
        Console.WriteLine($"Ставка за день работы: {worker.GetRate()}");
        Console.WriteLine($"Количество отработанных дней: {worker.GetDays()}");
        worker.GetSalary();
    }
}