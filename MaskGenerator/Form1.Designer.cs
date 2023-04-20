namespace MaskGenerator
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
            this.PB_RedChannel = new System.Windows.Forms.PictureBox();
            this.BT_ToMask = new System.Windows.Forms.Button();
            this.BT_ToChannels = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BT_ClearAlpha = new System.Windows.Forms.Button();
            this.PB_AlphaChannel = new System.Windows.Forms.PictureBox();
            this.BT_CopyAlphaChannel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BT_ClearBlue = new System.Windows.Forms.Button();
            this.PB_BlueChannel = new System.Windows.Forms.PictureBox();
            this.BT_CopyBlueChannel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BT_ClearGreen = new System.Windows.Forms.Button();
            this.PB_GreenChannel = new System.Windows.Forms.PictureBox();
            this.BT_CopyGreenChannel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_ClearRed = new System.Windows.Forms.Button();
            this.BT_CopyRedChannel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_ClearMask = new System.Windows.Forms.Button();
            this.BT_SaveMask = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.PB_Mask = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_OutputSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.CB_AlphaOne = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RedChannel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AlphaChannel)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BlueChannel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_GreenChannel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Mask)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_RedChannel
            // 
            this.PB_RedChannel.BackColor = System.Drawing.Color.Transparent;
            this.PB_RedChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_RedChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_RedChannel.Location = new System.Drawing.Point(6, 19);
            this.PB_RedChannel.Name = "PB_RedChannel";
            this.PB_RedChannel.Size = new System.Drawing.Size(128, 128);
            this.PB_RedChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_RedChannel.TabIndex = 0;
            this.PB_RedChannel.TabStop = false;
            this.PB_RedChannel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.PB_RedChannel.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // BT_ToMask
            // 
            this.BT_ToMask.Location = new System.Drawing.Point(325, 189);
            this.BT_ToMask.Name = "BT_ToMask";
            this.BT_ToMask.Size = new System.Drawing.Size(110, 23);
            this.BT_ToMask.TabIndex = 3;
            this.BT_ToMask.Text = "To Mask";
            this.BT_ToMask.UseVisualStyleBackColor = true;
            this.BT_ToMask.Click += new System.EventHandler(this.BT_ToMask_Click);
            // 
            // BT_ToChannels
            // 
            this.BT_ToChannels.Location = new System.Drawing.Point(325, 218);
            this.BT_ToChannels.Name = "BT_ToChannels";
            this.BT_ToChannels.Size = new System.Drawing.Size(110, 23);
            this.BT_ToChannels.TabIndex = 4;
            this.BT_ToChannels.Text = "To Channels";
            this.BT_ToChannels.UseVisualStyleBackColor = true;
            this.BT_ToChannels.Click += new System.EventHandler(this.BT_ToChannels_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 392);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channels";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BT_ClearAlpha);
            this.groupBox6.Controls.Add(this.PB_AlphaChannel);
            this.groupBox6.Controls.Add(this.BT_CopyAlphaChannel);
            this.groupBox6.Location = new System.Drawing.Point(154, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 181);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alpha Channel";
            // 
            // BT_ClearAlpha
            // 
            this.BT_ClearAlpha.Location = new System.Drawing.Point(73, 150);
            this.BT_ClearAlpha.Name = "BT_ClearAlpha";
            this.BT_ClearAlpha.Size = new System.Drawing.Size(61, 23);
            this.BT_ClearAlpha.TabIndex = 16;
            this.BT_ClearAlpha.Tag = "PB_AlphaChannel";
            this.BT_ClearAlpha.Text = "Clear";
            this.BT_ClearAlpha.UseVisualStyleBackColor = true;
            this.BT_ClearAlpha.Click += new System.EventHandler(this.BT_ClearImage_Click);
            // 
            // PB_AlphaChannel
            // 
            this.PB_AlphaChannel.BackColor = System.Drawing.Color.Transparent;
            this.PB_AlphaChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_AlphaChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_AlphaChannel.Location = new System.Drawing.Point(6, 19);
            this.PB_AlphaChannel.Name = "PB_AlphaChannel";
            this.PB_AlphaChannel.Size = new System.Drawing.Size(128, 128);
            this.PB_AlphaChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_AlphaChannel.TabIndex = 0;
            this.PB_AlphaChannel.TabStop = false;
            this.PB_AlphaChannel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.PB_AlphaChannel.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // BT_CopyAlphaChannel
            // 
            this.BT_CopyAlphaChannel.Location = new System.Drawing.Point(6, 151);
            this.BT_CopyAlphaChannel.Name = "BT_CopyAlphaChannel";
            this.BT_CopyAlphaChannel.Size = new System.Drawing.Size(61, 23);
            this.BT_CopyAlphaChannel.TabIndex = 15;
            this.BT_CopyAlphaChannel.Tag = "PB_AlphaChannel";
            this.BT_CopyAlphaChannel.Text = "Copy";
            this.BT_CopyAlphaChannel.UseVisualStyleBackColor = true;
            this.BT_CopyAlphaChannel.Click += new System.EventHandler(this.BT_CopyChannel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BT_ClearBlue);
            this.groupBox5.Controls.Add(this.PB_BlueChannel);
            this.groupBox5.Controls.Add(this.BT_CopyBlueChannel);
            this.groupBox5.Location = new System.Drawing.Point(6, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 181);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Blue Channel";
            // 
            // BT_ClearBlue
            // 
            this.BT_ClearBlue.Location = new System.Drawing.Point(73, 151);
            this.BT_ClearBlue.Name = "BT_ClearBlue";
            this.BT_ClearBlue.Size = new System.Drawing.Size(61, 23);
            this.BT_ClearBlue.TabIndex = 14;
            this.BT_ClearBlue.Tag = "PB_BlueChannel";
            this.BT_ClearBlue.Text = "Clear";
            this.BT_ClearBlue.UseVisualStyleBackColor = true;
            this.BT_ClearBlue.Click += new System.EventHandler(this.BT_ClearImage_Click);
            // 
            // PB_BlueChannel
            // 
            this.PB_BlueChannel.BackColor = System.Drawing.Color.Transparent;
            this.PB_BlueChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_BlueChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_BlueChannel.Location = new System.Drawing.Point(6, 19);
            this.PB_BlueChannel.Name = "PB_BlueChannel";
            this.PB_BlueChannel.Size = new System.Drawing.Size(128, 128);
            this.PB_BlueChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_BlueChannel.TabIndex = 0;
            this.PB_BlueChannel.TabStop = false;
            this.PB_BlueChannel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.PB_BlueChannel.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // BT_CopyBlueChannel
            // 
            this.BT_CopyBlueChannel.Location = new System.Drawing.Point(6, 152);
            this.BT_CopyBlueChannel.Name = "BT_CopyBlueChannel";
            this.BT_CopyBlueChannel.Size = new System.Drawing.Size(61, 23);
            this.BT_CopyBlueChannel.TabIndex = 13;
            this.BT_CopyBlueChannel.Tag = "PB_BlueChannel";
            this.BT_CopyBlueChannel.Text = "Copy";
            this.BT_CopyBlueChannel.UseVisualStyleBackColor = true;
            this.BT_CopyBlueChannel.Click += new System.EventHandler(this.BT_CopyChannel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BT_ClearGreen);
            this.groupBox4.Controls.Add(this.PB_GreenChannel);
            this.groupBox4.Controls.Add(this.BT_CopyGreenChannel);
            this.groupBox4.Location = new System.Drawing.Point(154, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 181);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Green Channel";
            // 
            // BT_ClearGreen
            // 
            this.BT_ClearGreen.Location = new System.Drawing.Point(73, 151);
            this.BT_ClearGreen.Name = "BT_ClearGreen";
            this.BT_ClearGreen.Size = new System.Drawing.Size(61, 23);
            this.BT_ClearGreen.TabIndex = 12;
            this.BT_ClearGreen.Tag = "PB_GreenChannel";
            this.BT_ClearGreen.Text = "Clear";
            this.BT_ClearGreen.UseVisualStyleBackColor = true;
            this.BT_ClearGreen.Click += new System.EventHandler(this.BT_ClearImage_Click);
            // 
            // PB_GreenChannel
            // 
            this.PB_GreenChannel.BackColor = System.Drawing.Color.Transparent;
            this.PB_GreenChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_GreenChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_GreenChannel.Location = new System.Drawing.Point(6, 19);
            this.PB_GreenChannel.Name = "PB_GreenChannel";
            this.PB_GreenChannel.Size = new System.Drawing.Size(128, 128);
            this.PB_GreenChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_GreenChannel.TabIndex = 0;
            this.PB_GreenChannel.TabStop = false;
            this.PB_GreenChannel.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.PB_GreenChannel.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // BT_CopyGreenChannel
            // 
            this.BT_CopyGreenChannel.Location = new System.Drawing.Point(6, 152);
            this.BT_CopyGreenChannel.Name = "BT_CopyGreenChannel";
            this.BT_CopyGreenChannel.Size = new System.Drawing.Size(61, 23);
            this.BT_CopyGreenChannel.TabIndex = 11;
            this.BT_CopyGreenChannel.Tag = "PB_GreenChannel";
            this.BT_CopyGreenChannel.Text = "Copy";
            this.BT_CopyGreenChannel.UseVisualStyleBackColor = true;
            this.BT_CopyGreenChannel.Click += new System.EventHandler(this.BT_CopyChannel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_ClearRed);
            this.groupBox3.Controls.Add(this.BT_CopyRedChannel);
            this.groupBox3.Controls.Add(this.PB_RedChannel);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 181);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Red Channel";
            // 
            // BT_ClearRed
            // 
            this.BT_ClearRed.Location = new System.Drawing.Point(73, 152);
            this.BT_ClearRed.Name = "BT_ClearRed";
            this.BT_ClearRed.Size = new System.Drawing.Size(61, 23);
            this.BT_ClearRed.TabIndex = 10;
            this.BT_ClearRed.Tag = "PB_RedChannel";
            this.BT_ClearRed.Text = "Clear";
            this.BT_ClearRed.UseVisualStyleBackColor = true;
            this.BT_ClearRed.Click += new System.EventHandler(this.BT_ClearImage_Click);
            // 
            // BT_CopyRedChannel
            // 
            this.BT_CopyRedChannel.Location = new System.Drawing.Point(6, 153);
            this.BT_CopyRedChannel.Name = "BT_CopyRedChannel";
            this.BT_CopyRedChannel.Size = new System.Drawing.Size(61, 23);
            this.BT_CopyRedChannel.TabIndex = 9;
            this.BT_CopyRedChannel.Tag = "PB_RedChannel";
            this.BT_CopyRedChannel.Text = "Copy";
            this.BT_CopyRedChannel.UseVisualStyleBackColor = true;
            this.BT_CopyRedChannel.Click += new System.EventHandler(this.BT_CopyChannel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_ClearMask);
            this.groupBox1.Controls.Add(this.BT_SaveMask);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.PB_Mask);
            this.groupBox1.Location = new System.Drawing.Point(441, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 370);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channels";
            // 
            // BT_ClearMask
            // 
            this.BT_ClearMask.Location = new System.Drawing.Point(137, 281);
            this.BT_ClearMask.Name = "BT_ClearMask";
            this.BT_ClearMask.Size = new System.Drawing.Size(125, 23);
            this.BT_ClearMask.TabIndex = 8;
            this.BT_ClearMask.Tag = "PB_Mask";
            this.BT_ClearMask.Text = "Clear";
            this.BT_ClearMask.UseVisualStyleBackColor = true;
            this.BT_ClearMask.Click += new System.EventHandler(this.BT_ClearImage_Click);
            // 
            // BT_SaveMask
            // 
            this.BT_SaveMask.Location = new System.Drawing.Point(6, 339);
            this.BT_SaveMask.Name = "BT_SaveMask";
            this.BT_SaveMask.Size = new System.Drawing.Size(256, 23);
            this.BT_SaveMask.TabIndex = 12;
            this.BT_SaveMask.Text = "Save As...";
            this.BT_SaveMask.UseVisualStyleBackColor = true;
            this.BT_SaveMask.Click += new System.EventHandler(this.BT_SaveMask_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(6, 310);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(256, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Save...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(6, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Browse...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // PB_Mask
            // 
            this.PB_Mask.BackColor = System.Drawing.Color.Transparent;
            this.PB_Mask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Mask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Mask.Location = new System.Drawing.Point(6, 19);
            this.PB_Mask.Name = "PB_Mask";
            this.PB_Mask.Size = new System.Drawing.Size(256, 256);
            this.PB_Mask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Mask.TabIndex = 0;
            this.PB_Mask.TabStop = false;
            this.PB_Mask.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.PB_Mask.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_OutputSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_OutputSize
            // 
            this.TSSL_OutputSize.Name = "TSSL_OutputSize";
            this.TSSL_OutputSize.Size = new System.Drawing.Size(68, 17);
            this.TSSL_OutputSize.Text = "OutputSize:";
            // 
            // CB_AlphaOne
            // 
            this.CB_AlphaOne.AutoSize = true;
            this.CB_AlphaOne.Location = new System.Drawing.Point(339, 247);
            this.CB_AlphaOne.Name = "CB_AlphaOne";
            this.CB_AlphaOne.Size = new System.Drawing.Size(76, 17);
            this.CB_AlphaOne.TabIndex = 9;
            this.CB_AlphaOne.Text = "Alpha One";
            this.CB_AlphaOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.CB_AlphaOne);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BT_ToChannels);
            this.Controls.Add(this.BT_ToMask);
            this.Name = "Form1";
            this.Text = "mask Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PB_RedChannel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_AlphaChannel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_BlueChannel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_GreenChannel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Mask)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_RedChannel;
        private System.Windows.Forms.Button BT_ToMask;
        private System.Windows.Forms.Button BT_ToChannels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PB_Mask;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox PB_AlphaChannel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox PB_BlueChannel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox PB_GreenChannel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BT_CopyRedChannel;
        private System.Windows.Forms.Button BT_SaveMask;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button BT_ClearAlpha;
        private System.Windows.Forms.Button BT_CopyAlphaChannel;
        private System.Windows.Forms.Button BT_ClearBlue;
        private System.Windows.Forms.Button BT_CopyBlueChannel;
        private System.Windows.Forms.Button BT_ClearGreen;
        private System.Windows.Forms.Button BT_CopyGreenChannel;
        private System.Windows.Forms.Button BT_ClearRed;
        private System.Windows.Forms.Button BT_ClearMask;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_OutputSize;
        private System.Windows.Forms.CheckBox CB_AlphaOne;
    }
}

