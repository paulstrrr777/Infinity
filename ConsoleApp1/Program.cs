
Infinity();

 //NumberA();

 float NumberA()
{
    Console.Write("Input firrst number a : ");
    float a;
    string? str = Console.ReadLine();
    bool result = float.TryParse(str, out a);
    while (!result)
    {
        Console.Write($"You input {str}, type float number a = ");
        str = Console.ReadLine();
        result = float.TryParse(str, out a);
    }
    return a;
}
//NumberB();

 float NumberB()
{
    Console.Write("Input firrst number b : ");
    float a;
    string? str = Console.ReadLine();
    bool result = float.TryParse(str, out a);
    while (!result)
    {
        Console.Write($"You input {str}, type float number b = ");
        str = Console.ReadLine();
        result = float.TryParse(str, out a);
    }
    return a;
}

float Infinity()
{
    float a = NumberA();
    float b = NumberB();
    float c = a / b;
    Console.WriteLine("Infinity most been then b = 0 ");
        Console.WriteLine($" a = {a} , b = {b} , a/b = {c} ");
    return a/b;
}
