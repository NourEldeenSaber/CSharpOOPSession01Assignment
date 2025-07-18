using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefiendDataTypes
{
    /* what you can write inside?
     * 01- Class
     * 02- Struct
     * 03- Interface
     * 04- Enum
     */

    /* Access modifiers
     * 01- Inrernal (Defualt)
     * 02- Public
     */
    public class ClassA 
    {
        /* what you can write inside?
         * 1. Attribute => Member function
         *      int x;
         * 2. Functions => (Constructor , Normal Methods)
         * 3. Property(Full, Automatic, Indexer)
         *      int x{ get; set; }
         * 4. Event
         */

        /* Access modifiers
         * 01- private (Defult)
         * 02- protected private 
         * 03- protected 
         * 04- internal
         * 05- protected internal 
         * 06- public
         */

        //private
        private int x;

        //protected private 
        private protected int z;

        //protected
        protected int y;

        //internal
        internal int w;

        //protected internal
        protected internal int n;

        public void SetX(int value)
        {
            x = value;
            y = value;
            z= value;
            w = value;
        }
    }
}
