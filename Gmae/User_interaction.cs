using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmae
{
    public class User_interaction
    {
        Items _items = new Items();
        public int choose;
        public void Choose_item()
        {
            Console.WriteLine($"Choose item:\t Start from '1'");
            for (int i = 0; i < _items.item.Length; i++)
            {
                Console.WriteLine(_items.item[i]);
            }
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose > 0 && choose <= 2)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("You choose Sword");
                        break;
                    case 2:
                        Console.WriteLine("You choose Shield");
                        break;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Enter correct variable");
                    choose = Convert.ToInt32(Console.ReadLine());
                }while (choose < 1 || choose > 2);

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("You choose Sword");
                        break;
                    case 2:
                        Console.WriteLine("You choose Shield");
                        break;
                }
            }
        }

        public void Show_help()
        {
            Console.WriteLine("Welcome in directory for help \nWhat you`r interesting ?");
            Console.WriteLine("1.How to play \t 2.Items \t 3.Interaction \t 4.'Back' \nChange variable");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose > 0 && choose <= 4)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How to play:");
                        break;
                    case 2:
                        Console.WriteLine("Items: \n Sword: increase your attack power for 2 point 'atk' \n Shield: Reduces incoming damage by 1 unit");
                        break;
                    case 3:
                        Console.WriteLine("Interaction:");
                        break;
                    case 4:
                        break;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Enter correct variable");
                    choose = Convert.ToInt32(Console.ReadLine());
                } while (choose < 1 || choose > 4);

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("You choose Sword");
                        break;
                    case 2:
                        Console.WriteLine("You choose Shield");
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}