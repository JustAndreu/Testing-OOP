using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmae
{
    class GameMechanics
    {
        //Connect classes
        Characters_statistic _statistic = new Characters_statistic();
        User_interaction _interaction = new User_interaction();
        Items _items = new Items();
        Random _random = new Random();

        //Start programm
        int choose;
        public void Enemy_randomizer()
        {
            int enemy = _random.Next(1, 4);

            switch (enemy)
            {
                case 1:
                    Console.WriteLine("Spawned 'Troll \t(hp = 4, atk = 1)'");
                    break;
                case 2:
                    Console.WriteLine("Spawned 'Zombie \t(hp = 3, atk = 3)'");
                    break;
                case 3:
                    Console.WriteLine("Spawned 'Pirate \t(hp = 8, atk = 2)'");
                    break;
            }
        }
        public void Fight()
        {
            do
            {
                Console.WriteLine("Choose action: Attack, Defense, Heal \t'Start from 1'");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Deal_Damage(_statistic.enemy_hp, _statistic.hero_atk);
                        break;
                    case 2:
                        Deal_Damage(_statistic.enemy_hp, _statistic.hero_atk);
                        break;
                    case 3:
                        Healing();
                        break;
                }
                Take_Damage(_statistic.hero_hp, _statistic.enemy_atk);
            } while (_statistic.enemy_hp <= 0 || _statistic.hero_hp <= 0);
        }
        public void Take_Damage(double health, double damage)
        {
            health = _statistic.hero_hp;
            damage = _statistic.enemy_atk;

            switch(_interaction.choose)
            {
                case 1:
                    health -= damage;
                    break;
                case 2:
                    health -= (damage - 1);
                    break;
                case 3:
                    health -= damage;
                    break;
            }
            Console.WriteLine($"Damage done: {health} \nLeft enemy health: {damage}");
        }
        public void Deal_Damage(double health, double damage)
        {
            health = _statistic.enemy_hp;
            damage = _statistic.hero_atk;

            switch (_interaction.choose)
            {
                case 1:
                    health -= (damage + 2);
                    break;
                case 2:
                    health -= damage;
                    break;
                case 3:
                    health -= damage;
                    break;
            }
            Console.WriteLine($"Damage done: {damage} \nLeft enemy health: {health}");
        }
        public void Healing() 
        {
            if (_interaction.choose == 3 && _items.potion >= 1)
            {
                _statistic.hero_hp += 3;
            }
            else
            {
                Console.WriteLine("You haven`t potion");
                Deal_Damage(_statistic.enemy_hp, _statistic.hero_atk);
            }
        }
    }
}