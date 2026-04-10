using System.Linq.Expressions;
using System;

namespace  Lesson09
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region 1. 捕獲異常

            #region 異常捕獲

            

            //異常捕獲
            /*int a = 0;
            try
            {
                int i = 1 / a;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally");
            }*/
            #endregion

            #region 特定異常捕獲

            
            

            //捕捉特定異常
            /*int b = 0;
            try
            {
                int i = 1 / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                throw;
            }*/
            #endregion

            #region catch when
            
            

            //catch when
            /*int c = 0;
            bool flag = true;
            try
            {
                int i = 1 / c;
            }
            catch (Exception e) when (flag)
            {
                Console.WriteLine(e);
                Console.WriteLine("catch");
                throw;
            }
            finally
            {
                Console.WriteLine("finally");
            }*/
            #endregion

            #region using語句（類似try with resources)

            /*string filePath = "example.txt";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("找不到指定的檔案");
            }*/


            #endregion

            #endregion

            #region 2. 異常拋出
            
            // C#中所有異常都是非受檢異常，意思是可能有異常的地方也不會要求你強制try catch
            // 使用 throw new Exception();拋出異常
            /*try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }*/

            #endregion

            #region 3. 自定義異常

            try
            {
                throw new MyException("MyException");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            #endregion

        }
    }
    
    public class MyException: Exception
    {
        public MyException(string message): base(message)
        {
        }
    }
}