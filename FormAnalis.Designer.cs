namespace АВПЗ
{
    partial class FormAnalis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.джерелаПоявиРизиківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потенційніРизиковіПодіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSources = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSources)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(543, 532);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.джерелаПоявиРизиківToolStripMenuItem,
            this.потенційніРизиковіПодіїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.створитиToolStripMenuItem.Text = "Створити";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // джерелаПоявиРизиківToolStripMenuItem
            // 
            this.джерелаПоявиРизиківToolStripMenuItem.Name = "джерелаПоявиРизиківToolStripMenuItem";
            this.джерелаПоявиРизиківToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.джерелаПоявиРизиківToolStripMenuItem.Text = "Джерела появи ризиків";
            this.джерелаПоявиРизиківToolStripMenuItem.Click += new System.EventHandler(this.джерелаПоявиРизиківToolStripMenuItem_Click);
            // 
            // потенційніРизиковіПодіїToolStripMenuItem
            // 
            this.потенційніРизиковіПодіїToolStripMenuItem.Name = "потенційніРизиковіПодіїToolStripMenuItem";
            this.потенційніРизиковіПодіїToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.потенційніРизиковіПодіїToolStripMenuItem.Text = "Потенційні ризикові події ";
            this.потенційніРизиковіПодіїToolStripMenuItem.Click += new System.EventHandler(this.потенційніРизиковіПодіїToolStripMenuItem_Click);
            // 
            // dataGridViewSources
            // 
            this.dataGridViewSources.AllowUserToAddRows = false;
            this.dataGridViewSources.AllowUserToDeleteRows = false;
            this.dataGridViewSources.AllowUserToResizeColumns = false;
            this.dataGridViewSources.AllowUserToResizeRows = false;
            this.dataGridViewSources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column3});
            this.dataGridViewSources.Location = new System.Drawing.Point(-4, 19);
            this.dataGridViewSources.Name = "dataGridViewSources";
            this.dataGridViewSources.RowHeadersVisible = false;
            this.dataGridViewSources.Size = new System.Drawing.Size(1168, 458);
            this.dataGridViewSources.TabIndex = 6;
            this.dataGridViewSources.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSources_CellValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 499);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewSources);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Визначення ймовірності настання ризикових подій";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1171, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оцінки експертів у діапазоні [0...1]";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1171, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 864.9746F;
            this.Column1.HeaderText = "Потенційні ризикові події";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 123;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 13.7941F;
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 38;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 12.81453F;
            this.Column4.HeaderText = "2";
            this.Column4.Name = "Column4";
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 12.3371F;
            this.Column5.HeaderText = "3";
            this.Column5.Name = "Column5";
            this.Column5.Width = 38;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 16.5167F;
            this.Column6.HeaderText = "4";
            this.Column6.Name = "Column6";
            this.Column6.Width = 38;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 19.93294F;
            this.Column7.HeaderText = "5";
            this.Column7.Name = "Column7";
            this.Column7.Width = 38;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 24.21956F;
            this.Column8.HeaderText = "6";
            this.Column8.Name = "Column8";
            this.Column8.Width = 38;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 29.59832F;
            this.Column9.HeaderText = "7";
            this.Column9.Name = "Column9";
            this.Column9.Width = 38;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 36.34747F;
            this.Column10.HeaderText = "8";
            this.Column10.Name = "Column10";
            this.Column10.Width = 38;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 44.81613F;
            this.Column11.HeaderText = "9";
            this.Column11.Name = "Column11";
            this.Column11.Width = 38;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 55.44242F;
            this.Column12.HeaderText = "10";
            this.Column12.Name = "Column12";
            this.Column12.Width = 44;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 69.20614F;
            this.Column3.HeaderText = "0%";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 46;
            // 
            // FormAnalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAnalis";
            this.Text = "FormAnalis";
            this.Activated += new System.EventHandler(this.FormAnalis_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSources)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem джерелаПоявиРизиківToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewSources;
        private System.Windows.Forms.ToolStripMenuItem потенційніРизиковіПодіїToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage3;
    }
}