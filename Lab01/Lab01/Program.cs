using System; 
 public class intergerTest
 { 
     static void Main(string[] args)
     {          double a = 10, b = 20, x = 5, y = 2; 
         Console.WriteLine("{0} + {1} = {2}",a,b,a+b); 
         Console.WriteLine("{0} - {1} = {2}", x,b,x-b); 
         Console.WriteLine("{0} * {1} = {2}",x,b,x* b); 
         Console.WriteLine("{0} / {1} = {2}",y,a,y/a); 
         Console.WriteLine("{0} % {1} = {2}",b,y,b%y); 
         Console.WriteLine("{0} +10 % {1} = {2}",y,x,y+10%x); 
         Console.WriteLine("{0} / 3 * 5 = {1}",a,a/3*5); 
         Console.WriteLine("9 / 2 * {0} = {1}", a,9/2* a); 
         Console.WriteLine("{0} % 8= {1}", y,y%8); 
         Console.WriteLine("100 * {0} + {1} % 2 - {2} = {3}",x,y,a,100* x+y%2-a); 
     } 
 } 
