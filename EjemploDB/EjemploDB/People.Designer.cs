namespace EjemploDB
{
    partial class People
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblfristname = new System.Windows.Forms.Label();
            this.txtFristname = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblclienttipe = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemailaddress = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.lblphonenumer = new System.Windows.Forms.Label();
            this.lblsupportstaff = new System.Windows.Forms.Label();
            this.lblcontacttype = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cblRestrictions = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cblPermissions = new System.Windows.Forms.CheckedListBox();
            this.cblicense = new System.Windows.Forms.ComboBox();
            this.lbllicense = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.chkStaf = new System.Windows.Forms.CheckBox();
            this.cbContactType = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btneditclient = new System.Windows.Forms.Button();
            this.btneditcontact = new System.Windows.Forms.Button();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.lblcreateddate = new System.Windows.Forms.Label();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.panelFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRUD EXAMPLE CREATE READ UPDATE DELETE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblfristname
            // 
            this.lblfristname.AutoSize = true;
            this.lblfristname.Location = new System.Drawing.Point(7, 13);
            this.lblfristname.Name = "lblfristname";
            this.lblfristname.Size = new System.Drawing.Size(54, 13);
            this.lblfristname.TabIndex = 2;
            this.lblfristname.Text = "FristName";
            // 
            // txtFristname
            // 
            this.txtFristname.Location = new System.Drawing.Point(99, 10);
            this.txtFristname.Name = "txtFristname";
            this.txtFristname.Size = new System.Drawing.Size(178, 20);
            this.txtFristname.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(99, 36);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(178, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Location = new System.Drawing.Point(7, 39);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(69, 13);
            this.lblmiddlename.TabIndex = 4;
            this.lblmiddlename.Text = "Middle Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(99, 62);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 20);
            this.txtLastname.TabIndex = 7;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(7, 65);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(58, 13);
            this.lbllastname.TabIndex = 6;
            this.lbllastname.Text = "Last Name";
            // 
            // lblclienttipe
            // 
            this.lblclienttipe.AutoSize = true;
            this.lblclienttipe.Location = new System.Drawing.Point(7, 91);
            this.lblclienttipe.Name = "lblclienttipe";
            this.lblclienttipe.Size = new System.Drawing.Size(60, 13);
            this.lblclienttipe.TabIndex = 8;
            this.lblclienttipe.Text = "Client Type";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(99, 192);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 20);
            this.txtemail.TabIndex = 11;
            // 
            // lblemailaddress
            // 
            this.lblemailaddress.AutoSize = true;
            this.lblemailaddress.Location = new System.Drawing.Point(7, 192);
            this.lblemailaddress.Name = "lblemailaddress";
            this.lblemailaddress.Size = new System.Drawing.Size(73, 13);
            this.lblemailaddress.TabIndex = 10;
            this.lblemailaddress.Text = "Email Address";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(99, 166);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(178, 20);
            this.txtphonenumber.TabIndex = 13;
            // 
            // lblphonenumer
            // 
            this.lblphonenumer.AutoSize = true;
            this.lblphonenumer.Location = new System.Drawing.Point(7, 166);
            this.lblphonenumer.Name = "lblphonenumer";
            this.lblphonenumer.Size = new System.Drawing.Size(78, 13);
            this.lblphonenumer.TabIndex = 12;
            this.lblphonenumer.Text = "Phone Number";
            // 
            // lblsupportstaff
            // 
            this.lblsupportstaff.AutoSize = true;
            this.lblsupportstaff.Location = new System.Drawing.Point(7, 140);
            this.lblsupportstaff.Name = "lblsupportstaff";
            this.lblsupportstaff.Size = new System.Drawing.Size(69, 13);
            this.lblsupportstaff.TabIndex = 14;
            this.lblsupportstaff.Text = "Support Staff";
            // 
            // lblcontacttype
            // 
            this.lblcontacttype.AutoSize = true;
            this.lblcontacttype.Location = new System.Drawing.Point(7, 117);
            this.lblcontacttype.Name = "lblcontacttype";
            this.lblcontacttype.Size = new System.Drawing.Size(71, 13);
            this.lblcontacttype.TabIndex = 16;
            this.lblcontacttype.Text = "Contact Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(283, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 318);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cblRestrictions);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cblPermissions);
            this.tabPage1.Controls.Add(this.cblicense);
            this.tabPage1.Controls.Add(this.lbllicense);
            this.tabPage1.Controls.Add(this.txtpassword);
            this.tabPage1.Controls.Add(this.txtusername);
            this.tabPage1.Controls.Add(this.lblpassword);
            this.tabPage1.Controls.Add(this.lblusername);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login Access Detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Restrictions";
            // 
            // cblRestrictions
            // 
            this.cblRestrictions.FormattingEnabled = true;
            this.cblRestrictions.Location = new System.Drawing.Point(332, 139);
            this.cblRestrictions.Name = "cblRestrictions";
            this.cblRestrictions.Size = new System.Drawing.Size(267, 94);
            this.cblRestrictions.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Application Permissions";
            // 
            // cblPermissions
            // 
            this.cblPermissions.FormattingEnabled = true;
            this.cblPermissions.Location = new System.Drawing.Point(18, 139);
            this.cblPermissions.Name = "cblPermissions";
            this.cblPermissions.Size = new System.Drawing.Size(267, 94);
            this.cblPermissions.TabIndex = 23;
            // 
            // cblicense
            // 
            this.cblicense.FormattingEnabled = true;
            this.cblicense.Location = new System.Drawing.Point(107, 67);
            this.cblicense.Name = "cblicense";
            this.cblicense.Size = new System.Drawing.Size(178, 21);
            this.cblicense.TabIndex = 21;
            // 
            // lbllicense
            // 
            this.lbllicense.AutoSize = true;
            this.lbllicense.Location = new System.Drawing.Point(15, 67);
            this.lbllicense.Name = "lbllicense";
            this.lbllicense.Size = new System.Drawing.Size(44, 13);
            this.lbllicense.TabIndex = 19;
            this.lbllicense.Text = "License";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(107, 41);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(178, 20);
            this.txtpassword.TabIndex = 22;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(107, 15);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(178, 20);
            this.txtusername.TabIndex = 20;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(15, 44);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 21;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(15, 18);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(55, 13);
            this.lblusername.TabIndex = 19;
            this.lblusername.Text = "Username";
            // 
            // cbClientType
            // 
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Location = new System.Drawing.Point(99, 88);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(178, 21);
            this.cbClientType.TabIndex = 19;
            // 
            // chkStaf
            // 
            this.chkStaf.AutoSize = true;
            this.chkStaf.Location = new System.Drawing.Point(99, 140);
            this.chkStaf.Name = "chkStaf";
            this.chkStaf.Size = new System.Drawing.Size(15, 14);
            this.chkStaf.TabIndex = 20;
            this.chkStaf.UseVisualStyleBackColor = true;
            this.chkStaf.CheckedChanged += new System.EventHandler(this.chkStaf_CheckedChanged);
            // 
            // cbContactType
            // 
            this.cbContactType.FormattingEnabled = true;
            this.cbContactType.Location = new System.Drawing.Point(99, 113);
            this.cbContactType.Name = "cbContactType";
            this.cbContactType.Size = new System.Drawing.Size(178, 21);
            this.cbContactType.TabIndex = 21;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 790);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(108, 790);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(201, 790);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(9, 419);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(1100, 365);
            this.dgvPeople.TabIndex = 30;
            this.dgvPeople.Click += new System.EventHandler(this.dgvPeople_Click);
            // 
            // btneditclient
            // 
            this.btneditclient.Location = new System.Drawing.Point(296, 790);
            this.btneditclient.Name = "btneditclient";
            this.btneditclient.Size = new System.Drawing.Size(96, 23);
            this.btneditclient.TabIndex = 31;
            this.btneditclient.Text = "editClientType";
            this.btneditclient.UseVisualStyleBackColor = true;
            // 
            // btneditcontact
            // 
            this.btneditcontact.Location = new System.Drawing.Point(411, 790);
            this.btneditcontact.Name = "btneditcontact";
            this.btneditcontact.Size = new System.Drawing.Size(96, 23);
            this.btneditcontact.TabIndex = 32;
            this.btneditcontact.Text = "editContactType";
            this.btneditcontact.UseVisualStyleBackColor = true;
            // 
            // panelFrom
            // 
            this.panelFrom.Controls.Add(this.txtCreatedDate);
            this.panelFrom.Controls.Add(this.lblcreateddate);
            this.panelFrom.Controls.Add(this.txtLastname);
            this.panelFrom.Controls.Add(this.lblfristname);
            this.panelFrom.Controls.Add(this.txtFristname);
            this.panelFrom.Controls.Add(this.lblmiddlename);
            this.panelFrom.Controls.Add(this.txtMiddleName);
            this.panelFrom.Controls.Add(this.lbllastname);
            this.panelFrom.Controls.Add(this.lblclienttipe);
            this.panelFrom.Controls.Add(this.tabControl1);
            this.panelFrom.Controls.Add(this.cbContactType);
            this.panelFrom.Controls.Add(this.lblemailaddress);
            this.panelFrom.Controls.Add(this.chkStaf);
            this.panelFrom.Controls.Add(this.txtemail);
            this.panelFrom.Controls.Add(this.cbClientType);
            this.panelFrom.Controls.Add(this.lblphonenumer);
            this.panelFrom.Controls.Add(this.txtphonenumber);
            this.panelFrom.Controls.Add(this.lblcontacttype);
            this.panelFrom.Controls.Add(this.lblsupportstaff);
            this.panelFrom.Location = new System.Drawing.Point(12, 28);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(1100, 358);
            this.panelFrom.TabIndex = 33;
            // 
            // lblcreateddate
            // 
            this.lblcreateddate.AutoSize = true;
            this.lblcreateddate.Location = new System.Drawing.Point(7, 219);
            this.lblcreateddate.Name = "lblcreateddate";
            this.lblcreateddate.Size = new System.Drawing.Size(70, 13);
            this.lblcreateddate.TabIndex = 22;
            this.lblcreateddate.Text = "Created Date";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(99, 219);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(178, 20);
            this.txtCreatedDate.TabIndex = 23;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(791, 790);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 23);
            this.btnupdate.TabIndex = 34;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(893, 790);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 23);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 825);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panelFrom);
            this.Controls.Add(this.btneditcontact);
            this.Controls.Add(this.btneditclient);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.panelFrom.ResumeLayout(false);
            this.panelFrom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfristname;
        private System.Windows.Forms.TextBox txtFristname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblclienttipe;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemailaddress;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label lblphonenumer;
        private System.Windows.Forms.Label lblsupportstaff;
        private System.Windows.Forms.Label lblcontacttype;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox cblRestrictions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox cblPermissions;
        private System.Windows.Forms.ComboBox cblicense;
        private System.Windows.Forms.Label lbllicense;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.CheckBox chkStaf;
        private System.Windows.Forms.ComboBox cbContactType;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btneditclient;
        private System.Windows.Forms.Button btneditcontact;
        private System.Windows.Forms.Panel panelFrom;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label lblcreateddate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}

