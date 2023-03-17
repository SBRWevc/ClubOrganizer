using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubOrganizer.Pages.Fast_Tennis.Class
{
    class DaysHours
    {
        internal static void DaysSum()
        {
            static int CountDays(DayOfWeek day, DateTime start, DateTime end)
            {
                TimeSpan ts = end - start;
                int count = (int)Math.Floor(ts.TotalDays / 7);
                int remainder = (int)(ts.TotalDays % 7);
                int sinceLastDay = (int)(end.DayOfWeek - day);
                if (sinceLastDay < 0) sinceLastDay += 7;

                if (remainder >= sinceLastDay) count++;

                return count;
            }

            ContractData.days = CountDays(ContractData.DayOfWeek, ContractData.DateStart, ContractData.DateEnd);
        }

        internal static void HoursSum()
        {
            if (ContractData.HourED > ContractData.HourST)
            {
                if (ContractData.MinED != ContractData.MinST)
                {
                    if (ContractData.MinED > ContractData.MinST)
                    {
                        ContractData.time = ContractData.HourED - ContractData.HourST + 0.5;
                    }
                    else
                    {
                        ContractData.time = ContractData.HourED - ContractData.HourST - 0.5;
                    }
                }
                else
                {
                    ContractData.time = ContractData.HourED - ContractData.HourST;
                }
            }
            else if (ContractData.HourED == ContractData.HourST)
            {
                ContractData.time = 0.5;
            }
        }

        internal static void MonthSum()
        {
            DateTime dt = ContractData.DateStart;
            DateTime dt2 = ContractData.DateEnd;
            Dictionary<int, int> di = new();
            int tek_month = dt.Month;
            for (DateTime i = dt; i <= dt2; i = i.AddDays(1))
            {
                if (!di.ContainsKey(i.Month))
                {
                    di.Add(i.Month, 0);
                }
                if (i.DayOfWeek == ContractData.DayOfWeek)
                {
                    di[i.Month]++;
                }
            }
            ServiceData.month = string.Join("      \n", di.Select(p => $"{new DateTime(2000, p.Key, 1):MMMM}").ToList());
            ServiceData.days = string.Join("      \n", di.Select(p => $"{p.Value}").ToList());
            ServiceData.hours = string.Join("       \n", di.Select(p => Convert.ToDouble($"{p.Value}") * ContractData.time));
            ServiceData.month_price = string.Join("       \n", di.Select(p => Convert.ToDouble($"{p.Value}") * ContractData.time * Convert.ToDouble(ContractData.price)));
        }
    }
}
