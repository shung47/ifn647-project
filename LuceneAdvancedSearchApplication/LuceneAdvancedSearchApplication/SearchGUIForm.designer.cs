﻿namespace LuceneAdvancedSearchApplication
{
    partial class SearchGUIForm
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
            this.TextEnter = new System.Windows.Forms.TextBox();
            this.myNeedsDialog = new System.Windows.Forms.OpenFileDialog();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.NeedsButton = new System.Windows.Forms.Button();
            this.NeedsLabel = new System.Windows.Forms.Label();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.SaveResult = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.FinalQTxtbox = new System.Windows.Forms.TextBox();
            this.FinalQLab = new System.Windows.Forms.Label();
            this.resultLab = new System.Windows.Forms.Label();
            this.resultNumLab = new System.Windows.Forms.Label();
            this.asIsCheckBox = new System.Windows.Forms.CheckBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextEnter
            // 
            this.TextEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEnter.Location = new System.Drawing.Point(128, 56);
            this.TextEnter.Name = "TextEnter";
            this.TextEnter.Size = new System.Drawing.Size(471, 22);
            this.TextEnter.TabIndex = 1;
            this.TextEnter.TextChanged += new System.EventHandler(this.TextEnter_TextChanged);
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Enabled = false;
            this.SearchBtn1.Location = new System.Drawing.Point(662, 124);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(100, 20);
            this.SearchBtn1.TabIndex = 13;
            this.SearchBtn1.Text = "Search";
            this.SearchBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SearchBtn1.UseVisualStyleBackColor = true;
            this.SearchBtn1.Click += new System.EventHandler(this.SearchBtn1_Click);
            // 
            // NeedsButton
            // 
            this.NeedsButton.Location = new System.Drawing.Point(42, 125);
            this.NeedsButton.Name = "NeedsButton";
            this.NeedsButton.Size = new System.Drawing.Size(120, 20);
            this.NeedsButton.TabIndex = 14;
            this.NeedsButton.Text = "Select Cran needs";
            this.NeedsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NeedsButton.UseVisualStyleBackColor = true;
            this.NeedsButton.Click += new System.EventHandler(this.NeedsButton_Click);
            // 
            // NeedsLabel
            // 
            this.NeedsLabel.AutoSize = true;
            this.NeedsLabel.Location = new System.Drawing.Point(43, 149);
            this.NeedsLabel.Name = "NeedsLabel";
            this.NeedsLabel.Size = new System.Drawing.Size(57, 13);
            this.NeedsLabel.TabIndex = 15;
            this.NeedsLabel.Text = "Needs File";
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Enabled = false;
            this.PreviousBtn.Location = new System.Drawing.Point(298, 492);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(75, 23);
            this.PreviousBtn.TabIndex = 18;
            this.PreviousBtn.Text = "Previous 10";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(389, 492);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 19;
            this.NextBtn.Text = "Next 10";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search for:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "OR";
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(662, 55);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(100, 20);
            this.SearchBtn2.TabIndex = 22;
            this.SearchBtn2.Text = "Search";
            this.SearchBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SearchBtn2.UseVisualStyleBackColor = true;
            this.SearchBtn2.Click += new System.EventHandler(this.SearchBtn2_Click);
            // 
            // SaveResult
            // 
            this.SaveResult.Enabled = false;
            this.SaveResult.Location = new System.Drawing.Point(662, 170);
            this.SaveResult.Name = "SaveResult";
            this.SaveResult.Size = new System.Drawing.Size(100, 20);
            this.SaveResult.TabIndex = 24;
            this.SaveResult.Text = "Save";
            this.SaveResult.UseVisualStyleBackColor = true;
            this.SaveResult.Click += new System.EventHandler(this.SaveResult_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "001",
            "002",
            "023",
            "157",
            "219"});
            this.comboBox1.Location = new System.Drawing.Point(298, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Select Need:";
            // 
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Location = new System.Drawing.Point(643, 502);
            this.Pagelabel.MaximumSize = new System.Drawing.Size(130, 20);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(0, 13);
            this.Pagelabel.TabIndex = 29;
            // 
            // resultListView
            // 
            this.resultListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.resultListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(12, 228);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(750, 250);
            this.resultListView.TabIndex = 10;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListDictView_SelectedIndexChanged);
            // 
            // FinalQTxtbox
            // 
            this.FinalQTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalQTxtbox.Location = new System.Drawing.Point(296, 170);
            this.FinalQTxtbox.Multiline = true;
            this.FinalQTxtbox.Name = "FinalQTxtbox";
            this.FinalQTxtbox.Size = new System.Drawing.Size(347, 52);
            this.FinalQTxtbox.TabIndex = 30;
            // 
            // FinalQLab
            // 
            this.FinalQLab.AutoSize = true;
            this.FinalQLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalQLab.Location = new System.Drawing.Point(194, 183);
            this.FinalQLab.Name = "FinalQLab";
            this.FinalQLab.Size = new System.Drawing.Size(98, 16);
            this.FinalQLab.TabIndex = 31;
            this.FinalQLab.Text = "Final query - ";
            // 
            // resultLab
            // 
            this.resultLab.AutoSize = true;
            this.resultLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLab.Location = new System.Drawing.Point(24, 213);
            this.resultLab.Name = "resultLab";
            this.resultLab.Size = new System.Drawing.Size(0, 16);
            this.resultLab.TabIndex = 32;
            // 
            // resultNumLab
            // 
            this.resultNumLab.AutoSize = true;
            this.resultNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNumLab.Location = new System.Drawing.Point(141, 213);
            this.resultNumLab.Name = "resultNumLab";
            this.resultNumLab.Size = new System.Drawing.Size(0, 16);
            this.resultNumLab.TabIndex = 33;
            // 
            // asIsCheckBox
            // 
            this.asIsCheckBox.AutoSize = true;
            this.asIsCheckBox.Location = new System.Drawing.Point(513, 81);
            this.asIsCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asIsCheckBox.Name = "asIsCheckBox";
            this.asIsCheckBox.Size = new System.Drawing.Size(86, 17);
            this.asIsCheckBox.TabIndex = 34;
            this.asIsCheckBox.Text = "Search As Is";
            this.asIsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Enabled = false;
            this.ConvertBtn.Location = new System.Drawing.Point(662, 196);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(100, 20);
            this.ConvertBtn.TabIndex = 35;
            this.ConvertBtn.Text = "Convert2Unix";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // SearchGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.asIsCheckBox);
            this.Controls.Add(this.resultNumLab);
            this.Controls.Add(this.resultLab);
            this.Controls.Add(this.FinalQLab);
            this.Controls.Add(this.FinalQTxtbox);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveResult);
            this.Controls.Add(this.SearchBtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.NeedsLabel);
            this.Controls.Add(this.NeedsButton);
            this.Controls.Add(this.SearchBtn1);
            this.Controls.Add(this.TextEnter);
            this.Name = "SearchGUIForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchGUIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextEnter;
        private System.Windows.Forms.OpenFileDialog myNeedsDialog;

        private System.Windows.Forms.Label[] LabelArray;
        private System.Windows.Forms.Button SearchBtn1;
        private System.Windows.Forms.Button NeedsButton;
        private System.Windows.Forms.Label NeedsLabel;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn2;
        private System.Windows.Forms.Button SaveResult;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.TextBox FinalQTxtbox;
        private System.Windows.Forms.Label FinalQLab;
        private System.Windows.Forms.Label resultLab;
        private System.Windows.Forms.Label resultNumLab;
        private System.Windows.Forms.CheckBox asIsCheckBox;
        private System.Windows.Forms.Button ConvertBtn;
    }
}

