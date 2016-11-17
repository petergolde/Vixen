namespace VixenEditor
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadMainFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChannels = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelChannelsTemplate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPeriodTemplate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLengthTemplate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFileNameTemplate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLoadTemplate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownTriggerChannel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.upDownTriggerEvery = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCopyTo = new System.Windows.Forms.TextBox();
            this.textBoxMergeTo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonSaveMainFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.upDownTemplateAlign = new VixenEditor.TimeSpanUpDown();
            this.upDownTemplateEndTime = new VixenEditor.TimeSpanUpDown();
            this.upDownTemplateStartTime = new VixenEditor.TimeSpanUpDown();
            this.upDownEndTime = new VixenEditor.TimeSpanUpDown();
            this.upDownStartTime = new VixenEditor.TimeSpanUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTriggerChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTriggerEvery)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.DefaultExt = "vix";
            this.openFileDialogMain.Filter = "Vixen Files|*.vix";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSaveMainFile);
            this.groupBox1.Controls.Add(this.labelChannels);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelPeriod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonLoadMainFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vixen File Being Edited";
            // 
            // buttonLoadMainFile
            // 
            this.buttonLoadMainFile.Location = new System.Drawing.Point(6, 19);
            this.buttonLoadMainFile.Name = "buttonLoadMainFile";
            this.buttonLoadMainFile.Size = new System.Drawing.Size(108, 23);
            this.buttonLoadMainFile.TabIndex = 1;
            this.buttonLoadMainFile.Text = "Load File...";
            this.buttonLoadMainFile.UseVisualStyleBackColor = true;
            this.buttonLoadMainFile.Click += new System.EventHandler(this.buttonLoadMainFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(211, 24);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(16, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(211, 41);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(16, 13);
            this.labelLength.TabIndex = 5;
            this.labelLength.Text = "---";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(448, 41);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(16, 13);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Period:";
            // 
            // labelChannels
            // 
            this.labelChannels.AutoSize = true;
            this.labelChannels.Location = new System.Drawing.Point(448, 24);
            this.labelChannels.Name = "labelChannels";
            this.labelChannels.Size = new System.Drawing.Size(16, 13);
            this.labelChannels.TabIndex = 9;
            this.labelChannels.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Channels:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelChannelsTemplate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelPeriodTemplate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelLengthTemplate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelFileNameTemplate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonLoadTemplate);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vixen Template";
            // 
            // labelChannelsTemplate
            // 
            this.labelChannelsTemplate.AutoSize = true;
            this.labelChannelsTemplate.Location = new System.Drawing.Point(448, 24);
            this.labelChannelsTemplate.Name = "labelChannelsTemplate";
            this.labelChannelsTemplate.Size = new System.Drawing.Size(16, 13);
            this.labelChannelsTemplate.TabIndex = 9;
            this.labelChannelsTemplate.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Channels:";
            // 
            // labelPeriodTemplate
            // 
            this.labelPeriodTemplate.AutoSize = true;
            this.labelPeriodTemplate.Location = new System.Drawing.Point(448, 41);
            this.labelPeriodTemplate.Name = "labelPeriodTemplate";
            this.labelPeriodTemplate.Size = new System.Drawing.Size(16, 13);
            this.labelPeriodTemplate.TabIndex = 7;
            this.labelPeriodTemplate.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Period:";
            // 
            // labelLengthTemplate
            // 
            this.labelLengthTemplate.AutoSize = true;
            this.labelLengthTemplate.Location = new System.Drawing.Point(211, 41);
            this.labelLengthTemplate.Name = "labelLengthTemplate";
            this.labelLengthTemplate.Size = new System.Drawing.Size(16, 13);
            this.labelLengthTemplate.TabIndex = 5;
            this.labelLengthTemplate.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Length:";
            // 
            // labelFileNameTemplate
            // 
            this.labelFileNameTemplate.AutoSize = true;
            this.labelFileNameTemplate.Location = new System.Drawing.Point(211, 24);
            this.labelFileNameTemplate.Name = "labelFileNameTemplate";
            this.labelFileNameTemplate.Size = new System.Drawing.Size(16, 13);
            this.labelFileNameTemplate.TabIndex = 3;
            this.labelFileNameTemplate.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name: ";
            // 
            // buttonLoadTemplate
            // 
            this.buttonLoadTemplate.Location = new System.Drawing.Point(6, 19);
            this.buttonLoadTemplate.Name = "buttonLoadTemplate";
            this.buttonLoadTemplate.Size = new System.Drawing.Size(108, 23);
            this.buttonLoadTemplate.TabIndex = 1;
            this.buttonLoadTemplate.Text = "Load File...";
            this.buttonLoadTemplate.UseVisualStyleBackColor = true;
            this.buttonLoadTemplate.Click += new System.EventHandler(this.buttonLoadTemplate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.upDownTriggerEvery);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.upDownEndTime);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.upDownStartTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.upDownTriggerChannel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trigger Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trigger Channel:";
            // 
            // upDownTriggerChannel
            // 
            this.upDownTriggerChannel.Location = new System.Drawing.Point(127, 24);
            this.upDownTriggerChannel.Name = "upDownTriggerChannel";
            this.upDownTriggerChannel.Size = new System.Drawing.Size(54, 20);
            this.upDownTriggerChannel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Start Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "End Time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Trigger Every:";
            // 
            // upDownTriggerEvery
            // 
            this.upDownTriggerEvery.Location = new System.Drawing.Point(127, 54);
            this.upDownTriggerEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownTriggerEvery.Name = "upDownTriggerEvery";
            this.upDownTriggerEvery.Size = new System.Drawing.Size(54, 20);
            this.upDownTriggerEvery.TabIndex = 7;
            this.upDownTriggerEvery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.upDownTemplateAlign);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.upDownTemplateEndTime);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.upDownTemplateStartTime);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Template To Copy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "End Time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Start Time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Align With Trigger:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.textBoxMergeTo);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBoxCopyTo);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(12, 391);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(530, 80);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Channel Operations";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Copy channel numbers:";
            // 
            // textBoxCopyTo
            // 
            this.textBoxCopyTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCopyTo.Location = new System.Drawing.Point(159, 22);
            this.textBoxCopyTo.Name = "textBoxCopyTo";
            this.textBoxCopyTo.Size = new System.Drawing.Size(356, 20);
            this.textBoxCopyTo.TabIndex = 1;
            // 
            // textBoxMergeTo
            // 
            this.textBoxMergeTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMergeTo.Location = new System.Drawing.Point(159, 47);
            this.textBoxMergeTo.Name = "textBoxMergeTo";
            this.textBoxMergeTo.Size = new System.Drawing.Size(356, 20);
            this.textBoxMergeTo.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Merge channel numbers:";
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(210, 492);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(140, 42);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonSaveMainFile
            // 
            this.buttonSaveMainFile.Location = new System.Drawing.Point(6, 48);
            this.buttonSaveMainFile.Name = "buttonSaveMainFile";
            this.buttonSaveMainFile.Size = new System.Drawing.Size(108, 23);
            this.buttonSaveMainFile.TabIndex = 10;
            this.buttonSaveMainFile.Text = "Save File...";
            this.buttonSaveMainFile.UseVisualStyleBackColor = true;
            this.buttonSaveMainFile.Click += new System.EventHandler(this.buttonSaveMainFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "vix";
            this.saveFileDialog.Filter = "Vixen Files|*.vix";
            // 
            // upDownTemplateAlign
            // 
            this.upDownTemplateAlign.Increment = System.TimeSpan.Parse("00:00:00.1000000");
            this.upDownTemplateAlign.Location = new System.Drawing.Point(378, 30);
            this.upDownTemplateAlign.MaximumValue = System.TimeSpan.Parse("00:01:00");
            this.upDownTemplateAlign.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.upDownTemplateAlign.Name = "upDownTemplateAlign";
            this.upDownTemplateAlign.Size = new System.Drawing.Size(104, 20);
            this.upDownTemplateAlign.TabIndex = 11;
            this.upDownTemplateAlign.Text = "0:00.000";
            this.upDownTemplateAlign.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // upDownTemplateEndTime
            // 
            this.upDownTemplateEndTime.Increment = System.TimeSpan.Parse("00:00:00.1000000");
            this.upDownTemplateEndTime.Location = new System.Drawing.Point(91, 56);
            this.upDownTemplateEndTime.MaximumValue = System.TimeSpan.Parse("00:01:00");
            this.upDownTemplateEndTime.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.upDownTemplateEndTime.Name = "upDownTemplateEndTime";
            this.upDownTemplateEndTime.Size = new System.Drawing.Size(104, 20);
            this.upDownTemplateEndTime.TabIndex = 9;
            this.upDownTemplateEndTime.Text = "0:00.000";
            this.upDownTemplateEndTime.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // upDownTemplateStartTime
            // 
            this.upDownTemplateStartTime.Increment = System.TimeSpan.Parse("00:00:00.1000000");
            this.upDownTemplateStartTime.Location = new System.Drawing.Point(91, 30);
            this.upDownTemplateStartTime.MaximumValue = System.TimeSpan.Parse("00:01:00");
            this.upDownTemplateStartTime.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.upDownTemplateStartTime.Name = "upDownTemplateStartTime";
            this.upDownTemplateStartTime.Size = new System.Drawing.Size(104, 20);
            this.upDownTemplateStartTime.TabIndex = 7;
            this.upDownTemplateStartTime.Text = "0:00.000";
            this.upDownTemplateStartTime.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // upDownEndTime
            // 
            this.upDownEndTime.Increment = System.TimeSpan.Parse("00:00:00.1000000");
            this.upDownEndTime.Location = new System.Drawing.Point(378, 50);
            this.upDownEndTime.MaximumValue = System.TimeSpan.Parse("00:01:00");
            this.upDownEndTime.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.upDownEndTime.Name = "upDownEndTime";
            this.upDownEndTime.Size = new System.Drawing.Size(104, 20);
            this.upDownEndTime.TabIndex = 5;
            this.upDownEndTime.Text = "0:00.000";
            this.upDownEndTime.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // upDownStartTime
            // 
            this.upDownStartTime.Increment = System.TimeSpan.Parse("00:00:00.1000000");
            this.upDownStartTime.Location = new System.Drawing.Point(378, 24);
            this.upDownStartTime.MaximumValue = System.TimeSpan.Parse("00:01:00");
            this.upDownStartTime.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.upDownStartTime.Name = "upDownStartTime";
            this.upDownStartTime.Size = new System.Drawing.Size(104, 20);
            this.upDownStartTime.TabIndex = 3;
            this.upDownStartTime.Text = "0:00.000";
            this.upDownStartTime.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 546);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vixen Bulk Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTriggerChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTriggerEvery)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoadMainFile;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelChannelsTemplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPeriodTemplate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLengthTemplate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFileNameTemplate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLoadTemplate;
        private System.Windows.Forms.GroupBox groupBox3;
        private TimeSpanUpDown upDownStartTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown upDownTriggerChannel;
        private System.Windows.Forms.Label label3;
        private TimeSpanUpDown upDownEndTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown upDownTriggerEvery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private TimeSpanUpDown upDownTemplateAlign;
        private System.Windows.Forms.Label label15;
        private TimeSpanUpDown upDownTemplateEndTime;
        private System.Windows.Forms.Label label13;
        private TimeSpanUpDown upDownTemplateStartTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxMergeTo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCopyTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSaveMainFile;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

