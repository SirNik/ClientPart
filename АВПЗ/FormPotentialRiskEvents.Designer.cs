namespace АВПЗ
{
    partial class FormPotentialRiskEvents
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
            this.джерелаПоявиРизиківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналізРизиківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSources = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSources)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(403, 491);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.джерелаПоявиРизиківToolStripMenuItem,
            this.аналізРизиківToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // джерелаПоявиРизиківToolStripMenuItem
            // 
            this.джерелаПоявиРизиківToolStripMenuItem.Name = "джерелаПоявиРизиківToolStripMenuItem";
            this.джерелаПоявиРизиківToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.джерелаПоявиРизиківToolStripMenuItem.Text = "Джерела появи ризиків";
            this.джерелаПоявиРизиківToolStripMenuItem.Click += new System.EventHandler(this.джерелаПоявиРизиківToolStripMenuItem_Click);
            // 
            // аналізРизиківToolStripMenuItem
            // 
            this.аналізРизиківToolStripMenuItem.Name = "аналізРизиківToolStripMenuItem";
            this.аналізРизиківToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.аналізРизиківToolStripMenuItem.Text = "Аналіз ризиків";
            this.аналізРизиківToolStripMenuItem.Click += new System.EventHandler(this.аналізРизиківToolStripMenuItem_Click);
            // 
            // dataGridViewSources
            // 
            this.dataGridViewSources.AllowUserToAddRows = false;
            this.dataGridViewSources.AllowUserToDeleteRows = false;
            this.dataGridViewSources.AllowUserToResizeColumns = false;
            this.dataGridViewSources.AllowUserToResizeRows = false;
            this.dataGridViewSources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewSources.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewSources.Name = "dataGridViewSources";
            this.dataGridViewSources.RowHeadersVisible = false;
            this.dataGridViewSources.Size = new System.Drawing.Size(844, 450);
            this.dataGridViewSources.TabIndex = 3;
            this.dataGridViewSources.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSources1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 187.095F;
            this.Column1.HeaderText = "Ідентифікація потенційних ризикових подій";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 67.21975F;
            this.Column2.HeaderText = "Так/ні (1/0)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 45.68528F;
            this.Column3.HeaderText = "%";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormPotentialRiskEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewSources);
            this.Name = "FormPotentialRiskEvents";
            this.Text = " Ідентифікація потенційних ризикових подій";
            this.Activated += new System.EventHandler(this.FormPotentialRiskEvents_Activated);
            this.Load += new System.EventHandler(this.FormPotentialRiskEvents_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem джерелаПоявиРизиківToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewSources;
        private System.Windows.Forms.ToolStripMenuItem аналізРизиківToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}