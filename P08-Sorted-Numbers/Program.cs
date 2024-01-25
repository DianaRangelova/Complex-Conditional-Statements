int numb1 = int.Parse(Console.ReadLine());
int numb2 = int.Parse(Console.ReadLine());
int numb3 = int.Parse(Console.ReadLine());

if (numb1 < numb2 && numb2 < numb3)
{
    Console.WriteLine("Ascending");
}
else if (numb1 > numb2 && numb2 > numb3)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}