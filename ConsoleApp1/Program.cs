
using System.Text;

Console.WriteLine("Введите кол-во денег: ");
decimal money = decimal.Parse(Console.ReadLine());
decimal butter = 150;
decimal bread = 100;
decimal tea = 100;
decimal gloves = 100;
decimal cap = 70;
decimal shirt = 300;
String Price = $" Масло {butter}\n Хлеб {bread} \n Чай {tea} \n Перчатки {gloves} \n Шапки {cap} \n Рубашки {shirt}";
Console.WriteLine(Price);


Console.WriteLine(" Ввведите кол-во  масла: ");
int butterQ = int.Parse(Console.ReadLine());


Console.WriteLine(" Ввведите кол-во  хлеба: ");
int breadQ = int.Parse(Console.ReadLine());


Console.WriteLine(" Ввведите кол-во  чая: ");
int teaQ = int.Parse(Console.ReadLine());


Console.WriteLine(" Ввведите кол-во  перчаток: ");
int glovesQ = int.Parse(Console.ReadLine());


Console.WriteLine(" Ввведите кол-во  шапок: ");
int capQ = int.Parse(Console.ReadLine());


Console.WriteLine(" Ввведите кол-во  рубашки: ");
int shirtQ = int.Parse(Console.ReadLine());

decimal butterS = butter * butterQ;
decimal breadS = breadQ * bread;
decimal teaS = teaQ * tea;
decimal glovesS = glovesQ * gloves;
decimal capS = capQ * cap;
decimal shirtS = shirtQ * shirt;

decimal allS = butterS + breadS + teaS + glovesS + capS + shirtS;

if (allS < 500)
{
    Console.WriteLine("Поздравляем с покупкой, приходите к нам еще.");
}
else
{
    Console.WriteLine("На вашем счету недостаточно средсвт");
}