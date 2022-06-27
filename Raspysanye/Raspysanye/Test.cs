using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raspysanye
{
    public partial class Test : Form
    {
        Connect con = new Connect();
        YacheikaRaspisanya ych = new YacheikaRaspisanya();

        //public string[] maszan;
        //string[] masraspys;
        private int cntyach=5;
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.DataSource = maszan[0].GetValue(0);
            //dataGridView2.DataSource = masraspys;
        }

        public void GrypYach()
        {
            ych.DayOfWek();
            
            string[] masden = con.MBD1("SELECT idYacheikaRaspys FROM yacheikaraspys", cntyach);
            int cntgr = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM groupps").ToString());
            string[] masgr = con.MBD1("SELECT idGroups FROM groupps",cntgr);
            int cntzv = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspisan1ezvonkov").ToString());
            string[] masnum = con.MBD1("SELECT idraspisan1e FROM raspisan1ezvonkov", cntzv);
            //maszan = masden,masgr,masnum;
            
            for(int i=0; i<masgr.Length; i++)
            {
                for (int j=0; j<masden.Length; j++)
                {
                    for(int z= 0; z<masnum.Length; z++)
                    {
                        int cntpr = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.predmet_has_groups WHERE Groups_idGroups = '" + masgr[i] + "';").ToString());
                        string[] maspredm = con.MBD1("SELECT predmet_idPredmet FROM raspysanye_novoselov.predmet_has_groups WHERE Groups_idGroups = '"+ masgr[i] + "';", cntpr);
                        for (int p=0; p < maspredm.Length; p++)
                        {
                            int cntprep = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.predmet_has_prepodavateli WHERE predmet_idPredmet = '" + maspredm[p] + "';").ToString());
                            string[] masprep = con.MBD1("SELECT prepodavateli_idprepodavateli FROM raspysanye_novoselov.predmet_has_prepodavateli WHERE predmet_idPredmet = '" + maspredm[p] + "';", cntprep);
                            for (int pp = 0; pp < masprep.Length; pp++)
                            {
                                int cntkab = Convert.ToInt32(con.ExecuteScalar("SELECT COUNT(*) FROM raspysanye_novoselov.kabinet_has_predmet WHERE predmet_idPredmet = '" + masprep[pp]+ "';").ToString());
                                string[] maskab = con.MBD1("SELECT kabinet_idKabinet FROM raspysanye_novoselov.kabinet_has_predmet WHERE predmet_idPredmet = '" + masprep[pp] + "';", cntkab);

                                //for (int k = 0; k<maskab.Length; k++)
                                //{
                                int k = 0;
                                /*
                                    maszan[0] = masgr[i];
                                    maszan[1] = masden[j];
                                    maszan[2] = masnum[z];
                                    maszan[3] = maspredm[p];
                                    maszan[4] = masprep[pp];
                                    maszan[5] = maskab[k];
                                */
            
                                string gr = masgr[i];
                                string den = masden[j];
                                string num = masnum[z];
                                string predm = maspredm[p];
                                string prepod = masprep[pp];
                                string kab = maskab[k];

                                int day = Convert.ToInt32(con.ExecuteScalar("SELECT dayofweek_idDayOfWeek FROM yacheikaraspys WHERE idYacheikaRaspys ='" + den + "'"));
                                con.SIDU("INSERT INTO raspysanyezanyatiy (kabinet_idKabinet,predmet_idPredmet,Groups_idGroups,prepodavateli_idprepodavateli,raspisan1ezvonkov_idraspisan1e,YacheikaRaspys_idYacheikaRaspys,YacheikaRaspys_dayofweek_idDayOfWeek)" + "VALUES('"+ kab+ "','"+ predm + "','" + gr + "','" + prepod + "','" + num + "','" + den + "','" + day + "')");
                                //}
                            }
                            
                        }

                    }
                    
                }

                
            }
            
            //Console.WriteLine(maszan);
            //return maszan;
        }

        public void Rasp()
        {
           // return masraspys;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrypYach();
        }
    }
}
