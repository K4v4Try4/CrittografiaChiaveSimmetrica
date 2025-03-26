namespace WF_SPN
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dgvSBox = new DataGridView();
            dgvPBox = new DataGridView();
            groupBox2 = new GroupBox();
            tbRisDecifrazione = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btDecifra = new Button();
            btDefault = new Button();
            btCifra = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbRisCifrazione = new TextBox();
            tbChiave2 = new TextBox();
            tbChiave1 = new TextBox();
            tbTestoInChiaro = new TextBox();
            btPulisci = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPBox).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvSBox);
            groupBox1.Controls.Add(dgvPBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PBOX AND SBOX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 112);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "SBOX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "PBOX";
            // 
            // dgvSBox
            // 
            dgvSBox.AllowUserToAddRows = false;
            dgvSBox.AllowUserToDeleteRows = false;
            dgvSBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvSBox.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvSBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSBox.Location = new Point(6, 130);
            dgvSBox.Name = "dgvSBox";
            dgvSBox.ReadOnly = true;
            dgvSBox.RowTemplate.Height = 25;
            dgvSBox.Size = new Size(376, 58);
            dgvSBox.TabIndex = 1;
            // 
            // dgvPBox
            // 
            dgvPBox.AllowUserToAddRows = false;
            dgvPBox.AllowUserToDeleteRows = false;
            dgvPBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvPBox.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvPBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPBox.Location = new Point(6, 40);
            dgvPBox.Name = "dgvPBox";
            dgvPBox.ReadOnly = true;
            dgvPBox.RowTemplate.Height = 25;
            dgvPBox.Size = new Size(376, 58);
            dgvPBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbRisDecifrazione);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbRisCifrazione);
            groupBox2.Controls.Add(tbChiave2);
            groupBox2.Controls.Add(tbChiave1);
            groupBox2.Controls.Add(tbTestoInChiaro);
            groupBox2.Location = new Point(12, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 178);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "INPUT AND OUTPUT";
            // 
            // tbRisDecifrazione
            // 
            tbRisDecifrazione.Location = new Point(133, 136);
            tbRisDecifrazione.Name = "tbRisDecifrazione";
            tbRisDecifrazione.Size = new Size(100, 23);
            tbRisDecifrazione.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 139);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 9;
            label7.Text = "Risultato Decifrazione";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btPulisci);
            groupBox3.Controls.Add(btDecifra);
            groupBox3.Controls.Add(btDefault);
            groupBox3.Controls.Add(btCifra);
            groupBox3.Location = new Point(263, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(87, 137);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "BTNS";
            // 
            // btDecifra
            // 
            btDecifra.Location = new Point(6, 80);
            btDecifra.Name = "btDecifra";
            btDecifra.Size = new Size(75, 23);
            btDecifra.TabIndex = 9;
            btDecifra.Text = "DECIFRA";
            btDecifra.UseVisualStyleBackColor = true;
            btDecifra.Click += btDecifra_Click;
            // 
            // btDefault
            // 
            btDefault.Location = new Point(6, 51);
            btDefault.Name = "btDefault";
            btDefault.Size = new Size(75, 23);
            btDefault.TabIndex = 1;
            btDefault.Text = "DEFAULT";
            btDefault.UseVisualStyleBackColor = true;
            btDefault.Click += btDefault_Click;
            // 
            // btCifra
            // 
            btCifra.Location = new Point(6, 22);
            btCifra.Name = "btCifra";
            btCifra.Size = new Size(75, 23);
            btCifra.TabIndex = 0;
            btCifra.Text = "CIFRA";
            btCifra.UseVisualStyleBackColor = true;
            btCifra.Click += btCifra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 7;
            label6.Text = "Risultato Cfrazione";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Chiave 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Chiave 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Testo in Chiaro";
            // 
            // tbRisCifrazione
            // 
            tbRisCifrazione.Location = new Point(133, 109);
            tbRisCifrazione.Name = "tbRisCifrazione";
            tbRisCifrazione.Size = new Size(100, 23);
            tbRisCifrazione.TabIndex = 3;
            // 
            // tbChiave2
            // 
            tbChiave2.Location = new Point(133, 80);
            tbChiave2.Name = "tbChiave2";
            tbChiave2.Size = new Size(100, 23);
            tbChiave2.TabIndex = 2;
            // 
            // tbChiave1
            // 
            tbChiave1.Location = new Point(133, 51);
            tbChiave1.Name = "tbChiave1";
            tbChiave1.Size = new Size(100, 23);
            tbChiave1.TabIndex = 1;
            // 
            // tbTestoInChiaro
            // 
            tbTestoInChiaro.Location = new Point(133, 22);
            tbTestoInChiaro.Name = "tbTestoInChiaro";
            tbTestoInChiaro.Size = new Size(100, 23);
            tbTestoInChiaro.TabIndex = 0;
            // 
            // btPulisci
            // 
            btPulisci.Location = new Point(6, 109);
            btPulisci.Name = "btPulisci";
            btPulisci.Size = new Size(75, 23);
            btPulisci.TabIndex = 10;
            btPulisci.Text = "PULISCI";
            btPulisci.UseVisualStyleBackColor = true;
            btPulisci.Click += btPulisci_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 395);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Crittografia SPN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgvSBox;
        private DataGridView dgvPBox;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbRisCifrazione;
        private TextBox tbChiave2;
        private TextBox tbChiave1;
        private TextBox tbTestoInChiaro;
        private GroupBox groupBox3;
        private Button btDecifra;
        private Button btDefault;
        private Button btCifra;
        private TextBox tbRisDecifrazione;
        private Label label7;
        private Button btPulisci;
    }
}