namespace WindowCRUD
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
            this.ED = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.CPass = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.sal = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textcpass = new System.Windows.Forms.TextBox();
            this.textpn = new System.Windows.Forms.TextBox();
            this.textdesig = new System.Windows.Forms.TextBox();
            this.textsalaey = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDBDataSet = new WindowCRUD.EmployeeDBDataSet();
            this.PD = new System.Windows.Forms.Label();
            this.dETAILSTableAdapter = new WindowCRUD.EmployeeDBDataSetTableAdapters.DETAILSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESIGNATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dETAILSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDBDataSet1 = new WindowCRUD.EmployeeDBDataSet1();
            this.dETAILSTableAdapter1 = new WindowCRUD.EmployeeDBDataSet1TableAdapters.DETAILSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ED
            // 
            this.ED.AutoSize = true;
            this.ED.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ED.Location = new System.Drawing.Point(186, 78);
            this.ED.Name = "ED";
            this.ED.Size = new System.Drawing.Size(122, 25);
            this.ED.TabIndex = 0;
            this.ED.Text = "Enter Details";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(61, 140);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(61, 176);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(61, 209);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(61, 242);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(69, 17);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password";
            // 
            // CPass
            // 
            this.CPass.AutoSize = true;
            this.CPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPass.Location = new System.Drawing.Point(61, 274);
            this.CPass.Name = "CPass";
            this.CPass.Size = new System.Drawing.Size(121, 17);
            this.CPass.TabIndex = 5;
            this.CPass.Text = "Confrim Password";
            // 
            // Gen
            // 
            this.Gen.AutoSize = true;
            this.Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gen.Location = new System.Drawing.Point(61, 338);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(56, 17);
            this.Gen.TabIndex = 6;
            this.Gen.Text = "Gender";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(61, 367);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(83, 17);
            this.Role.TabIndex = 7;
            this.Role.Text = "Designation";
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.Location = new System.Drawing.Point(61, 402);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(48, 17);
            this.sal.TabIndex = 8;
            this.sal.Text = "Salary";
            // 
            // PN
            // 
            this.PN.AutoSize = true;
            this.PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PN.Location = new System.Drawing.Point(61, 305);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(71, 17);
            this.PN.TabIndex = 9;
            this.PN.Text = "Mobile No";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(267, 137);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(241, 20);
            this.textid.TabIndex = 10;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(267, 173);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(241, 20);
            this.textname.TabIndex = 11;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(267, 206);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(241, 20);
            this.textemail.TabIndex = 12;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(267, 239);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(241, 20);
            this.textpass.TabIndex = 13;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // textcpass
            // 
            this.textcpass.Location = new System.Drawing.Point(267, 271);
            this.textcpass.Name = "textcpass";
            this.textcpass.PasswordChar = '*';
            this.textcpass.Size = new System.Drawing.Size(241, 20);
            this.textcpass.TabIndex = 14;
            this.textcpass.UseSystemPasswordChar = true;
            // 
            // textpn
            // 
            this.textpn.Location = new System.Drawing.Point(267, 302);
            this.textpn.MaxLength = 10;
            this.textpn.Name = "textpn";
            this.textpn.Size = new System.Drawing.Size(241, 20);
            this.textpn.TabIndex = 15;
            // 
            // textdesig
            // 
            this.textdesig.Location = new System.Drawing.Point(267, 364);
            this.textdesig.Name = "textdesig";
            this.textdesig.Size = new System.Drawing.Size(241, 20);
            this.textdesig.TabIndex = 16;
            // 
            // textsalaey
            // 
            this.textsalaey.Location = new System.Drawing.Point(267, 399);
            this.textsalaey.Name = "textsalaey";
            this.textsalaey.Size = new System.Drawing.Size(241, 20);
            this.textsalaey.TabIndex = 17;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(267, 334);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(56, 21);
            this.male.TabIndex = 18;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(436, 334);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(72, 21);
            this.female.TabIndex = 19;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(62, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(189, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(431, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(309, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dETAILSBindingSource
            // 
            this.dETAILSBindingSource.DataMember = "DETAILS";
            this.dETAILSBindingSource.DataSource = this.employeeDBDataSet;
            // 
            // employeeDBDataSet
            // 
            this.employeeDBDataSet.DataSetName = "EmployeeDBDataSet";
            this.employeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PD
            // 
            this.PD.AutoSize = true;
            this.PD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PD.Location = new System.Drawing.Point(806, 78);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(138, 25);
            this.PD.TabIndex = 27;
            this.PD.Text = "Person Details";
            // 
            // dETAILSTableAdapter
            // 
            this.dETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.mOBILENODataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.dESIGNATIONDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dETAILSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(560, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 384);
            this.dataGridView1.TabIndex = 28;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            // 
            // mOBILENODataGridViewTextBoxColumn
            // 
            this.mOBILENODataGridViewTextBoxColumn.DataPropertyName = "MOBILE_NO";
            this.mOBILENODataGridViewTextBoxColumn.HeaderText = "MOBILE_NO";
            this.mOBILENODataGridViewTextBoxColumn.Name = "mOBILENODataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            // 
            // dESIGNATIONDataGridViewTextBoxColumn
            // 
            this.dESIGNATIONDataGridViewTextBoxColumn.DataPropertyName = "DESIGNATION";
            this.dESIGNATIONDataGridViewTextBoxColumn.HeaderText = "DESIGNATION";
            this.dESIGNATIONDataGridViewTextBoxColumn.Name = "dESIGNATIONDataGridViewTextBoxColumn";
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            // 
            // dETAILSBindingSource1
            // 
            this.dETAILSBindingSource1.DataMember = "DETAILS";
            this.dETAILSBindingSource1.DataSource = this.employeeDBDataSet1;
            // 
            // employeeDBDataSet1
            // 
            this.employeeDBDataSet1.DataSetName = "EmployeeDBDataSet1";
            this.employeeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dETAILSTableAdapter1
            // 
            this.dETAILSTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.textsalaey);
            this.Controls.Add(this.textdesig);
            this.Controls.Add(this.textpn);
            this.Controls.Add(this.textcpass);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.CPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ED);
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ED;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label CPass;
        private System.Windows.Forms.Label Gen;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label sal;
        private System.Windows.Forms.Label PN;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textcpass;
        private System.Windows.Forms.TextBox textpn;
        private System.Windows.Forms.TextBox textdesig;
        private System.Windows.Forms.TextBox textsalaey;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label PD;
        private EmployeeDBDataSet employeeDBDataSet;
        private System.Windows.Forms.BindingSource dETAILSBindingSource;
        private EmployeeDBDataSetTableAdapters.DETAILSTableAdapter dETAILSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeDBDataSet1 employeeDBDataSet1;
        private System.Windows.Forms.BindingSource dETAILSBindingSource1;
        private EmployeeDBDataSet1TableAdapters.DETAILSTableAdapter dETAILSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
    }
}

