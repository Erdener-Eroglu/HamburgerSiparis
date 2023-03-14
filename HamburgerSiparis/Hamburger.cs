using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSiparis;

public class Hamburger
{
    public string HamburgerSize { get; set; }
    public string Icecek { get; set; }
    public List<string> Cesitler { get; set; } = new();

}
