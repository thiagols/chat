using System;

namespace ChatServer.Domain.Util
{
    public static class ConsoleUtil
    {
        public static void PrintWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
