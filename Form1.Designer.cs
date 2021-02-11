
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
            this.PdataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LVerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RVerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LogtextBox1 = new System.Windows.Forms.TextBox();
            this.Operate_groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpLocal_button = new System.Windows.Forms.Button();
            this.ExpRepo_button = new System.Windows.Forms.Button();
            this.UpdareAll_button = new System.Windows.Forms.Button();
            this.UpdateC_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).BeginInit();
            this.Operate_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PdataGridView
            // 
            this.PdataGridView.AllowUserToResizeRows = false;
            this.PdataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LVerColumn,
            this.RVerColumn,
            this.LPathColumn,
            this.URLColumn,
            this.OtherColumn});
            this.PdataGridView.Location = new System.Drawing.Point(12, 12);
            this.PdataGridView.MultiSelect = false;
            this.PdataGridView.Name = "PdataGridView";
            this.PdataGridView.RowHeadersVisible = false;
            this.PdataGridView.RowTemplate.Height = 25;
            this.PdataGridView.Size = new System.Drawing.Size(1024, 684);
            this.PdataGridView.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "程序名";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 160;
            // 
            // LVerColumn
            // 
            this.LVerColumn.HeaderText = "本地版本";
            this.LVerColumn.Name = "LVerColumn";
            this.LVerColumn.Width = 127;
            // 
            // RVerColumn
            // 
            this.RVerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RVerColumn.HeaderText = "服务器版本";
            this.RVerColumn.Name = "RVerColumn";
            this.RVerColumn.ReadOnly = true;
            this.RVerColumn.Width = 127;
            // 
            // LPathColumn
            // 
            this.LPathColumn.HeaderText = "路径";
            this.LPathColumn.Name = "LPathColumn";
            this.LPathColumn.Width = 225;
            // 
            // URLColumn
            // 
            this.URLColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.URLColumn.HeaderText = "Repo地址";
            this.URLColumn.Name = "URLColumn";
            this.URLColumn.Width = 225;
            // 
            // OtherColumn
            // 
            this.OtherColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OtherColumn.HeaderText = "其他属性";
            this.OtherColumn.Name = "OtherColumn";
            this.OtherColumn.Width = 157;
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
            // LogtextBox1
            // 
            this.LogtextBox1.Location = new System.Drawing.Point(1042, 480);
            this.LogtextBox1.Multiline = true;
            this.LogtextBox1.Name = "LogtextBox1";
            this.LogtextBox1.Size = new System.Drawing.Size(296, 216);
            this.LogtextBox1.TabIndex = 4;
            // 
            // Operate_groupBox1
            // 
            this.Operate_groupBox1.Controls.Add(this.ExpLocal_button);
            this.Operate_groupBox1.Controls.Add(this.ExpRepo_button);
            this.Operate_groupBox1.Controls.Add(this.UpdareAll_button);
            this.Operate_groupBox1.Controls.Add(this.UpdateC_button);
            this.Operate_groupBox1.Location = new System.Drawing.Point(1042, 12);
            this.Operate_groupBox1.Name = "Operate_groupBox1";
            this.Operate_groupBox1.Size = new System.Drawing.Size(296, 462);
            this.Operate_groupBox1.TabIndex = 3;
            this.Operate_groupBox1.TabStop = false;
            this.Operate_groupBox1.Text = "信息";
            // 
            // ExpLocal_button
            // 
            this.ExpLocal_button.Location = new System.Drawing.Point(6, 428);
            this.ExpLocal_button.Name = "ExpLocal_button";
            this.ExpLocal_button.Size = new System.Drawing.Size(127, 28);
            this.ExpLocal_button.TabIndex = 3;
            this.ExpLocal_button.Text = "浏览程序目录";
            this.ExpLocal_button.UseVisualStyleBackColor = true;
            // 
            // ExpRepo_button
            // 
            this.ExpRepo_button.Location = new System.Drawing.Point(6, 394);
            this.ExpRepo_button.Name = "ExpRepo_button";
            this.ExpRepo_button.Size = new System.Drawing.Size(127, 28);
            this.ExpRepo_button.TabIndex = 2;
            this.ExpRepo_button.Text = "访问Repo";
            this.ExpRepo_button.UseVisualStyleBackColor = true;
            // 
            // UpdareAll_button
            // 
            this.UpdareAll_button.Location = new System.Drawing.Point(163, 360);
            this.UpdareAll_button.Name = "UpdareAll_button";
            this.UpdareAll_button.Size = new System.Drawing.Size(127, 28);
            this.UpdareAll_button.TabIndex = 1;
            this.UpdareAll_button.Text = "更新所有程序";
            this.UpdareAll_button.UseVisualStyleBackColor = true;
            // 
            // UpdateC_button
            // 
            this.UpdateC_button.Location = new System.Drawing.Point(6, 360);
            this.UpdateC_button.Name = "UpdateC_button";
            this.UpdateC_button.Size = new System.Drawing.Size(127, 28);
            this.UpdateC_button.TabIndex = 0;
            this.UpdateC_button.Text = "更新当前程序";
            this.UpdateC_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LogtextBox1);
            this.Controls.Add(this.Operate_groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PdataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Updater";
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).EndInit();
            this.Operate_groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PdataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox LogtextBox1;
        private System.Windows.Forms.GroupBox Operate_groupBox1;
        private System.Windows.Forms.Button UpdareAll_button;
        private System.Windows.Forms.Button UpdateC_button;
        private System.Windows.Forms.Button ExpLocal_button;
        private System.Windows.Forms.Button ExpRepo_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherColumn;
    }
}

