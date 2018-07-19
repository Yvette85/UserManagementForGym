using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserManagementForGym.ViewModels
{
    public class GymClassViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [ValidDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string StartTime { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

  

        //TimeSpan ts = NowTime - ParkedTime;
        //TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";



        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1} } {2}", Date, StartTime, EndTime));
        }

        public string Description { get; set; }

        public DateTime NowTime { get; set; }

        public string TotalTime { get; set; }

        public GymClassViewModel()
        {
            //TimeSpan Duration = NowTime - Star 
            TotalTime = $"{ Math.Floor(Duration.TotalDays)} days, { Duration.Hours} hours and { Duration.Minutes} minutes";
             var EndTime = StartTime + Duration;

        }
        public string EndTime { get { return StartTime + Duration; } }

    }
}