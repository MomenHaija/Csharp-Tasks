using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSpace1;
using NameSpace2;
namespace NameSpace3
{
    internal class FullName
    {
       NameSpace1.FirstName fn=new NameSpace1.FirstName();
        NameSpace2.SecondName ln = new NameSpace2.SecondName(); 
       public void Name() { 
        
            Console.WriteLine(fn._FirstName()+ln.LastName());
       }

    }
}