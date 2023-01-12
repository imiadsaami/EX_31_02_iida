using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_31_02_iida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2, true);
            Character character2 = new Character("ささっき", 1000, 25, true);
            Tank tank1 = new Tank("Tiger", 500000, 250, false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false);
            tank2.bullet = 5;
            Cat cat1 = new Cat("ねこです", 600, 60, true);
            Cow cow1 = new Cow("牛ボーイ",2000, 100, true);
            Hornet hornet1 = new Hornet("キラービー", 200, 1, true);

            Character[] characters = { character1, character2, tank1, tank2, cat1, cow1, hornet1};
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}
