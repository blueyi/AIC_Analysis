namespace AIC_ERROR_Analysis
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.aic_error = new System.Windows.Forms.TextBox();
            this.analisys_button = new System.Windows.Forms.Button();
            this.aic_error_label = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.res_bin1 = new System.Windows.Forms.Label();
            this.res_bin2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.powerd = new System.Windows.Forms.Label();
            this.hex_lable = new System.Windows.Forms.Label();
            this.tofp16_button = new System.Windows.Forms.Button();
            this.hex_txt = new System.Windows.Forms.TextBox();
            this.convert_res = new System.Windows.Forms.TextBox();
            this.tip1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tofp32_button = new System.Windows.Forms.Button();
            this.UpperBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aic_error
            // 
            this.aic_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aic_error.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.aic_error.Location = new System.Drawing.Point(100, 12);
            this.aic_error.Name = "aic_error";
            this.aic_error.Size = new System.Drawing.Size(184, 21);
            this.aic_error.TabIndex = 0;
            this.aic_error.Text = "0x800000";
            // 
            // analisys_button
            // 
            this.analisys_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.analisys_button.Location = new System.Drawing.Point(290, 11);
            this.analisys_button.Name = "analisys_button";
            this.analisys_button.Size = new System.Drawing.Size(75, 23);
            this.analisys_button.TabIndex = 1;
            this.analisys_button.Text = "Analysis";
            this.analisys_button.UseVisualStyleBackColor = true;
            this.analisys_button.Click += new System.EventHandler(this.analisys_button_Click);
            // 
            // aic_error_label
            // 
            this.aic_error_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aic_error_label.AutoSize = true;
            this.aic_error_label.BackColor = System.Drawing.Color.Transparent;
            this.aic_error_label.Location = new System.Drawing.Point(4, 16);
            this.aic_error_label.Name = "aic_error_label";
            this.aic_error_label.Size = new System.Drawing.Size(101, 12);
            this.aic_error_label.TabIndex = 2;
            this.aic_error_label.Text = "AIC ERROR Code：";
            // 
            // res
            // 
            this.res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.res.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res.Location = new System.Drawing.Point(12, 167);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.res.Size = new System.Drawing.Size(679, 223);
            this.res.TabIndex = 3;
            // 
            // res_bin1
            // 
            this.res_bin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.res_bin1.AutoSize = true;
            this.res_bin1.BackColor = System.Drawing.Color.Transparent;
            this.res_bin1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_bin1.ForeColor = System.Drawing.Color.Coral;
            this.res_bin1.Location = new System.Drawing.Point(3, 53);
            this.res_bin1.Name = "res_bin1";
            this.res_bin1.Size = new System.Drawing.Size(406, 25);
            this.res_bin1.TabIndex = 5;
            this.res_bin1.Text = "0000 0000 0000 0000 0000 0000 0000 0000";
            // 
            // res_bin2
            // 
            this.res_bin2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.res_bin2.AutoSize = true;
            this.res_bin2.BackColor = System.Drawing.Color.Transparent;
            this.res_bin2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_bin2.ForeColor = System.Drawing.Color.Coral;
            this.res_bin2.Location = new System.Drawing.Point(3, 98);
            this.res_bin2.Name = "res_bin2";
            this.res_bin2.Size = new System.Drawing.Size(406, 25);
            this.res_bin2.TabIndex = 5;
            this.res_bin2.Text = "0000 0000 0000 0000 0000 0000 0000 0000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "28        24          20        16         12          8           4           0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = " 60        56          52         48         44         40         36         32";
            // 
            // powerd
            // 
            this.powerd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerd.AutoSize = true;
            this.powerd.Location = new System.Drawing.Point(488, 398);
            this.powerd.Name = "powerd";
            this.powerd.Size = new System.Drawing.Size(197, 12);
            this.powerd.TabIndex = 6;
            this.powerd.Text = "Powered by Program Language Lab.";
            // 
            // hex_lable
            // 
            this.hex_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hex_lable.AutoSize = true;
            this.hex_lable.Location = new System.Drawing.Point(374, 16);
            this.hex_lable.Name = "hex_lable";
            this.hex_lable.Size = new System.Drawing.Size(35, 12);
            this.hex_lable.TabIndex = 9;
            this.hex_lable.Text = "HEX：";
            // 
            // tofp16_button
            // 
            this.tofp16_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tofp16_button.Location = new System.Drawing.Point(591, 11);
            this.tofp16_button.Name = "tofp16_button";
            this.tofp16_button.Size = new System.Drawing.Size(55, 23);
            this.tofp16_button.TabIndex = 8;
            this.tofp16_button.Text = "ToFP16";
            this.tofp16_button.UseVisualStyleBackColor = true;
            this.tofp16_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // hex_txt
            // 
            this.hex_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hex_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hex_txt.Location = new System.Drawing.Point(404, 12);
            this.hex_txt.Name = "hex_txt";
            this.hex_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hex_txt.Size = new System.Drawing.Size(184, 21);
            this.hex_txt.TabIndex = 7;
            this.hex_txt.Text = "0x04000001";
            // 
            // convert_res
            // 
            this.convert_res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convert_res.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.convert_res.Location = new System.Drawing.Point(417, 59);
            this.convert_res.Multiline = true;
            this.convert_res.Name = "convert_res";
            this.convert_res.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.convert_res.Size = new System.Drawing.Size(274, 87);
            this.convert_res.TabIndex = 10;
            // 
            // tip1
            // 
            this.tip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Font = new System.Drawing.Font("宋体", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.Location = new System.Drawing.Point(98, 37);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(110, 10);
            this.tip1.TabIndex = 2;
            this.tip1.Text = "Support: 0x0010, 0010";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(374, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 10);
            this.label3.TabIndex = 2;
            this.label3.Text = "Support: 0x0400, 0x04000x0001, 04000001, and more fp16";
            // 
            // tofp32_button
            // 
            this.tofp32_button.Location = new System.Drawing.Point(649, 11);
            this.tofp32_button.Name = "tofp32_button";
            this.tofp32_button.Size = new System.Drawing.Size(49, 23);
            this.tofp32_button.TabIndex = 11;
            this.tofp32_button.Text = "ToFP32";
            this.tofp32_button.UseVisualStyleBackColor = true;
            this.tofp32_button.Click += new System.EventHandler(this.tofp32_button_Click);
            // 
            // UpperBox
            // 
            this.UpperBox.AutoSize = true;
            this.UpperBox.Location = new System.Drawing.Point(653, 38);
            this.UpperBox.Name = "UpperBox";
            this.UpperBox.Size = new System.Drawing.Size(54, 16);
            this.UpperBox.TabIndex = 12;
            this.UpperBox.Text = "Upper";
            this.UpperBox.UseVisualStyleBackColor = true;
            this.UpperBox.CheckedChanged += new System.EventHandler(this.UpperBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.analisys_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 414);
            this.Controls.Add(this.UpperBox);
            this.Controls.Add(this.tofp32_button);
            this.Controls.Add(this.convert_res);
            this.Controls.Add(this.tofp16_button);
            this.Controls.Add(this.hex_txt);
            this.Controls.Add(this.powerd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.res_bin2);
            this.Controls.Add(this.res_bin1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.analisys_button);
            this.Controls.Add(this.aic_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.aic_error_label);
            this.Controls.Add(this.hex_lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AIC Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aic_error;
        private System.Windows.Forms.Button analisys_button;
        private System.Windows.Forms.Label aic_error_label;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label res_bin1;
        private System.Windows.Forms.Label res_bin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label powerd;
        private System.Windows.Forms.Label hex_lable;
        private System.Windows.Forms.Button tofp16_button;
        private System.Windows.Forms.TextBox hex_txt;
        private System.Windows.Forms.TextBox convert_res;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tofp32_button;
        private System.Windows.Forms.CheckBox UpperBox;
    }
}

