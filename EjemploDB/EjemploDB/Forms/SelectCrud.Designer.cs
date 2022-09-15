
namespace EjemploDB
{
    partial class SelectCrud
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
            this.chbPeople = new System.Windows.Forms.CheckBox();
            this.chbClient = new System.Windows.Forms.CheckBox();
            this.chbContact = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbPeople
            // 
            this.chbPeople.AutoSize = true;
            this.chbPeople.Location = new System.Drawing.Point(22, 63);
            this.chbPeople.Name = "chbPeople";
            this.chbPeople.Size = new System.Drawing.Size(59, 17);
            this.chbPeople.TabIndex = 0;
            this.chbPeople.Text = "People";
            this.chbPeople.UseVisualStyleBackColor = true;
            this.chbPeople.CheckedChanged += new System.EventHandler(this.chbPeople_CheckedChanged);
            // 
            // chbClient
            // 
            this.chbClient.AutoSize = true;
            this.chbClient.Location = new System.Drawing.Point(108, 63);
            this.chbClient.Name = "chbClient";
            this.chbClient.Size = new System.Drawing.Size(52, 17);
            this.chbClient.TabIndex = 1;
            this.chbClient.Text = "Client";
            this.chbClient.UseVisualStyleBackColor = true;
            this.chbClient.CheckedChanged += new System.EventHandler(this.chbClient_CheckedChanged);
            // 
            // chbContact
            // 
            this.chbContact.AutoSize = true;
            this.chbContact.Location = new System.Drawing.Point(194, 63);
            this.chbContact.Name = "chbContact";
            this.chbContact.Size = new System.Drawing.Size(63, 17);
            this.chbContact.TabIndex = 2;
            this.chbContact.Text = "Contact";
            this.chbContact.UseVisualStyleBackColor = true;
            this.chbContact.CheckedChanged += new System.EventHandler(this.chbContact_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT CRUD";
            // 
            // SelectCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbContact);
            this.Controls.Add(this.chbClient);
            this.Controls.Add(this.chbPeople);
            this.Name = "SelectCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCrud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbPeople;
        private System.Windows.Forms.CheckBox chbClient;
        private System.Windows.Forms.CheckBox chbContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}