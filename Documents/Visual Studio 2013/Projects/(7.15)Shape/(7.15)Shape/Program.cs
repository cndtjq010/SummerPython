using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shape
{
    public abstract class shape
    {
        
        abstract public double Area(int r);
        
    }
    public abstract class TwoDim : shape
    {
        abstract public double length(int r);
        abstract public override double Area(int r);
        public int type;
        public int number;
    }
    public abstract class ThreeDim : shape
    {
        abstract public override double Area(int r);
        abstract public double Volume(int r);
        public int type;
        public int number;
    }
    public class Square : TwoDim
    {
        
        public override double Area(int r)
        {
            return r * r;
        }
        public override double length(int r)
        {
            return 4 * r;
        }
    }
    public class triangle : TwoDim
        {
           
            public override double Area(int r)
            {
                return Math.Sqrt(3.0) / 4 * r * r;
            }
            public override double length(int r)
            {
                return 3 * r;
            }
        }
    public class circle : TwoDim
        {
            public override double Area(int r)
            {
                return 3.141592 * r* r;
            }
            public override double length(int r)
            {
                return 3.141592 * r * 2;
            }
        }
    public class Sphere : ThreeDim
        {
           
            public override double Area(int r)
            {
                return 4 * 3.141592 * r * r;
            }
            public override double Volume(int r)
            {
                return (3.0) / (4.0) * 3.141592 * r * r * r;
            }
        }
    public class Cube : ThreeDim
        {
            public override double Area(int r)
            {
                return 6 * r * r;
            }
            public override double Volume(int r)
            {
                return r * r * r;
            }
        }
       class Program
        {
           static void process(string s)
           {
               if (s == null)
               {
                   throw new ArgumentNullException();
               }
           }
           static void Main(string[] args)
           {
               int count = 0;
               List<ThreeDim> threeList = new List<ThreeDim>();

               List<TwoDim> twoList = new List<TwoDim>();
               int r;
               string shape1;
               while (true)
               {
                   
                   Console.Write("shpae (1.square,2.triangle,3.circle,4.sphere,5.cube) : ");
                   shape1 = Console.ReadLine();
                   if (shape1 != "square" && shape1 != "triangle" && shape1 != "circle" && shape1 != "sphere" && shape1 != "cube")
                   {
                       shape1 = null;
                   }
                   try{
                       process(shape1);
                   }
                   catch(System.ArgumentNullException e)
                   {
                       Console.WriteLine("Enter square or triangle or circle or cube or sphere..please..", e);
                   }
                   try{
                   Console.Write("r : ");
                   r = Int32.Parse(Console.ReadLine());
                   
                    if (shape1 == "square")
                   {
                       foreach (var item in twoList)
                       {
                           if (item.type==1&&item.number==r)
                           {
                               Console.WriteLine("이미 존재 합니다..");
                               count = 1;
                               break;
                           }
                          
                       }
                       if (count == 0)
                       {
                           TwoDim square = new Square();
                           Console.WriteLine("Two Dim");
                           Console.WriteLine("길이 : " + square.length(r));
                           Console.WriteLine("넓이 : " + square.Area(r));
                           twoList.Add(square);
                       }
                       count = 0;
                   }
                   else if (shape1 == "triangle")
                   {
                       foreach (var item in twoList)
                       {
                           if (item.type==2&&item.number == r)
                           {
                               Console.WriteLine("이미 존재 합니다..");
                               count = 1;
                               break;
                           }

                       }
                       if (count == 0)
                       {
                           TwoDim triangle = new triangle();
                           Console.WriteLine("Two Dim");
                           Console.WriteLine("길이 : " + triangle.length(r));
                           Console.WriteLine("넓이 : " + triangle.Area(r));
                           twoList.Add(triangle);
                       }
                       count = 0;
                   }
                   else if (shape1 == "circle")
                   {
                       foreach (var item in twoList)
                       {
                           if (item.type==3&&item.number == r)
                           {
                               Console.WriteLine("이미 존재 합니다..");
                               count = 1;
                               break;
                           }

                       }
                       if (count == 0)
                       {
                           TwoDim circle = new circle();
                           Console.WriteLine("Two Dim");
                           Console.WriteLine("길이 : " + circle.length(r));
                           Console.WriteLine("넓이 : " + circle.Area(r));
                           twoList.Add(circle);
                       }
                       count = 0;
                   }
                   else if (shape1 == "cube")
                   {
                       foreach (var item in threeList)
                       {
                           if (item.type==3&&item.number == r)
                           {
                               Console.WriteLine("이미 존재 합니다..");
                               count = 1;
                               break;
                           }

                       }
                       if (count == 0)
                       {
                           ThreeDim cube = new Cube();
                           Console.WriteLine("Three Dim");
                           Console.WriteLine("넓이 : " + cube.Area(r));
                           Console.WriteLine("부피 : " + cube.Volume(r));
                           threeList.Add(cube);
                       }
                       count = 0;
                   }
                   else if (shape1 == "sphere")
                   {
                       foreach (var item in threeList)
                       {
                           if (item.type==4&&item.number == r)
                           {
                               Console.WriteLine("이미 존재 합니다..");
                               count = 1;
                               break;
                           }

                       }
                       if (count == 0)
                       {
                           ThreeDim sphere = new Sphere();
                           Console.WriteLine("Three Dim");
                           Console.WriteLine("넓이 : " + sphere.Area(r));
                           Console.WriteLine("부피 : " + sphere.Volume(r));
                           threeList.Add(sphere);
                       }
                       count = 0;
                   }

               } 
                   catch (System.FormatException e)
                   {
                       Console.WriteLine("Number..please..", e);

                   }
                  
                   finally { 

}
                   
           }//whlie문
           }
        }
    }