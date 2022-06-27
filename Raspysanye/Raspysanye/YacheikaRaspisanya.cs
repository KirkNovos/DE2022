using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Raspysanye
{
    public class YacheikaRaspisanya : IRaspisanye
    {
        //private DataTable rasp = new DataTable();
        Connect con = new Connect();
        //Form1 f1 = new Form1();


        private string vrem;
        private string yach;
        private int z = 1;
        private int j = 1;
        private int cntyach = 5;

        public void DayOfWek()
        {
            con.SIDU("DELETE FROM yacheikaraspys");
            DateTime DT = DateTime.Now;
            int d = Convert.ToInt32(DT.Day);
            



            if (DT.DayOfWeek == DayOfWeek.Monday)
            {
                d = DT.Day;
                for (int i = 1; i < 7; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('"+ d + "','" + i + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                }
            }
           
            else if (DT.DayOfWeek==DayOfWeek.Tuesday)
            {
                DT = DT.AddDays(6);
                d = DT.Day;
                for (int i = 1; i < 7; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('" + d + "','" + i + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                }
            }
            else if (DT.DayOfWeek == DayOfWeek.Wednesday)
            {
                DT = DT.AddDays(5);
                d = DT.Day;
                for (int i = 0; i < 6; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('" + d + "','" + j + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                    j++;
                }
            }
            else if (DT.DayOfWeek == DayOfWeek.Thursday)
            {
                DT = DT.AddDays(4);
                d = DT.Day;
                for (int i = 0; i < 6; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('" + d + "','" + j + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                    j++;

                }
            }
            else if (DT.DayOfWeek == DayOfWeek.Friday)
            {
                DT = DT.AddDays(3);
                d = DT.Day;
                for (int i = 0; i < 6; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('" + d + "','" + j + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                    j++;
                }
            }

            else if (DT.DayOfWeek == DayOfWeek.Saturday)
            {
                DT = DT.AddDays(2);
                d = DT.Day;
                for (int i = 1; i < 7; i++)
                {
                    yach = "INSERT INTO yacheikaraspys (daay,dayofweek_idDayOfWeek)" + "Values('" + d + "','" + i + "')";
                    con.SIDU(yach);
                    DT = DT.AddDays(1);
                    d = Convert.ToInt32(DT.Day);
                }
            }
        }

        public string NumberPara()
        {
            vrem = "SELECT vremya AS время FROM raspisan1ezvonkov";
            return vrem;
        }

        //int z1 = 0;
        int n = 0;
        public void ExecuteRaspys()
        {
            DayOfWek();

                string[] masden = con.MBD1("SELECT idYacheikaRaspys FROM yacheikaraspys", cntyach);
                int cntgr = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM groupps").ToString());
                string[] masgr = con.MBD1("SELECT idGroups FROM groupps", cntgr);
                int cntzv = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspisan1ezvonkov").ToString());
                string[] maszv = con.MBD1("SELECT idraspisan1e FROM raspisan1ezvonkov", cntzv);



                for (int i = 0; i < masgr.Length; i++)
                {
                    for (int j = 0; j < masden.Length; j++)
                    {
                    
                        for (int z = 0; z < maszv.Length; z++)
                        {
                            int cntpr = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.predmet_has_groups WHERE Groups_idGroups = '" + masgr[i] + "';").ToString());
                        
                            if (cntpr > 0)
                            {
                                string[] maspredm = con.MBD1("SELECT predmet_idPredmet FROM raspysanye_novoselov.predmet_has_groups WHERE Groups_idGroups = '" + masgr[i] + "';", cntpr);
                                for (int p=z; p < maspredm.Length; p++)
                                {
                                    int cntprep = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.predmet_has_prepodavateli WHERE predmet_idPredmet = '" + maspredm[p] + "';").ToString());
                                    string[] masprep = con.MBD1("SELECT prepodavateli_idprepodavateli FROM raspysanye_novoselov.predmet_has_prepodavateli WHERE predmet_idPredmet = '" + maspredm[p] + "';", cntprep);
                                    for (int pp = 0; pp < masprep.Length; pp++)
                                    {
                                        int cntkab = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.kabinet_has_predmet WHERE predmet_idPredmet = '" + maspredm[p] + "';").ToString());
                                        string[] maskab = con.MBD1("SELECT kabinet_idKabinet FROM raspysanye_novoselov.kabinet_has_predmet WHERE predmet_idPredmet = '" + maspredm[p] + "';", cntkab);

                                        for (int k = 0; k < maskab.Length; k++)
                                        {
                                            string gr = masgr[i];
                                            string den = masden[j];
                                            string num = maszv[z];
                                            string predm = maspredm[p];
                                            string prepod = masprep[pp];
                                            string kab = maskab[k];

                                            int day = Convert.ToInt32(con.ExecuteScalar("SELECT dayofweek_idDayOfWeek FROM yacheikaraspys WHERE idYacheikaRaspys ='" + den + "'"));

                                            int ColLessons = Convert.ToInt32(con.ExecuteScalarInt("select raspysanye_novoselov.lessons_exist('" + den + "','" + day + "','" + num + "','" + gr + "')"));
                                            if (ColLessons == 0)
                                            {
                                                con.SIDU("INSERT INTO raspysanyezanyatiy (kabinet_idKabinet,predmet_idPredmet,Groups_idGroups,prepodavateli_idprepodavateli,raspisan1ezvonkov_idraspisan1e,YacheikaRaspys_idYacheikaRaspys," +
                                                "YacheikaRaspys_dayofweek_idDayOfWeek)"
                                                + "VALUES('" + kab + "','" + predm + "','" + gr + "','" + prepod + "','" + num + "','" + den + "','" + day + "')");

                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                }
        }


        public void ExecuteZanyaty()
        {
            /*
            string queryG = "SELECT COUNT(*) FROM Groups";
            string qG = con.ExecuteScalar(queryG).ToString();
            int cG = Convert.ToInt32(qG);///////////////////////////количество групп


            int np = 0;

            for (int dn = 0; dn < 7; dn++) //цикл дня
            {
                for (int zv = 0; zv < 3; zv++)//цикл пар
                {
                    for (int i = 1; i < cG; i++)// цикл групп
                    {
                        string nameG = f1.dataGridView4[0, i].Value.ToString();//название группы

                        string queryIDG = con.ExecuteScalar("SELECT idGroups FROM groupps gr WHERE gr.name='"+nameG+"'").ToString();
                        //сравнивает по названию из даты грид и бд таблицы и выводит нужный id
                        int ig = Convert.ToInt32(queryIDG);//запихнуть в главную табличку!!!!!!!!!!!!!!

                        string queryP = "SELECT COUNT(*) FROM FROM predmet_has_groups WHERE Groups_idGroups='" + ig + "'";
                        string qP = con.ExecuteScalar(queryP).ToString();
                        int cP = Convert.ToInt32(qP);//количество предметов для определённой группы по id


                        
                        string predm_has_group = "SELECT predmet_idPredmet FROM predmet_has_groups WHERE Groups_idGroups='"+ig+"'";
                        //запрос для вывода списка предметов для орпеделённой группы
                        string[] MasPredm = con.MBD(predm_has_group, cP);
                        
                        int SelectedPredmet = Convert.ToInt32(MasPredm[np]);
                        np++;
                        string idPredm = "SELECT idPredmet FROM predmet WHERE ";
                        //int np = 0;
                        //int SelectedPredmet = Convert.ToInt32(MasPredm[np]);//айдишник предмета для занятия именно текущей группы
                        // запихнуть в главную табличку!!!!!!!!!!!!!!!

                        //string predm_kabinet = "SELECT ";

                    }
                }
            }
            */
        }

    }
}