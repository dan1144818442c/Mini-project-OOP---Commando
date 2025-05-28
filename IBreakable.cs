using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal interface IBreakable
    {
        string Status { get; set; }
        int MaxHits { get; }
        int CurrentHits { get; set; }
        void Hit();
    }
}
