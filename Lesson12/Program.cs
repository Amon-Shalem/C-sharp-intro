namespace  Lesson12
{
	public class Program
	{
		public static void Main(string[] args)
		{
			#region 交錯數組
				#region 聲明
				//第一個維度的長度不能留空，留空的維度後面的維度都要留空
				// int[][] iArr = new int[3][];
				//特殊聲明方法(使用中括號）
				/*int[][] iArr =
				[
					[1, 2],
					[3, 4, 5]
				];*/

				#endregion

				#region 調用

				/*int[][] iArr =
				[
					[1,2],
					[9]
				];

				Console.WriteLine(iArr[1][0]);*/

				#endregion
				
				#region 獲得長度

				int[][][] iArr = [ [[1,2],[2,3,4,5]],[[9]],[[4],[9]]];
				Console.WriteLine(iArr[0].Length);
				Console.WriteLine(iArr[1].Length);
				Console.WriteLine(iArr[0][0].Length);
				Console.WriteLine(iArr[0][1].Length);

				#endregion

				#endregion
		}
	}
}