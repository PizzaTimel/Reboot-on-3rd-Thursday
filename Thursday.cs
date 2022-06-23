namespace dotnet6
{
    class Thursday
    {        
        public static bool Checkdate()
        {
            //Locate first Thursday of Month - add 2 weeks
            int         DaysToAdd           = new int(); 
            DateTime    Today               = System.DateTime.Now;
            DateTime    FirstDayOfMonth     = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
            DateTime    ThursdayInTwoWeeks  = new DateTime();

            
            DaysToAdd           = 14 + (4 - ((int)FirstDayOfMonth.DayOfWeek));//4 represents Thursday
            ThursdayInTwoWeeks  = FirstDayOfMonth.AddDays(DaysToAdd);

            Console.WriteLine("3rd Thursday in this Month is: " + ThursdayInTwoWeeks.ToShortDateString());
            
            if(Today.ToShortDateString() == ThursdayInTwoWeeks.ToShortDateString())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
