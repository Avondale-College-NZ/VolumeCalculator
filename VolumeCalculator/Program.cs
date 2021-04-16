using System;

namespace VolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            do {
                Console.Clear();
                Console.WriteLine("\n\t\t\t\t\t~~~Volume & Surface Area Calculator~~~\n");
                cleared: //creating a label named "cleared" to be used by the goto function
                Console.WriteLine("\t\t---------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\tSelect the shape option (1-5) for which you want to calculate the volume and surface area for\n ");
                Console.WriteLine("\n\t\tCube: \t\t1 ");
                Console.WriteLine("\t\tSphere: \t2 ");
                Console.WriteLine("\t\tCylinder: \t3 ");
                Console.WriteLine("\t\tBox: \t\t4 ");
                Console.WriteLine("\t\tCone: \t\t5 ");
                Console.WriteLine("\t\t--------------------------------------------------------------------------------------------");
               
                Console.Write("\n\t\tYour Option is: ");
                string option = Console.ReadLine();
                
                int count = 1;
                while (option != "1" && option != "2" && option != "3" && option != "4" && option != "5")
                {                    
                    Console.Write("\n\t\tThe option you entered maybe invalid... \n\t\tPlease re enter your Option 1 - 5 only : ");                    
                    option = Console.ReadLine();
                                       
                    if (count == 4)
                    {
                        Console.Clear(); //clearing the console screen after invalid entry has been made five times.
                        goto cleared; //redirecting to the cleared label
                    }
                    count++;
                }

                float radius, length, height, width;
                switch (option)
                {
                    
                    case "1":

                        Console.Write("\n\t\tYou have selected Cube. \n\n\t\tEnter the length of the cube: ");
                        while (!float.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }

                        Cube cube = new Cube(length);
                        Console.WriteLine("\n\t\tThe volume of the cube is : " + Math.Round(cube.VolumeCalc,2));
                        Console.WriteLine("\t\tThe surface area of the cube is : " + Math.Round(cube.SufaceAreaCalc, 2));
                        break;

                    case "2":

                        Console.Write("\n\t\tYou have selected Sphere. \n\n\t\tEnter the radius of the sphere: ");
                        while (!float.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }

                        Sphere sphere = new Sphere(radius);
                        Console.WriteLine("\n\t\tThe volume of the Sphere is : " + Math.Round(sphere.VolumeCalc, 2));
                        Console.WriteLine("\t\tThe surface area of the Sphere is : " + Math.Round(sphere.SufaceAreaCalc, 2));
                        break;

                    case "3":

                        Console.Write("\n\t\tYou have selected Cylinder. \n\n\t\tEnter the radius of the cylinder: ");                        
                        while (!float.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }
                        Console.Write(" \t\tEnter the height of the cylinder: ");
                        while (!float.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }

                        Cylinder cylinder = new Cylinder(radius, height);

                        Console.WriteLine("\n\t\tThe volume of the Cyliner is : " + Math.Round(cylinder.VolumeCalc, 2));
                        Console.WriteLine("\t\tThe surface area of the Cylinder is : " + Math.Round(cylinder.SufaceAreaCalc, 2));
                        break;

                    case "4":

                        Console.Write("\n\t\tYou have selected Box. \n\t\tEnter the length of the box: ");                        
                        while (!float.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }
                        Console.Write("\n\t\tEnter the width of the box: ");
                        while (!float.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }
                        Console.Write("\t\tEnter the height of the box: ");
                        while (!float.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }

                        Box box = new Box(length, width, height);
                        Console.WriteLine("\n\t\tThe volume of the Box is : " + Math.Round(box.VolumeCalc, 2));
                        Console.WriteLine("\t\tThe surface area of the Box is : " + Math.Round(box.SufaceAreaCalc, 2));
                        break;

                    case "5":

                        Console.Write("\n\t\tYou have selected Cone. \n\n\t\tEnter the radius of the cone: ");
                        while (!float.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }
                        Console.Write("\t\tEnter the height of the cone: ");
                        while (!float.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.Write("\t\tThis is not valid input. Please enter a numeric value greater than 0: ");
                        }

                        Cone cone = new Cone(radius, height);
                        Console.WriteLine("\n\t\tThe volume of the Cone is : " + Math.Round(cone.VolumeCalc, 2));
                        Console.WriteLine("\t\tThe surface area of the Cone is : " + Math.Round(cone.SufaceAreaCalc, 2));
                        break;
                        
                }
                Console.Write("\n\n\t\tTo continue, press y/Y or any other key to exit: ");
                choice = char.Parse(Console.ReadLine());                

            } while (choice == 'y' || choice == 'Y');           
        }
    }
}
