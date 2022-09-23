/**
 * Walking Timer Copyright 2022 Justin Lloyd
 **/
using System;

namespace WalkingTimer
{
    public class SessionLog
    {
        public DateTime when { get; set; }
        public TimeSpan duration { get; set; }
        public bool closed { get; set; }
    }
}
