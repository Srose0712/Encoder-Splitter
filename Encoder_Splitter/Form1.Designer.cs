
using System.Windows.Forms;

namespace Encoder_Splitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.browseInputBox = new System.Windows.Forms.TextBox();
            this.writeInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitButton
            // 
            this.splitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitButton.Image = ((System.Drawing.Image)(resources.GetObject("splitButton.Image")));
            this.splitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.splitButton.Location = new System.Drawing.Point(634, 50);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(139, 23);
            this.splitButton.TabIndex = 0;
            this.splitButton.Text = "Split Bulk Inquiries";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decodeButton.Image = ((System.Drawing.Image)(resources.GetObject("decodeButton.Image")));
            this.decodeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.decodeButton.Location = new System.Drawing.Point(489, 50);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(139, 23);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "HTML Query Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encodeButton.Image = ((System.Drawing.Image)(resources.GetObject("encodeButton.Image")));
            this.encodeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.encodeButton.Location = new System.Drawing.Point(489, 9);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(139, 23);
            this.encodeButton.TabIndex = 2;
            this.encodeButton.Text = "HTML Query Encode\r\n";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
            this.browseButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.browseButton.Location = new System.Drawing.Point(344, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseInputBox
            // 
            this.browseInputBox.Location = new System.Drawing.Point(36, 12);
            this.browseInputBox.Name = "browseInputBox";
            this.browseInputBox.Size = new System.Drawing.Size(302, 20);
            this.browseInputBox.TabIndex = 4;
            this.browseInputBox.TextChanged += new System.EventHandler(this.browseInputBox_TextChanged);
            // 
            // writeInputBox
            // 
            this.writeInputBox.Location = new System.Drawing.Point(36, 53);
            this.writeInputBox.Name = "writeInputBox";
            this.writeInputBox.Size = new System.Drawing.Size(302, 20);
            this.writeInputBox.TabIndex = 5;
            this.writeInputBox.TextChanged += new System.EventHandler(this.writeInputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(334, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*For best results do not include any comments within your inquiries to be encoded" +
    "/decoded.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HTML Query Encode is specifically for taking an XML/HTML query and encoding the H" +
    "TML entities into the line so SoapUI can read it.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(618, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "HTML Query Decode is specifically for taking an XML/HTML query and decoding the H" +
    "TML entities out of the line for legacy use.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(632, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Split Bulk Inquiries is used for taking a single file and splitting out the many " +
    "queries into their own individual files to the specified folder.";
            // 
            // closeButton
            // 
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.Location = new System.Drawing.Point(763, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(344, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Insert Name for Enc/Dec Only";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(201, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 171);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeInputBox);
            this.Controls.Add(this.browseInputBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.splitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox browseInputBox;
        private System.Windows.Forms.TextBox writeInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
    }
}

