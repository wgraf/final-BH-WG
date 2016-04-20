using System.Linq;

namespace vnvbnvnvbnvbn
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.serbtn = new System.Windows.Forms.Button();
            this.deserbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tempbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 130);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textbox);
            this.tabPage1.Controls.Add(this.urlbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sprawdz strone";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tekst:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "URL:";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(73, 69);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(308, 20);
            this.textbox.TabIndex = 6;
            this.textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(73, 43);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(308, 20);
            this.urlbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "na danej stronie zawiera się obrazek, którego opisa zawiera tekst:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.citybox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tempbox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(407, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sprawdz pogode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(43, 292);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(407, 103);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.addressbox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(399, 77);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Wyslij email";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adress:";
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(63, 40);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(308, 20);
            this.addressbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "wyślij wiadomość na ades email:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(399, 77);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Pokaz";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jezeli to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "To wykonaj to:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(44, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nazwa:";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(93, 410);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(181, 20);
            this.namebox.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(483, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 238);
            this.listBox1.TabIndex = 10;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(43, 436);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(231, 46);
            this.addbtn.TabIndex = 11;
            this.addbtn.Text = "Dodaj do listy";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(483, 277);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(123, 71);
            this.sendbtn.TabIndex = 12;
            this.sendbtn.Text = "Wyslij";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(612, 277);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(123, 71);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "Czysc";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // serbtn
            // 
            this.serbtn.Location = new System.Drawing.Point(741, 277);
            this.serbtn.Name = "serbtn";
            this.serbtn.Size = new System.Drawing.Size(123, 34);
            this.serbtn.TabIndex = 14;
            this.serbtn.Text = "Serialized";
            this.serbtn.UseVisualStyleBackColor = true;
            this.serbtn.Click += new System.EventHandler(this.serbtn_Click);
            // 
            // deserbtn
            // 
            this.deserbtn.Location = new System.Drawing.Point(741, 314);
            this.deserbtn.Name = "deserbtn";
            this.deserbtn.Size = new System.Drawing.Size(123, 34);
            this.deserbtn.TabIndex = 15;
            this.deserbtn.Text = "DeSerialized";
            this.deserbtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(26, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "tempratura w tym miscie jest wyzsza niz wartosc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(26, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Temperatura:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tempbox
            // 
            this.tempbox.Location = new System.Drawing.Point(114, 60);
            this.tempbox.Name = "tempbox";
            this.tempbox.Size = new System.Drawing.Size(53, 20);
            this.tempbox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(22, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "pokaz komunikat na ekranie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(26, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Miasto:";
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(79, 38);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(88, 20);
            this.citybox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 556);
            this.Controls.Add(this.deserbtn);
            this.Controls.Add(this.serbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button serbtn;
        private System.Windows.Forms.Button deserbtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tempbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Label label12;
    }
}

