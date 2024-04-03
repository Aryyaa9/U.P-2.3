using System;
class Calculation
{
    string calculationLine;
    public string CalculationLine
    {
        get { return calculationLine; }
    }
    
    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (calculationLine.Length > 0)
        {
            return calculationLine[calculationLine.Length - 1];
        }
        else
        {
            throw new InvalidOperationException("Строка вычислений пуста");
        }
    }

    public void DeleteLastSymbol()
    {
        if (calculationLine.Length > 0)
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
        else
        {
            throw new InvalidOperationException("Нечего удалять, строка вычислений пуста");
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();

        calc.SetCalculationLine("2+2");
        Console.WriteLine(calc.GetCalculationLine()); 

        calc.SetLastSymbolCalculationLine('5');
        Console.WriteLine(calc.GetCalculationLine());

        Console.WriteLine(calc.GetLastSymbol()); 

        calc.DeleteLastSymbol();
        Console.WriteLine(calc.GetCalculationLine()); 

        calc.DeleteLastSymbol();
        calc.DeleteLastSymbol(); 
    }
}