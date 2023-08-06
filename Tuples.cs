namespace AllAboutTuples;


//# Tuples are reference type in c#
//# You can't define methods in a tuple type, but you can use the methods provided by .NET
//# When using Create System.Tuple is used which is reference type while parenthesis tuple are created using System.ValueTuple
//# With Create method you can only create up to 8 tuple elements

public class Tuples
{

  public void TuplesUsingParanthesis()
  {
    var student = ("Ram", 5, 11, "DPS");
    Console.WriteLine($"TuplesUsingParanthesis: {student}");
  }

  public void TuplesUsingCreate()
  {
    var student = Tuple.Create("Ram", 5, 11, "DPS");
    Console.WriteLine($"TuplesUsingCreate: {student}");
  }


  public void AccessTuplesUsingItems()
  {
    var student = Tuple.Create("Ram", 5, 11, "DPS");
    Console.WriteLine($"AccessTuplesUsingItems: Hi my name is {student.Item1}, I am of {student.Item2} yrs of age. I study in class {student.Item3} in {student.Item4}");
  }

  public void AccessTuplesUsingNamedProp()
  {
    //you cannot use nameprops in case of Tuple.Create method
    var student = (Name: "Ram", Age: 5, Class: 11, School: "DPS");
    Console.WriteLine($"AccessTuplesUsingNamedProp: Hi my name is {student.Name}, I am of {student.Age} yrs of age. I study in class {student.Class} in {student.School}");

  }

  public void ReassignTupleValues()
  {
    //you cannot change values created by create method in tuples
    var student = (Name: "Ram", Age: 5, Class: 11, School: "DPS");
    Console.WriteLine($"ReassignTupleValues: Tuple before change{student}");
    student.Age = 12;
    Console.WriteLine($"ReassignTupleValues: Tuple after change {student}");

  }

  public void NestedTuple()
  {
    var school = Tuple.Create("DPS", (Name: "Ram", Age: 5, Class: 11, School: "DPS"));
    Console.WriteLine(school);
  }


  public void TupleAsParamter()
  {
    var numbers = Tuple.Create(1, "John", 2);
    displayTuple(numbers);

    static void displayTuple(Tuple<int, string, int> numbers)
    {
      Console.WriteLine("TupleAsParamter: Tuple: " + numbers);
    }
  }

  public void TupleAsReturnType()
  {
    var employee = displaySalary();
    Console.WriteLine("TupleAsReturnType: " + employee.Salary);

    static (string Name, int Salary, int Age) displaySalary()
    {
      return (Name: "Selena", Salary: 15000, Age: 23);
    }
  }

  ///Extra tips
  public void ExtraTips()
  {
    var sum = 4.5;
    var count = 3;
    var x = (sum, count);
    Console.WriteLine("---------ExtraTips--------------------------");
    Console.WriteLine($"Sum of {x.count} elements is {x.sum}.");


    var a = 1;
    var t = (a, b: 2, 3);
    Console.WriteLine($"The 1st element is {t.Item1} (same as {t.a}).");
    Console.WriteLine($"The 2nd element is {t.Item2} (same as {t.b}).");
    Console.WriteLine($"The 3rd element is {t.Item3}.");


    var z = ("post office", 3.6);
    var (destination, distance) = z;
    Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

  }

}