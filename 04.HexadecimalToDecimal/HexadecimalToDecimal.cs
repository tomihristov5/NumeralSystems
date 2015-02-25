// Problem 4. Hexadecimal to decimal
// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hex number: ");
        string hex = Console.ReadLine();
        hex.ToUpper();
        byte[] convertedHex = new byte[hex.Length];
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case 'A': convertedHex[i] = 10; break;
                case 'B': convertedHex[i] = 11; break;
                case 'C': convertedHex[i] = 12; break;
                case 'D': convertedHex[i] = 13; break;
                case 'E': convertedHex[i] = 14; break;
                case 'F': convertedHex[i] = 15; break;
                default: convertedHex[i] = byte.Parse(Convert.ToString(hex[i]));
                    break;
            }
        }
        int decNumber = 0;
        int power = convertedHex.Length - 1;
        for (int i = 0; i < convertedHex.Length; i++)
        {
            decNumber += convertedHex[i] * (int)Math.Pow(16, power);
            power--;
        }
        Console.WriteLine(decNumber);
    }

}


