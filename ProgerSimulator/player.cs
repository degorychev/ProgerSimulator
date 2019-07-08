using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgerSimulator
{
    class player
    {
        public string name; //username
        int ITRespect; //it репутация
        int LegalRespect; //Правовая репутация
        int Money; //Деньги
        public int Satiety { get; } //Настроение
        public int Mood { get; } //Сытость
        public int Health { get; } //Здоровье
        public Job MainJob { get; set; } //Основная работа
        public Requirements getSkills()
        {
            Requirements output = new Requirements(new HashSet<int>(), new HashSet<int>(), ITRespect);
            return output;
        }

        public player(string inputName)
        {
            name = inputName;
            ITRespect = 0;
            LegalRespect = 0;
            Money = 1000;
            Satiety = 70;
            Mood = 70;
            Health = 100;
            MainJob = new Job("Безработный", 0);
        }
        public string getMoney()
        {
            StringBuilder output = new StringBuilder();
            output.Append(Money.ToString());
            output.Append(" р.");
            return output.ToString();
        }

        public string getLegalRep()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Карма: ");
            output.Append(LegalRespect.ToString());
            output.Append("\nСтатус: ");
            output.Append(getLegalRespectName());
            return output.ToString();
        }

        public string getItRep()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Опыт: ");
            output.Append(ITRespect.ToString());
            output.Append("\nСтатус: ");
            output.Append(getITRespectName());
            return output.ToString();
        }
        private string getITRespectName()
        {
            if (ITRespect < 100)
                return "Ламер";
            return "none";
        }
        private string getLegalRespectName()
        {
            if (LegalRespect == 0)
                return "Гражданин";
            return "none";
        }
    }
}
