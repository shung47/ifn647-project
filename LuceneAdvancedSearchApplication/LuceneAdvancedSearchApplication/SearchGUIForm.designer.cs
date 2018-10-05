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
            this.SuspendLayout();
            // 
            // TextEnter
            // 
            this.TextEnter.Location = new System.Drawing.Point(177, 76);
            this.TextEnter.Name = "TextEnter";
            this.TextEnter.Size = new System.Drawing.Size(471, 20);
            this.TextEnter.TabIndex = 1;
            this.TextEnter.TextChanged += new System.EventHandler(this.TextEnter_TextChanged);
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Location = new System.Drawing.Point(676, 151);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(84, 22);
            this.SearchBtn1.TabIndex = 13;
            this.SearchBtn1.Text = "Search";
            this.SearchBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SearchBtn1.UseVisualStyleBackColor = true;
            this.SearchBtn1.Click += new System.EventHandler(this.SearchBtn1_Click);
            // 
            // NeedsButton
            // 
            this.NeedsButton.Location = new System.Drawing.Point(119, 150);
            this.NeedsButton.Name = "NeedsButton";
            this.NeedsButton.Size = new System.Drawing.Size(121, 23);
            this.NeedsButton.TabIndex = 14;
            this.NeedsButton.Text = "Select Cran needs";
            this.NeedsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NeedsButton.UseVisualStyleBackColor = true;
            this.NeedsButton.Click += new System.EventHandler(this.NeedsButton_Click);
            // 
            // NeedsLabel
            // 
            this.NeedsLabel.AutoSize = true;
            this.NeedsLabel.Location = new System.Drawing.Point(119, 176);
            this.NeedsLabel.Name = "NeedsLabel";
            this.NeedsLabel.Size = new System.Drawing.Size(57, 13);
            this.NeedsLabel.TabIndex = 15;
            this.NeedsLabel.Text = "Needs File";
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Enabled = false;
            this.PreviousBtn.Location = new System.Drawing.Point(568, 497);
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
            this.NextBtn.Location = new System.Drawing.Point(720, 497);
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
            this.label1.Location = new System.Drawing.Point(116, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search for:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "OR";
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(676, 76);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(84, 22);
            this.SearchBtn2.TabIndex = 22;
            this.SearchBtn2.Text = "Search";
            this.SearchBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SearchBtn2.UseVisualStyleBackColor = true;
            this.SearchBtn2.Click += new System.EventHandler(this.SearchBtn2_Click);
            // 
            // SaveResult
            // 
            this.SaveResult.Enabled = false;
            this.SaveResult.Location = new System.Drawing.Point(1124, 176);
            this.SaveResult.Name = "SaveResult";
            this.SaveResult.Size = new System.Drawing.Size(176, 40);
            this.SaveResult.TabIndex = 24;
            this.SaveResult.Text = "Save";
            this.SaveResult.UseVisualStyleBackColor = true;
            this.SaveResult.Click += new System.EventHandler(this.SaveResult_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "001",
            "002",
            "023",
            "157",
            "219"});
            this.comboBox1.Location = new System.Drawing.Point(371, 150);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "SelectCranNeed";
            // 
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Location = new System.Drawing.Point(650, 502);
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
            this.resultListView.Location = new System.Drawing.Point(26, 234);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(1274, 257);
            this.resultListView.TabIndex = 10;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.ResultListView_SelectedIndexChanged);
            // 
            // SearchGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 549);
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

        
    }
}

