// See https://aka.ms/new-console-template for more information
using first_assignment;

parsing p=new parsing();
p.parsingexample();
p.tryparseexample();

usingtuples t=new usingtuples();
 var info=t.getpersoninfo();
string name = info.Item1;
int age=info.Item2;
int salary = info.Item3;
double com=info.Item4;
double total=info.Item5;
Console.WriteLine($"Name:{name},Age:{age},Salary:{salary},Commission:{com}%,Total salary:{total}");

alldetails all=new alldetails();
all.display();
all.displaysalary();
all.displaytotal();


ternaryexample obj=new ternaryexample();
obj.findage();
obj.Checknull();


ListWithLINQ obj1=new ListWithLINQ();
obj1.listexample();

