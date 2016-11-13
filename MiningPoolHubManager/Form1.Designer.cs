﻿namespace MiningPoolHubManager
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
                try
                {
                    components.Dispose();
                }
                catch(System.Exception e)
                {

                }
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginTextField = new System.Windows.Forms.TextBox();
            this.coinComboBox = new System.Windows.Forms.ComboBox();
            this.coinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.coinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpuRadioButton = new System.Windows.Forms.RadioButton();
            this.gpuAMDRadioButton = new System.Windows.Forms.RadioButton();
            this.gpuNVIDIARadioButton = new System.Windows.Forms.RadioButton();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worker password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode:";
            // 
            // loginTextField
            // 
            this.loginTextField.AccessibleDescription = "";
            this.loginTextField.AccessibleName = "";
            this.loginTextField.Location = new System.Drawing.Point(132, 13);
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.Size = new System.Drawing.Size(285, 20);
            this.loginTextField.TabIndex = 1;
            this.loginTextField.Text = "loginname.worker";
            this.loginTextField.TextChanged += new System.EventHandler(this.loginTextField_TextChanged);
            // 
            // coinComboBox
            // 
            this.coinComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.coinComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.coinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coinBindingSource1, "name", true));
            this.coinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.coinBindingSource1, "name", true));
            this.coinComboBox.DataSource = this.coinBindingSource1;
            this.coinComboBox.DisplayMember = "name";
            this.coinComboBox.FormattingEnabled = true;
            this.coinComboBox.Location = new System.Drawing.Point(132, 65);
            this.coinComboBox.Name = "coinComboBox";
            this.coinComboBox.Size = new System.Drawing.Size(285, 21);
            this.coinComboBox.TabIndex = 3;
            this.coinComboBox.SelectedIndexChanged += new System.EventHandler(this.coinComboBox_SelectedIndexChanged_1);
            // 
            // coinBindingSource1
            // 
            this.coinBindingSource1.DataSource = typeof(MiningPoolHubManager.Coin);
            // 
            // modeComboBox
            // 
            this.modeComboBox.Enabled = false;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Simple coin mining (20XXX)",
            "Algo swirch mining (17XXX)",
            "Multi-Aalgo switch mining (12XXX)"});
            this.modeComboBox.Location = new System.Drawing.Point(132, 93);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(285, 21);
            this.modeComboBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(505, 266);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start mining!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Location = new System.Drawing.Point(132, 39);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.Size = new System.Drawing.Size(285, 20);
            this.passwordTextField.TabIndex = 2;
            this.passwordTextField.Text = "x";
            this.passwordTextField.TextChanged += new System.EventHandler(this.passwordTextField_TextChanged);
            // 
            // coinBindingSource
            // 
            this.coinBindingSource.DataSource = typeof(MiningPoolHubManager.Coin);
            // 
            // resultLabel
            // 
            this.resultLabel.AccessibleName = "";
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 204);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(155, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Fill out the form above to start...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Server-Country:";
            // 
            // serverComboBox
            // 
            this.serverComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.serverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serverComboBox.DataSource = this.serverBindingSource;
            this.serverComboBox.DisplayMember = "name";
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(132, 120);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(285, 21);
            this.serverComboBox.TabIndex = 4;
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged_1);
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataSource = typeof(MiningPoolHubManager.Server);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Location = new System.Drawing.Point(132, 147);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.Size = new System.Drawing.Size(483, 20);
            this.configTextBox.TabIndex = 13;
            this.configTextBox.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Miner configuration:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mining mode:";
            // 
            // cpuRadioButton
            // 
            this.cpuRadioButton.AutoSize = true;
            this.cpuRadioButton.Checked = true;
            this.cpuRadioButton.Location = new System.Drawing.Point(132, 174);
            this.cpuRadioButton.Name = "cpuRadioButton";
            this.cpuRadioButton.Size = new System.Drawing.Size(47, 17);
            this.cpuRadioButton.TabIndex = 5;
            this.cpuRadioButton.TabStop = true;
            this.cpuRadioButton.Text = "CPU";
            this.cpuRadioButton.UseVisualStyleBackColor = true;
            this.cpuRadioButton.CheckedChanged += new System.EventHandler(this.cpuRadioButton_CheckedChanged);
            // 
            // gpuAMDRadioButton
            // 
            this.gpuAMDRadioButton.AutoSize = true;
            this.gpuAMDRadioButton.Location = new System.Drawing.Point(186, 174);
            this.gpuAMDRadioButton.Name = "gpuAMDRadioButton";
            this.gpuAMDRadioButton.Size = new System.Drawing.Size(81, 17);
            this.gpuAMDRadioButton.TabIndex = 6;
            this.gpuAMDRadioButton.Text = "GPU (AMD)";
            this.gpuAMDRadioButton.UseVisualStyleBackColor = true;
            this.gpuAMDRadioButton.CheckedChanged += new System.EventHandler(this.gpuAMDRadioButton_CheckedChanged);
            // 
            // gpuNVIDIARadioButton
            // 
            this.gpuNVIDIARadioButton.AutoSize = true;
            this.gpuNVIDIARadioButton.Location = new System.Drawing.Point(274, 174);
            this.gpuNVIDIARadioButton.Name = "gpuNVIDIARadioButton";
            this.gpuNVIDIARadioButton.Size = new System.Drawing.Size(93, 17);
            this.gpuNVIDIARadioButton.TabIndex = 7;
            this.gpuNVIDIARadioButton.Text = "GPU (NVIDIA)";
            this.gpuNVIDIARadioButton.UseVisualStyleBackColor = true;
            this.gpuNVIDIARadioButton.CheckedChanged += new System.EventHandler(this.gpuNVIDIARadioButton_CheckedChanged);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(397, 266);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(102, 23);
            this.saveSettingsButton.TabIndex = 8;
            this.saveSettingsButton.Text = "Save settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 301);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.gpuNVIDIARadioButton);
            this.Controls.Add(this.gpuAMDRadioButton);
            this.Controls.Add(this.cpuRadioButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.configTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.serverComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.coinComboBox);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MiningPoolHub Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginTextField;
        private System.Windows.Forms.ComboBox coinComboBox;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox passwordTextField;
        private System.Windows.Forms.BindingSource coinBindingSource;
        private System.Windows.Forms.BindingSource coinBindingSource1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton cpuRadioButton;
        private System.Windows.Forms.RadioButton gpuAMDRadioButton;
        private System.Windows.Forms.RadioButton gpuNVIDIARadioButton;
        private System.Windows.Forms.Button saveSettingsButton;
    }
}
