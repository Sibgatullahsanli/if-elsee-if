internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time>=6 && time<11 )
            Console.WriteLine("Hayırlı sabahlar");
        else if(time<= 18)
             Console.WriteLine("Hayırlı günler");
        else
             Console.WriteLine("Hayırlı geceler");

        string sonuc = time<=18 ? "Hayırlı günler" : "Hayırlı geceler";

        sonuc = time>=6 && time<11 ? "Hayırlı sabahlar" : time<= 18 ? "Hayırlı günler" : "Hayırlı geceler" ;
        Console.WriteLine(sonuc);                  


    }
}