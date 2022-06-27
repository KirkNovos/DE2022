
namespace Raspysanye
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Predmet = new System.Windows.Forms.TabPage();
            this.chance = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrp = new System.Windows.Forms.ComboBox();
            this.comboBoxPrep = new System.Windows.Forms.ComboBox();
            this.comboBoxKab = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prepodavatel = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Auditorya = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Groups = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Zvonki = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Raspysanye = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Actions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnImpPDF = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Predmet.SuspendLayout();
            this.chance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Prepodavatel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Auditorya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Zvonki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.Raspysanye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Predmet);
            this.TabControl.Controls.Add(this.Prepodavatel);
            this.TabControl.Controls.Add(this.Auditorya);
            this.TabControl.Controls.Add(this.Groups);
            this.TabControl.Controls.Add(this.Zvonki);
            this.TabControl.Controls.Add(this.Raspysanye);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(807, 450);
            this.TabControl.TabIndex = 2;
            this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // Predmet
            // 
            this.Predmet.Controls.Add(this.chance);
            this.Predmet.Controls.Add(this.dataGridView1);
            this.Predmet.Location = new System.Drawing.Point(4, 22);
            this.Predmet.Name = "Predmet";
            this.Predmet.Padding = new System.Windows.Forms.Padding(3);
            this.Predmet.Size = new System.Drawing.Size(799, 424);
            this.Predmet.TabIndex = 0;
            this.Predmet.Text = "Предмет";
            this.Predmet.UseVisualStyleBackColor = true;
            // 
            // chance
            // 
            this.chance.Controls.Add(this.button3);
            this.chance.Controls.Add(this.button2);
            this.chance.Controls.Add(this.label3);
            this.chance.Controls.Add(this.label2);
            this.chance.Controls.Add(this.label1);
            this.chance.Controls.Add(this.comboBoxGrp);
            this.chance.Controls.Add(this.comboBoxPrep);
            this.chance.Controls.Add(this.comboBoxKab);
            this.chance.Controls.Add(this.splitter1);
            this.chance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chance.Location = new System.Drawing.Point(3, 328);
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(793, 93);
            this.chance.TabIndex = 3;
            this.chance.TabStop = false;
            this.chance.Text = "отношения";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Отвязать предмет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Связать предмет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "преподаватель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "кабинет";
            // 
            // comboBoxGrp
            // 
            this.comboBoxGrp.FormattingEnabled = true;
            this.comboBoxGrp.Location = new System.Drawing.Point(507, 25);
            this.comboBoxGrp.Name = "comboBoxGrp";
            this.comboBoxGrp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrp.TabIndex = 4;
            // 
            // comboBoxPrep
            // 
            this.comboBoxPrep.FormattingEnabled = true;
            this.comboBoxPrep.Location = new System.Drawing.Point(287, 25);
            this.comboBoxPrep.Name = "comboBoxPrep";
            this.comboBoxPrep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrep.TabIndex = 3;
            // 
            // comboBoxKab
            // 
            this.comboBoxKab.FormattingEnabled = true;
            this.comboBoxKab.Location = new System.Drawing.Point(60, 25);
            this.comboBoxKab.Name = "comboBoxKab";
            this.comboBoxKab.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKab.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(787, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Prepodavatel
            // 
            this.Prepodavatel.Controls.Add(this.dataGridView2);
            this.Prepodavatel.Location = new System.Drawing.Point(4, 22);
            this.Prepodavatel.Name = "Prepodavatel";
            this.Prepodavatel.Padding = new System.Windows.Forms.Padding(3);
            this.Prepodavatel.Size = new System.Drawing.Size(799, 424);
            this.Prepodavatel.TabIndex = 1;
            this.Prepodavatel.Text = "Преподаватель";
            this.Prepodavatel.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(793, 418);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Auditorya
            // 
            this.Auditorya.Controls.Add(this.dataGridView3);
            this.Auditorya.Location = new System.Drawing.Point(4, 22);
            this.Auditorya.Name = "Auditorya";
            this.Auditorya.Size = new System.Drawing.Size(799, 424);
            this.Auditorya.TabIndex = 2;
            this.Auditorya.Text = "Аудитория";
            this.Auditorya.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(799, 424);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Groups
            // 
            this.Groups.Controls.Add(this.dataGridView4);
            this.Groups.Location = new System.Drawing.Point(4, 22);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(799, 424);
            this.Groups.TabIndex = 3;
            this.Groups.Text = "Группа";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(799, 424);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // Zvonki
            // 
            this.Zvonki.Controls.Add(this.dataGridView5);
            this.Zvonki.Location = new System.Drawing.Point(4, 22);
            this.Zvonki.Name = "Zvonki";
            this.Zvonki.Size = new System.Drawing.Size(799, 424);
            this.Zvonki.TabIndex = 4;
            this.Zvonki.Text = "Звонки";
            this.Zvonki.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(799, 424);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // Raspysanye
            // 
            this.Raspysanye.Controls.Add(this.BtnImpPDF);
            this.Raspysanye.Controls.Add(this.button1);
            this.Raspysanye.Controls.Add(this.dataGridView6);
            this.Raspysanye.Location = new System.Drawing.Point(4, 22);
            this.Raspysanye.Name = "Raspysanye";
            this.Raspysanye.Size = new System.Drawing.Size(799, 424);
            this.Raspysanye.TabIndex = 5;
            this.Raspysanye.Text = "Расписание";
            this.Raspysanye.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(799, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Составить расписание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(799, 424);
            this.dataGridView6.TabIndex = 0;
            // 
            // Actions
            // 
            this.Actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.Actions.Name = "contextMenuStrip1";
            this.Actions.ShowCheckMargin = true;
            this.Actions.Size = new System.Drawing.Size(156, 70);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // BtnImpPDF
            // 
            this.BtnImpPDF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnImpPDF.Location = new System.Drawing.Point(0, 366);
            this.BtnImpPDF.Name = "BtnImpPDF";
            this.BtnImpPDF.Size = new System.Drawing.Size(799, 23);
            this.BtnImpPDF.TabIndex = 2;
            this.BtnImpPDF.Text = "Импорт в PDF";
            this.BtnImpPDF.UseVisualStyleBackColor = true;
            this.BtnImpPDF.Click += new System.EventHandler(this.BtnImpPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.ContextMenuStrip = this.Actions;
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расписание ЙОТК";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Predmet.ResumeLayout(false);
            this.chance.ResumeLayout(false);
            this.chance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Prepodavatel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Auditorya.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Zvonki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.Raspysanye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.Actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Predmet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Prepodavatel;
        private System.Windows.Forms.TabPage Auditorya;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.TabPage Zvonki;
        private System.Windows.Forms.TabPage Raspysanye;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.ContextMenuStrip Actions;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox chance;
        private System.Windows.Forms.ComboBox comboBoxGrp;
        private System.Windows.Forms.ComboBox comboBoxPrep;
        private System.Windows.Forms.ComboBox comboBoxKab;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnImpPDF;
    }
}

