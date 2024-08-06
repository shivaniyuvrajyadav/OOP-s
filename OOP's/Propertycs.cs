using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s
{
    internal class Propertycs
    {
        private int myproperty;

        public int Myproperty
        {
            get { return myproperty; }
            set { myproperty = value; }
        }

        public string Myproperty1 { get; set; }
    }
}

/*  what is a property?
 *  a property is a class member that provides a flexible mechanism to read and write private field.
 * property is  a specialized function only. 
 *  specialized means proprties are used only to get and set field values. 
 */