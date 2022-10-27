using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiwainStockUtility;

namespace TestTaiwainStock
{
	internal class TestTaiwanStock
	{
		[Test]
		public void IsTradingTime_平日晚上 ()
		{
			var obj = new Stock();

			string expected = "不再營業時間";
			DateTime today = DateTime.Now;
			DateTime date = new DateTime(today.Year, today.Month, today.Day, 22, 0, 0);
			string actual = obj.IsTradingTime(date);

			Assert.AreEqual(expected, actual);


		}
		[Test]
		public void IsTradingTime_假日()
		{
			var obj = new Stock();

			string expected = "不再營業時間";
			DateTime today = DateTime.Now;
			DateTime date = new DateTime(today.Year, today.Month, 29, 00, 0, 0);
			string actual = obj.IsTradingTime(date);

			Assert.AreEqual(expected, actual);


		}
		public void IsTradingTime_平日凌晨()
		{
			var obj = new Stock();

			string expected = "不再營業時間";
			DateTime today = DateTime.Now;
			DateTime date = new DateTime(today.Year, today.Month, today.Day, 02, 0, 0);
			string actual = obj.IsTradingTime(date);

			Assert.AreEqual(expected, actual);


		}
	}
}
