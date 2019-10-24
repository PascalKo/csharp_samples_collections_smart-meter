using System;

namespace SmartMeter.Core
{
    public class Day
    {
        private DateTime _date;
        private double _measurement;

        public Day(DateTime date,double measurement)
        {
            _date = date;
            _measurement = measurement;
        }

        public override string ToString()
        {
            return $"_date: {_date.ToShortDateString()}, _measurement: {_measurement}";
        }
    }
}
