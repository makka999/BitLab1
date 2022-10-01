using BtiLab1;


char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
string text, result;
int key, switch_on;

while (true)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Szyfrowanie");
    Console.WriteLine("2 - Odszyfrowywanie");
    Console.WriteLine("3 - Odszyfrowywanie bez kodu");

    switch_on = Convert.ToInt32(Console.ReadLine());


    switch (switch_on)
    {
        case 1:
            Console.WriteLine("Wpisz wiadomosc");
            text = Console.ReadLine();
            Console.WriteLine("Wpisz klucz");
            key = Convert.ToInt32(Console.ReadLine());
            result = Function.Encrypt(text, alphabet, key);
            Console.WriteLine(result);
            break;
        case 2:
            Console.WriteLine("Wpisz wiadomosc");
            text = Console.ReadLine();
            Console.WriteLine("Wpisz klucz");
            key = Convert.ToInt32(Console.ReadLine());
            result = Function.UnEncrypt(text, alphabet, key);
            Console.WriteLine(result);
            break;
        case 3:
            Console.WriteLine("Wpisz wiadamosc");
            text = Console.ReadLine();
            for (int i = 0; i < alphabet.Length; i++)
            {
                result = Function.UnEncrypt(text, alphabet, i);
                Console.WriteLine();
                Console.WriteLine("Kod: " + i);
                Console.WriteLine(result);
            }
            break;
    }
    Console.WriteLine();
}







