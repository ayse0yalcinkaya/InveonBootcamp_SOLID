// See https://aka.ms/new-console-template for more information
using InveonBootcamp2.App;
using InveonBootcamp2.App.DIP;
using InveonBootcamp2.App.LSP;

Console.WriteLine("Hello, World!");

#region SRP


Action method1 = () => Console.WriteLine("Mehaba World"); //parantezlerden sonrası method ve ben bunu bir değişkene atadım (Action delegesi)
//Action: parametre alabilir almayabilir geriye boolean döner

Predicate<int> method2 = (x) => x > 1;
//Predicate: parametre alır boolean döner

Func<decimal, int, decimal> method3 = (x,y) => x*2;
//Func: istediği kadar par. alır


SRP salaryCalculator = new SRP();
var managerSalary = salaryCalculator.Calculate(1000, new ManagerSalaryCalculate());


var xSalary = salaryCalculator.CalculateAsDelegate(1000, ManagerSalary);
var ySalary = salaryCalculator.CalculateAsDelegate(1000, (x) => x * 2); //bize sonradan istediklerinde esneklik sağlanır

Console.WriteLine(managerSalary);
static decimal ManagerSalary(decimal salary)
{
    return salary*2;
}

#endregion

#region LSP
Phone phone = new Iphone();
phone.Call();
//phone.TakePhoto(); //artık böyle erişemem
if(phone is ITakePhoto phoneTakePhoto)
{
    phoneTakePhoto.TakePhoto();
}

phone = new Nokia(); //başka bi sınıfı verme
phone.Call();
//phone.TakePhoto(); //patlar zaten hata verir
if (phone is ITakePhoto nokia)
{
    nokia.TakePhoto();
}

#endregion

#region DIP
var productController = new ProductController();

var products = productController.GetAll();

foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id} Price: {product.Price}");
}

#endregion
