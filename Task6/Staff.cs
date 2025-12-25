namespace Task6;

public class Staff : Person
{
    private string _school;
    private double _pay;
    
    public Staff(string name, string addres, string school, double pay) : base(addres, name){}
    
    public string GetSchool()
    {
        return _school;
    }
    public void SetSchool(string school)
    {
        _school = school;
    }
        public double GetPay()
    {
        return _pay;
    }
    public void SetPay(double pay)
    {
        _pay = pay;
    }
    public string ToString()
    {
        return $"{_school} {_pay}";
    }
}
