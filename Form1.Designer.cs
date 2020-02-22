namespace AIC_ERROR_Analysis
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // aic_error
            // 
            this.aic_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aic_error.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.aic_error.Location = new System.Drawing.Point(271, 16);
            this.aic_error.Name = "aic_error";
            this.aic_error.Size = new System.Drawing.Size(166, 21);
            this.aic_error.TabIndex = 0;
            // 
            // analisys_button
            // 
            this.analisys_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.analisys_button.Location = new System.Drawing.Point(443, 15);
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
            this.aic_error_label.Location = new System.Drawing.Point(157, 20);
            this.aic_error_label.Name = "aic_error_label";
            this.aic_error_label.Size = new System.Drawing.Size(113, 12);
            this.aic_error_label.TabIndex = 2;
            this.aic_error_label.Text = "AIC ERROR Code: 0X";
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
            this.res_bin1.Location = new System.Drawing.Point(156, 56);
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
            this.res_bin2.Location = new System.Drawing.Point(156, 101);
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
            this.label2.Location = new System.Drawing.Point(192, 126);
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
            this.label1.Location = new System.Drawing.Point(188, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = " 60        56          52         48         44         40         36         32";
            // 
            // powerd
            // 
            this.powerd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerd.AutoSize = true;
            this.powerd.Location = new System.Drawing.Point(500, 398);
            this.powerd.Name = "powerd";
            this.powerd.Size = new System.Drawing.Size(197, 12);
            this.powerd.TabIndex = 6;
            this.powerd.Text = "Powered by Program Language Lab.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 414);
            this.Controls.Add(this.powerd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.res_bin2);
            this.Controls.Add(this.res_bin1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.aic_error_label);
            this.Controls.Add(this.analisys_button);
            this.Controls.Add(this.aic_error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIC ERROR Analysis";
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
    }
}

