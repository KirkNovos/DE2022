using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raspysanye
{
    public partial class Form1 : Form
    {
        Connect con = new Connect();
        YacheikaRaspisanya ch = new YacheikaRaspisanya();
        Zanyatye zan = new Zanyatye();
        Test ts = new Test();
        int j = 1;
        int predmid;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtel = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.CO(zan.Predmet(1)).Tables[0];
            dataGridView2.DataSource = con.CO(zan.Prepodavat(1)).Tables[0];
            dataGridView3.DataSource = con.CO(zan.Auditorya(1)).Tables[0];
            dataGridView4.DataSource = con.CO(zan.Group(1)).Tables[0];
            dataGridView5.DataSource = con.CO(ch.NumberPara()).Tables[0];
            dataGridView6.DataSource = con.CO("Proc_Rasp_tb").Tables[0];

            //label1.Text = ch.ExecuteZanyaty();

            string kab = "Select Naimenovanie from kabinet ";
            dt1 = con.ConDT(kab);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBoxKab.Items.Add(dr[0].ToString());
            }
            string pr = "Select FIO from prepodavateli ";
            dt2 = con.ConDT(pr);
            foreach (DataRow dr in dt2.Rows)
            {
                comboBoxPrep.Items.Add(dr[0].ToString());
            }
            string gr = "Select Name from groupps ";
            dt2 = con.ConDT(gr);
            foreach (DataRow dr in dt2.Rows)
            {
                comboBoxGrp.Items.Add(dr[0].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ch.ExecuteRaspys();
            dataGridView6.DataSource = con.CO("Proc_Rasp_tb").Tables[0];
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    j = 1;
                    break;
                case 1:
                    j = 2;
                    break;
                case 2:
                    j = 3;
                    break;
                case 3:
                    j = 4;
                    break;
                case 4:
                    j = 5;
                    break;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (j)
            {
                case 1:
                    int k = dataGridView1.CurrentCell.RowIndex;
                    string col = dataGridView1[0,k].Value.ToString();
                    string s = "DELETE FROM predmet WHERE NaimenovaniePredmeta = '" + col + "';";
                    con.SIDU(s);
                    dataGridView1.DataSource = con.CO(zan.Predmet(1)).Tables[0];
                    break;
                case 2:
                    k = dataGridView2.CurrentCell.RowIndex;
                    col = dataGridView2[0, k].Value.ToString();
                    s = "DELETE FROM prepodavateli WHERE FIO = '" + col + "';";
                    con.SIDU(s);
                    dataGridView2.DataSource = con.CO(zan.Prepodavat(1)).Tables[0];
                    break;
                case 3:
                    k = dataGridView3.CurrentCell.RowIndex;
                    col = dataGridView3[0, k].Value.ToString();
                    s = "DELETE FROM kabinet WHERE Naimenovanie = '" + col + "';";
                    con.SIDU(s);
                    dataGridView3.DataSource = con.CO(zan.Auditorya(1)).Tables[0];
                    break;
                case 4:
                    k = dataGridView4.CurrentCell.RowIndex;
                    col = dataGridView4[0, k].Value.ToString();
                    s = "DELETE FROM groupps WHERE Name = '" + col + "';";
                    con.SIDU(s);
                    dataGridView4.DataSource = con.CO(zan.Group(1)).Tables[0];
                    break;
                case 5:
                    k = dataGridView5.CurrentCell.RowIndex;
                    col = dataGridView5[0, k].Value.ToString();
                    s = "DELETE FROM raspisan1ezvonkov WHERE vremya = '" + col + "';";
                    con.SIDU(s);
                    dataGridView5.DataSource = con.CO(ch.NumberPara()).Tables[0];
                    break;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (j)
            {
                case 1:
                    int k = dataGridView1.CurrentCell.RowIndex;
                    string col = dataGridView1[0, k].Value.ToString();
                    string s = "insert predmet set NaimenovaniePredmeta = '" + col + "';";
                    con.SIDU(s);
                    dataGridView1.DataSource = con.CO(zan.Predmet(1)).Tables[0];
                    break;
                case 2:
                    k = dataGridView2.CurrentCell.RowIndex;
                    col = dataGridView2[0, k].Value.ToString();
                    s = "insert prepodavateli set FIO = '" + col + "';";
                    con.SIDU(s);
                    dataGridView2.DataSource = con.CO(zan.Prepodavat(1)).Tables[0];
                    break;
                case 3:
                    k = dataGridView3.CurrentCell.RowIndex;
                    col = dataGridView3[0, k].Value.ToString();
                    string col1 = dataGridView3[1, k].Value.ToString();
                    s = "insert kabinet set Naimenovanie = '" + col + "', KolvoMest = '" + col1 + "';";
                    con.SIDU(s);
                    dataGridView3.DataSource = con.CO(zan.Auditorya(1)).Tables[0];
                    break;
                case 4:
                    k = dataGridView4.CurrentCell.RowIndex;
                    col = dataGridView4[0, k].Value.ToString();
                    col1 = dataGridView4[1, k].Value.ToString();
                    s = "insert groupps set Name = '" + col + "',ColvoChelovek = '" + col1 + "';";
                    con.SIDU(s);
                    dataGridView4.DataSource = con.CO(zan.Group(1)).Tables[0];
                    break;
                case 5:
                    k = dataGridView5.CurrentCell.RowIndex;
                    col = dataGridView5[0, k].Value.ToString();
                    s = "insert raspisan1ezvonkov set vremya = '" + col + "';";
                    con.SIDU(s);
                    dataGridView5.DataSource = con.CO(ch.NumberPara()).Tables[0];
                    break;
            }
        }



        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (j)
            {
                case 1:
                    int k = dataGridView1.CurrentCell.RowIndex;
                    string col = dataGridView1[0, k].Value.ToString();
                    int l = k + 1;
                    string s = "Update predmet set NaimenovaniePredmeta = '" + col + "' where idPredmet ='" + predmid + "';";
                    con.SIDU(s);
                    dataGridView1.DataSource = con.CO(zan.Predmet(1)).Tables[0];
                    break;
                case 2:
                    k = dataGridView2.CurrentCell.RowIndex;
                    col = dataGridView2[0, k].Value.ToString();
                    s = "Update prepodavateli set FIO = '" + col + "' where = idprepodavateli'" + predmid + "';";
                    con.SIDU(s);
                    dataGridView2.DataSource = con.CO(zan.Prepodavat(1)).Tables[0];
                    break;
                case 3:
                    k = dataGridView3.CurrentCell.RowIndex;
                    col = dataGridView3[0, k].Value.ToString();
                    string col1 = dataGridView3[1, k].Value.ToString();
                    s = "Update kabinet set Naimenovanie = '" + col + "', KolvoMest = '" + col1 + "' where = idKabinet'" + predmid + "';";
                    con.SIDU(s);
                    dataGridView3.DataSource = con.CO(zan.Auditorya(1)).Tables[0];
                    break;
                case 4:
                    k = dataGridView4.CurrentCell.RowIndex;
                    col = dataGridView4[0, k].Value.ToString();
                    col1 = dataGridView4[1, k].Value.ToString();
                    s = "Update groupps set Name = '" + col + "',ColvoChelovek = '" + col1 + "' where = idKabinet'" + predmid + "';";
                    con.SIDU(s);
                    dataGridView4.DataSource = con.CO(zan.Group(1)).Tables[0];
                    break;
                case 5:
                    k = dataGridView5.CurrentCell.RowIndex;
                    col = dataGridView5[0, k].Value.ToString();
                    s = "Update raspisan1ezvonkov set vremya = '" + col + "' where = idraspisan1e'" + predmid + ";";
                    con.SIDU(s);
                    dataGridView5.DataSource = con.CO(ch.NumberPara()).Tables[0];
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = dataGridView1.CurrentCell.RowIndex;
            string col = dataGridView1[0, k].Value.ToString();
            string s = "select idPredmet from predmet where NaimenovaniePredmeta = '" + col + "';";
            predmid = con.ExecuteScalarInt(s);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = dataGridView2.CurrentCell.RowIndex;
            string col = dataGridView2[0, k].Value.ToString();
            string s = "select idprepodavateli from prepodavateli where FIO = '" + col + "';";
            predmid = con.ExecuteScalarInt(s);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = dataGridView3.CurrentCell.RowIndex;
            string col = dataGridView3[0, k].Value.ToString();
            string s = "select idKabinet from kabinet where Naimenovanie = '" + col + "';";
            predmid = con.ExecuteScalarInt(s);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = dataGridView4.CurrentCell.RowIndex;
            string col = dataGridView4[0, k].Value.ToString();
            string s = "select idGroups from groupps where Name = '" + col + "';";
            predmid = con.ExecuteScalarInt(s);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = dataGridView5.CurrentCell.RowIndex;
            string col = dataGridView5[0, k].Value.ToString();
            string s = "select idraspisan1e from raspisan1ezvonkov where vremya = '" + col + "';";
            predmid = con.ExecuteScalarInt(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string k = "select idKabinet from kabinet where Naimenovanie = '" + comboBoxKab.SelectedItem + "';";
            int idk= con.ExecuteScalarInt(k);

            string k1 = "insert kabinet_has_predmet set predmet_idPredmet " +
                "= '" + predmid + "',kabinet_idKabinet =" +
                "  '" + idk + "';";
            con.SIDU(k1);

            string p = "select idprepodavateli from prepodavateli where FIO = '" + comboBoxPrep.SelectedItem + "';";
            int idp = con.ExecuteScalarInt(p);

            string p1 = "insert predmet_has_prepodavateli set predmet_idPredmet " +
                "= '" + predmid + "',prepodavateli_idprepodavateli =" +
                "  '" + idp + "';";
            con.SIDU(p1);

            string g = "select idGroups from groupps where Name = '" + comboBoxGrp.SelectedItem + "';";
            int idg = con.ExecuteScalarInt(g);

            string g1 = "insert predmet_has_groups set predmet_idPredmet " +
                "= '" + predmid + "',Groups_idGroups =" +
                "  '" + idg + "';";
            con.SIDU(g1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = "delete from kabinet_has_predmet where predmet_idPredmet = '" + predmid + "'";
            con.SIDU(d);
            string d1 = "delete from predmet_has_prepodavateli where predmet_idPredmet = '" + predmid + "'";
            con.SIDU(d1);
            string d2 = "delete from predmet_has_groups where predmet_idPredmet = '" + predmid + "'";
            con.SIDU(d2);
        }

        
        private void BtnImpPDF_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView6.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;


            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
            BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
            iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL);


            PdfPTable table = new PdfPTable(dataGridView6.Columns.Count);
            //Adding DataRow


            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView6.Columns.Count; j++)
                {
                    Paragraph p = new Paragraph(new Phrase(dataGridView6.Rows[i].Cells[j].Value.ToString()));
                    p.Font = fontParagraph;
                    pdfTable.AddCell(p);
                }
            }

/*
            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //pdfTable.AddCell(cell.Value.ToString()); //не работает
                    //PdfPCell cells = new PdfPCell(new Phrase(row.Height));
                    Paragraph p = new Paragraph(new Phrase(row.Height));
                    p.Font = fontParagraph;
                    pdfTable.AddCell(p);
                }
            }
*/
            //Экспорт PDF
            //Путь
            string folderPath = "C:\\PDFs\\";
            //если каталог не существует, создаём его
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}
