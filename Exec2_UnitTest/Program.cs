using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaiwainStockUtility;

namespace Exec2_UnitTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now; //給時間
			
			var obj = new Stock();
			string result = obj.IsTradingTime(now);
			


			Console.WriteLine(result);




		}
	}
}
