﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2.Models
{
    public class utah_crashes
    {
        [Key]
        [Required]
        public string CRASH_ID { get; set; }

        public DateTime CRASH_DATETIME { get; set; }

        public string ROUTE { get; set; }

        public int MILEPOINT { get; set; }

        public int LAT_UTM_Y { get; set; }

        public int LONG_UTM_X { get; set; }

        public string MAIN_ROAD_NAME { get; set; }

        public string CITY { get; set; }

        public string COUNTY_NAME { get; set; }

        public bool WORK_ZONE_RELATED { get; set; }

        public bool PEDESTRIAN_INVOLVED { get; set; }

        public bool BICYCLIST_INVOLVED { get; set; }

        public bool MOTORCYCLE_INVOLVED { get; set; }

        public bool IMPROPER_RESTRAINT { get; set; }

        public bool UNRESTRAINED { get; set; }

        public bool DUI { get; set; }

        public bool INTERSECTION_RELATED { get; set; }

        public bool WILD_ANIMAL_RELATED { get; set; }

        public bool DOMESTIC_ANIMAL_RELATED { get; set; }

        public bool OVERTURN_ROLLOVER { get; set; }

        public bool COMMERCIAL_MOTOR_VEH_INVOLVED { get; set; }

        public bool TEENAGE_DRIVER_INVOLVED { get; set; }

        public bool OLDER_DRIVER_INVOLVED { get; set; }

        public bool NIGHT_DARK_CONDITION { get; set; }

        public bool SINGLE_VEHICLE { get; set; }

        public bool DISTRACTED_DRIVING { get; set; }

        public bool DROWSY_DRIVING { get; set; }

        public bool ROADWAY_DEPARTURE { get; set; }

        [Required]
        public int SeverityId { get; set; }
        public Severity Severity { get; set; }

    }
}
