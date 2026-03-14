using System;
 
public class Figura{
    public virtual void WyswietlInformacje(){
        Console.WriteLine("Figura");
    }
}
 
public class Figura2D : Figura{
    public virtual double Pole(){
        return 0;
    }
 
    public virtual double Obwod(){
        return 0;
    }
}
 
public class Kwadrat : Figura2D{
    double a;
 
    public Kwadrat(double a){
        this.a = a;
    }
 
    public override double Pole(){
        return a * a;
    }
 
    public override double Obwod(){
        return 4 * a;
    }

}
 
public class Prostokat : Figura2D{
    double a, b;
 
    public Prostokat(double a, double b){
        this.a = a;
        this.b = b;
    }
 
    public override double Pole(){
        return a * b;
    }
 
    public override double Obwod(){
        return 2 * (a + b);
    }
}
 
public class Kolo : Figura2D{
    double r;
 
    public Kolo(double r){
        this.r = r;
    }
 
    public override double Pole(){
        return Math.PI * r * r;
    }
 
    public override double Obwod(){
        return 2 * Math.PI * r;
    }
}
 
public class Figura3D : Figura{
    public virtual double Objetosc(){
        return 0;
    }
 
    public virtual double PolePowierzchni(){
        return 0;
    }
}
 
public class Szescian : Figura3D{
    double a;
 
    public Szescian(double a){
        this.a = a;
    }
 
    public override double Objetosc(){
        return a * a * a;
    }
 
    public override double PolePowierzchni(){
        return 6 * a * a;
    }
}
 
public class Prostopadloscian : Figura3D{
    double a, b, c;
 
    public Prostopadloscian(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }
 
    public override double Objetosc(){
        return a * b * c;
    }
 
    public override double PolePowierzchni(){
        return 2 * (a * b + b * c + a * c);
    }
}
 
public class Kula : Figura3D{
    double r;
 
    public Kula(double r){
        this.r = r;
    }
 
    public override double Objetosc(){
        return 4.0 / 3.0 * Math.PI * r * r * r;
    }
 
    public override double PolePowierzchni(){
        return 4 * Math.PI * r * r;
    }
}
 
class Program{
    static void Main(){
        int wybor;
 
        do{
            Console.WriteLine("1 – Figury 2D");
            Console.WriteLine("2 – Figury 3D");
            Console.WriteLine("0 – Wyjście");
            Console.WriteLine();
 
            wybor = int.Parse(Console.ReadLine());
 
            if (wybor == 1){
                Console.WriteLine("1-Kwadrat 2-Prostokat 3-Kolo");
                int f = int.Parse(Console.ReadLine());
                
                if (f == 1){
                    double a = double.Parse(Console.ReadLine());
                    
                    Kwadrat k = new Kwadrat(a);
                    Console.WriteLine("Pole: " + k.Pole());
                    Console.WriteLine("Obwod: " + k.Obwod());
                }

                if (f == 2){
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());

                    Prostokat p = new Prostokat(a, b);
                    Console.WriteLine("Pole: " + p.Pole());
                    Console.WriteLine("Obwod: " + p.Obwod());
                }

                if (f == 3){
                    double r = double.Parse(Console.ReadLine());

                    Kolo k = new Kolo(r);
                    Console.WriteLine("Pole: " + k.Pole());
                    Console.WriteLine("Obwod: " + k.Obwod());
                }
            }
 
            if (wybor == 2){
                Console.WriteLine("1-Szescian 2-Prostopadloscian 3-Kula");
                int f = int.Parse(Console.ReadLine());
 
                if (f == 1){
                    double a = double.Parse(Console.ReadLine());

                    Szescian s = new Szescian(a);
                    Console.WriteLine("Objetosc: " + s.Objetosc());
                    Console.WriteLine("Pole powierzchni: " + s.PolePowierzchni());
                }

                if (f == 2){
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());

                    Prostopadloscian p = new Prostopadloscian(a, b, c);
                    Console.WriteLine("Objetosc: " + p.Objetosc());
                    Console.WriteLine("Pole powierzchni: " + p.PolePowierzchni());
                }

                if (f == 3){
                    double r = double.Parse(Console.ReadLine());

                    Kula k = new Kula(r);
                    Console.WriteLine("Objetosc: " + k.Objetosc());
                    Console.WriteLine("Pole powierzchni: " + k.PolePowierzchni());
                }
            }
        } while (wybor != 0);
    }
}