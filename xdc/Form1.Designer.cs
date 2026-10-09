namespace xdc
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnSifirla = new Button();
            btnHesabla = new Button();
            txtAdSoyad = new TextBox();
            mtbTelebeNo = new MaskedTextBox();
            mtbSF1 = new MaskedTextBox();
            mtbSF2 = new MaskedTextBox();
            mtbFF = new MaskedTextBox();
            mtbLAB = new MaskedTextBox();
            mtbFINAL = new MaskedTextBox();
            btnCikis = new Button();
            dataGridView1 = new DataGridView();
            fulname = new DataGridViewTextBoxColumn();
            NUMBER = new DataGridViewTextBoxColumn();
            RESULT = new DataGridViewTextBoxColumn();
            KATEQORY = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 99);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FloralWhite;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bmuu;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 102);
            label1.Name = "label1";
            label1.Size = new Size(353, 50);
            label1.TabIndex = 1;
            label1.Text = "IMTAHAN SISTEMI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(45, 30);
            label2.TabIndex = 2;
            label2.Text = "SF1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(45, 30);
            label3.TabIndex = 3;
            label3.Text = "SF2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(33, 30);
            label4.TabIndex = 4;
            label4.Text = "FF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 401);
            label5.Name = "label5";
            label5.Size = new Size(50, 30);
            label5.TabIndex = 5;
            label5.Text = "LAB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 466);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 6;
            label6.Text = "FINAL";
            label6.Click += label6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSifirla);
            groupBox1.Controls.Add(btnHesabla);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(mtbTelebeNo);
            groupBox1.Location = new Point(254, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 322);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "TELEBE MELUMATLARI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 105);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 16;
            label7.Text = "TELEBE NOMRESI";
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(42, 234);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(131, 40);
            btnSifirla.TabIndex = 15;
            btnSifirla.Text = "XANARI SIFIRLA";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // btnHesabla
            // 
            btnHesabla.Location = new Point(42, 171);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(131, 37);
            btnHesabla.TabIndex = 14;
            btnHesabla.Text = "HESABLA";
            btnHesabla.UseVisualStyleBackColor = true;
            btnHesabla.Click += button1_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(6, 65);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(188, 23);
            txtAdSoyad.TabIndex = 13;
            txtAdSoyad.TextChanged += textBox1_TextChanged;
            // 
            // mtbTelebeNo
            // 
            mtbTelebeNo.Location = new Point(6, 123);
            mtbTelebeNo.Mask = "000000000";
            mtbTelebeNo.Name = "mtbTelebeNo";
            mtbTelebeNo.Size = new Size(188, 23);
            mtbTelebeNo.TabIndex = 12;
            mtbTelebeNo.ValidatingType = typeof(int);
            // 
            // mtbSF1
            // 
            mtbSF1.Location = new Point(87, 176);
            mtbSF1.Name = "mtbSF1";
            mtbSF1.Size = new Size(100, 23);
            mtbSF1.TabIndex = 0;
            // 
            // mtbSF2
            // 
            mtbSF2.Location = new Point(87, 250);
            mtbSF2.Name = "mtbSF2";
            mtbSF2.Size = new Size(100, 23);
            mtbSF2.TabIndex = 8;
            // 
            // mtbFF
            // 
            mtbFF.Location = new Point(87, 327);
            mtbFF.Name = "mtbFF";
            mtbFF.Size = new Size(100, 23);
            mtbFF.TabIndex = 9;
            // 
            // mtbLAB
            // 
            mtbLAB.Location = new Point(87, 410);
            mtbLAB.Name = "mtbLAB";
            mtbLAB.Size = new Size(100, 23);
            mtbLAB.TabIndex = 10;
            // 
            // mtbFINAL
            // 
            mtbFINAL.Location = new Point(87, 475);
            mtbFINAL.Name = "mtbFINAL";
            mtbFINAL.Size = new Size(100, 23);
            mtbFINAL.TabIndex = 11;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(957, 489);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 23);
            btnCikis.TabIndex = 12;
            btnCikis.Text = "CIXIS";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fulname, NUMBER, RESULT, KATEQORY });
            dataGridView1.Location = new Point(488, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(437, 419);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fulname
            // 
            fulname.HeaderText = "AD SOYAD";
            fulname.Name = "fulname";
            // 
            // NUMBER
            // 
            NUMBER.HeaderText = "TELEBE NOMRESI";
            NUMBER.Name = "NUMBER";
            // 
            // RESULT
            // 
            RESULT.HeaderText = "NETICE";
            RESULT.Name = "RESULT";
            // 
            // KATEQORY
            // 
            KATEQORY.HeaderText = "KATEQORIYA";
            KATEQORY.Name = "KATEQORY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 47);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 17;
            label8.Text = "AD VE SOYAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1044, 524);
            Controls.Add(dataGridView1);
            Controls.Add(btnCikis);
            Controls.Add(mtbFINAL);
            Controls.Add(mtbLAB);
            Controls.Add(mtbFF);
            Controls.Add(mtbSF2);
            Controls.Add(mtbSF1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnSifirla;
        private Button btnHesabla;
        private TextBox txtAdSoyad;
        private MaskedTextBox mtbTelebeNo;
        private MaskedTextBox mtbSF1;
        private MaskedTextBox mtbSF2;
        private MaskedTextBox mtbFF;
        private MaskedTextBox mtbLAB;
        private MaskedTextBox mtbFINAL;
        private Button btnCikis;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fulname;
        private DataGridViewTextBoxColumn NUMBER;
        private DataGridViewTextBoxColumn RESULT;
        private DataGridViewTextBoxColumn KATEQORY;
        private Label label7;
        private Label label8;
    }
}
