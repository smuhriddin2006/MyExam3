using System.Dynamic;
using Task6;

Person person = new Person("Umed","Norak");
System.Console.WriteLine(person.ToString());
person.SetName("Muhriddin");
System.Console.WriteLine(person.GetName());
person.SetAddres("Norak,Rudaki 3");
System.Console.WriteLine(person.GetAddress());

Student student = new Student("Umed","Norak", "C#",2006, 21);
student.SetName("Umed");
student.SetAddres("Norak");
student.SetFee(12);
System.Console.WriteLine(student.ToString());
System.Console.WriteLine(student.GetName());
System.Console.WriteLine(student.GetAddress());
System.Console.WriteLine(student.GetFee());

Staff staff = new Staff("UMed", "Norak", "School Number 5", 2000);
staff.SetSchool("№5");
staff.SetPay(2000);
System.Console.WriteLine(staff.GetSchool());
System.Console.WriteLine(staff.GetPay());
