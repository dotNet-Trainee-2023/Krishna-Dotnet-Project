// See https://aka.ms/new-console-template for more information
using Assignment1;
class program
{
    public static void Main(string[] args) {


        Iexample e = new Iexample();
        e.display(2,2);
       int a= e.sum(2,2);
        Console.WriteLine("Sum="+a);



        conditionloop c= new conditionloop();
        c.loop();   


        SwitchExample s=new SwitchExample();
        s.findresult();


        listexample obj=new listexample();
        obj.numbers();
        obj.display();

    }
}


