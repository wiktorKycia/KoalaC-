﻿using System;
using System.Collections.Generic;

namespace KoalaSupport_task12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[,] ogrod = new char[8, 8];
            ogrod = FillGarden(ogrod, ' ');
            List<string> wykorzystane = new List<string>();
            int counter = 0;
            string test;

            for (int rowOfFirstZ = 0; rowOfFirstZ < 8; rowOfFirstZ++)
            {
                for (int columnOfFirstZ = 0; columnOfFirstZ < 8; columnOfFirstZ++)
                {
                    if (Check(ogrod, rowOfFirstZ, columnOfFirstZ, 'z'))
                    {
                        ogrod[rowOfFirstZ, columnOfFirstZ] = 'z';
                        for (int rowOfSecondZ = 0; rowOfSecondZ < 8; rowOfSecondZ++)
                        {
                            for (int columnOfSecondZ = 0; columnOfSecondZ < 8; columnOfSecondZ++)
                            {
                                if (Check(ogrod, rowOfSecondZ, columnOfSecondZ, 'z'))
                                {
                                    ogrod[rowOfSecondZ, columnOfSecondZ] = 'z';
                                    for (int i = 0; i < 8; i++)
                                    {
                                        for (int j = 0; j < 8; j++)
                                        {
                                            test = $"{rowOfFirstZ} {columnOfFirstZ} {rowOfFirstZ} {columnOfFirstZ} {i} {j}";
                                            
                                            // Console.Write(wykorzystane.Contains(test)+" ");
                                            if (Check(ogrod, i, j, 'f') && !wykorzystane.Contains(test))
                                            {
                                                wykorzystane.Add(test);
                                                ogrod[i, j] = 'f';
                                                counter++;
                                                // DisplayGarden(ogrod);
                                                // Console.WriteLine("===========================");
                                                ogrod[i, j] = ' ';
                                            }
                                        }
                                    }
                                    ogrod[rowOfSecondZ, columnOfSecondZ] = ' ';
                                }
                                
                            }
                        }
                        ogrod[rowOfFirstZ, columnOfFirstZ] = ' ';
                    }
                    
                }
            }

            
            // DisplayList(wykorzystane);
            Console.WriteLine($"Ilość możliwości: {counter}");
            //
            // ogrod[0, 0] = 'z';
            // ogrod[0, 1] = 'z';
            
            Console.ReadKey();
        }

        static void DisplayList(List<int[]> lista)
        {
            Console.Clear();
            foreach (int[] tablica in lista)
            {
                foreach (int item in tablica)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        static bool Check(char[,] array, int row, int column, char flower)
        {
            if (flower != 'c')
            {
                if (array[row, column] == 'c'){ return false; }
                try{if (array[row-1, column] == 'c'){return false;}}catch(IndexOutOfRangeException){}
                try{if (array[row-2, column] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-2] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+2, column] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+2] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column+1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column+1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column-1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column-1] == 'c'){ return false; }}catch(IndexOutOfRangeException){}
            }
            if (flower != 'f')
            {
                if (array[row, column] == 'f'){ return false; }
                try{if (array[row-1, column] == 'f'){return false;}}catch(IndexOutOfRangeException){}
                try{if (array[row-2, column] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-2] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+2, column] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+2] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column+1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column+1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column-1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column-1] == 'f'){ return false; }}catch(IndexOutOfRangeException){}
            }
            if (flower != 'z')
            {
                if (array[row, column] == 'z'){ return false; }
                try{if (array[row-1, column] == 'z'){return false;}}catch(IndexOutOfRangeException){}
                try{if (array[row-2, column] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column-2] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+2, column] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row, column+2] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column+1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column+1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row+1, column-1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
                try{if (array[row-1, column-1] == 'z'){ return false; }}catch(IndexOutOfRangeException){}
            }

            if (flower == 'z')
            {
                if (array[row, column] == 'z'){ return false; }
            }

            return true;
        }

        static char[,] FillGarden(char[,] array, char letter)
        {
            char[,] result = array;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (result[i, j] == ' ');
                    {
                        result[i,j] = letter;
                    }
                }
            }
            result[7, 0] = 'c';
            return result;
        }

        static void DisplayGarden(char[,] array)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    switch (array[i,j])
                    {
                        case 'n':
                        {
                            PrintColorMessage($"{array[i,j]} ", ConsoleColor.Blue);
                            break;
                        }
                        case 'c':
                        {
                            PrintColorMessage($"{array[i,j]} ", ConsoleColor.Red);
                            break;
                        }
                        case 'f':
                        {
                            PrintColorMessage($"{array[i,j]} ", ConsoleColor.DarkMagenta);
                            break;
                        }
                        case 'z':
                        {
                            PrintColorMessage($"{array[i,j]} ", ConsoleColor.Yellow);
                            break;
                        }
                        default:
                        {
                            PrintColorMessage("* ", ConsoleColor.White);
                            break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        static void PrintColorMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}