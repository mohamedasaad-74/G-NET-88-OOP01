using Assignment5.struct1;
using Assignment5.struct2;
using System.Security.Cryptography.X509Certificates;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)


        {
            #region Theoretical Questions Q1
            //(A)  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //===========solution=========
            // DeliveryAddress=>struct
            // بيتخزن جوا ال stack
            // وهو عباره عن =<value type 
            //وبكدا هيكون عندي اتنين object
            //والمتغير الاصلي مش هيتاثر بالتغيير 

            //(B)What happens when a Customer variable is copied into another variable and one variable modifies the object
            // Customer=>class
            //عباره عن refrence type
            //بتتخزن جوا ال heab
            // one object
            // وبكدا هيحصل تغيير في المتغير الاصلي 
            #endregion
            #region Theoretical Questions Q2 
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //==============solution===============
            //1 لازم البيانات  اللي جوا ال struct تكون من نوع private.عشان امنع ان اي حد يدخل ويعدل عليها من برا
            //2 مفيش تحكم بالقيم الي داخله 
            //=======================================================
            //  b) How can private fields and public properties improve this design?
            //======================الحل =================
            //private =(لمنع دخول اي حد من برا الكلاس يدخل يعدل علي الfields)

            //public properties=(بتديني امكانيه اني اتجكم في القيم الي داخله لي )
            #endregion
            #region Smart Delivery Management System Q3
            //DelivryAddress address1 = new DelivryAddress(74, "elharam","giza");

            //DelivryAddress address2 = address1;
            //address2.City = "barcelona";
            //address2.BuildingNumber = 10;
            //address2.Street = "lm";
            //Console.WriteLine($"Original Address {address1.GetFullAddress()}");
            //Console.WriteLine($"After change {address2.GetFullAddress()}");


            #endregion
            #region Shipment Q4
            //Shipment s1 = new Shipment("OOP");
            //s1.PrintShipment();
            //Console.WriteLine(s1);
            #endregion
        }
    }
}
