using System;     
class Test    
{    
   static void Main(string[] arg)    
   {    
      Console.WriteLine(checkPassward("ghb!2#@fc",5));
    
   }    
   static bool checkPassward(string passWord,int min)
   {
       bool Num = false;
       bool Upp = false;
       bool Low = false;
       bool Spec = false;
       char currentChar;
      if(!(passWard.length >= min))
      {
          return false;
      }
      
       for(int i=0;i< passWard.length;i++)
       {
           currentChar = passWord[i];
           if (char.IsDigit(currentChar))
           {
               Num = true;
           }
           else if(char.IsUpper(currentChar))
           {
               Upp = true;
           }
           else if(char.IsLower(currentChar))
           {
               Low = true;
           }
           else if(!char.IsLetterOrDigit(currentChar))
           {
               Spec = true;
           }
           if(Num && Upp && Low && Spec)
           {
               return true;
           }
       }
       return false;
   }
}