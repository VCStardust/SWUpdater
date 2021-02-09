
namespace SWUpdater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LVerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RVerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewP
            // 
            this.dataGridViewP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LVerColumn,
            this.RVerColumn,
            this.LPathColumn,
            this.URLColumn,
            this.OtherColumn});
            this.dataGridViewP.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewP.MultiSelect = false;
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.RowHeadersVisible = false;
            this.dataGridViewP.RowTemplate.Height = 25;
            this.dataGridViewP.Size = new System.Drawing.Size(1024, 684);
            this.dataGridViewP.TabIndex = 1;
            this.dataGridViewP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewP_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 160;
            // 
            // LVerColumn
            // 
            this.LVerColumn.HeaderText = "Local Version";
            this.LVerColumn.Name = "LVerColumn";
            this.LVerColumn.Width = 127;
            // 
            // RVerColumn
            // 
            this.RVerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RVerColumn.HeaderText = "Remote Version";
            this.RVerColumn.Name = "RVerColumn";
            this.RVerColumn.Width = 127;
            // 
            // LPathColumn
            // 
            this.LPathColumn.HeaderText = "Path";
            this.LPathColumn.Name = "LPathColumn";
            this.LPathColumn.Width = 225;
            // 
            // URLColumn
            // 
            this.URLColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.URLColumn.HeaderText = "Repo URL";
            this.URLColumn.Name = "URLColumn";
            this.URLColumn.Width = 225;
            // 
            // OtherColumn
            // 
            this.OtherColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OtherColumn.HeaderText = "Other Properties";
            this.OtherColumn.Name = "OtherColumn";
            this.OtherColumn.Width = 157;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Updater";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherColumn;
    }
}

