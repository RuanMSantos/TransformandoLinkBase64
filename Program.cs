using System.Text;

string linkBase64 = "aHR0cHM6Ly95b3V0dS5iZS9HaE4zaXcwWUxXUT9zaT1qR0lWbFBoNDR3UFlOSWdI";

byte[] arrayBytes = Convert.FromBase64String(linkBase64);
// Converte automaticamente a string em base64 para um array de bytes
// também funciona com hexadecimal :(

string link = Encoding.UTF8.GetString(arrayBytes);

Console.WriteLine(link);