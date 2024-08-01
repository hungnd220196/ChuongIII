namespace ChuongIII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x,y;
            //x = 6;
            //y = 9;

            //double z = (double) x/y;
            //Console.WriteLine("z = " + z);

            //int n1,n2;
            //int x1, x2;
            //n1 = n2 = 1;
            //// phép toán tăng bên phải n1
            //x1 = 10 * n1++;
            //x2 = 10 * ++n2;

            //Console.WriteLine("x1 = {0}, n1 = {1}",x1,n1);
            //Console.WriteLine("x2 = {0}, n2 = {1}",x2,n2);

            //// toán tử 3 ngôi 
            //int a,b,c, max;
            // Console.WriteLine("nhập sô a: ");
            // a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("nhập sô b: ");
            // b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("nhập sô c: ");
            // c = Convert.ToInt32(Console.ReadLine());

            //max = (a >b) ? a : b;
            //max = (max > c) ? max : c;
            //Console.WriteLine("max là: {0} ", max );

            //int a;

            //Console.WriteLine("nhập a");
            //a = Convert.ToInt32(Console.ReadLine());
            //if (a%2 == 0)
            //{
            //    Console.WriteLine("a là số chẵn ");
            //}
            //else
            //{
            //    Console.WriteLine("a là số lẻ");
            //}

            //bai tap

            // 1) So sánh vòng lặp do và while
            // vòng lặp do while: + Thực hiện câu lệnh sau đó kiểm tra điều kiện, như vậy câu lệnh được thực hiện ít nhất 1 lần. 
            // vòng lặp while: + Kiểm tra điều kiện trước, thực hiện câu lệnh sau. Nếu điều kiện sai ngay từ đầu thì câu lệnh (khối
            // lệnh không ñược thực hiện lần nào). 

            /*
             * 2) Viết chương trình nhập các hệ số thực ai, i = 0, 1, 2,..., n và số thực x rồi tính giá trị của đa thức
               P(x)=anx
            n
            + an-1x
            n-1+ ... + a1x+ a0
            Theo cách tính của Horner để đạt được tốc độ tính nhanh:
            i. P(x)=((((anx+ an-1)x+ an-2... + a1)x+ a0
             */

            //Console.WriteLine("moi ban nhap so he so");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("mời bạn nhập x");
            //int x = int.Parse(Console.ReadLine());
            //double sum = 0;
            //for (int i = n; i> 0; i--)
            //{
            //    Console.WriteLine("nhap vao so thuc a{0}", i);
            //    double a = double.Parse(Console.ReadLine());
            //    sum += a*(Math.Pow(x,i));

            //}
            //Console.WriteLine("giá trị bieu thuc la: " + sum);


            //3 Nhập một số tự nhiên n. Hãy liệt kê các số nguyên tố không lớn hơn n. 
            //Console.WriteLine("mời bạn nhập số n");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i++)
            //{
            //    int count = 0;

            //    for ( int j = 2;  j <= i/2;  j++)
            //    {
            //        if (i%j==0)
            //        {
            //            count++;
            //            break;
            //        }

            //    }
            //    if (count==0 && i != 1)
            //    {
            //        Console.WriteLine("{0}", i);
            //    }
            //}


            //4

            //Console.WriteLine(" moi ban nhap so c: ");
            //double c = double.Parse(Console.ReadLine());
            //if (c<0)
            //{
            //    Console.WriteLine("giá trị phải lớn hơn 0");
            //    return;
            //}
            //int n = 0;
            //double pi = 0.0;
            //double temp1;
            //while (true)
            //{
            //    if (1.0 / (2.0 * n + 1.0) <= c)
            //    {
            //        break;
            //    }
            //    temp1  = 4.0 * ((n % 2 == 0 ? 1.0 : -1.0) / (2.0 * n + 1.0));
            //    pi += temp1;
            //    n++;
            //}

            //Console.WriteLine("gia tri cua pi la: {0}", pi);


            //b5
            //Console.Write("Nhập giá trị c (ví dụ c = 0.0001): ");
            //double c = double.Parse(Console.ReadLine());
            //if (c <= 0)
            //{
            //    Console.WriteLine("Giá trị c phải lớn hơn 0.");
            //    return;
            //}

            //double pi = 0.0;
            //double term;
            //int n;

            //for (n = 0; ; n++)
            //{
            //    term = 4.0 * ((n % 2 == 0 ? 1.0 : -1.0) / (2.0 * n + 1.0));
            //    pi += term;

            //    if (1.0 / (2.0 * n + 1.0) <= c)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Giá trị π gần đúng là: {pi}");
            ;

            //b6

            Console.WriteLine("Nhập giá trị c (ví dụ c = 0.0001): ");
            double c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Giá trị c phải lớn hơn 0.");
                return;
            }

            Console.Write("Nhập giá trị x: ");
            double x = double.Parse(Console.ReadLine());

            double result = 1.0;
            double term = 1.0;
            int n = 1;

            while (true)
            {
                term *= x / n;

                if (Math.Abs(term) <= c)
                {
                    break;
                }

                result += term;
                n++;
            }
            Console.WriteLine($"Giá trị gần đúng của e^{x} là: {result}");












        }
    }
}
