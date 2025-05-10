﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
