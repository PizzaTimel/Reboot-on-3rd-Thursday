namespace dotnet6
{
    class Thursday
    {        
        public static bool Checkdate()
        {
            bool        TodayReboot;            
            DateTime    Today               = System.DateTime.Now;
            DateTime    FirstDayOfMonth     = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
            DateTime    CheckDay            = FirstDayOfMonth.AddDays(-1);
            int         Difference          = new int();      
            DateTime    ThursdayInTwoWeeks  = new DateTime();
            
            Difference = 14 + (4 - ((int)FirstDayOfMonth.DayOfWeek));
            ThursdayInTwoWeeks = FirstDayOfMonth.AddDays(Difference);
            //DateTime FirstDayOfMonth = new DateTime();
            //Get First Day of Month - set week 1 as Array - get Thursday of Array - add 2 weeks - find Thursday

            Console.WriteLine("First Day of Month was : " + ((int)FirstDayOfMonth.DayOfWeek));
            Console.WriteLine("Day before was : " + ((int)CheckDay.DayOfWeek));
            Console.WriteLine("3rd Thrusday in this Month is: " + ThursdayInTwoWeeks);

            if(Today == ThursdayInTwoWeeks)
            {
                TodayReboot = true;
            }
            else
            {
                TodayReboot = false;
            }
            
            return TodayReboot;
        }
    }
}
