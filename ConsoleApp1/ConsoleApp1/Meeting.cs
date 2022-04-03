using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Meeting
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Name { get; set; }
        #region Test
        //public Meeting()
        //{
        //    FromDate = DateTime.Now;
        //}
       #endregion
        public string ShowInfo()
        {
            return $"FromDate: {this.FromDate} - ToDate: {this.ToDate} - Name: {this.Name}";
        } 
        
    }
}
