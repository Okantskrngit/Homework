

// Ödev 7


Console.Write("Öğrenci sayısı: ");
int totalStudent = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= totalStudent; i++)
{
    Console.Write("Öğrencinin adı: ");
    string firstName = Console.ReadLine();

    Console.Write("Öğrencinin soyadı: ");
    string lastName = Console.ReadLine();

    Console.Write("Öğrencinin birinci notu: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Öğrencinin ikinci notu: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Öğrencinin üçüncü notu: ");
    int number3 = Convert.ToInt32(Console.ReadLine());


    double totalNumber = (number1 + number2 + number3) / 3;

    Console.WriteLine("Öğrencinin adı: " + firstName + " " + lastName);
    Console.WriteLine("Not ortalaması: " + totalNumber);
    Console.ReadLine();
}

