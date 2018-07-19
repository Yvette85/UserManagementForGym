using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UserManagementForGym.ViewModels;

namespace UserManagementForGym.Models
{
    public class GymClass

    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [ValidTime]
        public DateTime StartTime { get; set; }
        [Required]
        public  TimeSpan Duration { get; set; }

        public DateTime EndTime { get { return StartTime + Duration; } }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
   
    public virtual ICollection <ApplicationUser> AttendingMemebers { get; set; }

    }

}