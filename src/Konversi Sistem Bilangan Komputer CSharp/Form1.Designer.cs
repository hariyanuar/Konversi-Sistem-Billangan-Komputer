namespace Konversi_Sistem_Bilangan_Komputer_CSharp
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
            this.result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hex_result = new System.Windows.Forms.Label();
            this.bin_result = new System.Windows.Forms.Label();
            this.oct_result = new System.Windows.Forms.Label();
            this.dec_result = new System.Windows.Forms.Label();
            this.dec_button = new System.Windows.Forms.Button();
            this.oct_button = new System.Windows.Forms.Button();
            this.bin_button = new System.Windows.Forms.Button();
            this.hex_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttonf = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.buttone = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(0, 16);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(364, 97);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hex_result);
            this.groupBox1.Controls.Add(this.bin_result);
            this.groupBox1.Controls.Add(this.oct_result);
            this.groupBox1.Controls.Add(this.dec_result);
            this.groupBox1.Controls.Add(this.dec_button);
            this.groupBox1.Controls.Add(this.oct_button);
            this.groupBox1.Controls.Add(this.bin_button);
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.hex_button);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-3, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // hex_result
            // 
            this.hex_result.BackColor = System.Drawing.Color.Transparent;
            this.hex_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hex_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_result.Location = new System.Drawing.Point(54, 113);
            this.hex_result.Name = "hex_result";
            this.hex_result.Size = new System.Drawing.Size(301, 26);
            this.hex_result.TabIndex = 5;
            this.hex_result.Text = "0";
            this.hex_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bin_result
            // 
            this.bin_result.BackColor = System.Drawing.Color.Transparent;
            this.bin_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bin_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin_result.Location = new System.Drawing.Point(54, 194);
            this.bin_result.Name = "bin_result";
            this.bin_result.Size = new System.Drawing.Size(301, 26);
            this.bin_result.TabIndex = 8;
            this.bin_result.Text = "0";
            this.bin_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oct_result
            // 
            this.oct_result.BackColor = System.Drawing.Color.Transparent;
            this.oct_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oct_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_result.Location = new System.Drawing.Point(54, 167);
            this.oct_result.Name = "oct_result";
            this.oct_result.Size = new System.Drawing.Size(301, 26);
            this.oct_result.TabIndex = 7;
            this.oct_result.Text = "0";
            this.oct_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dec_result
            // 
            this.dec_result.BackColor = System.Drawing.Color.Transparent;
            this.dec_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_result.Location = new System.Drawing.Point(54, 140);
            this.dec_result.Name = "dec_result";
            this.dec_result.Size = new System.Drawing.Size(301, 26);
            this.dec_result.TabIndex = 6;
            this.dec_result.Text = "0";
            this.dec_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dec_button
            // 
            this.dec_button.FlatAppearance.BorderSize = 0;
            this.dec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_button.Location = new System.Drawing.Point(9, 140);
            this.dec_button.Margin = new System.Windows.Forms.Padding(0);
            this.dec_button.Name = "dec_button";
            this.dec_button.Size = new System.Drawing.Size(346, 26);
            this.dec_button.TabIndex = 4;
            this.dec_button.Text = "DEC";
            this.dec_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dec_button.UseVisualStyleBackColor = true;
            this.dec_button.Click += new System.EventHandler(this.dec_button_Click);
            // 
            // oct_button
            // 
            this.oct_button.FlatAppearance.BorderSize = 0;
            this.oct_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_button.Location = new System.Drawing.Point(9, 167);
            this.oct_button.Margin = new System.Windows.Forms.Padding(0);
            this.oct_button.Name = "oct_button";
            this.oct_button.Size = new System.Drawing.Size(346, 26);
            this.oct_button.TabIndex = 3;
            this.oct_button.Text = "OCT";
            this.oct_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oct_button.UseVisualStyleBackColor = true;
            this.oct_button.Click += new System.EventHandler(this.oct_button_Click);
            // 
            // bin_button
            // 
            this.bin_button.FlatAppearance.BorderSize = 0;
            this.bin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin_button.Location = new System.Drawing.Point(9, 194);
            this.bin_button.Margin = new System.Windows.Forms.Padding(0);
            this.bin_button.Name = "bin_button";
            this.bin_button.Size = new System.Drawing.Size(346, 26);
            this.bin_button.TabIndex = 2;
            this.bin_button.Text = "BIN";
            this.bin_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bin_button.UseVisualStyleBackColor = true;
            this.bin_button.Click += new System.EventHandler(this.bin_button_Click);
            // 
            // hex_button
            // 
            this.hex_button.BackColor = System.Drawing.Color.Transparent;
            this.hex_button.FlatAppearance.BorderSize = 0;
            this.hex_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hex_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_button.Location = new System.Drawing.Point(9, 113);
            this.hex_button.Margin = new System.Windows.Forms.Padding(0);
            this.hex_button.Name = "hex_button";
            this.hex_button.Size = new System.Drawing.Size(346, 26);
            this.hex_button.TabIndex = 1;
            this.hex_button.Text = "HEX";
            this.hex_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hex_button.UseVisualStyleBackColor = false;
            this.hex_button.Click += new System.EventHandler(this.hex_button_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(213, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(275, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(151, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(213, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(275, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 47);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(151, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 47);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(213, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 47);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(275, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 47);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Location = new System.Drawing.Point(213, 388);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 47);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttona
            // 
            this.buttona.Enabled = false;
            this.buttona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttona.Location = new System.Drawing.Point(27, 229);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(56, 47);
            this.buttona.TabIndex = 19;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Enabled = false;
            this.buttonb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonb.Location = new System.Drawing.Point(89, 229);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(56, 47);
            this.buttonb.TabIndex = 20;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttonc
            // 
            this.buttonc.Enabled = false;
            this.buttonc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonc.Location = new System.Drawing.Point(27, 282);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(56, 47);
            this.buttonc.TabIndex = 21;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttonf
            // 
            this.buttonf.Enabled = false;
            this.buttonf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonf.Location = new System.Drawing.Point(89, 335);
            this.buttonf.Name = "buttonf";
            this.buttonf.Size = new System.Drawing.Size(56, 47);
            this.buttonf.TabIndex = 22;
            this.buttonf.Text = "F";
            this.buttonf.UseVisualStyleBackColor = true;
            this.buttonf.Click += new System.EventHandler(this.buttonf_Click);
            // 
            // buttond
            // 
            this.buttond.Enabled = false;
            this.buttond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttond.Location = new System.Drawing.Point(89, 282);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(56, 47);
            this.buttond.TabIndex = 23;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // buttone
            // 
            this.buttone.Enabled = false;
            this.buttone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttone.Location = new System.Drawing.Point(27, 335);
            this.buttone.Name = "buttone";
            this.buttone.Size = new System.Drawing.Size(56, 47);
            this.buttone.TabIndex = 24;
            this.buttone.Text = "E";
            this.buttone.UseVisualStyleBackColor = true;
            this.buttone.Click += new System.EventHandler(this.buttone_Click);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(275, 388);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(56, 47);
            this.delete.TabIndex = 25;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(27, 388);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 47);
            this.clear.TabIndex = 28;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-3, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 263);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 468);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.buttone);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonf);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Konversi Sistem Bilangan Komputer";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hex_button;
        private System.Windows.Forms.Button dec_button;
        private System.Windows.Forms.Button oct_button;
        private System.Windows.Forms.Button bin_button;
        private System.Windows.Forms.Label hex_result;
        private System.Windows.Forms.Label bin_result;
        private System.Windows.Forms.Label oct_result;
        private System.Windows.Forms.Label dec_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttonf;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Button buttone;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

