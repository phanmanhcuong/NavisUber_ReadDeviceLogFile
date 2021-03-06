﻿using System.Windows.Forms;

namespace ReadDeviceLogFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_filename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkbox_selectall = new System.Windows.Forms.CheckBox();
            this.checkBox_unselectall = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_servername = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtbox_foldername = new System.Windows.Forms.TextBox();
            this.btn_openfolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_testconnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name: ";
            // 
            // txtbox_filename
            // 
            this.txtbox_filename.Location = new System.Drawing.Point(93, 97);
            this.txtbox_filename.Name = "txtbox_filename";
            this.txtbox_filename.Size = new System.Drawing.Size(259, 20);
            this.txtbox_filename.TabIndex = 1;
            this.txtbox_filename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".txt";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(385, 95);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Load File";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header});
            this.listView1.Location = new System.Drawing.Point(15, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 212);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // header
            // 
            this.header.Text = "";
            this.header.Width = 441;
            // 
            // checkbox_selectall
            // 
            this.checkbox_selectall.AutoSize = true;
            this.checkbox_selectall.Location = new System.Drawing.Point(16, 354);
            this.checkbox_selectall.Name = "checkbox_selectall";
            this.checkbox_selectall.Size = new System.Drawing.Size(70, 17);
            this.checkbox_selectall.TabIndex = 5;
            this.checkbox_selectall.Text = "Select All";
            this.checkbox_selectall.UseVisualStyleBackColor = true;
            this.checkbox_selectall.CheckedChanged += new System.EventHandler(this.checkbox_selectall_CheckedChanged);
            // 
            // checkBox_unselectall
            // 
            this.checkBox_unselectall.AutoSize = true;
            this.checkBox_unselectall.Location = new System.Drawing.Point(126, 354);
            this.checkBox_unselectall.Name = "checkBox_unselectall";
            this.checkBox_unselectall.Size = new System.Drawing.Size(82, 17);
            this.checkBox_unselectall.TabIndex = 6;
            this.checkBox_unselectall.Text = "Unselect All";
            this.checkBox_unselectall.UseVisualStyleBackColor = true;
            this.checkBox_unselectall.CheckedChanged += new System.EventHandler(this.checkBox_unselectall_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(126, 388);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(205, 23);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server Name: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbox_servername
            // 
            this.txtbox_servername.Location = new System.Drawing.Point(94, 9);
            this.txtbox_servername.Name = "txtbox_servername";
            this.txtbox_servername.Size = new System.Drawing.Size(258, 20);
            this.txtbox_servername.TabIndex = 10;
            // 
            // txtbox_foldername
            // 
            this.txtbox_foldername.Location = new System.Drawing.Point(94, 53);
            this.txtbox_foldername.Name = "txtbox_foldername";
            this.txtbox_foldername.ReadOnly = true;
            this.txtbox_foldername.Size = new System.Drawing.Size(258, 20);
            this.txtbox_foldername.TabIndex = 11;
            // 
            // btn_openfolder
            // 
            this.btn_openfolder.Location = new System.Drawing.Point(361, 52);
            this.btn_openfolder.Name = "btn_openfolder";
            this.btn_openfolder.Size = new System.Drawing.Size(99, 23);
            this.btn_openfolder.TabIndex = 12;
            this.btn_openfolder.Text = "Open Folder";
            this.btn_openfolder.UseVisualStyleBackColor = true;
            this.btn_openfolder.Click += new System.EventHandler(this.btn_openfolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Folder Name: ";
            // 
            // btn_testconnection
            // 
            this.btn_testconnection.Location = new System.Drawing.Point(361, 7);
            this.btn_testconnection.Name = "btn_testconnection";
            this.btn_testconnection.Size = new System.Drawing.Size(99, 23);
            this.btn_testconnection.TabIndex = 14;
            this.btn_testconnection.Text = "Test Connection";
            this.btn_testconnection.UseVisualStyleBackColor = true;
            this.btn_testconnection.Click += new System.EventHandler(this.btn_testconnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 438);
            this.Controls.Add(this.btn_testconnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_openfolder);
            this.Controls.Add(this.txtbox_foldername);
            this.Controls.Add(this.txtbox_servername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.checkBox_unselectall);
            this.Controls.Add(this.checkbox_selectall);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_filename);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Send Device Log To Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_filename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkbox_selectall;
        private System.Windows.Forms.CheckBox checkBox_unselectall;
        private System.Windows.Forms.Button btn_start;
        private ColumnHeader header;
        private Label label3;
        private TextBox txtbox_servername;
        private FolderBrowserDialog folderBrowserDialog;
        private TextBox txtbox_foldername;
        private Button btn_openfolder;
        private Label label4;
        private Button btn_testconnection;
    }
}

