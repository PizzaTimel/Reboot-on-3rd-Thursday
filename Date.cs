namespace dotnet6
{
    class Thursday
    {        
        public static bool Checkdate()
        {
            //Locate first Thursday of Month - add 2 weeks
            DateTime    Today               = System.DateTime.Now;
            DateTime    FirstDayOfMonth     = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
            int         Difference          = new int();      
            DateTime    ThursdayInTwoWeeks  = new DateTime();
            
            Difference = 14 + (4 - ((int)FirstDayOfMonth.DayOfWeek));
            ThursdayInTwoWeeks = FirstDayOfMonth.AddDays(Difference);            

            Console.WriteLine("First Day of Month was : " + ((int)FirstDayOfMonth.DayOfWeek));
            Console.WriteLine("3rd Thursday in this Month is: " + ThursdayInTwoWeeks);

            if(Today == ThursdayInTwoWeeks)
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
