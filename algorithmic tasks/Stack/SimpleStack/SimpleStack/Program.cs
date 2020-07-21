using System;

namespace SimpleStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleStack.Stack<string> stack = new SimpleStack.Stack<string>(5);
            string line;

            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                try
                {
                    if (line.StartsWith("PUSH"))
                    {
                        stack.Push(line.Split(' ')[1]);
                    }
                    else if (line.StartsWith("POP"))
                    {
                        stack.Pop();
                    }
                    else if (line.StartsWith("PEEK"))
                    {
                        Console.WriteLine(stack.Peek());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("EXCEPTION");
                }
            }

            Console.WriteLine(stack.Empty().ToString().ToLower());
        }
    }
}
