using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interaction
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Sortable sortble = new Sortable();
            sortble.sortable();
            Slectable slectble = new Slectable();  
            slectble.selectable();
            //Sortable.sortable();
            //Slectable.selectable();
        }
    }
}
