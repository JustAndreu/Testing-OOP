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
        void Choose_item()
        {
            int choose;

            Console.WriteLine($"Choose item: \t {_items}", "\n Start from 1");
            choose = Convert.ToInt32(Console.ReadLine());
            
            switch (choose)
            {

            }
        }
    }
}
