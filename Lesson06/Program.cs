// See https://aka.ms/new-console-template for more information

namespace Lesson06
{
    public static class Lesson06
    {
        public static void Main(string[] args)
        {
            #region 資料轉換
            //隱式轉換
            // short i = 1;
            // int i1 = i;
            // //顯式轉換括號轉換
            // short i2 = (short)i1;
            // Console.WriteLine(i2);
            //使用.Parse轉型(如果值不合法會報FormatException）
            // string s = "1a";
            // int i = int.Parse(s);
            // Console.WriteLine(i+1);
            //使用.TryParse判斷是否轉型成功
            // string s = "1";
            // int b = 0;
            // if (int.TryParse(s,out b))
            // { 
            //     Console.WriteLine(int.Parse(s));
            // }
            //使用Convert.To數據類型轉型（精度比括號轉型高）
            // float f = 0.9f;
            // Console.WriteLine((int)f); //無條件捨去
            // Console.WriteLine(Convert.ToInt32(f)); //四捨五入
            //toString(),幾乎所有資料類型都有toString方法
            // int i = 1;
            // String s = i.ToString();
            // Console.WriteLine(s);
            #endregion

            #region 拆裝箱
            // 目的：方便不同類型統一管理使用，或是把基礎類型當成引用類型來用
            // c#的List可以放基礎類型
            // var list = new List<int>();
            // list.Add(1);
            // list.Add(3);
            // Console.WriteLine(list.Count);
            // foreach (var i in list)
            // {
            //     Console.WriteLine(i);
            // }
            //拆裝箱
            int a = 1;
            object b = 2;
            int c = (int)b;



            #endregion



        }
    }
};

