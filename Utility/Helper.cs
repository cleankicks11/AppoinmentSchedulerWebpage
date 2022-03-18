using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduler.Utility
{
    public static class Helper
    {
        public static string admin = "Admin";
        public static string doctor = "Doctor";
        public static string patient = "Patient";
        public static string appointmentAdded = "Appointment added successfully.";
        public static string appointmentUpdated = "Appointment updated successfully.";
        public static string appointmentDeleted = "Appointment deleted successfully.";
        public static string appointmentExists = "Appointment for selected date and time already exists.";
        public static string appointmentNotExists = "Appointment not exists.";

        public static string appointmentAddError = "Something went wront, Please try again.";
        public static string appointmentUpdatError = "Something went wront, Please try again.";
        public static string somethingWentWrong = "Something went wront, Please try again.";
        public static int success_code = 1;
        public static int failure_code = 0;

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.admin,Text=Helper.admin},
                new SelectListItem{Value=Helper.patient,Text=Helper.patient},
                new SelectListItem{Value=Helper.doctor,Text=Helper.doctor}
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 30;
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i <= 1; i=+30)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Minutes" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hour" });
                minute = minute + 60;
            }
            return duration;
        }
    }
}
