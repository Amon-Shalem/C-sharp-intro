namespace Lesson11
{
    public class Program
    {
        public static void Main(String[] args)
        {
            #region 一維數組

            #region 聲明數組
            //聲明並初始化
            // int[] iArray = new int[10];
            //聲明長度和字面量（僅c#支持)
            // int[] iArray2 = new int[10]{1,2,3,4,5,6,7,8,9,10};
            //聲明字面量
            // int[] iArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //直接設置字面量（不能用var)
            // int[] iArray4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //直接使用集合表達式（c#9.0後，不能用var)
            // int[] iArray5 = [1, 2, 3, 4, 5];
            //不聲明類別
            // var iArray5 = new[] { 1, 2, 3 };
            #endregion

            #region 調用數組
            //調用
            /*int[] intArray = { 1, 2, 3 };
            Console.WriteLine(intArray[1]);*/
            //重新賦值
            /*intArray[1] = 4;
            Console.WriteLine(intArray[1]);*/

            #endregion

            #region 獲得長度

            /*int[] iArr = new int[3] { 1, 2, 3 };
            Console.WriteLine(iArr.Length);*/

            #endregion

            #region 常見API

            //Sort
            /*int[] iArr = { 1, 3, 2, 4 };
            Array.Sort(iArr);
            Console.WriteLine(string.Join(",",iArr));*/

            /*Point[] points = new Point[] { new Point(1, 2), new Point(1, 3), new Point(2, 3) };
            
            Array.Sort(points);

            foreach (Point point in points)
            {
                Console.WriteLine(point.X + " " + point.Y);
            }
            
            Array.Sort(points, (prev, curr) => prev.X == curr.X? curr.Y-prev.Y:curr.X-curr.Y);
            
            foreach (Point point in points)
            {
                Console.WriteLine(point.X + " " + point.Y);
            }*/
            
            //BinarySearch
            /*int[] iArr = { 1, 2, 3 };
            Console.WriteLine(Array.BinarySearch(iArr,1));//0
            Console.WriteLine(Array.BinarySearch(iArr,4));//-4*/
            
            //Copy
            /*int[] iArr = { 1, 3, 3 };
            int[] iArr2 = new int[3];
            Array.Copy(iArr, iArr2, 3);
            Console.WriteLine(string.Join(" ",iArr2));*/
            
            //Clear
            /*int[] iArr = { 1, 3, 4, 5 };
            Array.Clear(iArr,0,iArr.Length);//清空後，使用默認值填充
            Console.WriteLine(string.Join(",", iArr));*/
            
            //IndexOf,LastIndexOf
            /*int[] iArr = { 1, 2, 3, 4, 5, 5 };
            Console.WriteLine(Array.IndexOf(iArr, 5));//從前面找
            Console.WriteLine(Array.LastIndexOf(iArr, 5));//從後面找*/
            
            //Reverse
            /*int[] iArr = { 1, 3, 4, 5 };
            Array.Reverse(iArr);
            Console.WriteLine(string.Join(",", iArr));*/
            
            //Resize
            /*int[] iArr1 = { 1, 3, 4 };
            int[] iArr2 = [];
            Array.Resize(ref iArr2, iArr1.Length);
            Array.Copy(iArr1, iArr2, iArr1.Length);
            Console.WriteLine(string.Join(',', iArr2));*/


            #endregion


            #endregion

            #region 二維數組

                #region 聲明

                /*
                int[,] iArr2 = new int[,]
                {
                    { 1, 2 },
                    { 3, 4 }
                };
                */
                
                

                /*foreach (var i in iArr2)
                {
                    Console.WriteLine(i);
                }*/
                
                
                #endregion

                #region 調用

                /*int[,] iArr2 = new int[,] { { 1, 2 }, { 3, 4 } };
                Console.WriteLine(iArr2[0, 0]);*/

                #endregion

                #region 獲得長度

                int[,] iArr = new int[,] { { 1, 2, 0}, { 3, 4, 5 } };
                Console.WriteLine(iArr.GetLength(0));
                Console.WriteLine(iArr.GetLength(1));

                #endregion

                #endregion
        }

        internal record Point(int X, int Y) : IComparable<Point>
        {
            public int CompareTo(Point? other)
            {
                if (other == null) return 0;
                return X == other.X ? Y - other.Y : X - other.X;
            }
        };
    }
}