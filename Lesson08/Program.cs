namespace Lesson08
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region 特殊的空值處理

            #region 1. 空合並運算符

            //1.1基本使用
            //前者會空就返回後者，非空則直接返回前者
            string a = "0", b = null;
            // Console.WriteLine(a ?? b);
            // Console.WriteLine(b ?? a);
            // Console.WriteLine(ReferenceEquals(b ?? a, b));

            #endregion

            #region 2. 空條件運算符

            //在空的變量後面打一個問號，不為null時執行方法或索引器
            var c = "str";
            // Console.WriteLine(c?.Length);
            string d = null;
            // Console.WriteLine(d?.Length);
            // Console.WriteLine(d?[0]);

            #endregion

            #region 3. 空引用抑制運算符（執行還是會報錯）

            //System.NullReferenceException:
            // Console.WriteLine(b!.Length);

            #endregion

            #region 4. 空類型運算符

            Nullable<int> ni = null;
            int? ni2 = null;

            #endregion

            #endregion

            #region 模式匹配

            object obj = 13;
            object obj2 = "Hello";
            object obj3 = null;
            //類型
            // if(obj is int i)
            //     Console.WriteLine(i);

            //類型 新變量
            // if(obj2 is string str)
            //     Console.WriteLine(str.ToUpper());

            //常量
            // if(obj3 is null)
            //     Console.WriteLine("obj 3 is null");

            //使用switch
            // switch (obj)
            // {
            //     case int i:
            //         Console.WriteLine(i);
            //         break;    
            // }


            //元組匹配
            // Point point = new Point(10, 20);
            // if(point is (10,20))
            //     Console.WriteLine("Point is (10,20)");

            //屬性匹配
            // Emploee e = new Emploee { Name = "Anson", Age = 28 };
            // if (e is { Name: "Anson", Age: 28 })
            // {
            //     Console.WriteLine("Hi, Anson");
            // }
            
            //列表匹配(再複雜一點就是歸併排序了）
            // var numbers = new[] { 1, 2, 3, 4, 5 };
            // var numbers2 = new[] { 1, 2, 3, 4, 5 };
            // var numbers = new int[]{};

            // switch (numbers, numbers2)
            // {
            //     case([var leftFirst,..],[var rightFirst, ..]):
            //         Console.WriteLine("Both arrray have value");  
            //         break;
            //     case([],[var rightFirst,..]):
            //         Console.WriteLine("Only right array has value");
            //         break;
            //     case([var leftFirst,..],[]):
            //         Console.WriteLine("Only left array has value");
            //         break;
            // }
            
            // when, 只能用在switch
            // object obj1 = 4;
            // switch (obj1)
            // {
            //     case int n when n is 4:
            //         Console.WriteLine(n);
            //         break;
            // }
            
            //and or not
            // object obj5 = 12;
            // if (obj5 is int and 12)
            // {
            //     Console.WriteLine("obj is int and 12");
            // }
            //
            // if (obj5 is int i and > 10)
            // {
            //     Console.WriteLine("obj is int and greater than 10");
            // }
            //
            // if (obj5 is not null)
            // {
            //     Console.WriteLine("obj5 is not null");
            // }
            

            #endregion

            #region 循環

            string str = "Hello";
            for (int i=0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            foreach (var c2 in str)
            {
                Console.WriteLine(c2);
            }

            #endregion
        }
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    public class Emploee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}