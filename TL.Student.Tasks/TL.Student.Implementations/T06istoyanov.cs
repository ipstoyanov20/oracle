using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T06istoyanov : IT06
    {
        //Направих две променливи за интервала
        private int lo;
        private int hi;
        public IT06 Interval(int lo, int hi)
        {
            this.lo = lo;
            this.hi = hi;

            return this;
        }


        public int Calculate()
        {
            int sum = 0;
            //Итерираме през итервала за да намерим най-големите делители
            for (int number = lo; number <= hi; number++)
            {
                int largestPrime = FindTheBiggest(number);
                sum += largestPrime;
            }

            return sum;
        }
        //Изнесох отделен метод за изчисление
        private int FindTheBiggest(int aNumberFromInterval)
        {
            if (aNumberFromInterval < 2) return 0; // когато числото е 0, 1 или по малко от 2, то е ясно, че е просто и няма делители

            int tempMax = int.MinValue; //Това е добра практика когато намираме най-голямото да го инициализираме с потенциално малко число

            //Тук много важно ако е четно число делим на две докато се освободим от ненужните делители на 2
            while (aNumberFromInterval % 2 == 0)
            {
                tempMax = 2;
                aNumberFromInterval /= 2;
            }
            //След като сме се освобдили правим цикъл през нечетни делители където ако деление е възможно без остатък присвоява и разделя числото на потенциалния делител
            for (int i = 3; i <= Math.Sqrt(aNumberFromInterval); i += 2)
            {
                while (aNumberFromInterval % i == 0)
                {
                    tempMax = i;
                    aNumberFromInterval /= i;
                }
            }
            //Тук се прави проверка ако самото число след горния цикъл остане ( тоест вече се дели само и единствено на себе си ) тогава слагаме него като най-голям делител
            if (aNumberFromInterval > 2)
                tempMax = aNumberFromInterval;

            return tempMax;
        }
    }
}
