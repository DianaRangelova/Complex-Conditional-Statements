string typeOfMovie = Console.ReadLine();
int countOfTheRows = int.Parse(Console.ReadLine());
int countOfTheSeatsPerRow = int.Parse(Console.ReadLine());

if (typeOfMovie == "Normal")
{
    double seat = 7.50;
    double totalCountOfTheSeats = countOfTheRows * countOfTheSeatsPerRow;
    double totalPrice = totalCountOfTheSeats * seat;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (typeOfMovie == "Premiere")
{
    double seat = 12.00;
    double totalCountOfTheSeats = countOfTheRows * countOfTheSeatsPerRow;
    double totalPrice = totalCountOfTheSeats * seat;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (typeOfMovie == "Discount")
{
    double seat = 5.00;
    double totalCountOfTheSeats = countOfTheRows * countOfTheSeatsPerRow;
    double totalPrice = totalCountOfTheSeats * seat;
    Console.WriteLine($"{totalPrice:F2}");
}