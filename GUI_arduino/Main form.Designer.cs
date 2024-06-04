using System.Windows.Forms;

namespace GUI_arduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.scanLabel = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.scanBox = new System.Windows.Forms.TextBox();
            this.selectedId = new System.Windows.Forms.Label();
            this.setModelBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jdgLabel = new System.Windows.Forms.Label();
            this.judge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.Location = new System.Drawing.Point(10, 32);
            this.scanLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(55, 24);
            this.scanLabel.TabIndex = 1;
            this.scanLabel.Text = "SCAN";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLabel.Location = new System.Drawing.Point(10, 67);
            this.setLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(103, 24);
            this.setLabel.TabIndex = 2;
            this.setLabel.Text = "SET MODEL";
            // 
            // scanBox
            // 
            this.scanBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBox.Location = new System.Drawing.Point(146, 27);
            this.scanBox.Margin = new System.Windows.Forms.Padding(5);
            this.scanBox.Name = "scanBox";
            this.scanBox.Size = new System.Drawing.Size(193, 26);
            this.scanBox.TabIndex = 5;
            // 
            // selectedId
            // 
            this.selectedId.AutoSize = true;
            this.selectedId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedId.Location = new System.Drawing.Point(143, 106);
            this.selectedId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.selectedId.Name = "selectedId";
            this.selectedId.Size = new System.Drawing.Size(14, 21);
            this.selectedId.TabIndex = 10;
            this.selectedId.Text = "-";
            // 
            // setModelBox
            // 
            this.setModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setModelBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setModelBox.FormattingEnabled = true;
            this.setModelBox.Location = new System.Drawing.Point(146, 64);
            this.setModelBox.Margin = new System.Windows.Forms.Padding(5);
            this.setModelBox.Name = "setModelBox";
            this.setModelBox.Size = new System.Drawing.Size(193, 29);
            this.setModelBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.jdgLabel);
            this.panel1.Location = new System.Drawing.Point(388, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 236);
            this.panel1.TabIndex = 12;
            // 
            // jdgLabel
            // 
            this.jdgLabel.AutoSize = true;
            this.jdgLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdgLabel.ForeColor = System.Drawing.Color.White;
            this.jdgLabel.Location = new System.Drawing.Point(25, 40);
            this.jdgLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.jdgLabel.Name = "jdgLabel";
            this.jdgLabel.Size = new System.Drawing.Size(217, 151);
            this.jdgLabel.TabIndex = 13;
            this.jdgLabel.Text = "OK";
            this.jdgLabel.Visible = false;
            // 
            // judge
            // 
            this.judge.AutoSize = true;
            this.judge.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judge.Location = new System.Drawing.Point(465, 93);
            this.judge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.judge.Name = "judge";
            this.judge.Size = new System.Drawing.Size(112, 24);
            this.judge.TabIndex = 13;
            this.judge.Text = "JUDGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "REG. NUMBER";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(21, 310);
            this.portLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(116, 21);
            this.portLabel.TabIndex = 15;
            this.portLabel.Text = "PORT ARDUINO";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(158, 328);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(77, 28);
            this.selectButton.TabIndex = 17;
            this.selectButton.Text = "OPEN";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // portBox
            // 
            this.portBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(25, 330);
            this.portBox.Margin = new System.Windows.Forms.Padding(5);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(125, 24);
            this.portBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setModelBox);
            this.groupBox1.Controls.Add(this.scanLabel);
            this.groupBox1.Controls.Add(this.setLabel);
            this.groupBox1.Controls.Add(this.scanBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectedId);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 161);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(241, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "CLOSE";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Laundry System Business Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Barcode Scanner Case A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(634, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "  ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 74);
            this.panel2.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.judge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Barcode Scanner Case A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.TextBox scanBox;
        private System.Windows.Forms.Label selectedId;
        private System.Windows.Forms.ComboBox setModelBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label jdgLabel;
        private Label judge;
        private Label label1;
        private Label portLabel;
        private Button selectButton;
        private ComboBox portBox;
        private GroupBox groupBox1;
        private Button cancelButton;
        private Label label3;
        private Label label2;
        private Label label5;
        private Panel panel2;
    }
}

