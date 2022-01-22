using Abstraindo_um_Jogo_de_RPG.src.Entities;

class Program 
{
     static void Main(string [] args)
     {     
        Knigth arus = new Knigth("Arus", 12, "Knigth");
        Wizard janica = new Wizard("Jenica", 12, "While Wizard");
        BlackWizard shura = new BlackWizard("Shura", 12, "Black Wizard");
        Ninja zorro = new Ninja("Zorro", 12, "Ninja");

        Console.WriteLine("##### JOGO FINALBATTLE #######");
        Console.WriteLine(arus.Attack(1));
        Console.WriteLine(janica.Attack(7));
        Console.WriteLine(shura.Attack(3));
        Console.WriteLine(zorro.Attack(3));

    }  

}