using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //menu:
            //    Console.WriteLine("1.Start Meeting\n2.Close program");
            //    string choise = Console.ReadLine();
            //    bool endProcces = false;
            //    do
            //    {
            //        switch (choise)
            //        {
            //            case "1":
            //                Meeting meeting1 = new Meeting();
            //                meeting1.Name = Console.ReadLine();
            //            exit:
            //                Console.WriteLine("1.End meeting");
            //                string exit = Console.ReadLine();
            //                switch (exit)
            //                {
            //                    case "1":
            //                        meeting1.ToDate = DateTime.Now;
            //                        goto info;
            //                    info:
            //                        Console.WriteLine(meeting1.ShowInfo());
            //                        break;
            //                    default:
            //                        goto exit;
            //                }
            //                goto menu;
            //            case "2":
            //                endProcces = true;
            //                break;
            //            default:
            //                goto menu;

            //        }
            //    } while (!endProcces);

            //Meeting meeting1 = new Meeting();
            //Console.WriteLine("Meeting name");
            //meeting1.Name = Console.ReadLine();
            //meeting1.ToDate = DateTime.Now;
            //Meeting meeting2 = new Meeting();
            //Console.WriteLine("Meeting name");
            //meeting2.Name = Console.ReadLine();
            //meeting2.ToDate = DateTime.Now;
            //Meeting meeting3 = new Meeting();
            //Console.WriteLine("Meeting name");
            //meeting3.Name = Console.ReadLine();
            //meeting3.ToDate = DateTime.Now;
            //Console.WriteLine(meeting1.ShowInfo()+ "\n" + meeting2.ShowInfo() + "\n"+ meeting3.ShowInfo());
            #endregion
            //Meeting meeting1 = new Meeting();
            //meeting1.Name = "Test";
            //meeting1.FromDate = new DateTime(2022,04,24,8,30,00);
            //meeting1.ToDate = new DateTime(2022, 04, 24, 12, 30,00);

            //Meeting meeting2 = new Meeting();
            //meeting2.Name = "Test2";
            //meeting2.FromDate = new DateTime(2022, 05, 20, 9, 00, 00);
            //meeting2.ToDate = new DateTime(2022, 05, 20, 13, 00, 00);

            //Meeting meeting3 = new Meeting();
            //meeting3.Name = "Test3";
            //meeting3.FromDate = new DateTime(2022, 06, 16, 9, 30, 00);
            //meeting3.ToDate = new DateTime(2022, 06, 16, 13, 30, 00);

            MeetingSchedule meetings = new MeetingSchedule();
            meetings.SetMeeting("Test1", new DateTime(2022, 04, 24, 8, 30, 00), new DateTime(2022, 04, 24, 12, 30, 00));
            meetings.SetMeeting("Test2", new DateTime(2022, 05, 20, 9, 00, 00), new DateTime(2022, 05, 20, 13, 00, 00));
            meetings.SetMeeting("Test3", new DateTime(2022, 06, 16, 9, 30, 00), new DateTime(2022, 06, 16, 13, 30, 00));
            foreach (var item in meetings.FindMeetingsCount(new DateTime(2022, 04, 24, 8, 30, 00)))
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine(meetings.IsExistsMeetingByName("est3"));
            foreach (var item in meetings.GetExistMeetings("est1"))
            {
                Console.WriteLine(item.ShowInfo());
            }
        }
    }
}
