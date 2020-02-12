using System;

namespace c_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myarray = new int[5]{ 3,4,5,6,7};
            myarray[0]=2; // UPDATE VALUE BT INDEX
            Console.WriteLine (myarray[0]); //OUTPUT A VALUE
            for( int i=0; i<5; i++)
           {   
                Console.WriteLine("Array index:"+i+"| Array Value :"+myarray[i]);
           }
 //  PANNYET FOR START TO END
        //     Console.WriteLine(" HELLO PANNYET!"+X);
        //  if ( X<30 )
        //  {
        //      Console.WriteLine ("X IS LESS THAN THIRTY");
        //  } 
        //  else if( X==30)
        //  {
        //      Console.WriteLine("x is thirty");

        //  }
        //   else {
        //       Console.WriteLine(" x is greater than thirty");
        int a=3;
        switch (a) {
            case 1 :
            Console.WriteLine("value is 1!");
            break;
            case 2 :
            Console.WriteLine ("value is 2!");
            break;
            case 3 :
            Console.WriteLine ("value is 3 !");
            break;
            default:
            break;
        }
           MyMethod();
           
      }
     
           // let's try making a mothod.
            static void MyMethod()
        {
            Console.WriteLine("test!");
        }

       }
    }




      
    
        
 
