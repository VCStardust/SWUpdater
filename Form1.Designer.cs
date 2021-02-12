
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
            this.LogtextBox = new System.Windows.Forms.TextBox();
            this.Operate_groupBox = new System.Windows.Forms.GroupBox();
            this.ExpLocal_button = new System.Windows.Forms.Button();
            this.ExpRepo_button = new System.Windows.Forms.Button();
            this.UpdateAll_button = new System.Windows.Forms.Button();
            this.UpdateC_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VerSelect_comboBox = new System.Windows.Forms.ComboBox();
            this.AppName_label = new System.Windows.Forms.Label();
            this.LocalVer_label = new System.Windows.Forms.Label();
            this.UpdateTime_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).BeginInit();
            this.Operate_groupBox.SuspendLayout();
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
            // LogtextBox
            // 
            this.LogtextBox.Location = new System.Drawing.Point(1042, 480);
            this.LogtextBox.Multiline = true;
            this.LogtextBox.Name = "LogtextBox";
            this.LogtextBox.Size = new System.Drawing.Size(296, 216);
            this.LogtextBox.TabIndex = 4;
            // 
            // Operate_groupBox
            // 
            this.Operate_groupBox.Controls.Add(this.UpdateTime_label);
            this.Operate_groupBox.Controls.Add(this.LocalVer_label);
            this.Operate_groupBox.Controls.Add(this.AppName_label);
            this.Operate_groupBox.Controls.Add(this.VerSelect_comboBox);
            this.Operate_groupBox.Controls.Add(this.label1);
            this.Operate_groupBox.Controls.Add(this.ExpLocal_button);
            this.Operate_groupBox.Controls.Add(this.ExpRepo_button);
            this.Operate_groupBox.Controls.Add(this.UpdateAll_button);
            this.Operate_groupBox.Controls.Add(this.UpdateC_button);
            this.Operate_groupBox.Location = new System.Drawing.Point(1042, 12);
            this.Operate_groupBox.Name = "Operate_groupBox";
            this.Operate_groupBox.Size = new System.Drawing.Size(296, 462);
            this.Operate_groupBox.TabIndex = 3;
            this.Operate_groupBox.TabStop = false;
            this.Operate_groupBox.Text = "信息";
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
            // UpdateAll_button
            // 
            this.UpdateAll_button.Location = new System.Drawing.Point(163, 360);
            this.UpdateAll_button.Name = "UpdateAll_button";
            this.UpdateAll_button.Size = new System.Drawing.Size(127, 28);
            this.UpdateAll_button.TabIndex = 1;
            this.UpdateAll_button.Text = "更新所有程序";
            this.UpdateAll_button.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "更新至";
            // 
            // VerSelect_comboBox
            // 
            this.VerSelect_comboBox.FormattingEnabled = true;
            this.VerSelect_comboBox.Location = new System.Drawing.Point(56, 246);
            this.VerSelect_comboBox.Name = "VerSelect_comboBox";
            this.VerSelect_comboBox.Size = new System.Drawing.Size(121, 25);
            this.VerSelect_comboBox.TabIndex = 5;
            // 
            // AppName_label
            // 
            this.AppName_label.AutoSize = true;
            this.AppName_label.Location = new System.Drawing.Point(43, 32);
            this.AppName_label.Name = "AppName_label";
            this.AppName_label.Size = new System.Drawing.Size(56, 17);
            this.AppName_label.TabIndex = 6;
            this.AppName_label.Text = "程序名：";
            // 
            // LocalVer_label
            // 
            this.LocalVer_label.AutoSize = true;
            this.LocalVer_label.Location = new System.Drawing.Point(7, 49);
            this.LocalVer_label.Name = "LocalVer_label";
            this.LocalVer_label.Size = new System.Drawing.Size(92, 17);
            this.LocalVer_label.TabIndex = 7;
            this.LocalVer_label.Text = "当前本地版本：";
            // 
            // UpdateTime_label
            // 
            this.UpdateTime_label.AutoSize = true;
            this.UpdateTime_label.Location = new System.Drawing.Point(31, 66);
            this.UpdateTime_label.Name = "UpdateTime_label";
            this.UpdateTime_label.Size = new System.Drawing.Size(68, 17);
            this.UpdateTime_label.TabIndex = 8;
            this.UpdateTime_label.Text = "更新日期：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LogtextBox);
            this.Controls.Add(this.Operate_groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PdataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Updater";
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).EndInit();
            this.Operate_groupBox.ResumeLayout(false);
            this.Operate_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PdataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox LogtextBox;
        private System.Windows.Forms.GroupBox Operate_groupBox;
        private System.Windows.Forms.Button UpdateAll_button;
        private System.Windows.Forms.Button UpdateC_button;
        private System.Windows.Forms.Button ExpLocal_button;
        private System.Windows.Forms.Button ExpRepo_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherColumn;
        private System.Windows.Forms.ComboBox VerSelect_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateTime_label;
        private System.Windows.Forms.Label LocalVer_label;
        private System.Windows.Forms.Label AppName_label;
    }
}

