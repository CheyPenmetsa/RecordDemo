using RecordDemo;

// Mutability sample
var studentRecord = new StudentRecord("John", "Doe", 18);
//studentRecord.LastName = "Jack";

var studentClass = new StudentClass();
studentClass.LastName = "Smith";
studentClass.FirstName = "Jack";
studentClass.Age = 20;

studentClass.FirstName = "John";

// Nondestructive mutation
var studentRecord1 = new StudentRecord("John", "Doe", 18);
var studentRecord2 = studentRecord1 with { FirstName = "Jack" };

//Class wont allow this
//var studentClass1 = studentClass with { FirstName = "John" };

//Value based equality
var stuRecord1 = new StudentRecord("John", "Doe", 18);
var stuRecord2 = new StudentRecord("John", "Doe", 18);
//Console.WriteLine($"Record Value based Equality: {stuRecord1==stuRecord2}");

var stuClass1 = new StudentClass();
studentClass.LastName = "Smith";
studentClass.FirstName = "Jack";
studentClass.Age = 20;
var stuClass2 = new StudentClass();
studentClass.LastName = "Smith";
studentClass.FirstName = "Jack";
studentClass.Age = 20;
//Console.WriteLine($"Class Value based Equality: {stuClass1 == stuClass2}");

//Deconstruction
var stuRecordList = new List<StudentRecord>
{
    studentRecord1,
    studentRecord2
};
foreach (var (fn,ln,age) in stuRecordList)
{
   // Console.WriteLine($"Record - FirstName: {fn}, LastName:{ln}, Age:{age}");
}

var stuClassList = new List<StudentClass>()
{
    studentClass
};
foreach(var (fn,ln,age) in stuClassList)
{
  //  Console.WriteLine($"Class - FirstName: {fn}, LastName:{ln}, Age:{age}");
}


var tstRecord1 = new TestRecord();
tstRecord1.Color = "red";
tstRecord1.Size = 100;

var tstRecord2 = new TestRecord();
tstRecord2.Color = "red";
tstRecord2.Size = 100;

Console.WriteLine(tstRecord1==tstRecord2);

Console.ReadLine();