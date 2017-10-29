using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Bohater
    {
        private int hp;
        private string nazwa;
    
        public Bohater(int hp, string nazwa)
        {
            this.hp = hp;
            this.nazwa = nazwa;
        }

        public void ZadajCios(int cios)
        {
            if (hp > cios)
                hp = hp - cios;
            else
                hp = 0;
        }

        public bool Stan()
        {
            if (hp > 0)
                return true;
            else
                return false;
        }

        public string Opis()
        {
            return nazwa + " " + hp; 
        }
    }
}
