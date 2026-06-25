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
        public static SingletonMB instance;
        int company;
        int operability;
        int antiheat;
        int efficiency;
        Random random = new Random();

        SingletonMB()
        {
            
        }
        public static SingletonMB GetInstance(int company, TextBox textBox1, Button button1, Button button2)
        {
            if (instance == null)
            {
                instance = new SingletonMB();
                instance.company = company;
                if (company == 1)
                {
                    instance.operability = 5;
                    instance.antiheat = 3;
                    instance.efficiency = 3;
                }
                if (company == 2)
                {
                    instance.operability = 3;
                    instance.antiheat = 5;
                    instance.efficiency = 3;
                }
                else
                {
                    instance.operability = 3;
                    instance.antiheat = 3;
                    instance.efficiency = 5;
                }
                instance.MBLife(textBox1, 1, button1, button2);
            }
            else
            {
                MessageBox.Show("Экземпляр уже создан!");
            }
            return instance;
        }
        int round = 0;
        public void MBLife(TextBox textBox1, int ans, Button button1, Button button2)
        {
            if (IsWorking(textBox1))
            {
                Crushed(textBox1, button1, button2);
            }
            else
            {
                if (round == 0) MatherBoardIn(textBox1);
                if (round == 1) MatherBoardMine(ans, textBox1);
                if (round == 2) MatherBoardTest(ans, textBox1);
                if (round == 3) MatherBoardUpload(ans, textBox1);
                if (round == 4) MatherBoardWet(ans, textBox1);
                if (round == 5)
                {
                    textBox1.Text = "Материнская плата выжила! Ура";
                    button1.Enabled = false;
                    button2.Enabled = false;
                }  
                round++;
            }
        }
        bool IsWorking (TextBox textBox1)
        {
            if (operability < 1 || antiheat < 1 || efficiency < 1) return true;
            else return false;
        }
        void Crushed(TextBox textBox1, Button button1, Button button2)
        {
            List<string> reason = new List<string>();
            if (operability < 1) reason.Add("неисправность");
            if (antiheat < 1) reason.Add("перегрев");
            if (efficiency < 1) reason.Add("плохая производительность");
            string reas = default;
            foreach (string s in reason) reas += $"{s}, ";
            MessageBox.Show($"Материнская плата сломалась! Причиной этому стали {reas}");
            button1.Enabled = false;
            button2.Enabled = false;
        }
        public void MatherBoardIn(TextBox textBox1)
        {
            textBox1.Text = "Вы принесли материнскую плату и установили на место. Запустить майнкрафт релистичные шейдеры скачать онлайн на максималках?";
        }
        public void MatherBoardMine(int answer, TextBox textBox1)
        {
            if (answer == 1) efficiency -= 1;
            else antiheat -= 2;
            textBox1.Text = "Стало скучно. Провести стресс‑тест AIDA64 на 2 часа?";
        }
        public void MatherBoardTest(int answer, TextBox textBox1)
        {
            if (answer == 1)
            {
                antiheat -= 2;
                operability -= 2;
            }
            else efficiency -= 2;
            textBox1.Text = "Уведомление: Компьютер хочет обновиться. Поставить обновление на всю ночь?";
        }
        public void MatherBoardUpload(int answer, TextBox textBox1)
        {
            if (answer == 1) operability -= 2;
            else efficiency -= 2;
            textBox1.Text = "Окей. Включить увлажнитель воздуха за работой?";
        }
        public void MatherBoardWet(int answer, TextBox textBox1)
        {
            if (answer == 1) operability -= 2;
            else antiheat -= 2;
            textBox1.Text = "Вы легли спать, но увидели включенный экран. Подняться и выключить?";
        }
    }
}
