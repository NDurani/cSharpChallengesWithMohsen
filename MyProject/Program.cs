// using MyArr;
namespace myproject{

public class Program{

public static void Main(string[] args){
    MyArr myarr = new MyArr();
    myarr.FavNums = new int[]{5, 10, 15, 20, 25, 30};
    myarr.Customers = new string[]{"Bob", "Sally", "Sue"};
    myarr.Employees = new string[]{"Mike", "Paul", "Rick"};
    myarr.obj = new object[] {12, "ahmad", true};

    string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };
    
System.Console.WriteLine(custNames[0,0]);


    // System.Console.WriteLine(myarr.FavNums[2] + "\n" + myarr.Customers[1] + " " + myarr.obj[1].GetType());
}

}
}