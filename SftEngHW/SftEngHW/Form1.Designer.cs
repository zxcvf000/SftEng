namespace SftEngHW
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtyun = new System.Windows.Forms.TextBox();
            this.txtold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.txted = new System.Windows.Forms.TextBox();
            this.chyun = new System.Windows.Forms.CheckBox();
            this.chth = new System.Windows.Forms.CheckBox();
            this.chten = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時間";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(233, 54);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(165, 31);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "假日及晚上";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(38, 54);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(138, 31);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "平日中午";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chten);
            this.groupBox2.Controls.Add(this.chth);
            this.groupBox2.Controls.Add(this.chyun);
            this.groupBox2.Controls.Add(this.txtyun);
            this.groupBox2.Controls.Add(this.txtold);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "人數";
            // 
            // txtyun
            // 
            this.txtyun.Location = new System.Drawing.Point(110, 120);
            this.txtyun.Name = "txtyun";
            this.txtyun.Size = new System.Drawing.Size(66, 40);
            this.txtyun.TabIndex = 3;
            this.txtyun.Text = "0";
            // 
            // txtold
            // 
            this.txtold.Location = new System.Drawing.Point(110, 49);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(66, 40);
            this.txtold.TabIndex = 2;
            this.txtold.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "小孩";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "大人";
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsend.Location = new System.Drawing.Point(42, 355);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(130, 60);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "送出";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txted
            // 
            this.txted.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txted.Location = new System.Drawing.Point(246, 355);
            this.txted.Name = "txted";
            this.txted.Size = new System.Drawing.Size(192, 40);
            this.txted.TabIndex = 3;
            // 
            // chyun
            // 
            this.chyun.AutoSize = true;
            this.chyun.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chyun.Location = new System.Drawing.Point(302, 87);
            this.chyun.Name = "chyun";
            this.chyun.Size = new System.Drawing.Size(123, 23);
            this.chyun.TabIndex = 6;
            this.chyun.Text = "是否為小孩";
            this.chyun.UseVisualStyleBackColor = true;
            // 
            // chth
            // 
            this.chth.AutoSize = true;
            this.chth.Location = new System.Drawing.Point(233, 50);
            this.chth.Name = "chth";
            this.chth.Size = new System.Drawing.Size(193, 31);
            this.chth.TabIndex = 7;
            this.chth.Text = "三人同行優惠";
            this.chth.UseVisualStyleBackColor = true;
            // 
            // chten
            // 
            this.chten.AutoSize = true;
            this.chten.Location = new System.Drawing.Point(233, 121);
            this.chten.Name = "chten";
            this.chten.Size = new System.Drawing.Size(193, 31);
            this.chten.TabIndex = 8;
            this.chten.Text = "十人以上優惠";
            this.chten.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.txted);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SftEng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtyun;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txted;
        private System.Windows.Forms.CheckBox chyun;
        private System.Windows.Forms.CheckBox chth;
        private System.Windows.Forms.CheckBox chten;
    }
}

