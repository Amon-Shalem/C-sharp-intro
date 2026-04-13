using System.Security.AccessControl;

namespace  Lesson15
{
	public class Program
	{
		public static void Main(string[] args)
		{
			#region 結構體
			
			//帕斯卡命名法，本質是自定義的值類型數據，Java沒有結構體
			//一般聲明在命名空間，類，結構體，接口內部
			//結構體不可以繼承或被繼承，但是可以實現接口
			//自身可被訪問修飾符修飾
				//public 可被任何代碼訪問
				//private 只能在作用域範圍內訪問
				//internal 同一程序集內訪問
				//protected 嵌套它的類集

				/*var p = new Point(1);//可以訪問
				Console.WriteLine(p.ToString());*/

				// var p2 = new PointTest.Point2(1);//不可以訪問
				
				/*Prop prop = new Prop();
				prop.X = 5;
				Console.WriteLine(prop.X);*/
				
				/*Prop2 prop = new Prop2();
				Console.WriteLine(prop.X);*/
			
			//方法
			//帕斯卡命名法

				#endregion
		}

		private struct  Point(int x)
		{
			public int X = x;

			public override string ToString()
			{
				return $"{X}";
			}
		}

		private struct Prop()
		{
			private int _x;

			public int X
			{
				get { return _x; }
				set { _x = value; }
			}
			
		}
		
		private struct Prop2()
		{
			public int X
			{
				get;
				set;
			} = 2;
		}
	}

	class PointTest
	{
		private struct  Point2(int x)
		{
			public int X = x;

			public override string ToString()
			{
				return $"{X}";
			}
		}
	}
}