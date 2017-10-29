using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Bohater
    {
        private int hp;
        private string nazwa;

        public Bohater(string nazwa, int hp)
        {
            this.nazwa = nazwa;
            this.hp = hp;
        }

        public Bohater(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public Bohater()
        {
            this.nazwa = "Zeus";
        }

        public void zadajCios(int cios)
        {
            if (this.hp - cios <= 0) {
                this.hp = 0;
            }
            else {
                this.hp -= cios;
            }
        }

        public bool Stan()
        {
            if (this.hp > 0)
            {
                return true;
            }
            return false;
        }

        public string Opis()
        {
            return "Nazwa to: " + this.nazwa + ", a hp to: " + this.hp;
        }

    }
}
