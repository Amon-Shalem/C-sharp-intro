using System.Drawing;

namespace Lesson17;
class Program
{
    static void Main(string[] args)
    {
        #region 命名參數
        
        //通過顯式的傳參，可以越過中間有默認值的參數

        /*void SayHello(string name, int age = 10, string country = "USA")
        {
            Console.WriteLine($"Hello, my name is {name}, i'm {age} years old, i'm from {country}.");
        }
        
        SayHello("Anson", country:"Taiwan");*/

        #endregion

        #region 動態類型
        
        //Java不支持
        //盡量不要使用
        /*dynamic a = 123;
        a = "123";
        Console.WriteLine(a);*/
        
        //缺點
        //開銷大，編譯時無成員提示，類型不直觀
        #endregion

        #region 數字字面量聲明

        //字面量分隔符：增加數字可讀性，儲存不變
        // int a = 123_246;

        //其他進制的聲明
        //十六進制：0x
        // int a = 0x1a;
        // Console.WriteLine(a);//26
        
        //八進制（不支持）
        
        //二進制:0b
        // int b = 0b1010;
        // Console.WriteLine(b);//10

        #endregion

        #region 引用相關的特殊語法

            #region 1.ref

            //引用一個變量
            /*int a = 12;
            ref int b = ref a;//b存儲了a的引用
            b = 123;
            Console.WriteLine(a);//123*/
            
            //引用一個變量的成員
            /*Person person1 = new Person();
            person1.Age = 10;
            person1.Name = "john";
            ref string person = ref person1.Name;
            person = "Jessica";
            Console.WriteLine(person1.Name);//Jessica*/

            //引用方法的返回值

            /*ref int Find(int[] nums, int num)
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == num)
                    {
                        return ref nums[i];
                    }
                }

                throw new Exception("Not found");
            }
            
            var nums =  new int[] {1,2,3,4,5};
            ref int i1 = ref Find(nums, 1);
            i1 = 4;
            Console.WriteLine(string.Join(",", nums));*/


            #endregion
            
            #region 2.in
                
            //聲明in參數，強調該參數是按值傳遞的只讀，不能修改
            
            /*PersonStruct person = new PersonStruct(1,"Armon");

            void Print(in PersonStruct p)
            {
                Console.WriteLine($"{p.Age} {p.Name}");
                // p.Age = 2;//這裡會發生編譯錯誤，'in' 形参 'p' 为只读引用。访问的结构未被分类为变量时不能修改结构成员
            }
            
            Print(in person);*/
            
            
            #endregion
            
            #region 3.ref readonly
            
            /*BigPoint myPoint = new BigPoint { X = 1.2, Y = 3.4, Z = 5.6 };

            // 呼叫時需加上 ref 關鍵字（或是 in，視 C# 版本與語法習慣而定）
            PhysicsEngine.CalculateDistance(ref myPoint);
        
            Console.WriteLine("計算完成。");*/


            #endregion
            
            #region 4.靜態局部函數
            
            //確保局部函數不會訪問函數內其他變量
            CalculateCircleMetrics(1.2);

            #endregion

            #endregion

    }
    
    public static void CalculateCircleMetrics(double radius)
    {
        if (radius < 0) return;

        // 呼叫靜態區域函式
        double area = GetArea(radius);
        double circumference = GetCircumference(radius);

        Console.WriteLine($"半徑: {radius}");
        Console.WriteLine($"面積: {area:F2}");
        Console.WriteLine($"周長: {circumference:F2}");

        // --- 靜態區域函式定義 ---

        // 使用 static 確保不會意外存取 CalculateCircleMetrics 內的變數
        static double GetArea(double r) => Math.PI * r * r;

        static double GetCircumference(double r) => 2 * Math.PI * r;
    }
    
}

struct PersonStruct(int age, string name)
{
    public int Age { get; set; } = age;
    public string Name { get; set; } = name;
}
class Person
{
    public int Age { get; set; }
    public string Name;
    public Person(int age, string name)
    {this.Age = age;
        this.Name = name;
    }
}

public struct BigPoint
{
    public double X;
    public double Y;
    public double Z;
    // 假設這裡還有很多其他欄位...
}

public class PhysicsEngine
{
    // 使用 ref readonly 傳遞參數
    public static void CalculateDistance(ref readonly BigPoint point)
    {
        // 1. 可以讀取資料
        Console.WriteLine($"正在計算座標 ({point.X}, {point.Y}, {point.Z}) 的距離...");

        // 2. 編譯錯誤！不允許修改 ref readonly 參數的內容
        // point.X = 100.0; 
    }
}

