namespace Lesson10
{
	public static class MainClass
	{
		public static void Main(string[] args)
		{
			#region 枚舉類

			#region Flags用法
			// Days meettingDay = Days.Monday | Days.Wednesday | Days.Friday;
			// Console.WriteLine(meettingDay);
			#endregion

			#region 字符串和枚舉類轉換
			//枚舉類實例轉字符串用ToString
			/*Days day = Days.Monday;
			string s = day.ToString();
			Console.WriteLine(s);*/

			//字符串轉枚舉類，使用Enum.TryParse(字符串,是否忽略大小寫,out 欲賦值的變量(可直接在此聲明))
			// Days day;
			/*bool success = Enum.TryParse<Days>("monday", true, out Days day);
			Console.WriteLine(success);
			Console.WriteLine(day);*/
			


			#endregion

			#region 枚舉類和int轉換

			//還可以和int直接強轉
			/*int i = (int)Days.Wednesday;
			Console.WriteLine(i);*/

			/*Days newDays = 0;
			Days newDays1 = (Days)2;
			Console.WriteLine(newDays);
			Console.WriteLine(newDays1);*/
			

			#endregion

			#region 遍歷枚舉類

			foreach (Days day in Enum.GetValues(typeof(Days)))
			{
				Console.WriteLine(day);
				Console.WriteLine((int)day);
			}

			#endregion
			


			#endregion
		}
	}
	
	[Flags]
	public enum Days
	{
		None = 0,
		Monday = 1,
		Tuesday = 2,
		Wednesday = 4,
		Thursday = 8,
		Friday = 16,
		Saturday = 32,
		Sunday = 64
	}
	
	
}