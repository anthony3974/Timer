using System.Collections.Generic;
using System;

namespace TonysTimer
{
    /// <summary>
    /// Class that tracks average time
    /// </summary>
    public class Timer
    {
        #region class info
        /// <summary>
        /// Gets version of the class
        /// </summary>
        /// <returns>Version</returns>
        public string getVersion() { return "1.0.1"; }
        #endregion
        #region constructors
        /// <summary>
        /// Makes a new Timer class for easy tracking of average time
        /// </summary>
        public Timer()
        {
        }
        #endregion
        #region vars
        DateTime startTime;
        DateTime endTime;
        List<TimeSpan> advrageTimes = new List<TimeSpan>();
        #endregion
        #region methods
        /// <summary>
        /// Set the start time
        /// </summary>
        public void Start()
        {
            startTime = DateTime.Now;
        }
        /// <summary>
        /// Set the endtime
        /// </summary>
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        /// <summary>
        /// Gets the diffrence of start minus stop
        /// </summary>
        /// <returns>The diffrence in TimeSpan format</returns>
        public TimeSpan Get()
        {
            return startTime - endTime;
        }
        /// <summary>
        /// Stops the timer and returns the diffrence
        /// </summary>
        /// <returns>The diffrence in TimeSpan format</returns>
        public TimeSpan StopGet()
        {
            Stop();
            return Get();
        }
        /// <summary>
        /// Reset the list
        /// </summary>
        public void Reset()
        {
            advrageTimes = new List<TimeSpan>();
        }
        /// <summary>
        /// Add to the list a time
        /// </summary>
        public void Add()
        {
            advrageTimes.Add(startTime - DateTime.Now);
        }
        /// <summary>
        /// Adds the values and divides it by the amount
        /// </summary>
        /// <returns>The diffrence in TimeSpan format</returns>
        public TimeSpan GetAverage()
        {
            TimeSpan t = new TimeSpan();
            foreach (TimeSpan x in advrageTimes) t += x;
            return new TimeSpan(t.Ticks / advrageTimes.Count);
        }
        #endregion
        #region properties
        /// <summary>
        /// Gets the StartTime in Datetime format
        /// </summary>
        public DateTime StartTime { get { return startTime; } }
        /// <summary>
        /// Gets the EndTime in Datetime format
        /// </summary>
        public DateTime EndTime { get { return endTime; } }
        /// <summary>
        /// Gets the List of average times
        /// </summary>
        public List<TimeSpan> AdvrageTimes { get { return advrageTimes; } }
        #endregion
    }
}
