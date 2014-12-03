﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSim
{
    public static class GUI
    {
        public static void CleanPosition(Entity empty, int currentX, int currentY)
        {
            if (empty == null)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(currentX, currentY);
                Console.Write(" ");
                //Console.ResetColor();
                Console.SetCursorPosition(75, 20);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(currentX, currentY);
                Console.Write(empty.PrintedName);
                //Console.ResetColor();
                Console.SetCursorPosition(75, 20);
            }
        }

        internal static void PrintEntity(Entity newEntity)
        {
            Console.SetCursorPosition(newEntity.PositionX, newEntity.PositionY);
            //Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(newEntity.PrintedName);
            //Console.ResetColor();
            Console.SetCursorPosition(75, 20);
        }

        internal static void CurrentCursorPosition(int currentX, int currentY)
        {
            Console.SetCursorPosition(currentX, currentY);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            //Console.ResetColor();
            Console.SetCursorPosition(75, 20);
        }

    }
}
