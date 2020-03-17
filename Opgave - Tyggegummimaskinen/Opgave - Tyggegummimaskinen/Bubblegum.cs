using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave___Tyggegummimaskinen
{
    class Bubblegum
    {
		private string gumColor;

		public string GumColor
		{
			get { return gumColor; }
			set { gumColor = value; }
		}

		public Bubblegum(string gumColor)
		{
			this.GumColor = gumColor;
		}
	}
}
