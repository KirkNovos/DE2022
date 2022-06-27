using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspysanye
{
    public interface IZanyatye
    {
        string Predmet(int ch);
        string Prepodavat(int ch);
        string Group(int ch);
        string Auditorya(int ch);
    }
}