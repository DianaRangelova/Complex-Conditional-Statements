int numb1 = int.Parse(Console.ReadLine());
int numb2 = int.Parse(Console.ReadLine());
int numb3 = int.Parse(Console.ReadLine());

if (numb1 > numb2)
{
    {
        if (numb1 > numb3)
            Console.WriteLine(numb1);
        else
            Console.WriteLine(numb3);
    }
}
else
{
    if (numb2 > numb3)
        Console.WriteLine(numb2);
    else
        Console.WriteLine(numb3);
}
