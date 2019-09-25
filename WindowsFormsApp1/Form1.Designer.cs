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

            //addNameButton
            addNameButton.Size = new Size(50, 50);
            addNameButton.Location = new Point(30, 30);
            addNameButton.Text = "Add name";
            this.Controls.Add(addNameButton);
            //addNameButton.Click += new EventHandler();

            //eraseAllNamesButton
            eraseAllNamesButton.Size = new Size(50, 50);
            eraseAllNamesButton.Location = new Point(80, 30);
            eraseAllNamesButton.Text = "Erase all names";
            this.Controls.Add(eraseAllNamesButton);
            addNameButton.Click += new EventHandler(listofnames.EraseAll);

            //getAllNamesButton
            getAllNamesButton.Size = new Size(50, 50);
            getAllNamesButton.Location = new Point(80, 30);
            getAllNamesButton.Text = "Erase all names";
            this.Controls.Add(getAllNamesButton);
            //getAllNamesButton.Click += new EventHandler();


            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            components.Add(addNameButton);
            components.Add(eraseAllNamesButton);
            components.Add(getAllNamesButton);

        }

        #endregion
    }
}

