using System;

namespace FirstTaskOfTheSecondOption
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        
        
        public Time(int hour, int minute, int second)
        {
            _hour = SetHourValue(hour);
            _minute = SetMinuteValue(minute);
            _second = SetSecondValue(second);
        }

        private int SetHourValue(int hour)
        {
            if (hour >= 0 && hour < 24)
            {
                return hour;
            }

            if (hour > 24)
            {
                return hour % 24;
            }

            throw new Exception("Отрицательное значение");
        }

        private int SetMinuteValue(int minute)
        {
            if (minute >= 0 && minute < 60)
            {
                return minute;
            }

            if (minute > 60)
            {
                _hour += minute / 60;
                return minute % 60;
            }

            throw new Exception("Отрицательное значение");
        }

        private int SetSecondValue(int second)
        {
            if (second >= 0 && second < 60)
            {
                return second;
            }

            if (second > 60)
            {
                _minute += second / 60;
                return second % 60;
            }

            throw new Exception("Отрицательное значение");
        }

        public override string ToString()
        {
            return _hour + ":" + _minute + ":" + _second;
        }

        public int Hour
        {
            get => _hour;
            set
            {
                try
                {
                    _hour = SetHourValue(value);
                }
                catch (Exception)
                {
                    _hour += value;
                    while (_hour < 0)
                    {
                        _hour += 24;
                    }
                }
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                try
                {
                    _minute = SetMinuteValue(value);
                }
                catch (Exception)
                {
                    _minute += value;
                    while (_minute < 0)
                    {
                        _hour -= 1;
                        _minute += 60;
                    }
                }
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                try
                {
                    _second = SetSecondValue(value);
                }
                catch (Exception)
                {
                    _second += value;
                    while (_second < 0)
                    {
                        _minute -= 1;
                        _second += 60;
                    }
                }
            }
        }
    }
}