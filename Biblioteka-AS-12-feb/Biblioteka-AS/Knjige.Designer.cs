namespace Biblioteka_AS
{
    partial class Knjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knjige));
            this.osvjezibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ispisKnjigetxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.spremiknjigabtn = new System.Windows.Forms.Button();
            this.xmlispis = new System.Windows.Forms.RichTextBox();
            this.uploadknjigabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // osvjezibtn
            // 
            this.osvjezibtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvjezibtn.Location = new System.Drawing.Point(455, 27);
            this.osvjezibtn.Name = "osvjezibtn";
            this.osvjezibtn.Size = new System.Drawing.Size(75, 23);
            this.osvjezibtn.TabIndex = 7;
            this.osvjezibtn.Text = "Osvježi";
            this.osvjezibtn.UseVisualStyleBackColor = true;
            this.osvjezibtn.Click += new System.EventHandler(this.osvjezibtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sortiraj po:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Naziv",
            "Autor",
            "Godina izdanja"});
            this.comboBox1.Location = new System.Drawing.Point(301, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ispisKnjigetxt
            // 
            this.ispisKnjigetxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.ispisKnjigetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ispisKnjigetxt.Location = new System.Drawing.Point(12, 56);
            this.ispisKnjigetxt.Name = "ispisKnjigetxt";
            this.ispisKnjigetxt.Size = new System.Drawing.Size(614, 368);
            this.ispisKnjigetxt.TabIndex = 4;
            this.ispisKnjigetxt.Text = "";
            this.ispisKnjigetxt.TextChanged += new System.EventHandler(this.ispisKnjigetxt_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spremiknjigabtn
            // 
            this.spremiknjigabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spremiknjigabtn.Location = new System.Drawing.Point(632, 27);
            this.spremiknjigabtn.Name = "spremiknjigabtn";
            this.spremiknjigabtn.Size = new System.Drawing.Size(75, 23);
            this.spremiknjigabtn.TabIndex = 12;
            this.spremiknjigabtn.Text = "Spremi";
            this.spremiknjigabtn.UseVisualStyleBackColor = true;
            this.spremiknjigabtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // xmlispis
            // 
            this.xmlispis.BackColor = System.Drawing.Color.LavenderBlush;
            this.xmlispis.Location = new System.Drawing.Point(632, 56);
            this.xmlispis.Name = "xmlispis";
            this.xmlispis.Size = new System.Drawing.Size(156, 368);
            this.xmlispis.TabIndex = 13;
            this.xmlispis.Text = "";
            // 
            // uploadknjigabtn
            // 
            this.uploadknjigabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadknjigabtn.Location = new System.Drawing.Point(713, 27);
            this.uploadknjigabtn.Name = "uploadknjigabtn";
            this.uploadknjigabtn.Size = new System.Drawing.Size(75, 23);
            this.uploadknjigabtn.TabIndex = 14;
            this.uploadknjigabtn.Text = "Upload";
            this.uploadknjigabtn.UseVisualStyleBackColor = true;
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadknjigabtn);
            this.Controls.Add(this.xmlispis);
            this.Controls.Add(this.spremiknjigabtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osvjezibtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ispisKnjigetxt);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osvjezibtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox ispisKnjigetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button spremiknjigabtn;
        private System.Windows.Forms.RichTextBox xmlispis;
        private System.Windows.Forms.Button uploadknjigabtn;
    }
}