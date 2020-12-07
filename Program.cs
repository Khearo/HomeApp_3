using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp_3 // by Aleksandr K
{
    class Program
    {
        static void Main()
        {
            ComplexClass();   // Вычитание и умножение с помощью Complex. PS, Самое сложное задание для понимания и разбора с начала курса. 
                              // Также попробовал реализовать через цикл неоднократный ввод выражений, чтобы после 1го не закрывалось окно.     
            
            SumOddNumber();  // Через TryParse. 
        }

        private static void ComplexClass()
        {
            Complex complex1 = new Complex(7, 4);
            Complex complex2 = new Complex(5, 2);
            Complex result = new Complex();


            string operation;
           

            do
            {
                Console.WriteLine("Какое выражение нужно посчитать: minus or multi");
                operation = Console.ReadLine();
                switch (operation)
                
                {
                   
                    case "minus":
                        result = complex1.Minus(complex2); // Вычитание
                       
                        break;

                    case "multi":
                        result = complex1.Mult(complex2); // Умножение
                        
                        break;
                }

                Console.WriteLine(result.ToString());
                Console.ReadKey();
               
            } while (operation == "minus" || operation == "multi");
            
              
                
               
        }

        private static void SumOddNumber()
        {
            int number;
            int sum = 0;

            Console.WriteLine("Введите число: ");

            do
            {
                string input = Console.ReadLine();                  // Строковая переменная, которая будет проходить проверку, иначе выдаст сообщение ввести число.
                bool result = int.TryParse(input, out number);     // Проверяет произошло ли преобразование введенного значения (input) и возвращает его в out. 
                                                                   //По крайней мере, я так это понимаю. Возможны неточности формулировки.


                if (result == true)               
                {
                    if (number > 0 && number % 2 == 1)
                    {
                        sum = sum + number;
                    }
      
                }
                else
                {
                    Console.WriteLine("Введите пожалуйста число");
                    Console.ReadKey();
                }
            }
            while (number != 0);

            Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");   
            Console.ReadKey();
        }
    }

}
