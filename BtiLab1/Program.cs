using BtiLab1;


char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

int switch_on = 0;

Console.WriteLine("Menu");
Console.WriteLine("1 - Szyfrowanie");
Console.WriteLine("2 - Odszyfrowywanie");
Console.WriteLine("3 - Odszyfrowywanie bez kodu");

switch_on = Convert.ToInt32(Console.ReadLine());


switch (switch_on)
{
    case 0:
        

    case 1:
        Console.WriteLine("Wpisz wiadomosc");
        string text = Console.ReadLine();
        Console.WriteLine("Wpisz klucz");
        int key = Convert.ToInt32(Console.ReadLine());
        text = text.ToLower();
        char[] charText = text.ToCharArray();
        string cryptText = Function.Encrypt(charText, alphabet, key);
        Console.WriteLine(cryptText);
        break;
    case 2:
        Console.WriteLine("Wpisz wiadomosc");
        string textD = Console.ReadLine();
        Console.WriteLine("Wpisz klucz");
        int keyD = Convert.ToInt32(Console.ReadLine());
        textD = textD.ToLower();
        char[] charTextD = textD.ToCharArray();
        string cryptTextD = Function.UnEncrypt(charTextD, alphabet, keyD);
        Console.WriteLine(cryptTextD);
        break;
    case 3:
        Console.WriteLine("Wpisz wiadamosc");
        string textDK = Console.ReadLine();
        textDK = textDK.ToLower();
        char[] charTextDK = textDK.ToCharArray();
        for (int i = 0; i < alphabet.Length; i++)
        {
            string cryptTextDK = Function.Encrypt(charTextDK, alphabet, i);
            Console.WriteLine(cryptTextDK);
        }

        break;

}









