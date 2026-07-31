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
        }
    }
}
