using System;

class Program {
  public static double CylinderVolume(double radius, double height)  {
    
    double volume = 3.14 * radius * radius * height;//logic
    return volume; 
  }

  public static void Main (string[] args) {
    Console.WriteLine("Enter radius of the cylinder:" );
    double radius1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter height of the cylinder:" );
    double height1 = Convert.ToDouble(Console.ReadLine()); 
    double volumeofcylinder = CylinderVolume(radius1, height1); 
    Console.WriteLine("The volume of the cylinder = " + volumeofcylinder);
  }
}