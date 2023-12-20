namespace DesignPattern_Example.Homework512.Decorator
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Fee Fee { get; set; }
        public Student(string name, string iD, Fee fee)
        {
            Name = name;
            ID = iD;
            Fee = fee;
        }
    }

}
