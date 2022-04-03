using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MeetingSchedule
    {
        public List<Meeting> MeetingList = new List<Meeting>();
        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            if (MeetingList.Count != 0)
            {
                foreach (var item in MeetingList)
                {
                    if (item.Name == name || (item.FromDate <= fromDate && item.ToDate >=fromDate) || (item.FromDate <= toDate && item.ToDate >= toDate))
                    {
                        throw new ExistingMeetingeException("Bu adda veye zamanda meeting movcuddur");
                    }
                }
                MeetingList.Add(new Meeting() { Name = name, FromDate = fromDate, ToDate = toDate });
            }
            else if(MeetingList.Count == 0)
                MeetingList.Add(new Meeting() { Name = name, FromDate = fromDate, ToDate = toDate });
        }
        public List<Meeting> FindMeetingsCount(DateTime date)
        {
            List<Meeting> searchedMeetings = new List<Meeting>();
            foreach (var meeting in MeetingList)
            {
                if (meeting.FromDate > date)
                {
                    searchedMeetings.Add(meeting);
                }
            }
            return searchedMeetings;
        }
        public bool IsExistsMeetingByName(string text)
        {
            foreach (var meeting in MeetingList)
            {
                if (meeting.Name.Contains(text))
                    return true;
            }
            return false;
        }
        public List<Meeting> GetExistMeetings(string text)
        {
            List<Meeting> searchedMeetings = new List<Meeting>();
            foreach (var meeting in MeetingList)
            {
                if (meeting.Name.Contains(text))
                {
                    searchedMeetings.Add(meeting);
                }
            }
            return searchedMeetings;
        }
    }
}
