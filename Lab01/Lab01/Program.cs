using System; 
 
 
 namespace Lab01
 { 
     class Program
     { 
         static void Main(string[] args)
         { 
             const double lightSpeed = 186000d;   // miles per second 
             Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed); 
             const double mileTokm = 1.609344; 
             Console.WriteLine("Light speed = {0} km Per second", lightSpeed* mileTokm); 
             Console.WriteLine("-----------------------------------------------------"); 
             string[] SunTo_Distance_name = new string[8]; 
             SunTo_Distance_name[0] = "SunToMercury"; 
             SunTo_Distance_name[1] = "SunToVenus"; 
             SunTo_Distance_name[2] = "SunToEarth"; 
             SunTo_Distance_name[3] = "SunToMars"; 
             SunTo_Distance_name[4] = "SunToJupiter"; 
             SunTo_Distance_name[5] = "SunToUranus"; 
             SunTo_Distance_name[6] = "SunToNeptune"; 
             SunTo_Distance_name[7] = "SunToPluto"; 
             double[] SunTo_Distance_num = new double[8];
             SunTo_Distance_num[0] = 35983605d;    //SunToMercury 
             SunTo_Distance_num[1] = 67232362d;    //SunToVenus 
             SunTo_Distance_num[2] = 93000000d;    //SunToEarth 
             SunTo_Distance_num[3] = 141635349d;   //SunToMars 
             SunTo_Distance_num[4] = 483631838d;   //SunToJupiter 
             SunTo_Distance_num[5] = 1785541183d;  //SunToUranus 
             SunTo_Distance_num[6] = 2796791726d;  //SunToNeptune 
             SunTo_Distance_num[7] = 3694610958d;  //SunToPluto 
             for (int i = 0; i<SunTo_Distance_num.Length; i++)              { 
                 Console.WriteLine("{0}Distance = {1} km", SunTo_Distance_name[i], SunTo_Distance_num[i] * mileTokm); 
                 double SunTo_TimeOfLight = SunTo_Distance_num[i] / lightSpeed;  // miles 
                 Console.WriteLine("{0}TimeOfLight = {1} seconds", SunTo_Distance_name[i], SunTo_TimeOfLight); 
                 Console.WriteLine("{0}TimeOfLight = {1} minutes", SunTo_Distance_name[i], SunTo_TimeOfLight / 60d); 
                 Console.WriteLine("{0}AU = {1} A.U.", SunTo_Distance_name[i], SunTo_Distance_num[i] / SunTo_Distance_num[2]); 
                 Console.WriteLine("-----------------------------------------------------"); 
             } 
             Console.ReadKey(); 
         } 
     } 
 } 
