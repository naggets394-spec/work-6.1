using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6._1
{
    internal class SingletonMB
    {
        static SingletonMB instance;
        int company;
        int operability;
        int antiheat;
        int efficiency;
        Dictionary<string, string> choice = new Dictionary<string, string>()
        {
            ["Надпись"] = default(string),
            ["Кнопка1"] = default(string),
            ["Кнопка2"] = default(string),
        };
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
        public static SingletonMB GetInstance(int company)
        {
            if (instance == null) instance = new SingletonMB(company);
            return instance;
        }
        public Dictionary<string, string> MatherBoardIn(int answer)
        {
            if (answer == 1) antiheat -= 1;
            else operability -= 1;
            choice["Надпись"] = "ОЙ!!!";
            return default;
        }

    }
}
