using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_31_02_iida
{
    internal class Cow:Character
    {
        public Cow(string name, float hp, float power, bool animal):base(name,hp,power,animal)
        {

        }
        public override void Attack(Character destination)
        {
            if (this.hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}を角で突く！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は攻撃出来ない!");
            }
        }
    }
}
