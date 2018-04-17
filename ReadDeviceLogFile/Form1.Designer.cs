using System.Windows.Forms;

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
            this.checkbox_selectall = new System.Windows.Forms.CheckBox();
            this.checkBox_unselectall = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name: ";
            // 
            // txtbox_filename
            // 
            this.txtbox_filename.Location = new System.Drawing.Point(79, 28);
            this.txtbox_filename.Name = "txtbox_filename";
            this.txtbox_filename.Size = new System.Drawing.Size(115, 20);
            this.txtbox_filename.TabIndex = 1;
            this.txtbox_filename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".txt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(283, 28);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(178, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connnect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(16, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 223);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Width = -2;
            this.listView1.Columns.Add(header);
            // 
            // checkbox_selectall
            // 
            this.checkbox_selectall.AutoSize = true;
            this.checkbox_selectall.Location = new System.Drawing.Point(16, 309);
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
            this.checkBox_unselectall.Location = new System.Drawing.Point(126, 309);
            this.checkBox_unselectall.Name = "checkBox_unselectall";
            this.checkBox_unselectall.Size = new System.Drawing.Size(82, 17);
            this.checkBox_unselectall.TabIndex = 6;
            this.checkBox_unselectall.Text = "Unselect All";
            this.checkBox_unselectall.UseVisualStyleBackColor = true;
            this.checkBox_unselectall.CheckedChanged += new System.EventHandler(this.checkBox_unselectall_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(16, 342);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(205, 23);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(244, 341);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(217, 23);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 393);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.checkBox_unselectall);
            this.Controls.Add(this.checkbox_selectall);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_filename);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btn_stop;
    }
}

