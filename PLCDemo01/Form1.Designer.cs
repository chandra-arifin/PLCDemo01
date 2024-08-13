namespace PLCDemo01
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
            btnConnect = new Button();
            lblKoneksi = new Label();
            txtStationNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblCPUType = new Label();
            checkBox1 = new CheckBox();
            chkPause = new CheckBox();
            btnRead = new Button();
            btnWrite = new Button();
            txtAddress = new TextBox();
            label3 = new Label();
            txtHasil = new TextBox();
            lblCPUType2 = new Label();
            txtVariable = new TextBox();
            btnUpload = new Button();
            txtFilePath = new TextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(38, 57);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // lblKoneksi
            // 
            lblKoneksi.AutoSize = true;
            lblKoneksi.Location = new Point(169, 62);
            lblKoneksi.Name = "lblKoneksi";
            lblKoneksi.Size = new Size(0, 25);
            lblKoneksi.TabIndex = 1;
            // 
            // txtStationNo
            // 
            txtStationNo.Location = new Point(106, 20);
            txtStationNo.Name = "txtStationNo";
            txtStationNo.Size = new Size(150, 31);
            txtStationNo.TabIndex = 2;
            txtStationNo.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 3;
            label1.Text = "Station";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 20);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "CPU Type";
            // 
            // lblCPUType
            // 
            lblCPUType.AutoSize = true;
            lblCPUType.Location = new Point(539, 20);
            lblCPUType.Name = "lblCPUType";
            lblCPUType.Size = new Size(87, 25);
            lblCPUType.TabIndex = 3;
            lblCPUType.Text = "CPU Type";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Run / Stop";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkPause
            // 
            chkPause.AutoSize = true;
            chkPause.Location = new Point(38, 194);
            chkPause.Name = "chkPause";
            chkPause.Size = new Size(83, 29);
            chkPause.TabIndex = 4;
            chkPause.Text = "Pause";
            chkPause.UseVisualStyleBackColor = true;
            chkPause.CheckedChanged += chkPause_CheckedChanged;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(38, 333);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(112, 34);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(38, 373);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(112, 34);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(122, 276);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 279);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(295, 336);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(150, 31);
            txtHasil.TabIndex = 2;
            // 
            // lblCPUType2
            // 
            lblCPUType2.AutoSize = true;
            lblCPUType2.Location = new Point(539, 62);
            lblCPUType2.Name = "lblCPUType2";
            lblCPUType2.Size = new Size(87, 25);
            lblCPUType2.TabIndex = 3;
            lblCPUType2.Text = "CPU Type";
            // 
            // txtVariable
            // 
            txtVariable.Location = new Point(156, 335);
            txtVariable.Name = "txtVariable";
            txtVariable.Size = new Size(78, 31);
            txtVariable.TabIndex = 2;
            txtVariable.Text = "X0";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(38, 456);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Read";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(169, 459);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(150, 31);
            txtFilePath.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(chkPause);
            Controls.Add(checkBox1);
            Controls.Add(lblCPUType2);
            Controls.Add(lblCPUType);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtVariable);
            Controls.Add(txtFilePath);
            Controls.Add(txtHasil);
            Controls.Add(txtAddress);
            Controls.Add(txtStationNo);
            Controls.Add(lblKoneksi);
            Controls.Add(btnWrite);
            Controls.Add(btnUpload);
            Controls.Add(btnRead);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Label lblKoneksi;
        private TextBox txtStationNo;
        private Label label1;
        private Label label2;
        private Label lblCPUType;
        private CheckBox checkBox1;
        private CheckBox chkPause;
        private Button btnRead;
        private Button btnWrite;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtHasil;
        private Label lblCPUType2;
        private TextBox txtVariable;
        private Button btnUpload;
        private TextBox txtFilePath;
    }
}
