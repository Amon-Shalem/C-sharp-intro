var manager =  new StudentManager();

while (true)
{
    Console.WriteLine("主菜單");
    Console.WriteLine("----------------------");
    Console.WriteLine("1. 添加");
    Console.WriteLine("2. 刪除");
    Console.WriteLine("3. 更新");
    Console.WriteLine("4. 查詢單個");
    Console.WriteLine("5. 查詢所有");
    Console.WriteLine("6. 退出");
    Console.WriteLine("----------------------");
    Console.Write("請選擇操作： （鍵盤輸入數字）");
    var input = Console.ReadLine();
    if (int.TryParse(input, out var selection))
    {
        switch ((EMenuSelection)selection)
        {
            case EMenuSelection.Add:
                Console.Write("請輸入姓名：");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "未輸入姓名";
                }
                Console.Write("請輸入年齡（留空則不輸入）：");
                var age = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(age) || !int.TryParse(age, out var ageValue))
                {
                    ageValue = 0;
                }
                Console.Write("請輸入班級（留空則不輸入）：");
                var  className = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(className))
                {
                    className = "未輸入班級";
                }
                Console.Write("請輸入年級（留空則不輸入）：");
                var grade = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(grade) || !int.TryParse(grade, out var gradeValue) && gradeValue >= 1 && gradeValue <= 6)
                {
                    gradeValue = 1;
                }
                
                manager.Add(new Student(name, ageValue, className, (Student.EGrade)gradeValue));
                break;
            case EMenuSelection.Delete:
                Console.Write("請輸入要刪除的學生ID:");
                var id = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(id) || !int.TryParse(id, out var idValue))
                {
                    idValue = -1;
                }
                
                var res = manager.Delete(idValue);
                Console.WriteLine(res? "刪除成功":"刪除失敗");
                break;
            case EMenuSelection.Update:
                Console.WriteLine("請輸入學生ID");
                var updateId = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(updateId) || !int.TryParse(updateId, out var updateIdValue))
                {
                    Console.WriteLine("無效的ID");
                    continue;
                }
                var s = manager.GetOne(updateIdValue);
                if (s == null)
                {
                    Console.WriteLine("未找到該學生");
                    continue;
                }

                Console.WriteLine("請輸入姓名（留空則不更新）");
                var updateName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(updateName))
                {
                    s = s.Value with {Name = updateName};
                }
                
                Console.Write("請輸入年齡（留空則不輸入）：");
                var updateAge = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(updateAge) && int.TryParse(updateAge, out var updateAgeValue))
                {
                    s = s.Value with {Age = updateAgeValue};
                }
                
                Console.Write("請輸入班級（留空則不輸入）：");
                var  updateClassName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(updateClassName))
                {
                    s = s.Value with {ClassName = updateClassName};
                }

                Console.Write("請輸入年級（留空則不輸入）：");
                var updateGrade = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(updateGrade) && int.TryParse(updateGrade, out var updateGradeValue) &&
                    updateGradeValue is >= 1 and <= 6)
                {
                    s = s.Value with{Grade = (Student.EGrade)updateGradeValue};
                }
                
                manager.Update(updateIdValue, s.Value);
                Console.WriteLine("更新成功");
                break;
            case EMenuSelection.GetOne:
                Console.WriteLine("請輸入學生ID");
                var getId =  Console.ReadLine();
                if (string.IsNullOrWhiteSpace(getId) || !int.TryParse(getId, out var getIdValue))
                {
                    Console.WriteLine("無效的ID");
                    continue;
                }
                var student = manager.GetOne(getIdValue);
                Console.WriteLine(student is null?"未找到該學生": student.ToString());
                break;
            case EMenuSelection.GetAll:
                var students = manager.GetAll();
                foreach (var item in students)
                {
                    Console.WriteLine(item.ToString());
                }
                break;
            case EMenuSelection.Exit:
                Console.WriteLine("退出");
                return;
            default:
                Console.WriteLine("無效的選擇");
                break;
        }
    }
    else
    {
        Console.WriteLine("無效的選擇");
    }
}

enum EMenuSelection
{
    Add = 1,
    Delete,
    Update,
    GetOne,
    GetAll,
    Exit
}

struct Student(string name)
{
    private static int _curId = 0;
    public int Id { get; }
    public string Name { get; set;}
    public int? Age { get; set; }
    public string ClassName { get; set; }
    public EGrade Grade { get; set; }

    public enum EGrade
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six
    }

    public Student(string name, int age, string className, EGrade grade) : this(name)
    {
        Id = _curId++;
        Name = name;
        Age = age;
        ClassName = className;
        Grade = grade;
    }

    override public string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, ClassName: {ClassName}, Grade: {Grade}";
    }
}

struct StudentManager(int capacity)
{
    private Student[] _students = new Student[capacity];
    private int _count = 0;

    public StudentManager() : this(10)
    {
    }

    /// <summary>
    /// 數組擴容
    /// </summary>
    private void Expend()
    {
        var newStudents = new Student[capacity * 2];
        Array.Copy(_students, newStudents, capacity);
        _students = newStudents;
        capacity *= 2;
    }

    /// <summary>
    /// 添加學生
    /// </summary>
    /// <param name="student">學生</param>
    public void Add(Student student)
    {
        if ((double)_count / capacity >= 0.75)
        {
            Expend();
        }

        _students[_count++] = student;
    }

    /// <summary>
    /// 刪除學生
    /// </summary>
    /// <param name="id">學生ID</param>
    /// <returns>是否刪除學生</returns>
    public bool Delete(int id)
    {
        var flag = false;
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Id != id) continue;
            for (var j = i; j < _count - 1; j++)
            {
                _students[j] = _students[j + 1];
            }

            _count--;
            flag = true;
            break;
        }
        return flag;
    }

    /// <summary>
    /// 更新學生
    /// </summary>
    /// <param name="id">學生ID</param>
    /// <param name="student">學生</param>
    public void Update(int id, Student student)
    {
        for (var i = 0; i < _count; i++)
        {
            if (_students[i].Id != id) continue;
            _students[i] = student;
            break;
        }
    }

    /// <summary>
    /// 查詢單個學生
    /// </summary>
    /// <param name="id">學生ID</param>
    /// <returns>查詢到的學生或null值</returns>
    public Student? GetOne(int id)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Id == id)
            {
                return _students[i];
            }
        }
        return null;
        // return _students.Cast<Student?>().FirstOrDefault(s => s?.Id == id);
    }


    // public Student[] GetAll() => _students.Take(_count).ToArray();

    /// <summary>
    /// 查詢所有的學生
    /// </summary>
    /// <returns>所有學生的數組</returns>
    public Student[] GetAll()
    {
        var students = new Student[_count];
        Array.Copy(_students, students, _count);
        return students;
    }
}