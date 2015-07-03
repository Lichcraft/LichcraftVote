namespace SampleSQLFileReader
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnwinner5 = new System.Windows.Forms.Button();
            this.btnwinner4 = new System.Windows.Forms.Button();
            this.btnwinner3 = new System.Windows.Forms.Button();
            this.btnwinner2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(323, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select File";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(128, 82);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(189, 20);
            this.txtbox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Winner 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(191, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Winner 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnwinner5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnwinner4);
            this.groupBox1.Controls.Add(this.btnwinner3);
            this.groupBox1.Controls.Add(this.btnwinner2);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Location = new System.Drawing.Point(3, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Winners";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Winner 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Winner 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Winner 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Winner 2";
            // 
            // btnwinner5
            // 
            this.btnwinner5.Location = new System.Drawing.Point(23, 213);
            this.btnwinner5.Name = "btnwinner5";
            this.btnwinner5.Size = new System.Drawing.Size(118, 23);
            this.btnwinner5.TabIndex = 8;
            this.btnwinner5.Text = "Winner 5";
            this.btnwinner5.UseVisualStyleBackColor = true;
            this.btnwinner5.Click += new System.EventHandler(this.btnwinner5_Click);
            // 
            // btnwinner4
            // 
            this.btnwinner4.Location = new System.Drawing.Point(23, 167);
            this.btnwinner4.Name = "btnwinner4";
            this.btnwinner4.Size = new System.Drawing.Size(118, 23);
            this.btnwinner4.TabIndex = 7;
            this.btnwinner4.Text = "Winner 4";
            this.btnwinner4.UseVisualStyleBackColor = true;
            this.btnwinner4.Click += new System.EventHandler(this.btnwinner4_Click);
            // 
            // btnwinner3
            // 
            this.btnwinner3.Location = new System.Drawing.Point(23, 118);
            this.btnwinner3.Name = "btnwinner3";
            this.btnwinner3.Size = new System.Drawing.Size(118, 23);
            this.btnwinner3.TabIndex = 6;
            this.btnwinner3.Text = "Winner 3";
            this.btnwinner3.UseVisualStyleBackColor = true;
            this.btnwinner3.Click += new System.EventHandler(this.btnwinner3_Click);
            // 
            // btnwinner2
            // 
            this.btnwinner2.Location = new System.Drawing.Point(23, 69);
            this.btnwinner2.Name = "btnwinner2";
            this.btnwinner2.Size = new System.Drawing.Size(118, 23);
            this.btnwinner2.TabIndex = 5;
            this.btnwinner2.Text = "Winner 2";
            this.btnwinner2.UseVisualStyleBackColor = true;
            this.btnwinner2.Click += new System.EventHandler(this.btnwinner2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(711, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "www.lichcraft.com/vote";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "www.lichcraft.com/vote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnwinner5;
        private System.Windows.Forms.Button btnwinner4;
        private System.Windows.Forms.Button btnwinner3;
        private System.Windows.Forms.Button btnwinner2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

