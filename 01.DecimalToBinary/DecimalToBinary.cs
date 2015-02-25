﻿// Problem 1. Decimal to binary
// Write a program to convert decimal numbers to their binary representation.

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        string binary = string.Empty;
        while (number != 0)
        {
            int bit = number % 2;
            binary = bit + binary;
            number /= 2;
        }
        Console.WriteLine("Number in binary: {0}", binary);
    }
}

