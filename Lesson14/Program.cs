namespace  Lesson14
{
	public class Program
	{
		public static void Main(string[] args)
		{
			#region 參數傳遞

			#region 值類型

			//聲明的變量指代現有對象本身
			//包含基本數據類型，結構體實例，枚舉類，引用變量本身
			//一般存儲在棧上，除非被閉包引用，或聲明為類內字段或屬性
			//傳遞和賦值都是直接拷貝本身數據

			#endregion

			#region 引用類型

			//引用本身是值類型數據，但引用指向的對象是引用類型數據
			//包含值類型和指針以外的數據
			//存儲在堆上
			//傳遞和賦值是拷貝自身的引用

			#endregion

			#region 指針變量

			//指针是一种特殊的变量，存储另一个变量的内存地址，使用时需要显式解引用
			//通过 类型* 指针变量名 = &目标变量 声明一个指针对象并初始化
			//使用 *指針變量 取得指針地址指向的值
			//指針變量不被gc管理，因此要考慮生命週期

			/*int a = 0;

			unsafe
			{
				int* pa = &a;
				Console.WriteLine(*pa);
				int b = 10;
				pa = &b;
				Console.WriteLine(*pa);
				Console.WriteLine(a);
				pa = &a;
				*pa = 20;
				Console.WriteLine(a);

			}*/
			

			#endregion

			#region 幾種參數傳遞方式

			//1.值傳遞，實參賦值一份傳給形參，不影響實參本體
			/*void ChangeValue(int a)
			{
				a = 2;
			}

			int b = 1;
			
			ChangeValue(b);

			Console.WriteLine(b);//還是1*/
			
			//2.指針傳遞

			/*unsafe
			{
				void ChangeValue(int* a)
				{
					*a = 2;//此時指針a還是指向c的地址，因此將c賦值2
					var b = 3;
					a = &b;//此時a已經指向b
					Console.WriteLine(*a);//3
				}

				var c = 1;
				ChangeValue(&c);
				Console.WriteLine(c);//2
			}*/
			
			//引用傳遞
			//實參的引用被傳遞給形參，本質還是在傳地址

			/*void Swap(ref int a, ref int b)
			{
				(a, b) = (b, a);
			}
			
			int x = 1, y = 2;
			Swap(ref x, ref y);

			Console.WriteLine($"X = {x}, Y = {y}");*/
			
			//共享傳遞
			//實參的引用被複製一份傳遞給形參,重新賦值不會影響實參，但是屬性修改會影響
			// var a = new Person("John", 25);
			// ChangeVal1(a);
			// Console.WriteLine(a); // Name: John, Age: 25
			// ChangeVal2(a);
			// Console.WriteLine(a); // Name: Alice, Age: 30
			
			

			#endregion

			#region ref and out

			//c#獨有，Java不支持引用傳遞，Java傳引用類型比較像是共享傳參
			//內部對形參改變後，實參的值也會改變
			//傳參時，型參和實參都要加ref或是out

			
			/*void Sum(ref int ans, int a, int b) => ans = a + b;

			int ans = 0;
			Sum(ref ans, 10, 20);
			Console.WriteLine(ans);*/
			
			//ref 和 out 的區別是 ref傳遞的參數要先初始化，而out傳遞的不必，但是方法中必須賦值

			/*
			void Sum(out int ans, int a, int b)
			{
				ans = a + b;
			}
			
			Sum(out int ans, 1, 2);
			Console.WriteLine(ans);
			*/
			
			
			#endregion
			
			

			#endregion
		}
		
		
		// static void ChangeVal1(Person p) => p = new Person("Alice", 30);
		//
		// static void ChangeVal2(Person p)
		// {
		// 	p.Name = "Alice";
		// 	p.Age = 30;
		// }
		//
		// internal class Person(string? name, int? age)
		// {
		// 	public string? Name { get; set; } = name;
		// 	public int? Age { get; set; } = age;
		//
		// 	public override string ToString() => $"Name: {Name}, Age: {Age}";
		// }
	}
}