using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmae
{
    class GameMechanics
    {
        public void Attack()
        {
            Characters_statistic _statistic = new Characters_statistic();
            _statistic.Hero_hp -= 2;
            Console.WriteLine(_statistic.Hero_hp);
        }
    }
}
