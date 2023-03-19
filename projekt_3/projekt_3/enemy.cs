using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt_3
{
    internal class Enemy
    {
        Random rnd = new Random();
        int hp;
        int dmg;
        string name;
        int crit;
        public Enemy(int hp, int dmg, string name, int crit)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.name = name;
            this.crit = crit;
        }
        public void Skeleton()
        {
            hp = 50;
            dmg = 5;
            name = "Skeleton";
            crit = 5;
        }
        public void Magician()
        {
            hp = 30;
            dmg = 7;
            name = "Magician";
            crit= 100;
        }
        public void Zombie()
        {
            hp = 70;
            dmg = 3;
            name = "Zombie";
            crit = 0;
        }
        public void Critical()
        {
            if (rnd.Next(1,101)<= crit) {
                dmg = dmg * 2;
            }
        }
        public override string ToString()
        {
            return $"A {name} hp-ja= {hp} :)";
        }
    }
}
