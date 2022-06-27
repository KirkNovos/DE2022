using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspysanye
{
    public class Zanyatye : IZanyatye
    {
        public string Aud;
        public string Groupp;
        public string Pr;
        public string Pp;
        public string Auditorya(int ch)
        {
            switch (ch)
            {
                case 1:
                    Aud = "SELECT Naimenovanie AS Номер, KolvoMest AS вместимость FROM kabinet";
                    break;
                case 2:
                    Aud = "INSERT INTO * FROM kabinet";
                    break;
                case 3:
                    Aud = "UPDATE * FROM kabinet";
                    break;
                case 4:
                    Aud = "DELETE * FROM kabinet";
                    break;
            }
            return Aud;
        }

        public string Group(int ch)
        {
            switch (ch)
            {
                case 1:
                    Groupp = "SELECT Name AS группа, ColvoChelovek AS количество FROM groupps";
                    break;
                case 2:
                    Groupp = "INSERT INTO * FROM groups";
                    break;
                case 3:
                    Groupp = "UPDATE * FROM groups";
                    break;
                case 4:
                    Groupp = "DELETE * FROM groups";
                    break;
            }
            return Groupp;
        }

        public string Predmet(int ch)
        {
            switch (ch)
            {
                case 1:
                    Pr = "SELECT NaimenovaniePredmeta AS предмет FROM predmet";
                    break;
                case 2:
                    Pr = "INSERT INTO * FROM predmet";
                    break;
                case 3:
                    Pr = "UPDATE * FROM predmet";
                    break;
                case 4:
                    Pr = "DELETE * FROM predmet";
                    break;
            }
            return Pr;
        }

        public string Prepodavat(int ch)
        {
            switch (ch)
            {
                case 1:
                    Pp = "SELECT FIO AS ФИО FROM prepodavateli";
                    break;
                case 2:
                    Pp = "INSERT INTO * FROM prepodavateli";
                    break;
                case 3:
                    Pp = "UPDATE * FROM prepodavateli";
                    break;
                case 4:
                    Pp = "DELETE * FROM prepodavateli";
                    break;
            }
            return Pp;
        }
    }
}