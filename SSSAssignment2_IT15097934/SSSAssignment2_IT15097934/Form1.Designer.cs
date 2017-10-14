namespace SSSAssignment2_IT15097934
{
    partial class frm_encDec
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
            this.txt_enc_writeText = new System.Windows.Forms.TextBox();
            this.txt_dec_writeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_enc_pub = new System.Windows.Forms.RadioButton();
            this.rb_enc_pri = new System.Windows.Forms.RadioButton();
            this.rb_dec_pri = new System.Windows.Forms.RadioButton();
            this.rb_dec_pub = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enc_Ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_enc_output = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dec_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dec_output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_enc_writeText
            // 
            this.txt_enc_writeText.Location = new System.Drawing.Point(129, 30);
            this.txt_enc_writeText.Multiline = true;
            this.txt_enc_writeText.Name = "txt_enc_writeText";
            this.txt_enc_writeText.Size = new System.Drawing.Size(320, 41);
            this.txt_enc_writeText.TabIndex = 0;
            // 
            // txt_dec_writeText
            // 
            this.txt_dec_writeText.Location = new System.Drawing.Point(129, 21);
            this.txt_dec_writeText.Multiline = true;
            this.txt_dec_writeText.Name = "txt_dec_writeText";
            this.txt_dec_writeText.Size = new System.Drawing.Size(320, 42);
            this.txt_dec_writeText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted Text:";
            // 
            // rb_enc_pub
            // 
            this.rb_enc_pub.AutoSize = true;
            this.rb_enc_pub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_enc_pub.Location = new System.Drawing.Point(138, 89);
            this.rb_enc_pub.Name = "rb_enc_pub";
            this.rb_enc_pub.Size = new System.Drawing.Size(89, 20);
            this.rb_enc_pub.TabIndex = 5;
            this.rb_enc_pub.TabStop = true;
            this.rb_enc_pub.Text = "Public Key";
            this.rb_enc_pub.UseVisualStyleBackColor = true;
            // 
            // rb_enc_pri
            // 
            this.rb_enc_pri.AutoSize = true;
            this.rb_enc_pri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_enc_pri.Location = new System.Drawing.Point(282, 89);
            this.rb_enc_pri.Name = "rb_enc_pri";
            this.rb_enc_pri.Size = new System.Drawing.Size(94, 20);
            this.rb_enc_pri.TabIndex = 6;
            this.rb_enc_pri.TabStop = true;
            this.rb_enc_pri.Text = "Private Key";
            this.rb_enc_pri.UseVisualStyleBackColor = true;
            // 
            // rb_dec_pri
            // 
            this.rb_dec_pri.AutoSize = true;
            this.rb_dec_pri.Location = new System.Drawing.Point(282, 72);
            this.rb_dec_pri.Name = "rb_dec_pri";
            this.rb_dec_pri.Size = new System.Drawing.Size(94, 20);
            this.rb_dec_pri.TabIndex = 8;
            this.rb_dec_pri.TabStop = true;
            this.rb_dec_pri.Text = "Private Key";
            this.rb_dec_pri.UseVisualStyleBackColor = true;
            // 
            // rb_dec_pub
            // 
            this.rb_dec_pub.AutoSize = true;
            this.rb_dec_pub.Location = new System.Drawing.Point(138, 74);
            this.rb_dec_pub.Name = "rb_dec_pub";
            this.rb_dec_pub.Size = new System.Drawing.Size(89, 20);
            this.rb_dec_pub.TabIndex = 7;
            this.rb_dec_pub.TabStop = true;
            this.rb_dec_pub.Text = "Public Key";
            this.rb_dec_pub.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enc_Ok);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_enc_output);
            this.groupBox1.Controls.Add(this.txt_enc_writeText);
            this.groupBox1.Controls.Add(this.rb_enc_pub);
            this.groupBox1.Controls.Add(this.rb_enc_pri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encription";
            // 
            // btn_enc_Ok
            // 
            this.btn_enc_Ok.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_enc_Ok.Location = new System.Drawing.Point(325, 124);
            this.btn_enc_Ok.Name = "btn_enc_Ok";
            this.btn_enc_Ok.Size = new System.Drawing.Size(124, 38);
            this.btn_enc_Ok.TabIndex = 1;
            this.btn_enc_Ok.Text = "OK";
            this.btn_enc_Ok.UseVisualStyleBackColor = false;
            this.btn_enc_Ok.Click += new System.EventHandler(this.btn_enc_Ok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Encrypted Using:";
            // 
            // txt_enc_output
            // 
            this.txt_enc_output.Location = new System.Drawing.Point(571, 29);
            this.txt_enc_output.Multiline = true;
            this.txt_enc_output.Name = "txt_enc_output";
            this.txt_enc_output.Size = new System.Drawing.Size(265, 155);
            this.txt_enc_output.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dec_OK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_dec_output);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rb_dec_pri);
            this.groupBox2.Controls.Add(this.txt_dec_writeText);
            this.groupBox2.Controls.Add(this.rb_dec_pub);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 185);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decription";
            // 
            // btn_dec_OK
            // 
            this.btn_dec_OK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_dec_OK.Location = new System.Drawing.Point(325, 115);
            this.btn_dec_OK.Name = "btn_dec_OK";
            this.btn_dec_OK.Size = new System.Drawing.Size(124, 38);
            this.btn_dec_OK.TabIndex = 9;
            this.btn_dec_OK.Text = "OK";
            this.btn_dec_OK.UseVisualStyleBackColor = false;
            this.btn_dec_OK.Click += new System.EventHandler(this.btn_dec_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Encrypted Using:";
            // 
            // txt_dec_output
            // 
            this.txt_dec_output.Location = new System.Drawing.Point(571, 24);
            this.txt_dec_output.Multiline = true;
            this.txt_dec_output.Name = "txt_dec_output";
            this.txt_dec_output.Size = new System.Drawing.Size(265, 146);
            this.txt_dec_output.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Decrypted Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Text:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_generate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(881, 96);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate a key pair";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_generate.Location = new System.Drawing.Point(138, 38);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(168, 38);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(221, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(482, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Asymmetric Encryption/ Decription ";
            // 
            // frm_encDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(905, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_encDec";
            this.Text = "Asymmetric Encryption Decription";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_enc_writeText;
        private System.Windows.Forms.TextBox txt_dec_writeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_enc_pub;
        private System.Windows.Forms.RadioButton rb_enc_pri;
        private System.Windows.Forms.RadioButton rb_dec_pri;
        private System.Windows.Forms.RadioButton rb_dec_pub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_enc_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dec_output;
        private System.Windows.Forms.Button btn_enc_Ok;
        private System.Windows.Forms.Button btn_dec_OK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label7;
    }
}

