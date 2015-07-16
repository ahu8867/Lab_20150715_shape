using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Program
    {
        abstract class Shape
        {
            public abstract void Area(double num);
        }
        abstract class TwoDim : Shape
        {
            public int typeTwo;
            public double numTwo;
            public abstract void Length(double num);
            public override abstract void Area(double num);
        }
        abstract class ThreeDim : Shape
        {
            public int typeThree;
            public double numThree;
            public override abstract void Area(double num);
            public abstract void Volume(double num);
        }
        class Triangle : TwoDim
        {
            public override void Length(double num)
            {
                Console.WriteLine("둘레: " + 3 * num);
            }
            public override void Area(double num)
            {
                Console.WriteLine("넓이: " + Math.Sqrt(3) / 4 * num * num);
            }
        }
        class Square : TwoDim
        {
            public override void Length(double num)
            {
                Console.WriteLine("둘레: " + 4 * num);
            }
            public override void Area(double num)
            {
                Console.WriteLine("넓이: " + num * num);
            }
        }
        class Circle : TwoDim
        {
            public override void Length(double num)
            {
                Console.WriteLine("둘레: " + 2 * 3.14 * num);
            }
            public override void Area(double num)
            {
                Console.WriteLine("넓이: " + 3.14 * num * num);
            }
        }
        class Cube : ThreeDim
        {
            public override void Area(double num)
            {
                Console.WriteLine("겉넓이: " + 6 * num * num);
            }
            public override void Volume(double num)
            {
                Console.WriteLine("부피: " + num * num * num);
            }
        }
        class Sphere : ThreeDim
        {
            public override void Area(double num)
            {
                Console.WriteLine("겉넓이: " + 4 * 3.14 * num * num);
            }
            public override void Volume(double num)
            {
                Console.WriteLine("부피: " + 4 / 3 * 3.14 * num * num);
            }
        }
        static void Main(string[] args)
        {
            List<TwoDim> twodim = new List<TwoDim>();
            List<ThreeDim> threedim = new List<ThreeDim>();
            while (true)
            {
                Console.WriteLine("도형종류 : Triangle, Square, Circle, Cube, Sphere");
                double number;
                Console.Write("단위 크기 : ");
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    if (number<=0)
                    {
                        Console.WriteLine("잘못된 범위의 값을 입력하였습니다.");
                        continue;
                    }
                }
                catch (System.FormatException x)
                {
                    Console.WriteLine(x.Message);
                    continue;
                }
                catch (SystemException y)
                {
                    Console.WriteLine(y.Message);
                    continue;
                }

                Console.Write("모양 : ");

                string whatShape = Console.ReadLine();
                int count = 0;
                int i = 0;
                if (whatShape != "Triangle" && whatShape != "Square" && whatShape != "Circle"&&whatShape!="Cube"&&whatShape!="Sphere")
                {
                    Console.WriteLine("없는 도형입니다.");
                    continue;
                }
                else if (whatShape == "Triangle")
                {
                    TwoDim tri = new Triangle();
                    foreach (var item in twodim)
                    {
                        if (twodim[i].typeTwo == 3 && twodim[i].numTwo == number)
                        {
                            Console.WriteLine("이미 담은 도형입니다.");
                            count += 1;
                            break;
                        }
                        i++;
                    }
                    if (count == 0)
                    {
                        tri.typeTwo = 3;
                        tri.numTwo = number;
                        tri.Length(number);
                        tri.Area(number);
                        twodim.Add(tri);
                        i = 0;
                    }
                    count = 0;
                }
                else if (whatShape == "Square")
                {
                    TwoDim squ = new Square();
                    foreach (var item in twodim)
                    {
                        if (twodim[i].typeTwo == 4 && twodim[i].numTwo == number)
                        {
                            Console.WriteLine("이미 담은 도형입니다.");
                            count += 1;
                            break;
                        }
                        i++;
                    }
                    if (count == 0)
                    {
                        squ.typeTwo = 4;
                        squ.numTwo = number;
                        squ.Length(number);
                        squ.Area(number);
                        twodim.Add(squ);
                        i = 0;
                    }
                    count = 0;
                }
                else if (whatShape == "Circle")
                {
                    TwoDim cir = new Circle();
                    foreach (var item in twodim)
                    {
                        if (twodim[i].typeTwo == 0 && twodim[i].numTwo == number)
                        {
                            Console.WriteLine("이미 담은 도형입니다.");
                            count += 1;
                            break;
                        }
                        i++;
                    }
                    if (count == 0)
                    {
                        cir.typeTwo = 0;
                        cir.numTwo = number;
                        cir.Length(number);
                        cir.Area(number);
                        twodim.Add(cir);
                        i = 0;
                    }
                    count = 0;
                }
                else if (whatShape == "Cube")
                {
                    ThreeDim cub = new Cube();
                    foreach (var item in threedim)
                    {
                        if (threedim[i].numThree == number && threedim[i].typeThree == 6)
                        {
                            Console.WriteLine("이미 담은 도형입니다.");
                            count += 1;
                            break;
                        }
                        i++;
                    }
                    if (count == 0)
                    {
                        cub.typeThree = 6;
                        cub.Area(number);
                        cub.Volume(number);
                        threedim.Add(cub);
                        i = 0;
                    }
                    count = 0;
                }
                else if (whatShape == "Sphere")
                {
                    ThreeDim sph = new Sphere();
                    foreach (var item in threedim)
                    {
                        if (threedim[i].numThree == number && threedim[i].typeThree == 6)
                        {
                            Console.WriteLine("이미 담은 도형입니다.");
                            count += 1;
                            break;
                        }
                        i++;
                    }
                    if (count == 0)
                    {
                        sph.typeThree = 0;
                        sph.Area(number);
                        sph.Volume(number);
                        threedim.Add(sph);
                        i = 0;
                    }
                    count = 0;
                }
            }
        }
    }
}

