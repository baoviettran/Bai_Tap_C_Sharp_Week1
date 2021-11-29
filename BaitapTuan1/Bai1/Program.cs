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
                if (KtraNto(intArray[j]))//Khong nen goi ham trong cau lenh dieu kien, gan ket qua cho bien va kiem tra gia tri bien
                {
                    Console.WriteLine(intArray[j]);
                }
            }
            Console.ReadKey();
        }

        //Ham kiem tra so nguyen to
        static bool KtraNto(int n)//Khong nen viet tat ten ham. Vi du: kiemtraNguyento(int n)
        {
            bool result = true;
            if (n <= 1)
            {
                result = false;
            }
            for (int i = 2; i <= Math.Sqrt(n); ++i)//Tai lai lai la Sqrt nhi?
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
