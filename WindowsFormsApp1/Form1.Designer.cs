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
            this.addNameButton = new Button();
            this.getAllNamesButton = new Button();
            this.eraseAllNamesButton = new Button();
            this.textBox1 = new TextBox();

            //textbox1
            textBox1.Visible = true;
            textBox1.Size = new Size(30, 60);
            textBox1.Location = new Point(80, 30);
            textBox1.Width = 250;
            textBox1.Height = 50;
            textBox1.ForeColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(textBox1);


            //addNameButton
            addNameButton.Size = new Size(50, 50);
            addNameButton.Location = new Point(30, 30);
            addNameButton.Text = "Add name";
            this.Controls.Add(addNameButton);
            addNameButton.Click += new EventHandler(AddName);

            //eraseAllNamesButton
            eraseAllNamesButton.Size = new Size(50, 50);
            eraseAllNamesButton.Location = new Point(30, 100);
            eraseAllNamesButton.Text = "Erase all names";
            this.Controls.Add(eraseAllNamesButton);
            eraseAllNamesButton.Click += new EventHandler(EraseAllNames);

            //getAllNamesButton
            getAllNamesButton.Size = new Size(50, 50);
            getAllNamesButton.Location = new Point(80, 100);
            getAllNamesButton.Text = "Get all names";
            this.Controls.Add(getAllNamesButton);
            getAllNamesButton.Click += new EventHandler(GetAllNames);


            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            components.Add(addNameButton);
            components.Add(eraseAllNamesButton);
            components.Add(getAllNamesButton);
            components.Add(textBox1);

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

