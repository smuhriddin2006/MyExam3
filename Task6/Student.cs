namespace Task6;

public class Student : Person
{
    private string _programm;
    private int _year;
    private double _fee;

    public Student(string name, string addres, string _programm , int _year, double fee) : base (addres, name) {}
    public string GetProgram()
    {
        return _programm;
    }
    public void SetProgramm(string programm)
    {
       _programm = programm;
    }
        public int GetYear()
    {
        return _year;
    }
    public void SetYear(int year)
    {
       _year = year;
    }
        public double GetFee()
    {
        return _fee;
    }
    public void SetFee(double fee)
    {
       _fee = fee;
    }
    public  string ToString()
    {
        return $"{_programm}, {_year}, {_fee} ";
    }

}
