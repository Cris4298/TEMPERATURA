using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    string entrada;
    Double temperatura, celsius;
    
Console.WriteLine ("digite temperatura em fahrenheit");
entrada=Console.ReadLine();
    
temperatura = Double.Parse(entrada);
celsius = (temperatura-32)/1.8 ;
Console.WriteLine ( celsius);


  }
}