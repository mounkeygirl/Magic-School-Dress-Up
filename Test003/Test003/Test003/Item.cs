using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Test003
{
    public class Item
    {

        public Item(string name, string description = null, Bitmap image = null)
        {
            Name = name;
            Image = image;
            Description = description;

        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }


        public Bitmap Image
        {
            get;
            set;
        }


    }
}
