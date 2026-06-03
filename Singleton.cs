using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6._1
{
    internal class SingletonMB
    {
        static SingletonMB instance;
        int company;
        int operability;
        int antiheat;
        int efficiency;

        SingletonMB(int company)
        {
            this.company = company;
            if (company == 1)
            {
                operability = 5;
                antiheat = 3;
                efficiency = 3;
            }
            if (company == 2)
            {
                operability = 3;
                antiheat = 5;
                efficiency = 3;
            }
            else
            {
                operability = 3;
                antiheat = 3;
                efficiency = 5;
            }
        }
        bool IsWorking ()
        {
            if (operability < 1 || antiheat < 1 || efficiency < 1)
            {
                return true;
            }
            else
            {
                Crushed();
                return false;
            }
        }
        void Crushed()
        {
            List<string> reason = new List<string>();
            if (operability < 1) reason.Append("неисправность,");
            if (antiheat < 1) reason.Append("перегрев,");
            if (antiheat < 1) reason.Append("плохая производительность,");
            MessageBox.Show($"Материнская плата сломалась! Причиной этому стала {reason}");
        }
        public static SingletonMB GetInstance(int company)
        {
            if (instance == null) instance = new SingletonMB(company);
            return instance;
        }
        public string MatherBoardIn(int answer)
        {
            if (answer == 1) operability -= 1;
            else antiheat -= 1;
            return "Вы принесли материнскую плату и установили на место. Запустить майнкрафт релистичные шейдеры скачать онлайн на максималках?";
        }
        public string MatherBoardMine(int answer)
        {
            if (answer == 1) efficiency -= 1;
            else antiheat -= 1;
            return "Стало скучно. Провести стресс‑тест AIDA64 на 2 часа?";
        }
        public string MatherBoardTest(int answer)
        {
            if (answer == 1)
            {
                antiheat -= 1;
                operability -= 1;
            }
            else efficiency -= 1;
            return "Уведомление: Компьютер хочет обновиться. Поставить обновление на всю ночь?";
        }
        public string MatherBoardUpload(int answer)
        {
            if (answer == 1) operability -= 1;
            else efficiency -= 1;
            return "Окей. Включить увлажнитель воздуха за работой?";
        }
        public string MatherBoardWet(int answer)
        {
            if (answer == 1) operability -= 1;
            else antiheat -= 1;
            return "Окей. Включить увлажнитель воздуха за работой?";
        }


    }
}
