using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp1
{

    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private IListaNomes listofnames = new ListaNomes();
        private Button eraseAllNamesButton;
        private Button addNameButton;
        private Button getAllNamesButton;
        private TextBox textBox1;

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

        private void AddName(object sender, EventArgs e) {
            if (this.textBox1.Text.Length > 0) {
                listofnames.AddName(this.textBox1.Text);
            }
            Console.WriteLine(listofnames.GetAllNames());
            Console.WriteLine("HEY");
        }
        private void EraseAllNames(object sender, EventArgs e) {
            listofnames.EraseAll();
            Console.WriteLine(listofnames.GetAllNames());
            Console.WriteLine("HEY");
        }
        private void GetAllNames(object sender, EventArgs e) {
            String names = listofnames.GetAllNames();
            MessageBox.Show(names);
            Console.WriteLine("HEY");
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNameButton = new System.Windows.Forms.Button();
            this.getAllNamesButton = new System.Windows.Forms.Button();
            this.eraseAllNamesButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNameButton
            // 
            this.addNameButton.Location = new System.Drawing.Point(299, 30);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(103, 38);
            this.addNameButton.TabIndex = 1;
            this.addNameButton.Text = "Add name";
            this.addNameButton.Click += new System.EventHandler(this.AddName);
            // 
            // getAllNamesButton
            // 
            this.getAllNamesButton.Location = new System.Drawing.Point(171, 100);
            this.getAllNamesButton.Name = "getAllNamesButton";
            this.getAllNamesButton.Size = new System.Drawing.Size(109, 61);
            this.getAllNamesButton.TabIndex = 3;
            this.getAllNamesButton.Text = "Get all names";
            this.getAllNamesButton.Click += new System.EventHandler(this.GetAllNames);
            // 
            // eraseAllNamesButton
            // 
            this.eraseAllNamesButton.Location = new System.Drawing.Point(30, 100);
            this.eraseAllNamesButton.Name = "eraseAllNamesButton";
            this.eraseAllNamesButton.Size = new System.Drawing.Size(114, 61);
            this.eraseAllNamesButton.TabIndex = 2;
            this.eraseAllNamesButton.Text = "Erase all names";
            this.eraseAllNamesButton.Click += new System.EventHandler(this.EraseAllNames);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(30, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.eraseAllNamesButton);
            this.Controls.Add(this.getAllNamesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }

    public class MyEventArgs : EventArgs {
        public string MyEventString { get; set; }

        public MyEventArgs(string myString) {
            this.MyEventString = myString;
        }
    }
}

