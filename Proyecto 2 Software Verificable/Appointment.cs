using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_2_Software_Verificable
{
    [Serializable]
    public class Appointment
    {

        private string title;
        private string description;
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;
        private User creator;
        private List<User> invitedUsers;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }

        public User GetCreator()
        {
            return creator;
        }
        public Appointment() 
        {
        }
        public Appointment(string title, string description, DateTime date, DateTime startTime, DateTime endTime, User creator, List<User> invitedUsers)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.creator = creator;
            this.invitedUsers = invitedUsers;
        }

        public DateTime GetRealStartTime()
        {
            return date.Date.AddHours(startTime.Hour).AddMinutes(startTime.Minute).AddSeconds(startTime.Second);
        }
        public DateTime GetRealEndTime()
        {
            return date.Date.AddHours(endTime.Hour).AddMinutes(endTime.Minute).AddSeconds(endTime.Second);
        }
        public bool IsBetweenDates(DateTime initialDate, DateTime finalDate)
        {
            bool isAfterInitialDate = this.GetRealStartTime() >= initialDate;
            bool isBeforeFinalDate = this.GetRealStartTime() <= finalDate;
            bool isValidDate = (isAfterInitialDate && isBeforeFinalDate);

            if (isValidDate)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool IsUserInvited(User user)
        {
            if (user != null)
            {
                int possibleIndexOfUser = invitedUsers.IndexOf(user);
                bool isUserInInvitationsList = !(possibleIndexOfUser == -1);
                bool isUserTheCreator = (this.creator.Name == user.Name);
                if (isUserInInvitationsList || isUserTheCreator)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
