using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_31_02_iida
{
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}を毒針で刺した！");
            if (destination.animal)
            {
                destination.hp = 0;
                Console.WriteLine($"{destination.name}は即死した！");
            }
            else
            {
                Console.WriteLine($"{destination.name}に毒は効かないようだ…");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
        }
    }
}
