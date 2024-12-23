namespace Result_gen.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Student s1 = new Student(1, "Sanika");

        Assert.Equal(s1.name, "Sanika");
    }
    [Fact] public void Test2()
    {
        Student s1 = new Student(1, "Sanika");
        List<string> strings = new List<string>();
        List<string> sub = new List<string>() { "English ", "Hindi", "Mathematics", "History", "Science" };

        strings = s1.subjects;

        Assert.Equal(sub,strings);
    }
}