using System;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TryParseControl, between, firsttime = true;
            int D_1, D_2, Y_1, Y_2, interval;
            string M_1, M_2, day_of_week_1_s="", day_of_week_2_s="";


            do
            {
                Console.WriteLine("Please enter day 1: ");

                if (firsttime == false)
                {
                    Console.Clear();
                    Console.WriteLine("Your value is not valid. Please enter the day 1 again:");
                }
                firsttime = false;
                TryParseControl = Int32.TryParse(Console.ReadLine(), out D_1);
                between = D_1 < 32 && D_1 > 0;
            }
            while (TryParseControl == false || between == false);

            firsttime = true;

            Console.Clear();




            int month1 = 0;
            do

            {
                Console.Clear();
                Console.Write("Please enter month 1: ");
                M_1 = Console.ReadLine();

                switch (M_1)
                {
                    case "January": case "january": case "jan": month1 = 1; break;
                    case "February": case "february": case "feb": month1 = 2; break;
                    case "March": case "march": case "mar": month1 = 3; break;
                    case "April": case "april": case "apr": month1 = 4; break;
                    case "May": case "may": month1 = 5; break;
                    case "June": case "june": month1 = 6; break;
                    case "July": case "july": month1 = 7; break;
                    case "August": case "august": case "aug": month1 = 8; break;
                    case "September": case "september": case "sep": month1 = 9; break;
                    case "October": case "october": case "oct": month1 = 10; break;
                    case "November": case "november": case "nov": month1 = 11; break;
                    case "December": case "december": case "dec": month1 = 12; break;
                }
            } while (month1 == 0);
            Console.Clear();


            do
            {
                Console.WriteLine("Please enter year 1: ");

                if (firsttime == false)
                {
                    Console.Clear();
                    Console.WriteLine("Your value is not valid. Please enter the year 1 again:");
                }
                firsttime = false;
                TryParseControl = Int32.TryParse(Console.ReadLine(), out Y_1);
                between = Y_1 >= 2015;
            }
            while (TryParseControl == false || between == false);

            firsttime = true;

            Console.Clear();

            do
            {
                Console.WriteLine("Please enter day 2: ");

                if (firsttime == false)
                {
                    Console.Clear();
                    Console.WriteLine("Your value is not valid. Please enter the day 2 again:");
                }
                firsttime = false;
                TryParseControl = Int32.TryParse(Console.ReadLine(), out D_2);
                between = D_2 < 32 && D_2 > 0;
            }
            while (TryParseControl == false || between == false);

            firsttime = true;

            Console.Clear();

            int month2 = 0;
            do

            {
                Console.Clear();
                Console.Write("Please enter month 2: ");
                M_2 = Console.ReadLine();

                switch (M_2)
                {
                    case "January": case "january": case "jan": month2 = 1; break;
                    case "February": case "february": case "feb": month2 = 2; break;
                    case "March": case "march": case "mar": month2 = 3; break;
                    case "April": case "april": case "apr": month2 = 4; break;
                    case "May": case "may": month2 = 5; break;
                    case "June": case "june":  month2 = 6; break;
                    case "July": case "july":  month2 = 7; break;
                    case "August": case "august": case "aug": month2 = 8; break;
                    case "September": case "september": case "sep": month2 = 9; break;
                    case "October": case "october": case "oct": month2 = 10; break;
                    case "November": case "november": case "nov": month2 = 11; break;
                    case "December": case "december": case "dec": month2 = 12; break;                   
                }
            } while (month2 == 0);
            Console.Clear();



            do
            {
                Console.WriteLine("Please enter year 2: ");

                if (firsttime == false)
                {
                    Console.Clear();
                    Console.WriteLine("Your value is not valid. Please enter the year 2 again:");
                }
                firsttime = false;
                TryParseControl = Int32.TryParse(Console.ReadLine(), out Y_2);
                between = Y_2 >= 2015;
            }
            while (TryParseControl == false || between == false);

            firsttime = true;

            Console.Clear();

            do
            {
                Console.WriteLine("Please enter an interval: ");

                if (firsttime == false)
                {
                    Console.Clear();
                    Console.WriteLine("Your value is not valid. Please enter the interval again:");
                }
                firsttime = false;
                TryParseControl = Int32.TryParse(Console.ReadLine(), out interval);
            }
            while (TryParseControl == false || between == false);

            Console.Clear();
            Console.WriteLine("Interval is " + interval);

            if ((Y_1 > Y_2)|| ((Y_1 == Y_2) && (month1 > month2)) || ((Y_1 == Y_2) && (M_1 == M_2) && (D_1 > D_2)))
            {
                int temp1_month, temp1_day, temp1_year;
                string temp1_dayofweek;
                temp1_day = D_1;
                D_1 = D_2;
                D_2 = temp1_day;
                temp1_month = month1;
                M_1 = M_2;
                month2 = temp1_month;
                temp1_year = Y_1;
                Y_1 = Y_2;
                Y_2 = temp1_year;
                temp1_dayofweek = day_of_week_1_s;
                day_of_week_1_s = day_of_week_2_s;
                day_of_week_2_s = temp1_dayofweek;
            }

            int temp_day= D_1, temp_month= month1, temp_year= Y_1;

            string temp_month_s="";
         
            Console.Clear();

            Console.Write("Spring");
            Console.SetCursorPosition(45, 0);
            Console.Write("Summer");
            Console.SetCursorPosition(90, 0);
            Console.Write("Autumn");
            Console.SetCursorPosition(135, 0);
            Console.Write("Winter");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            int totlal_spring_days=0, totlal_winter_days = 0, totlal_autumn_days = 0, totlal_summer_days = 0;
            while (temp_year < Y_2 || (temp_month < month2  && temp_year == Y_2) || (temp_month == month2 && temp_year == Y_2 && temp_day< D_2 ))
            {
                switch (temp_month)
                {
                    case 1: temp_month_s = "January"; break;
                    case 2: temp_month_s = "February"; break;
                    case 3: temp_month_s = "March"; break;
                    case 4: temp_month_s = "April"; break;
                    case 5: temp_month_s = "May"; break;
                    case 6: temp_month_s = "June"; break;
                    case 7: temp_month_s = "July"; break;
                    case 8: temp_month_s = "August"; break;
                    case 9: temp_month_s = "September"; break;
                    case 10: temp_month_s = "October"; break;
                    case 11: temp_month_s = "November"; break;
                    case 12: temp_month_s = "December"; break;
                }

                int MonthOffset = 8;
                if (((temp_year % 4 == 0) && (temp_year % 100 != 0)) || temp_year % 400 == 0)
                {
                    if ((temp_month == 1) || (temp_month == 4) || (temp_month == 7))
                    {
                        MonthOffset = 0;
                    }

                    else if ((temp_month == 2) || (temp_month == 8))
                    {
                        MonthOffset = 3;
                    }
                    else if ((temp_month == 3) || (temp_month == 11))
                    {
                        MonthOffset = 4;
                    }

                    else if (temp_month == 5)
                    {
                        MonthOffset = 2;
                    }
                    else if (temp_month == 6)
                    {
                        MonthOffset = 5;
                    }
                    else if ((temp_month == 9) || (temp_month == 12))
                    {
                        MonthOffset = 6;
                    }
                    else if (temp_month == 10)
                    {
                        MonthOffset = 1;
                    }

                }

                else
                {
                    if ((temp_month == 1) || (temp_month == 10))
                    {
                        MonthOffset = 0;
                    }
                    else if ((temp_month == 2) || (temp_month == 3) || (temp_month == 11))
                    {
                        MonthOffset = 3;
                    }
                    else if ((temp_month == 4) || (temp_month == 7))
                    {
                        MonthOffset = 6;
                    }
                    else if (temp_month == 5)
                    {
                        MonthOffset = 1;
                    }
                    else if (temp_month == 6)
                    {
                        MonthOffset = 4;
                    }
                    else if (temp_month == 8)
                    {
                        MonthOffset = 2;
                    }
                    else if ((temp_month == 9) || (temp_month == 12))
                    {
                        MonthOffset = 5;
                    }
                }

                int day_of_week = (temp_day + MonthOffset + 5 * ((temp_year - 1) % 4) + 4 * ((temp_year - 1) % 100) + 6 * ((temp_year - 1) % 400)) % 7;
                string day_of_week_s="";
                if (day_of_week == 0)
                {
                    day_of_week_s = "Sunday";
                }
                else if (day_of_week == 1)
                {
                    day_of_week_s = "Monday";
                }
                else if (day_of_week == 2)
                {
                    day_of_week_s = "Tuesday";
                }
                else if (day_of_week == 3)
                {
                    day_of_week_s = "Wednesday";
                }
                else if (day_of_week == 4)
                {
                    day_of_week_s = "Thursday";
                }
                else if (day_of_week == 5)
                {
                    day_of_week_s = "Friday";
                }
                else if (day_of_week == 6)
                {
                    day_of_week_s = "Saturday";
                }
                
                if (temp_month==12 || temp_month== 1 || temp_month == 2)
                {
                    Console.SetCursorPosition(135, totlal_winter_days + 2);
                    totlal_winter_days += 1;
                }
                else if (temp_month == 3 || temp_month == 4 || temp_month == 5)
                {
                    Console.SetCursorPosition(0, totlal_spring_days+2);
                    totlal_spring_days+=1;
                }
                else if (temp_month == 6 || temp_month == 7|| temp_month == 8)
                {
                    Console.SetCursorPosition(45, totlal_summer_days + 2);
                    totlal_summer_days += 1;
                }
                else
                {
                    Console.SetCursorPosition(90, totlal_autumn_days + 2);
                    totlal_autumn_days += 1;
                }

                Console.Write( ""+ temp_day +" "+ temp_month_s + " " + temp_year + " is " + day_of_week_s);

                temp_day = temp_day + interval;

                if ((((temp_year % 4 == 0) || (temp_year % 100 != 0)) && temp_month == 2) && temp_day > 29)
                {
                    temp_day -= 29;
                    temp_month = temp_month + 1;
                }

                else if ((((temp_year % 4 != 0) || (temp_year % 100 == 0)) && temp_month == 2) && temp_day > 28)
                {
                    temp_day -= 28;
                    temp_month = temp_month + 1;
                }
                else if ((temp_month==1 || temp_month == 3 || temp_month == 5 || temp_month == 7 || temp_month == 8 || temp_month == 10 || temp_month == 12)&&temp_day>31)
                {
                    temp_day -= 31;
                    temp_month = temp_month + 1;
                }
                else if( ( temp_month == 4 || temp_month == 6 || temp_month == 9 || temp_month == 11)&& temp_day > 30)
                {
                    temp_day -= 30;
                    temp_month = temp_month + 1;
                }
                if(temp_month <= 12 == false)
                {
                    temp_month = temp_month - 12;
                    temp_year = temp_year + 1;
                }
            }
            Console.ReadKey();
        }
    }
}


