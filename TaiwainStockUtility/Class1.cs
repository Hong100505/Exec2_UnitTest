using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwainStockUtility
{
    public class Stock
    {
        public string IsTradingTime(DateTime now)
        {
			
			
			//時間要藉於9.00~13.30
			DateTime star = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0);
			DateTime end = new DateTime(now.Year, now.Month, now.Day, 13, 30, 0);

			
			//判斷有沒有在星期一到五
			string date = now.DayOfWeek.ToString("d"); //0~6
			int numebr = Convert.ToInt32(date);

			string result = string.Empty; 

			if (numebr > 0 && numebr < 6 && now > star && now < end)
			{
				result = "在營要時間";
			}
			else
			{
				result = "不再營業時間";
			}

			return result;

		}

    }
}
