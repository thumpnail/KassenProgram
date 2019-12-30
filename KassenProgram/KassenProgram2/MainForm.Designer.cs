using System.Windows.Forms;
using System;

namespace KassenProgram {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.buttonViewSelected = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectColum = new System.Windows.Forms.ComboBox();
            this.textSearchField = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.comboBoxSelectDateType = new System.Windows.Forms.ComboBox();
            this.buttonCMD = new System.Windows.Forms.Button();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(1226, 30);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(202, 34);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.AutoArrange = false;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "mainListView";
            this.listView2.Size = new System.Drawing.Size(1203, 775);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // buttonViewSelected
            // 
            this.buttonViewSelected.Location = new System.Drawing.Point(1226, 70);
            this.buttonViewSelected.Name = "buttonViewSelected";
            this.buttonViewSelected.Size = new System.Drawing.Size(202, 34);
            this.buttonViewSelected.TabIndex = 4;
            this.buttonViewSelected.Text = "View Selected  Item";
            this.buttonViewSelected.UseVisualStyleBackColor = true;
            this.buttonViewSelected.Click += new System.EventHandler(this.buttonViewSelected_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(1226, 110);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(202, 34);
            this.buttonDeleteSelected.TabIndex = 5;
            this.buttonDeleteSelected.Text = "Delete Selected Item";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1226, 725);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(94, 34);
            this.Update.TabIndex = 6;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1226, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Section:";
            // 
            // comboBoxSelectColum
            // 
            this.comboBoxSelectColum.FormattingEnabled = true;
            this.comboBoxSelectColum.Location = new System.Drawing.Point(1226, 170);
            this.comboBoxSelectColum.Name = "comboBoxSelectColum";
            this.comboBoxSelectColum.Size = new System.Drawing.Size(202, 28);
            this.comboBoxSelectColum.TabIndex = 8;
            // 
            // textSearchField
            // 
            this.textSearchField.Location = new System.Drawing.Point(1226, 204);
            this.textSearchField.Name = "textSearchField";
            this.textSearchField.PlaceholderText = "Search Field";
            this.textSearchField.Size = new System.Drawing.Size(202, 27);
            this.textSearchField.TabIndex = 9;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1226, 237);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 34);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1334, 237);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 34);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1226, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1226, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "To:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1226, 368);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(202, 27);
            this.dateTimePickerFrom.TabIndex = 14;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(1226, 421);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(202, 27);
            this.dateTimePickerTo.TabIndex = 15;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(1334, 454);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(94, 34);
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1236, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "_____________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1236, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "_____________________________";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(1226, 528);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(202, 34);
            this.buttonCalc.TabIndex = 18;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // comboBoxSelectDateType
            // 
            this.comboBoxSelectDateType.FormattingEnabled = true;
            this.comboBoxSelectDateType.Location = new System.Drawing.Point(1226, 314);
            this.comboBoxSelectDateType.Name = "comboBoxSelectDateType";
            this.comboBoxSelectDateType.Size = new System.Drawing.Size(202, 28);
            this.comboBoxSelectDateType.TabIndex = 19;
            // 
            // buttonCMD
            // 
            this.buttonCMD.Location = new System.Drawing.Point(1334, 725);
            this.buttonCMD.Name = "buttonCMD";
            this.buttonCMD.Size = new System.Drawing.Size(94, 34);
            this.buttonCMD.TabIndex = 20;
            this.buttonCMD.Text = "CMD Mode";
            this.buttonCMD.UseVisualStyleBackColor = true;
            this.buttonCMD.Click += new System.EventHandler(this.buttonCMD_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 775);
            this.Controls.Add(this.buttonCMD);
            this.Controls.Add(this.comboBoxSelectDateType);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textSearchField);
            this.Controls.Add(this.comboBoxSelectColum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonViewSelected);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonViewSelected;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button Update;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxSelectColum;
        public System.Windows.Forms.TextBox textSearchField;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ComboBox comboBoxSelectDateType;
        private Button buttonCMD;
    }
}