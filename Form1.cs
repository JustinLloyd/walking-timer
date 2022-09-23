/**
 * Walking Timer Copyright 2022 Justin Lloyd
 **/
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingTimer
{


    public partial class Form1 : Form
    {
        private const int k_STEPS_PER_LAP = 850;
        private const double k_MILES_PER_LAP = 0.3575f;
        private const int k_MAXIUM_LAPS = 25;
        Timer m_timer;
        DateTime m_startTime;
        TimeSpan m_sessionElapsedTime;
        TimeSpan m_totalElapsedTime;
        DateTime m_stopTime;
        int m_lapCounter;

        WalkingLog m_walkingLog = new WalkingLog();

        private DateTime GetNow()
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Kind);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            m_startTime = m_stopTime = GetNow();
            m_sessionElapsedTime = TimeSpan.Zero;
            UpdateOnScreenTime();
            UpdateOnScreenLaps();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWalkingLog();
            if (m_walkingLog.IsDayOpen())
            {
                m_totalElapsedTime = m_walkingLog.GetActiveDayLog().totalTime;
                if (m_walkingLog.GetActiveDayLog().IsSessionOpen())
                {
                    m_sessionElapsedTime = m_walkingLog.GetActiveDayLog().GetActiveSessionLog().duration;
                }

            }

            m_timer = new Timer();
            m_timer.Interval = 100;
            m_timer.Enabled = false;
            m_timer.Stop();
            m_timer.Tick += RefreshElapsedTime;
            m_startTime = m_stopTime = GetNow();
            buttonEndOfDay.Enabled = false;
            buttonEndSession.Enabled = false;
            buttonReset.Enabled = false;
            UpdateOnScreenTime();
            UpdateOnScreenLaps();
        }

        private void RefreshElapsedTime(object sender, EventArgs e)
        {
            UpdateOnScreenTime();
            UpdateOnScreenLaps();
        }

        private void UpdateOnScreenTime()
        {
            TimeSpan elapsedTime = m_sessionElapsedTime;
            if (m_timer.Enabled)
            {
                elapsedTime = m_sessionElapsedTime + (GetNow() - m_startTime);
            }

            labelSessionElapsedTime.Text = (elapsedTime).ToString("hh'  :  'mm'  :  'ss");
            labelTotalElapsedTime.Text = (elapsedTime + m_totalElapsedTime).ToString("hh'  :  'mm'  :  'ss");
        }

        private int CalculateSteps(int laps)
        {
            return laps * k_STEPS_PER_LAP;
        }

        private double CalculateFootSpeed(int laps, TimeSpan time)
        {
            return (CalculateDistance(laps) / time.TotalHours);
        }

        private double CalculateDistance(int laps)
        {
            return laps * k_MILES_PER_LAP;
        }

        private void UpdateOnScreenLaps()
        {
            labelLaps.Text = m_lapCounter.ToString("D2");
            labelEstimatedDistance.Text = CalculateDistance(m_lapCounter).ToString("F2");
            labelEstimatedSteps.Text = CalculateSteps(m_lapCounter).ToString("D5");
            if (m_totalElapsedTime.TotalHours == 0)
            {
                labelEstimatedSpeed.Text = "0.0";
            }
            else
            {
                double speed = Math.Min(9.9, CalculateFootSpeed(m_lapCounter, m_totalElapsedTime));
                labelEstimatedSpeed.Text = speed.ToString("F1");
            }
        }

        private void buttonStartPauseToggle_Click(object sender, EventArgs e)
        {

            if (!m_timer.Enabled)
            {
                Console.WriteLine("Session elapsed time" + m_sessionElapsedTime.TotalSeconds);
                m_startTime = GetNow();
                buttonStartPauseToggle.Text = "Pause";
                buttonReset.Enabled = false;
                buttonEndOfDay.Enabled = false;
                buttonEndSession.Enabled = false;
                m_timer.Start();
                m_timer.Enabled = true;
                m_walkingLog.GetActiveDayLog().GetActiveSessionLog().when = m_startTime;
            }
            else
            {
                m_timer.Stop();
                m_timer.Enabled = false;
                m_stopTime = GetNow();
                m_sessionElapsedTime += m_stopTime - m_startTime;
                buttonStartPauseToggle.Text = "Start";
                buttonReset.Enabled = true;
                buttonEndSession.Enabled = true;
                m_walkingLog.GetActiveDayLog().GetActiveSessionLog().duration = m_sessionElapsedTime;
                SaveWalkingLog();
                Console.WriteLine("Session elapsed time" + m_sessionElapsedTime.TotalSeconds);
            }
        }

        private void buttonAddLap_Click(object sender, EventArgs e)
        {
            m_lapCounter = Math.Min(k_MAXIUM_LAPS, m_lapCounter + 1);
            DayLog dayLog = m_walkingLog.GetActiveDayLog();
            dayLog.laps = m_lapCounter;
            dayLog.steps = CalculateSteps(m_lapCounter);
            dayLog.speed = CalculateFootSpeed(m_lapCounter, m_totalElapsedTime);
            SaveWalkingLog();

            UpdateOnScreenLaps();
        }

        private void buttonRemoveLap_Click(object sender, EventArgs e)
        {
            m_lapCounter = Math.Max(0, m_lapCounter - 1);
            DayLog dayLog = m_walkingLog.GetActiveDayLog();
            dayLog.laps = m_lapCounter;
            dayLog.steps = CalculateSteps(m_lapCounter);
            dayLog.speed = CalculateFootSpeed(m_lapCounter, m_totalElapsedTime);
            SaveWalkingLog();
            UpdateOnScreenLaps();
        }

        private void buttonEndSession_Click(object sender, EventArgs e)
        {
            m_totalElapsedTime += m_sessionElapsedTime;
            DayLog dayLog = m_walkingLog.GetActiveDayLog();
            SessionLog sessionLog = dayLog.GetActiveSessionLog();
            sessionLog.duration = m_sessionElapsedTime;
            sessionLog.closed = true;
            dayLog.totalTime = m_totalElapsedTime;
            dayLog.laps = m_lapCounter;
            dayLog.steps = CalculateSteps(m_lapCounter);
            dayLog.speed = CalculateFootSpeed(m_lapCounter, m_totalElapsedTime);

            SaveWalkingLog();

            m_sessionElapsedTime = TimeSpan.Zero;
            UpdateOnScreenTime();
            UpdateOnScreenLaps();
            buttonEndSession.Enabled = false;
            buttonEndOfDay.Enabled = true;
        }

        private void buttonEndOfDay_Click(object sender, EventArgs e)
        {
            m_totalElapsedTime += m_sessionElapsedTime;

            DayLog dayLog = m_walkingLog.GetActiveDayLog();
            SessionLog sessionLog = dayLog.GetActiveSessionLog();
            sessionLog.duration = m_sessionElapsedTime;
            sessionLog.when = DateTime.Now - m_sessionElapsedTime;
            sessionLog.closed = true;
            dayLog.laps = m_lapCounter;
            dayLog.totalTime = m_totalElapsedTime;
            dayLog.steps = CalculateSteps(m_lapCounter);
            dayLog.speed = CalculateFootSpeed(m_lapCounter, m_totalElapsedTime);

            SaveWalkingLog();

            m_sessionElapsedTime = TimeSpan.Zero;
            UpdateOnScreenTime();
            UpdateOnScreenLaps();
            buttonEndOfDay.Enabled = false;
            buttonEndSession.Enabled = false;
        }

        private void LoadWalkingLog()
        {
            //List<WalkingLog> walkingLog = new List<WalkingLog>();

            if (!File.Exists(@".\walking_log.json"))
            {
                return;
            }

            m_walkingLog = JsonConvert.DeserializeObject<WalkingLog>(File.ReadAllText(@".\walking_log.json"));
        }

        private void SaveWalkingLog()
        {
            string v = JsonConvert.SerializeObject(m_walkingLog);
            File.WriteAllText(@".\walking_log.json", v);
        }
    }
}
