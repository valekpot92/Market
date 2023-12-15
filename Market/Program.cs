using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.Serialization.Formatters;

namespace Market;

class Program
{
    static void Main()
    {

        Console.WriteLine("Добро пожаловать в магазин");
        Console.WriteLine("Для продолжения нажмите Enter");
        Console.ReadKey();
        Console.WriteLine("На какую сумму вы хотите совершить покупку?");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Теперь на вашем счету {a} рублей");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine($"На вашем счету {a}");
        Console.WriteLine("Список товаров и цена");
        Product product_1 = new Product() { Name = "Печенье", Price = 150 };
        Product product_2 = new Product() { Name = "Лимонад", Price = 100 };
        Console.WriteLine($"{product_1.Name} Цена: {product_1.Price}");
        Console.WriteLine($"{product_2.Name} Цена: {product_2.Price}");
        Console.WriteLine($"Чтобы купить {product_1.Name}, Введите  1 ");
        Console.WriteLine($"Чтобы купить {product_2.Name}, Введите 2 ");
        Console.WriteLine($"Чтобы купить оба товара, нажмите 3");
        int b = int.Parse(Console.ReadLine());
        int Sdacha_1 = a - product_1.Price;
        int Sdacha_2 = a - product_2.Price;



        Console.Clear();
        if (b == 1)
        {
            Console.WriteLine($"В Вашей корзине {product_1.Name} и сумма покупки составляет {product_1.Price}");

            if (a < product_1.Price)
            {
                Console.WriteLine("У вас недостаточно средств на счете");
            }
            if (a > product_1.Price)
            {
                Console.WriteLine($"Ваша сдача {Sdacha_1}");
                int number1 = Sdacha_1;
                int Sotny = number1 / 100;
                int Desyanky = (number1 - Sotny * 100) / 10;
                int Edenicy = number1 - Sotny * 100 - Desyanky * 10;
                Console.WriteLine($"Ваша сдача в монетах: \n {Sotny * 10}шт. по 10 рублей, \n {(Desyanky * 10) / 5}шт. по 5 рублей, \n {Edenicy * 1}шт.  по 1 рублю");
            }

        }

        if (b == 2)
        {
            Console.WriteLine($"В Вашей корзине {product_2.Name} и сумма покупки составляет {product_2.Price}");
            if (a < product_2.Price)
            {
                Console.WriteLine("У вас недостаточно средств на счете");
            }
            if (a > product_2.Price)
            {
                Console.WriteLine($"Ваша сдача {Sdacha_2}");
                int number2 = Sdacha_2;
                int Sotny2 = number2 / 100;
                int Desyanky2 = (number2 - Sotny2 * 100) / 10;
                int Edenicy2 = number2 - Sotny2 * 100 - Desyanky2 * 10;
                Console.WriteLine($"Ваша сдача в монетах: \n {Sotny2 * 10}шт. по 10 рублей, \n {(Desyanky2 * 10) / 5}шт. по 5 рублей, \n {Edenicy2 * 1}шт.  по 1 рублю");
            }
        }

        if (b == 3)
        {
            Console.WriteLine($"В Вашей корзине {product_1.Name} и {product_2.Name}");
            var e = product_1.Price + product_2.Price;
            Console.WriteLine($"Сумма покупки составляет: {e}");
          
            if (a < e)
            {
                Console.WriteLine("У вас недостаточно средств на счете");
            }
            if (a > e)
            {
                Console.WriteLine($"Ваша сдача: {a - e}");
                int number3 = a-e;
                int Sotny3 = number3 / 100;
                int Desyanky3 = (number3 - Sotny3 * 100) / 10;
                int Edenicy3 = number3 - Sotny3 * 100 - Desyanky3 * 10;
                Console.WriteLine($"Ваша сдача в монетах: \n {Sotny3 * 10}шт. по 10 рублей, \n {(Desyanky3 * 10) / 5}шт. по 5 рублей, \n {Edenicy3 * 1}шт.  по 1 рублю");
            }
        }
        Console.WriteLine("До Свидания!");


    }
        

}