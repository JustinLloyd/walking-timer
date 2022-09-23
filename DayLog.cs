/**
 * Walking Timer Copyright 2022 Justin Lloyd
 **/
using System;
using System.Collections.Generic;
using System.Linq;

namespace WalkingTimer
{
    public class DayLog
    {
        public List<SessionLog> sessionLog { get; set; } = new List<SessionLog>();

        public bool closed { get; set; }

        public int laps { get; set; }
        public double speed { get; set; }
        public int steps { get; set; }
        public TimeSpan totalTime { get; set; }

        public SessionLog GetActiveSessionLog()
        {
            //if (sessionLog==null)
            //{
            //    sessionLog = new List<SessionLog>();
            //}    
            if ((sessionLog.Count == 0) || (sessionLog.Last().closed == true))
            {
                sessionLog.Add(new SessionLog());
            }

            return sessionLog.Last();
        }

        public bool IsSessionOpen()
        {
            if (sessionLog.Count() == 0)
            {
                return false;
            }    
            return !sessionLog.Last().closed;
        }

        public bool IsSessionClosed()
        {
            if (sessionLog.Count() == 0)
            {
                return true;
            }
            return sessionLog.Last().closed;
        }

    }
}
