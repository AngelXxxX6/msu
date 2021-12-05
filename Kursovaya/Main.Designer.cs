namespace Kursovaya
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.arrchive = new System.Windows.Forms.Button();
            this.unarchive = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.Button();
            this.Help1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // arrchive
            // 
            this.arrchive.Location = new System.Drawing.Point(62, 140);
            this.arrchive.Name = "arrchive";
            this.arrchive.Size = new System.Drawing.Size(114, 59);
            this.arrchive.TabIndex = 0;
            this.arrchive.Text = "Архивировать";
            this.arrchive.UseVisualStyleBackColor = true;
            this.arrchive.Click += new System.EventHandler(this.arrchive_Click);
            // 
            // unarchive
            // 
            this.unarchive.Location = new System.Drawing.Point(219, 140);
            this.unarchive.Name = "unarchive";
            this.unarchive.Size = new System.Drawing.Size(110, 59);
            this.unarchive.TabIndex = 1;
            this.unarchive.Text = "Разархивировать";
            this.unarchive.UseVisualStyleBackColor = true;
            this.unarchive.Click += new System.EventHandler(this.unarchive_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(102, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Подсказки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(219, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 76);
            this.panel1.TabIndex = 5;
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(12, 10);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(114, 44);
            this.help.TabIndex = 6;
            this.help.Text = "Помощь";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Help1
            // 
            this.Help1.Location = new System.Drawing.Point(12, 60);
            this.Help1.Multiline = true;
            this.Help1.Name = "Help1";
            this.Help1.ReadOnly = true;
            this.Help1.Size = new System.Drawing.Size(372, 192);
            this.Help1.TabIndex = 7;
            this.Help1.Text = resources.GetString("Help1.Text");
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.Help1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unarchive);
            this.Controls.Add(this.arrchive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button arrchive;
        private Button unarchive;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox1;
        private Label label1;
        private Panel panel1;
        private Button help;
        private TextBox Help1;
    }
}