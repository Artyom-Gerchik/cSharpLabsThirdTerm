using System;

namespace _053502_GERCHIK_LAB5_.Entities
{
    class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("No Such Item In Collection!");
        }

        public MyException(string message)
        {
            
        }
    }
}