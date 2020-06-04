using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_2_Software_Verificable;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public const int MondayPosition = 0;
        public const int TuesdayPosition = 1;
        public const int WednesdayPosition = 2;
        public const int ThursdayPosition = 3;
        public const int FridayPosition = 4;
        public const int SaturdayPosition = 5;
        public const int SundayPosition = 6;

        public const string MondayName = "Monday";
        public const string TuesdayName = "Tuesday";
        public const string WednesdayName = "Wednesday";
        public const string ThursdayName = "Thursday";
        public const string FridayName = "Friday";
        public const string SaturdayName = "Saturday";
        public const string SundayName = "Sunday";
        [TestMethod]
        public void TestGetFirstDayOfWeek()
        {
            string appointmentTitle = "test";
            string appointmentDescription = "UnitTest Appointment";
            DateTime appointmentDate = new DateTime(2020, 06, 04);
            DateTime appointmentStartTime = new DateTime(01, 01, 01, 10, 0, 00);
            DateTime appointmentEndTime = new DateTime(01, 01, 01, 15, 0, 00);
            User user = new User();
            List<User> invitedUsers = new List<User>();
            Appointment appointment = new Appointment(appointmentTitle,appointmentDescription,appointmentDate,appointmentStartTime,appointmentEndTime,user,invitedUsers);
            DateTime firstDate = new DateTime(2020, 06, 01);
            DateTime secondDate = new DateTime(2020, 06, 07);
            bool isBetweenDates = appointment.IsBetweenDates(firstDate, secondDate);
            Assert.IsTrue(isBetweenDates);
        }
    }
}
