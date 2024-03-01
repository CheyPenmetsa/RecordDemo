namespace RecordDemo
{
    public class StudentClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void Deconstruct(out string fn, out string ln, out int age)
        {
            fn = this.FirstName;
            ln = this.LastName;
            age = this.Age;
        }
    }
}
