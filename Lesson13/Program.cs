#region 頂級語句

//不用namespace也不用聲明類和Main方法

// Console.WriteLine("Hello, World!");

#endregion

namespace Lesson13;
class Program
{
	static void Main(string[] args)
	{
#region 函數和方法

	#region Lambda



//lambda函數

//無返回值
/*void PrintHW() => Console.WriteLine("Hello, World!");
PrintHW();*/

//有返回值
/*
int Sum(int a, int b) => a + b;
Console.WriteLine(Sum(1,2));*/
#endregion

	#region 局部函數
	
		/*int Add(int a, int b)
		{
			return a + b;
		}

		Console.WriteLine(Add(1, 2));*/
	#endregion

	#region 閉包

	/*
	var func1 = Func1();
	func1();
	func1();

	//Action用於無返回值的閉包，有值的用Func<輸入參數類別, 返回值類別>
	Action Func1()
	{
		var count = 0;
		var lambda = new Action(() =>
		{
			count++;
			Console.WriteLine(count);
		});
		
		return lambda;
	}*/
	

	#endregion

	#region 函數重載
	
	//基本和Java一致，只有方法可以實現重載，具體如下
	//參數數量不同
	//參數數量相同，但返回類型或參數類型不同
	//參數數量相同，但不同類型順序不同
	//參數完全相同，但添加了ref和out

	#endregion

	#region 變長參數和參數默認值
	
	//一個方法內只能有一個變長參數，而且必須是該方法內的最後一個參數
	//變長參數在函數內部被視為一個數組
	//聲明方法如下
	//类型 函数名(参数类型1 参数1, params 参数类型2[] 参数2)

	/*
	void LongerArg(params string[] words)
	{
		foreach (var word in words)
		{
			Console.WriteLine(word);
		}
	}
	
	LongerArg("Hello", "World", "And", "Goodbye");
	*/

	#endregion

	#region 參數默認值

	//擁有默認值的參數必須在普通參數的後面，變長參數的前面
	//傳參時不能跳過中間的參數

	/*void SayHello(string name, string message = "Hello")
	{
		Console.WriteLine(message + " " + name + "!");
	}
	
	SayHello("Anson","Hi");
	SayHello("John");*/

	#endregion

	#region 遞歸函數

	//函數本身可以調用自己，但要主要不要出現無限遞歸
	
	//輾轉相除法求最大公因數

	/*int GCD(int a, int b)
	{
		return b == 0 ? a : GCD(b, a % b);
	}

	Console.WriteLine(GCD(12, 18));*/

	#endregion


#endregion
		
	}
}



