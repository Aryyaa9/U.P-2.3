using System;
class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }
    
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
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
        
        worker.GetSalary();
    }
}