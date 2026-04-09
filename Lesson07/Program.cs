using System.Text;

namespace  Lesson07
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region 1.字符串池
            //不管是Java還是c#,字符串常量都是儲存在字符串池中
            // var b = "abc";
            // string a = "abc";
            // if (ReferenceEquals(a, b))
            // {
            //     Console.WriteLine("a和b指向同個字符串");
            // }
            //
            // if (a == b)
            // {
            //     Console.WriteLine("a == b");
            // }
            // else
            // {
            //     Console.WriteLine("a != b");
            // }
            
            //如果使用new string()創建字符串，則不會放入字符串池中
            // var c = new string("str");
            // var d = "str";
            //
            // if (ReferenceEquals(c, d))
            // {
            //     Console.WriteLine("c和d指向同個字符串");
            // }
            // else
            // {
            //     Console.WriteLine("c和d指向不同字符串");
            // }
            //
            // if (c == d)
            // {
            //     Console.WriteLine("c == d");                
            // }
            //
            // if (Equals(c, d))
            // {
            //     Console.WriteLine("c equal d");
            // }
            
            //但是可以用string的intern靜態方法將字符串放到池子中
            // c = string.Intern(c);
            // Console.WriteLine("將c用intern放到池子中(要重新賦值）");
            //
            // if (ReferenceEquals(c, d))
            // {
            //     Console.WriteLine("c和d指向同個字符串");
            // }
            // else
            // {
            //     Console.WriteLine("c和d指向不同字符串");
            // }


            #endregion

            #region 2.字符串拼接
            //使用+號連接
            // string a = "abc" + "def";
            // Console.WriteLine(a);
            
            //使用string.Concat連接
            // string b = "abc";
            // string c = "def";
            // string d = string.Concat(b, " ",c);
            // Console.WriteLine(d);
            
            //使用StringBuilder進行連接
            //位於System.Text當中
            // var sb = new StringBuilder();
            // var a = "abc";
            // var b = "def";
            // sb.Append(a);
            // sb.Append(b);
            // Console.WriteLine(sb);
            
            //使用String.Join方法
            //第一個參數是分隔符
            // var str = string.Join("$", "abc", "def", "ghi");
            // Console.WriteLine(str);
            
            //使用format字符串,java中也是string.format,不過是%s
            // var str = string.Format("{0} {1}", "abc", "def");
            // Console.WriteLine(str);
            
            // c#6.0後可用字符串插值
            // var a = "abc";
            // var b = "def";
            // var str = $"{a} {b}";
            // Console.WriteLine(str);
            
            #endregion

            #region 字符串屬性方法

            string a = " str";
            Console.WriteLine(a.Length);
            Console.WriteLine(a[1]);
            Console.WriteLine(a.IndexOf("t"));
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.Trim());
            Console.WriteLine(a.Contains("t"));
            Console.WriteLine(a.Split('t')[0]);//切割後取數組指定的部分
            Console.WriteLine(string.IsNullOrEmpty(a));
            Console.WriteLine(string.IsNullOrWhiteSpace(a));
            

            #endregion
        }
    }
}