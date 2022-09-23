/**
 * Walking Timer Copyright 2022 Justin Lloyd
 **/
using System.Collections.Generic;
using System.Linq;

namespace WalkingTimer
{
    public class WalkingLog
    {
        public List<DayLog> dayLog { get; set; } = new List<DayLog>();

        public DayLog GetActiveDayLog()
        {
            //if (dayLog==null)
            //{
            //    dayLog = new List<DayLog>();
            //}

            if ((dayLog.Count == 0) || (dayLog.Last().closed == true))
            {
                dayLog.Add(new DayLog());
            }

            return dayLog.Last();
        }

        public bool IsDayOpen()
        {
            if (dayLog.Count() ==0)
            {
                return false;
            }
            return !dayLog.Last().closed;
        }

        public bool IsDayClosed()
        {
            if (dayLog.Count() == 0)
            {
                return true;
            }

            return !dayLog.Last().closed;
        }
    }
}
