using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khoi tao mang so nguyen
            int[] intArray = new int[1000];
            for (int i=0;i<1000;++i)
            {
                intArray[i] = i + 1;
            }
            Console.WriteLine("Mang so nguyen to 1-1000 da duoc khoi tao!");
            Console.WriteLine("Cac so nguyen to co trong mang:");
            for (int j=0;j<1000;++j)
            {
                bool isPrime = KiemtraNguyento(intArray[j]);
                if (isPrime)//Khong nen goi ham trong cau lenh dieu kien, gan ket qua cho bien va kiem tra gia tri bien
                {
                    Console.WriteLine(intArray[j]);
                }
            }
            Console.ReadKey();
        }

        //Ham kiem tra so nguyen to
        static bool KiemtraNguyento(int n) //Khong nen viet tat ten ham. Vi du: kiemtraNguyento(int n)
        {
            bool result = true;
            if (n <= 1)
            {
                result = false;
            }
            for (int i = 2; i <= Math.Sqrt(n); ++i) //Tai lai lai la Sqrt nhi? - Tai uoc so cua n phan bo deu tren 2 mien [2,sprt(n)] và [sqrt(n),n-1] nen chi can kiem tra tren mien dau tien thi toi uu hon a.
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return result;
        }
    }
}
