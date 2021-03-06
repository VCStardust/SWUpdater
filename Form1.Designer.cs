﻿
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LogtextBox = new System.Windows.Forms.TextBox();
            this.Operate_groupBox = new System.Windows.Forms.GroupBox();
            this.UpdMethod_comboBox = new System.Windows.Forms.ComboBox();
            this.UpdMethod_label = new System.Windows.Forms.Label();
            this.DelApp_button = new System.Windows.Forms.Button();
            this.InstallPath_label = new System.Windows.Forms.Label();
            this.UpdateTime_label = new System.Windows.Forms.Label();
            this.LocalVer_label = new System.Windows.Forms.Label();
            this.AppName_label = new System.Windows.Forms.Label();
            this.VerSelect_comboBox = new System.Windows.Forms.ComboBox();
            this.VerSelect_label = new System.Windows.Forms.Label();
            this.ExpLocal_button = new System.Windows.Forms.Button();
            this.ExpRepo_button = new System.Windows.Forms.Button();
            this.UpdateC_button = new System.Windows.Forms.Button();
            this.UpdateAll_button = new System.Windows.Forms.Button();
            this.AddApp_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).BeginInit();
            this.Operate_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PdataGridView
            // 
            this.PdataGridView.AllowUserToAddRows = false;
            this.PdataGridView.AllowUserToResizeRows = false;
            this.PdataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LVerColumn,
            this.RVerColumn,
            this.LPathColumn,
            this.URLColumn});
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
            this.LPathColumn.Width = 382;
            // 
            // URLColumn
            // 
            this.URLColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.URLColumn.HeaderText = "Repo地址";
            this.URLColumn.Name = "URLColumn";
            this.URLColumn.Width = 225;
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
            this.Operate_groupBox.Controls.Add(this.UpdMethod_comboBox);
            this.Operate_groupBox.Controls.Add(this.UpdMethod_label);
            this.Operate_groupBox.Controls.Add(this.DelApp_button);
            this.Operate_groupBox.Controls.Add(this.InstallPath_label);
            this.Operate_groupBox.Controls.Add(this.UpdateTime_label);
            this.Operate_groupBox.Controls.Add(this.LocalVer_label);
            this.Operate_groupBox.Controls.Add(this.AppName_label);
            this.Operate_groupBox.Controls.Add(this.VerSelect_comboBox);
            this.Operate_groupBox.Controls.Add(this.VerSelect_label);
            this.Operate_groupBox.Controls.Add(this.ExpLocal_button);
            this.Operate_groupBox.Controls.Add(this.ExpRepo_button);
            this.Operate_groupBox.Controls.Add(this.UpdateC_button);
            this.Operate_groupBox.Location = new System.Drawing.Point(1042, 12);
            this.Operate_groupBox.Name = "Operate_groupBox";
            this.Operate_groupBox.Size = new System.Drawing.Size(296, 428);
            this.Operate_groupBox.TabIndex = 3;
            this.Operate_groupBox.TabStop = false;
            this.Operate_groupBox.Text = "信息";
            // 
            // UpdMethod_comboBox
            // 
            this.UpdMethod_comboBox.Enabled = false;
            this.UpdMethod_comboBox.FormattingEnabled = true;
            this.UpdMethod_comboBox.Items.AddRange(new object[] {
            "覆盖并追加",
            "删除重建(完全)",
            "仅保留数据"});
            this.UpdMethod_comboBox.Location = new System.Drawing.Point(80, 213);
            this.UpdMethod_comboBox.Name = "UpdMethod_comboBox";
            this.UpdMethod_comboBox.Size = new System.Drawing.Size(121, 25);
            this.UpdMethod_comboBox.TabIndex = 12;
            // 
            // UpdMethod_label
            // 
            this.UpdMethod_label.AutoSize = true;
            this.UpdMethod_label.Location = new System.Drawing.Point(6, 216);
            this.UpdMethod_label.Name = "UpdMethod_label";
            this.UpdMethod_label.Size = new System.Drawing.Size(68, 17);
            this.UpdMethod_label.TabIndex = 11;
            this.UpdMethod_label.Text = "更新方式：";
            // 
            // DelApp_button
            // 
            this.DelApp_button.Enabled = false;
            this.DelApp_button.Location = new System.Drawing.Point(163, 360);
            this.DelApp_button.Name = "DelApp_button";
            this.DelApp_button.Size = new System.Drawing.Size(127, 28);
            this.DelApp_button.TabIndex = 10;
            this.DelApp_button.Text = "从列表中删除";
            this.DelApp_button.UseVisualStyleBackColor = true;
            // 
            // InstallPath_label
            // 
            this.InstallPath_label.AutoSize = true;
            this.InstallPath_label.Location = new System.Drawing.Point(6, 66);
            this.InstallPath_label.Name = "InstallPath_label";
            this.InstallPath_label.Size = new System.Drawing.Size(68, 17);
            this.InstallPath_label.TabIndex = 9;
            this.InstallPath_label.Text = "安装路径：";
            // 
            // UpdateTime_label
            // 
            this.UpdateTime_label.AutoSize = true;
            this.UpdateTime_label.Location = new System.Drawing.Point(6, 83);
            this.UpdateTime_label.Name = "UpdateTime_label";
            this.UpdateTime_label.Size = new System.Drawing.Size(68, 17);
            this.UpdateTime_label.TabIndex = 8;
            this.UpdateTime_label.Text = "更新日期：";
            // 
            // LocalVer_label
            // 
            this.LocalVer_label.AutoSize = true;
            this.LocalVer_label.Location = new System.Drawing.Point(6, 49);
            this.LocalVer_label.Name = "LocalVer_label";
            this.LocalVer_label.Size = new System.Drawing.Size(68, 17);
            this.LocalVer_label.TabIndex = 7;
            this.LocalVer_label.Text = "本地版本：";
            // 
            // AppName_label
            // 
            this.AppName_label.AutoSize = true;
            this.AppName_label.Location = new System.Drawing.Point(18, 32);
            this.AppName_label.Name = "AppName_label";
            this.AppName_label.Size = new System.Drawing.Size(56, 17);
            this.AppName_label.TabIndex = 6;
            this.AppName_label.Text = "程序名：";
            // 
            // VerSelect_comboBox
            // 
            this.VerSelect_comboBox.Enabled = false;
            this.VerSelect_comboBox.FormattingEnabled = true;
            this.VerSelect_comboBox.Location = new System.Drawing.Point(80, 182);
            this.VerSelect_comboBox.Name = "VerSelect_comboBox";
            this.VerSelect_comboBox.Size = new System.Drawing.Size(121, 25);
            this.VerSelect_comboBox.TabIndex = 5;
            // 
            // VerSelect_label
            // 
            this.VerSelect_label.AutoSize = true;
            this.VerSelect_label.Location = new System.Drawing.Point(18, 185);
            this.VerSelect_label.Name = "VerSelect_label";
            this.VerSelect_label.Size = new System.Drawing.Size(56, 17);
            this.VerSelect_label.TabIndex = 4;
            this.VerSelect_label.Text = "更新至：";
            // 
            // ExpLocal_button
            // 
            this.ExpLocal_button.Enabled = false;
            this.ExpLocal_button.Location = new System.Drawing.Point(6, 326);
            this.ExpLocal_button.Name = "ExpLocal_button";
            this.ExpLocal_button.Size = new System.Drawing.Size(127, 28);
            this.ExpLocal_button.TabIndex = 3;
            this.ExpLocal_button.Text = "浏览程序目录";
            this.ExpLocal_button.UseVisualStyleBackColor = true;
            // 
            // ExpRepo_button
            // 
            this.ExpRepo_button.Enabled = false;
            this.ExpRepo_button.Location = new System.Drawing.Point(6, 394);
            this.ExpRepo_button.Name = "ExpRepo_button";
            this.ExpRepo_button.Size = new System.Drawing.Size(127, 28);
            this.ExpRepo_button.TabIndex = 2;
            this.ExpRepo_button.Text = "访问Repo";
            this.ExpRepo_button.UseVisualStyleBackColor = true;
            // 
            // UpdateC_button
            // 
            this.UpdateC_button.Enabled = false;
            this.UpdateC_button.Location = new System.Drawing.Point(6, 360);
            this.UpdateC_button.Name = "UpdateC_button";
            this.UpdateC_button.Size = new System.Drawing.Size(127, 28);
            this.UpdateC_button.TabIndex = 0;
            this.UpdateC_button.Text = "更新当前程序";
            this.UpdateC_button.UseVisualStyleBackColor = true;
            // 
            // UpdateAll_button
            // 
            this.UpdateAll_button.Location = new System.Drawing.Point(1205, 444);
            this.UpdateAll_button.Name = "UpdateAll_button";
            this.UpdateAll_button.Size = new System.Drawing.Size(127, 28);
            this.UpdateAll_button.TabIndex = 1;
            this.UpdateAll_button.Text = "更新所有程序";
            this.UpdateAll_button.UseVisualStyleBackColor = true;
            // 
            // AddApp_button
            // 
            this.AddApp_button.Location = new System.Drawing.Point(1048, 446);
            this.AddApp_button.Name = "AddApp_button";
            this.AddApp_button.Size = new System.Drawing.Size(127, 26);
            this.AddApp_button.TabIndex = 5;
            this.AddApp_button.Text = "添加程序";
            this.AddApp_button.UseVisualStyleBackColor = true;
            this.AddApp_button.Click += new System.EventHandler(this.AddApp_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.AddApp_button);
            this.Controls.Add(this.LogtextBox);
            this.Controls.Add(this.Operate_groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PdataGridView);
            this.Controls.Add(this.UpdateAll_button);
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
        private System.Windows.Forms.ComboBox VerSelect_comboBox;
        private System.Windows.Forms.Label VerSelect_label;
        private System.Windows.Forms.Label UpdateTime_label;
        private System.Windows.Forms.Label LocalVer_label;
        private System.Windows.Forms.Label AppName_label;
        private System.Windows.Forms.Label InstallPath_label;
        private System.Windows.Forms.Button DelApp_button;
        private System.Windows.Forms.Button AddApp_button;
        private System.Windows.Forms.ComboBox UpdMethod_comboBox;
        private System.Windows.Forms.Label UpdMethod_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RVerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLColumn;
    }
}

