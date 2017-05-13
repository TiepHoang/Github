namespace ThreeLayoutVer2._0
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNameTable = new System.Windows.Forms.ComboBox();
            this.cmbNameDatabase = new System.Windows.Forms.ComboBox();
            this.btnNameServer = new System.Windows.Forms.TextBox();
            this.btnInsertAllProc = new System.Windows.Forms.Button();
            this.txtStringConnection = new System.Windows.Forms.RichTextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnProcGetAll = new System.Windows.Forms.Button();
            this.btnProcGetBy = new System.Windows.Forms.Button();
            this.btnProcInsert = new System.Windows.Forms.Button();
            this.btnProcUpdate = new System.Windows.Forms.Button();
            this.btnProcDelete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 481);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 201);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(3, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 265);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(672, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 475);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNameServer);
            this.groupBox1.Controls.Add(this.cmbNameDatabase);
            this.groupBox1.Controls.Add(this.cmbNameTable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAuthor);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 469);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Location = new System.Drawing.Point(320, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 201);
            this.panel5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.btnProcDelete);
            this.groupBox4.Controls.Add(this.btnProcUpdate);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.btnProcInsert);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.btnProcGetBy);
            this.groupBox4.Controls.Add(this.btnProcGetAll);
            this.groupBox4.Controls.Add(this.btnInsertAllProc);
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 192);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStringConnection);
            this.groupBox5.Location = new System.Drawing.Point(3, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 76);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "String Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name Table";
            // 
            // cmbNameTable
            // 
            this.cmbNameTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameTable.FormattingEnabled = true;
            this.cmbNameTable.Location = new System.Drawing.Point(101, 77);
            this.cmbNameTable.Name = "cmbNameTable";
            this.cmbNameTable.Size = new System.Drawing.Size(192, 21);
            this.cmbNameTable.TabIndex = 1;
            // 
            // cmbNameDatabase
            // 
            this.cmbNameDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameDatabase.FormattingEnabled = true;
            this.cmbNameDatabase.Location = new System.Drawing.Point(101, 47);
            this.cmbNameDatabase.Name = "cmbNameDatabase";
            this.cmbNameDatabase.Size = new System.Drawing.Size(192, 21);
            this.cmbNameDatabase.TabIndex = 1;
            // 
            // btnNameServer
            // 
            this.btnNameServer.Location = new System.Drawing.Point(101, 17);
            this.btnNameServer.Name = "btnNameServer";
            this.btnNameServer.Size = new System.Drawing.Size(192, 21);
            this.btnNameServer.TabIndex = 2;
            this.btnNameServer.Text = ".\\SQLEXPRESS";
            // 
            // btnInsertAllProc
            // 
            this.btnInsertAllProc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertAllProc.Location = new System.Drawing.Point(6, 17);
            this.btnInsertAllProc.Name = "btnInsertAllProc";
            this.btnInsertAllProc.Size = new System.Drawing.Size(88, 29);
            this.btnInsertAllProc.TabIndex = 3;
            this.btnInsertAllProc.Text = "All Proc";
            this.btnInsertAllProc.UseVisualStyleBackColor = false;
            // 
            // txtStringConnection
            // 
            this.txtStringConnection.Location = new System.Drawing.Point(6, 20);
            this.txtStringConnection.Name = "txtStringConnection";
            this.txtStringConnection.ReadOnly = true;
            this.txtStringConnection.Size = new System.Drawing.Size(293, 50);
            this.txtStringConnection.TabIndex = 4;
            this.txtStringConnection.Text = "";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 17);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(182, 417);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 20);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(645, 233);
            this.dgvData.TabIndex = 0;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAuthor.Location = new System.Drawing.Point(113, 440);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAuthor.TabIndex = 3;
            this.btnAuthor.Text = "Hoàng Tiệp";
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnProcGetAll
            // 
            this.btnProcGetAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcGetAll.Location = new System.Drawing.Point(126, 17);
            this.btnProcGetAll.Name = "btnProcGetAll";
            this.btnProcGetAll.Size = new System.Drawing.Size(88, 29);
            this.btnProcGetAll.TabIndex = 3;
            this.btnProcGetAll.Text = "Proc GetAll";
            this.btnProcGetAll.UseVisualStyleBackColor = false;
            // 
            // btnProcGetBy
            // 
            this.btnProcGetBy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcGetBy.Location = new System.Drawing.Point(246, 17);
            this.btnProcGetBy.Name = "btnProcGetBy";
            this.btnProcGetBy.Size = new System.Drawing.Size(88, 29);
            this.btnProcGetBy.TabIndex = 3;
            this.btnProcGetBy.Text = "Proc GetBy";
            this.btnProcGetBy.UseVisualStyleBackColor = false;
            // 
            // btnProcInsert
            // 
            this.btnProcInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcInsert.Location = new System.Drawing.Point(246, 52);
            this.btnProcInsert.Name = "btnProcInsert";
            this.btnProcInsert.Size = new System.Drawing.Size(88, 29);
            this.btnProcInsert.TabIndex = 3;
            this.btnProcInsert.Text = "Proc Insert";
            this.btnProcInsert.UseVisualStyleBackColor = false;
            // 
            // btnProcUpdate
            // 
            this.btnProcUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcUpdate.Location = new System.Drawing.Point(126, 52);
            this.btnProcUpdate.Name = "btnProcUpdate";
            this.btnProcUpdate.Size = new System.Drawing.Size(88, 29);
            this.btnProcUpdate.TabIndex = 3;
            this.btnProcUpdate.Text = "Proc Update";
            this.btnProcUpdate.UseVisualStyleBackColor = false;
            // 
            // btnProcDelete
            // 
            this.btnProcDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcDelete.Location = new System.Drawing.Point(6, 52);
            this.btnProcDelete.Name = "btnProcDelete";
            this.btnProcDelete.Size = new System.Drawing.Size(88, 29);
            this.btnProcDelete.TabIndex = 3;
            this.btnProcDelete.Text = "Proc Delete";
            this.btnProcDelete.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 29);
            this.button8.TabIndex = 3;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(126, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 29);
            this.button9.TabIndex = 3;
            this.button9.Text = "button1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(126, 122);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 29);
            this.button10.TabIndex = 3;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(126, 157);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 29);
            this.button11.TabIndex = 3;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 87);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 29);
            this.button12.TabIndex = 3;
            this.button12.Text = "button1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 122);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 29);
            this.button13.TabIndex = 3;
            this.button13.Text = "button1";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(246, 87);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 29);
            this.button14.TabIndex = 3;
            this.button14.Text = "button1";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(246, 122);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 29);
            this.button15.TabIndex = 3;
            this.button15.Text = "button1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(246, 157);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 29);
            this.button16.TabIndex = 3;
            this.button16.Text = "button1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 505);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnInsertAllProc;
        private System.Windows.Forms.RichTextBox txtStringConnection;
        private System.Windows.Forms.TextBox btnNameServer;
        private System.Windows.Forms.ComboBox cmbNameDatabase;
        private System.Windows.Forms.ComboBox cmbNameTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnProcUpdate;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnProcInsert;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnProcGetBy;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnProcDelete;
        private System.Windows.Forms.Button btnProcGetAll;
    }
}

