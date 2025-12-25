namespace Task6;

public class Person
{
    private string _name ;
    private string _addres;

    public Person(string name, string addres)
    {
        _name = name;
        _addres = addres;
    }
     public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
        public void SetAddres(string addres)
    {
        _addres = addres;
    }
        public string GetAddress()
    {
        return _addres;
    }


    public  string ToString()
    {
        return $"{_name}, {_addres}";
    }
}
