namespace LvdwiczakColors
{
    partial class Colors
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
            this.blueValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.redValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.Location = new System.Drawing.Point(12, 360);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(13, 15);
            this.blueValue.TabIndex = 19;
            this.blueValue.Text = "0";
            this.blueValue.Click += new System.EventHandler(this.BlueValue_Click);
            // 
            // greenValue
            // 
            this.greenValue.AutoSize = true;
            this.greenValue.Location = new System.Drawing.Point(12, 297);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(13, 15);
            this.greenValue.TabIndex = 18;
            this.greenValue.Text = "0";
            // 
            // redValue
            // 
            this.redValue.AutoSize = true;
            this.redValue.Location = new System.Drawing.Point(12, 237);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(13, 15);
            this.redValue.TabIndex = 17;
            this.redValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Blue";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(12, 330);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(776, 45);
            this.blueTrackBar.TabIndex = 15;
            this.blueTrackBar.TabStop = false;
            this.blueTrackBar.Scroll += new System.EventHandler(this.BlueTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Green";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(12, 267);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(776, 45);
            this.greenTrackBar.TabIndex = 13;
            this.greenTrackBar.TabStop = false;
            this.greenTrackBar.Scroll += new System.EventHandler(this.GreenTrackBar_Scroll);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(12, 192);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 15);
            this.RedLabel.TabIndex = 12;
            this.RedLabel.Text = "Red";
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(12, 207);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(776, 45);
            this.redTrackBar.TabIndex = 11;
            this.redTrackBar.TabStop = false;
            this.redTrackBar.Scroll += new System.EventHandler(this.RedTrackBar_Scroll);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(12, 76);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(776, 108);
            this.colorPanel.TabIndex = 10;
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.redValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.colorPanel);
            this.Name = "Colors";
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label blueValue;
        private Label greenValue;
        private Label redValue;
        private Label label2;
        private TrackBar blueTrackBar;
        private Label label1;
        private TrackBar greenTrackBar;
        private Label RedLabel;
        private TrackBar redTrackBar;
        private Panel colorPanel;
    }
}