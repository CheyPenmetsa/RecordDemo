namespace RecordDemo
{
    public record StudentRecord(string FirstName, string LastName, int Age);

    public record TestRecord
    {
        public int Size { get; set; }

        public string Color { get; set; }
    }
}
