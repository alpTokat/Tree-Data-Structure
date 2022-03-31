
namespace Final2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertBox = new System.Windows.Forms.TextBox();
            this.cancelBox = new System.Windows.Forms.TextBox();
            this.foundBox = new System.Windows.Forms.TextBox();
            this.showBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leafBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PostorderBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InorderBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preorderBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertBox
            // 
            this.insertBox.Location = new System.Drawing.Point(114, 35);
            this.insertBox.Multiline = true;
            this.insertBox.Name = "insertBox";
            this.insertBox.Size = new System.Drawing.Size(100, 30);
            this.insertBox.TabIndex = 0;
            // 
            // cancelBox
            // 
            this.cancelBox.Location = new System.Drawing.Point(114, 74);
            this.cancelBox.Multiline = true;
            this.cancelBox.Name = "cancelBox";
            this.cancelBox.Size = new System.Drawing.Size(100, 30);
            this.cancelBox.TabIndex = 1;
            // 
            // foundBox
            // 
            this.foundBox.Location = new System.Drawing.Point(114, 116);
            this.foundBox.Multiline = true;
            this.foundBox.Name = "foundBox";
            this.foundBox.Size = new System.Drawing.Size(100, 30);
            this.foundBox.TabIndex = 2;
            // 
            // showBox
            // 
            this.showBox.Location = new System.Drawing.Point(15, 214);
            this.showBox.Multiline = true;
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(238, 224);
            this.showBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Düğüm Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Düğüm Silme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Düğüm Bulma";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Düğüm Eklendi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Düğüm Silindi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Düğüm Düzeyi";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ağaçtaki Düğümleri Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.leafBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nodeBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PostorderBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.InorderBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.preorderBox);
            this.groupBox1.Location = new System.Drawing.Point(410, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 346);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yapraklar:";
            // 
            // leafBox
            // 
            this.leafBox.Location = new System.Drawing.Point(90, 201);
            this.leafBox.Multiline = true;
            this.leafBox.Name = "leafBox";
            this.leafBox.Size = new System.Drawing.Size(199, 30);
            this.leafBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ağacın Yüksekliği:";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(170, 165);
            this.heightBox.Multiline = true;
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(119, 30);
            this.heightBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ağaçtaki Toplam Düğüm Sayısı:";
            // 
            // nodeBox
            // 
            this.nodeBox.Location = new System.Drawing.Point(170, 129);
            this.nodeBox.Multiline = true;
            this.nodeBox.Name = "nodeBox";
            this.nodeBox.Size = new System.Drawing.Size(119, 30);
            this.nodeBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Postoreder:";
            // 
            // PostorderBox
            // 
            this.PostorderBox.Location = new System.Drawing.Point(90, 93);
            this.PostorderBox.Multiline = true;
            this.PostorderBox.Name = "PostorderBox";
            this.PostorderBox.Size = new System.Drawing.Size(199, 30);
            this.PostorderBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inorder:";
            // 
            // InorderBox
            // 
            this.InorderBox.Location = new System.Drawing.Point(90, 55);
            this.InorderBox.Multiline = true;
            this.InorderBox.Name = "InorderBox";
            this.InorderBox.Size = new System.Drawing.Size(199, 30);
            this.InorderBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preorder:";
            // 
            // preorderBox
            // 
            this.preorderBox.Location = new System.Drawing.Point(90, 19);
            this.preorderBox.Multiline = true;
            this.preorderBox.Name = "preorderBox";
            this.preorderBox.Size = new System.Drawing.Size(199, 30);
            this.preorderBox.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(410, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(295, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "Ağaç Bilgilerini Göster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBox);
            this.Controls.Add(this.foundBox);
            this.Controls.Add(this.cancelBox);
            this.Controls.Add(this.insertBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertBox;
        private System.Windows.Forms.TextBox cancelBox;
        private System.Windows.Forms.TextBox foundBox;
        private System.Windows.Forms.TextBox showBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leafBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PostorderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InorderBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preorderBox;
        private System.Windows.Forms.Button button5;
    }
}

