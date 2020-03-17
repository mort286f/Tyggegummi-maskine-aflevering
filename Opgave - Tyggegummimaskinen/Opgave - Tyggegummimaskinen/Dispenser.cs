using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave___Tyggegummimaskinen
{
    class Dispenser
    {

            private static Dispenser instance;


            public static Dispenser Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Dispenser();
                    }
                    return instance;
                }
            }


        public Bubblegum[] blue = new Bubblegum[14];
        public Bubblegum[] purple = new Bubblegum[7];
        public Bubblegum[] yellow = new Bubblegum[11];
        public Bubblegum[] orange = new Bubblegum[10];
        public Bubblegum[] red = new Bubblegum[7];
        public Bubblegum[] green = new Bubblegum[6];

        public Dispenser()
        {
            //Blue bubblegum
            blue[0] = new Bubblegum("Blue"); blue[1] = new Bubblegum("Blue"); blue[2] = new Bubblegum("Blue"); blue[3] = new Bubblegum("Blue"); blue[4] = new Bubblegum("Blue"); blue[5] = new Bubblegum("Blue"); blue[6] = new Bubblegum("Blue"); blue[7] = new Bubblegum("Blue"); blue[8] = new Bubblegum("Blue"); blue[9] = new Bubblegum("Blue"); blue[10] = new Bubblegum("Blue"); blue[11] = new Bubblegum("Blue"); blue[12] = new Bubblegum("Blue"); blue[13] = new Bubblegum("Blue");

            //Purple bubblegum
            purple[0] = new Bubblegum("Purple"); purple[1] = new Bubblegum("Purple"); purple[2] = new Bubblegum("Purple"); purple[3] = new Bubblegum("Purple"); purple[4] = new Bubblegum("Purple"); purple[5] = new Bubblegum("Purple"); purple[6] = new Bubblegum("Purple");

            //Yellow bubblegum
            yellow[0] = new Bubblegum("Yellow"); yellow[1] = new Bubblegum("Yellow"); yellow[2] = new Bubblegum("Yellow"); yellow[3] = new Bubblegum("Yellow"); yellow[4] = new Bubblegum("Yellow"); yellow[5] = new Bubblegum("Yellow"); yellow[6] = new Bubblegum("Yellow"); yellow[7] = new Bubblegum("Yellow"); yellow[8] = new Bubblegum("Yellow"); yellow[9] = new Bubblegum("Yellow"); yellow[10] = new Bubblegum("Yellow");

            //Orange bubblegum
            orange[0] = new Bubblegum("Orange"); orange[1] = new Bubblegum("Orange"); orange[2] = new Bubblegum("Orange"); orange[3] = new Bubblegum("Orange"); orange[4] = new Bubblegum("Orange"); orange[5] = new Bubblegum("Orange"); orange[6] = new Bubblegum("Orange"); orange[7] = new Bubblegum("Orange"); orange[8] = new Bubblegum("Orange"); orange[9] = new Bubblegum("Orange");

            //Red bubblegum
            red[0] = new Bubblegum("Red"); red[1] = new Bubblegum("Red"); red[2] = new Bubblegum("Red"); red[3] = new Bubblegum("Red"); red[4] = new Bubblegum("Red"); red[5] = new Bubblegum("Red"); red[6] = new Bubblegum("Red");

            //Green bubblegum
            green[0] = new Bubblegum("Green"); green[1] = new Bubblegum("Green"); green[2] = new Bubblegum("Green"); green[3] = new Bubblegum("Green"); green[4] = new Bubblegum("Green"); green[5] = new Bubblegum("Green");
        }
    }
}
