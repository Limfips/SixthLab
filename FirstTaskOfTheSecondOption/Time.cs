using System;
using System.Diagnostics;

namespace FirstTaskOfTheSecondOption
{
    public class Time
    {
        //rider ругается на отсутствие черточек
        private int _hour;
        private int _minute;
        private int _second;


        public Time(int hour, int minute, int second)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }

//смержить методы и сделать валидные геттеры и сеттеры
        public int Hour
        {
            get { return _hour; }
            set
            {
                _hour = value;
                if (_hour < 0 || _hour > 24)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0)
                {
                    while (value < 0)
                    {
                        Hour -= 1;
                        value += 60;
                    }

                    _minute = value;
                }
                else if (value > 0)
                {
                    _minute = value % 60;
                    Hour += value / 60;
                }
            }
        }

        public int Second
        {
            get { return _second; }
            set
            {
                if (value < 0)
                {
                    while (value < 0)
                    {
                        Minute -= 1;
                        value += 60;
                    }

                    _second = value;
                }
                else if (value > 0)
                {
                    _second = value % 60;
                    Minute += value / 60;
                }
            }
        }

        public override string ToString()
        {
            return _hour + ":" + _minute + ":" + _second;
        }
    }
}