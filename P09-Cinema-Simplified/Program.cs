string typeOfMovie = Console.ReadLine();
int countOfTheRows = int.Parse(Console.ReadLine());
int countOfTheSeatsPerRow = int.Parse(Console.ReadLine());

double seatPrice = 0;

if (typeOfMovie == "Normal")
{
    seatPrice = 7.50;
}
else if (typeOfMovie == "Premiere")
{
    seatPrice = 12.00;
}
else if (typeOfMovie == "Discount")
{
    seatPrice = 5.00;
}

double totalPrice = seatPrice * countOfTheRows * countOfTheSeatsPerRow;
Console.WriteLine($"{totalPrice:F2}");