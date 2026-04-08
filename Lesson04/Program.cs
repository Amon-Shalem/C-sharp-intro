namespace  Lesson04
{
    public static class Program
    {
        #region 常量
        
        //定義編譯時的常量
        private const string HelloString = "Hello, World!";
        
        //定義運行時的常量
        private static readonly int Value = GetValue();
        
        
        private static int GetValue()   
        {
            return 10;
        }
        
        #endregion

        public static void Main(string[] args)
        {
            //輸出常量
            Console.WriteLine(HelloString);
            Console.WriteLine(Value);
            
            //常量不能改變
            // HelloString = "byebye";
            // Value = 1;
        }
        
    }
}