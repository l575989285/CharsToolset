﻿namespace PubControlLibrary {
    partial class SplitCharsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.分列设置容器 = new System.Windows.Forms.GroupBox();
            this.字符_textB = new System.Windows.Forms.RichTextBox();
            this.字符个数_textB = new System.Windows.Forms.TextBox();
            this.字符个数_rad = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.整个文本_rad = new System.Windows.Forms.RadioButton();
            this.单个行_rad = new System.Windows.Forms.RadioButton();
            this.字符_rad = new System.Windows.Forms.RadioButton();
            this.空格_chk = new System.Windows.Forms.CheckBox();
            this.冒号_chk = new System.Windows.Forms.CheckBox();
            this.分号_chk = new System.Windows.Forms.CheckBox();
            this.制表符_chk = new System.Windows.Forms.CheckBox();
            this.保留空列_chk = new System.Windows.Forms.CheckBox();
            this.分列_but = new System.Windows.Forms.Button();
            this.关闭_but = new System.Windows.Forms.Button();
            this.数据表格 = new System.Windows.Forms.DataGridView();
            this.选项区容器 = new System.Windows.Forms.GroupBox();
            this.不包含制表符_chk = new System.Windows.Forms.CheckBox();
            this.不区分大小写_chk = new System.Windows.Forms.CheckBox();
            this.操作区容器 = new System.Windows.Forms.GroupBox();
            this.分列设置容器.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数据表格)).BeginInit();
            this.选项区容器.SuspendLayout();
            this.操作区容器.SuspendLayout();
            this.SuspendLayout();
            // 
            // 分列设置容器
            // 
            this.分列设置容器.Controls.Add(this.字符_textB);
            this.分列设置容器.Controls.Add(this.字符个数_textB);
            this.分列设置容器.Controls.Add(this.字符个数_rad);
            this.分列设置容器.Controls.Add(this.groupBox1);
            this.分列设置容器.Controls.Add(this.字符_rad);
            this.分列设置容器.Controls.Add(this.空格_chk);
            this.分列设置容器.Controls.Add(this.冒号_chk);
            this.分列设置容器.Controls.Add(this.分号_chk);
            this.分列设置容器.Controls.Add(this.制表符_chk);
            this.分列设置容器.Location = new System.Drawing.Point(8, 4);
            this.分列设置容器.Name = "分列设置容器";
            this.分列设置容器.Size = new System.Drawing.Size(162, 289);
            this.分列设置容器.TabIndex = 0;
            this.分列设置容器.TabStop = false;
            this.分列设置容器.Text = "分列设置";
            // 
            // 字符_textB
            // 
            this.字符_textB.AcceptsTab = true;
            this.字符_textB.AutoWordSelection = true;
            this.字符_textB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.字符_textB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.字符_textB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.字符_textB.Location = new System.Drawing.Point(7, 104);
            this.字符_textB.Name = "字符_textB";
            this.字符_textB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.字符_textB.Size = new System.Drawing.Size(147, 63);
            this.字符_textB.TabIndex = 9;
            this.字符_textB.Text = "";
            this.字符_textB.TextChanged += new System.EventHandler(this.字符_textB_TextChanged);
            // 
            // 字符个数_textB
            // 
            this.字符个数_textB.Enabled = false;
            this.字符个数_textB.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.字符个数_textB.Location = new System.Drawing.Point(7, 195);
            this.字符个数_textB.Name = "字符个数_textB";
            this.字符个数_textB.Size = new System.Drawing.Size(147, 26);
            this.字符个数_textB.TabIndex = 8;
            // 
            // 字符个数_rad
            // 
            this.字符个数_rad.AutoSize = true;
            this.字符个数_rad.Location = new System.Drawing.Point(6, 173);
            this.字符个数_rad.Name = "字符个数_rad";
            this.字符个数_rad.Size = new System.Drawing.Size(83, 16);
            this.字符个数_rad.TabIndex = 7;
            this.字符个数_rad.TabStop = true;
            this.字符个数_rad.Text = "字符个数：";
            this.字符个数_rad.UseVisualStyleBackColor = true;
            this.字符个数_rad.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.整个文本_rad);
            this.groupBox1.Controls.Add(this.单个行_rad);
            this.groupBox1.Location = new System.Drawing.Point(0, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分列格式";
            // 
            // 整个文本_rad
            // 
            this.整个文本_rad.AutoSize = true;
            this.整个文本_rad.Location = new System.Drawing.Point(68, 22);
            this.整个文本_rad.Name = "整个文本_rad";
            this.整个文本_rad.Size = new System.Drawing.Size(71, 16);
            this.整个文本_rad.TabIndex = 1;
            this.整个文本_rad.Text = "整个文本";
            this.整个文本_rad.UseVisualStyleBackColor = true;
            this.整个文本_rad.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // 单个行_rad
            // 
            this.单个行_rad.AutoSize = true;
            this.单个行_rad.Checked = true;
            this.单个行_rad.Location = new System.Drawing.Point(8, 22);
            this.单个行_rad.Name = "单个行_rad";
            this.单个行_rad.Size = new System.Drawing.Size(59, 16);
            this.单个行_rad.TabIndex = 0;
            this.单个行_rad.TabStop = true;
            this.单个行_rad.Text = "单个行";
            this.单个行_rad.UseVisualStyleBackColor = true;
            this.单个行_rad.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // 字符_rad
            // 
            this.字符_rad.AutoSize = true;
            this.字符_rad.Checked = true;
            this.字符_rad.Location = new System.Drawing.Point(7, 82);
            this.字符_rad.Name = "字符_rad";
            this.字符_rad.Size = new System.Drawing.Size(59, 16);
            this.字符_rad.TabIndex = 6;
            this.字符_rad.TabStop = true;
            this.字符_rad.Text = "字符：";
            this.字符_rad.UseVisualStyleBackColor = true;
            this.字符_rad.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // 空格_chk
            // 
            this.空格_chk.AutoSize = true;
            this.空格_chk.Location = new System.Drawing.Point(79, 54);
            this.空格_chk.Name = "空格_chk";
            this.空格_chk.Size = new System.Drawing.Size(48, 16);
            this.空格_chk.TabIndex = 3;
            this.空格_chk.Text = "空格";
            this.空格_chk.UseVisualStyleBackColor = true;
            // 
            // 冒号_chk
            // 
            this.冒号_chk.AutoSize = true;
            this.冒号_chk.Location = new System.Drawing.Point(7, 54);
            this.冒号_chk.Name = "冒号_chk";
            this.冒号_chk.Size = new System.Drawing.Size(48, 16);
            this.冒号_chk.TabIndex = 2;
            this.冒号_chk.Text = "冒号";
            this.冒号_chk.UseVisualStyleBackColor = true;
            // 
            // 分号_chk
            // 
            this.分号_chk.AutoSize = true;
            this.分号_chk.Location = new System.Drawing.Point(79, 18);
            this.分号_chk.Name = "分号_chk";
            this.分号_chk.Size = new System.Drawing.Size(48, 16);
            this.分号_chk.TabIndex = 1;
            this.分号_chk.Text = "分号";
            this.分号_chk.UseVisualStyleBackColor = true;
            // 
            // 制表符_chk
            // 
            this.制表符_chk.AutoSize = true;
            this.制表符_chk.Location = new System.Drawing.Point(7, 20);
            this.制表符_chk.Name = "制表符_chk";
            this.制表符_chk.Size = new System.Drawing.Size(60, 16);
            this.制表符_chk.TabIndex = 0;
            this.制表符_chk.Text = "制表符";
            this.制表符_chk.UseVisualStyleBackColor = true;
            // 
            // 保留空列_chk
            // 
            this.保留空列_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.保留空列_chk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.保留空列_chk.Location = new System.Drawing.Point(8, 16);
            this.保留空列_chk.Name = "保留空列_chk";
            this.保留空列_chk.Size = new System.Drawing.Size(148, 25);
            this.保留空列_chk.TabIndex = 7;
            this.保留空列_chk.Text = "保留空列";
            this.保留空列_chk.UseVisualStyleBackColor = true;
            this.保留空列_chk.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // 分列_but
            // 
            this.分列_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(94)))), ((int)(((byte)(55)))));
            this.分列_but.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.分列_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(94)))), ((int)(((byte)(55)))));
            this.分列_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.分列_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.分列_but.ForeColor = System.Drawing.Color.White;
            this.分列_but.Location = new System.Drawing.Point(6, 18);
            this.分列_but.Name = "分列_but";
            this.分列_but.Size = new System.Drawing.Size(73, 27);
            this.分列_but.TabIndex = 8;
            this.分列_but.Text = "确认分列";
            this.分列_but.UseVisualStyleBackColor = false;
            this.分列_but.Click += new System.EventHandler(this.分列_but_Click);
            // 
            // 关闭_but
            // 
            this.关闭_but.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.关闭_but.Location = new System.Drawing.Point(14, 413);
            this.关闭_but.Name = "关闭_but";
            this.关闭_but.Size = new System.Drawing.Size(139, 30);
            this.关闭_but.TabIndex = 9;
            this.关闭_but.Text = "关闭窗口";
            this.关闭_but.UseVisualStyleBackColor = true;
            this.关闭_but.Click += new System.EventHandler(this.关闭_but_Click);
            // 
            // 数据表格
            // 
            this.数据表格.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.数据表格.BackgroundColor = System.Drawing.Color.White;
            this.数据表格.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(198)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.数据表格.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.数据表格.ColumnHeadersHeight = 28;
            this.数据表格.EnableHeadersVisualStyles = false;
            this.数据表格.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.数据表格.Location = new System.Drawing.Point(176, 60);
            this.数据表格.Name = "数据表格";
            this.数据表格.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(198)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.数据表格.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(198)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.数据表格.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.数据表格.RowTemplate.Height = 23;
            this.数据表格.Size = new System.Drawing.Size(510, 382);
            this.数据表格.TabIndex = 0;
            // 
            // 选项区容器
            // 
            this.选项区容器.Controls.Add(this.不包含制表符_chk);
            this.选项区容器.Controls.Add(this.不区分大小写_chk);
            this.选项区容器.Controls.Add(this.保留空列_chk);
            this.选项区容器.Location = new System.Drawing.Point(8, 299);
            this.选项区容器.Name = "选项区容器";
            this.选项区容器.Size = new System.Drawing.Size(162, 105);
            this.选项区容器.TabIndex = 13;
            this.选项区容器.TabStop = false;
            this.选项区容器.Text = "选项区";
            // 
            // 不包含制表符_chk
            // 
            this.不包含制表符_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.不包含制表符_chk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.不包含制表符_chk.Location = new System.Drawing.Point(8, 72);
            this.不包含制表符_chk.Name = "不包含制表符_chk";
            this.不包含制表符_chk.Size = new System.Drawing.Size(148, 25);
            this.不包含制表符_chk.TabIndex = 9;
            this.不包含制表符_chk.Text = "导出时不包含制表符";
            this.不包含制表符_chk.UseVisualStyleBackColor = true;
            this.不包含制表符_chk.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // 不区分大小写_chk
            // 
            this.不区分大小写_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.不区分大小写_chk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.不区分大小写_chk.Location = new System.Drawing.Point(8, 43);
            this.不区分大小写_chk.Name = "不区分大小写_chk";
            this.不区分大小写_chk.Size = new System.Drawing.Size(148, 25);
            this.不区分大小写_chk.TabIndex = 8;
            this.不区分大小写_chk.Text = "分隔符不区分大小写";
            this.不区分大小写_chk.UseVisualStyleBackColor = true;
            this.不区分大小写_chk.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // 操作区容器
            // 
            this.操作区容器.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.操作区容器.Controls.Add(this.分列_but);
            this.操作区容器.Location = new System.Drawing.Point(176, 4);
            this.操作区容器.Name = "操作区容器";
            this.操作区容器.Size = new System.Drawing.Size(510, 50);
            this.操作区容器.TabIndex = 14;
            this.操作区容器.TabStop = false;
            this.操作区容器.Text = "操作区";
            // 
            // SplitCharsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 447);
            this.Controls.Add(this.操作区容器);
            this.Controls.Add(this.关闭_but);
            this.Controls.Add(this.选项区容器);
            this.Controls.Add(this.数据表格);
            this.Controls.Add(this.分列设置容器);
            this.MinimizeBox = false;
            this.Name = "SplitCharsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "分列字符";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplitCharsForm_FormClosed);
            this.Load += new System.EventHandler(this.SplitOrAddChars_Load);
            this.分列设置容器.ResumeLayout(false);
            this.分列设置容器.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数据表格)).EndInit();
            this.选项区容器.ResumeLayout(false);
            this.操作区容器.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 分列设置容器;
        private System.Windows.Forms.CheckBox 制表符_chk;
        private System.Windows.Forms.CheckBox 分号_chk;
        private System.Windows.Forms.CheckBox 冒号_chk;
        private System.Windows.Forms.CheckBox 空格_chk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton 单个行_rad;
        private System.Windows.Forms.RadioButton 整个文本_rad;
        private System.Windows.Forms.CheckBox 保留空列_chk;
        private System.Windows.Forms.Button 分列_but;
        private System.Windows.Forms.Button 关闭_but;
        private System.Windows.Forms.DataGridView 数据表格;
        private System.Windows.Forms.GroupBox 选项区容器;
        private System.Windows.Forms.RadioButton 字符_rad;
        private System.Windows.Forms.RadioButton 字符个数_rad;
        private System.Windows.Forms.TextBox 字符个数_textB;
        private System.Windows.Forms.CheckBox 不区分大小写_chk;
        private System.Windows.Forms.RichTextBox 字符_textB;
        private System.Windows.Forms.GroupBox 操作区容器;
        private System.Windows.Forms.CheckBox 不包含制表符_chk;
    }
}