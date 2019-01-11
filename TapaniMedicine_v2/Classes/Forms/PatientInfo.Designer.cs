namespace TapaniMedicine_v2.Classes.Forms
{
    partial class PatientInfo
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
            this.BT_ToOperation = new System.Windows.Forms.Button();
            this.GB_Person = new System.Windows.Forms.GroupBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.LB_Title = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.LB_Surname = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.GB_DefaultStats = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Pulse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_LPressure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_HPressure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Blood = new System.Windows.Forms.TextBox();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.GB_DocNotes = new System.Windows.Forms.GroupBox();
            this.RTB_DocNotes = new System.Windows.Forms.RichTextBox();
            this.GB_State = new System.Windows.Forms.GroupBox();
            this.LB_State = new System.Windows.Forms.Label();
            this.BT_Criofreeze = new System.Windows.Forms.Button();
            this.GB_Person.SuspendLayout();
            this.GB_DefaultStats.SuspendLayout();
            this.GB_DocNotes.SuspendLayout();
            this.GB_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_ToOperation
            // 
            this.BT_ToOperation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_ToOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_ToOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BT_ToOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ToOperation.Location = new System.Drawing.Point(28, 387);
            this.BT_ToOperation.Name = "BT_ToOperation";
            this.BT_ToOperation.Size = new System.Drawing.Size(185, 38);
            this.BT_ToOperation.TabIndex = 3;
            this.BT_ToOperation.Text = "Подготовить к операции";
            this.BT_ToOperation.UseVisualStyleBackColor = false;
            this.BT_ToOperation.Click += new System.EventHandler(this.BT_ToOperation_Click);
            this.BT_ToOperation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_ToOperation.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // GB_Person
            // 
            this.GB_Person.BackColor = System.Drawing.Color.Black;
            this.GB_Person.Controls.Add(this.LB_ID);
            this.GB_Person.Controls.Add(this.TB_ID);
            this.GB_Person.Controls.Add(this.LB_Title);
            this.GB_Person.Controls.Add(this.TB_Title);
            this.GB_Person.Controls.Add(this.LB_Surname);
            this.GB_Person.Controls.Add(this.TB_Surname);
            this.GB_Person.Controls.Add(this.LB_Name);
            this.GB_Person.Controls.Add(this.TB_Name);
            this.GB_Person.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_Person.Location = new System.Drawing.Point(22, 25);
            this.GB_Person.Name = "GB_Person";
            this.GB_Person.Size = new System.Drawing.Size(238, 140);
            this.GB_Person.TabIndex = 4;
            this.GB_Person.TabStop = false;
            this.GB_Person.Text = "Личность";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Location = new System.Drawing.Point(44, 108);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(18, 13);
            this.LB_ID.TabIndex = 7;
            this.LB_ID.Text = "ID";
            // 
            // TB_ID
            // 
            this.TB_ID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_ID.Location = new System.Drawing.Point(68, 104);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(156, 20);
            this.TB_ID.TabIndex = 6;
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(26, 78);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(36, 13);
            this.LB_Title.TabIndex = 5;
            this.LB_Title.Text = "Титул";
            // 
            // TB_Title
            // 
            this.TB_Title.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Title.Location = new System.Drawing.Point(68, 75);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.ReadOnly = true;
            this.TB_Title.Size = new System.Drawing.Size(156, 20);
            this.TB_Title.TabIndex = 4;
            // 
            // LB_Surname
            // 
            this.LB_Surname.AutoSize = true;
            this.LB_Surname.Location = new System.Drawing.Point(6, 52);
            this.LB_Surname.Name = "LB_Surname";
            this.LB_Surname.Size = new System.Drawing.Size(56, 13);
            this.LB_Surname.TabIndex = 3;
            this.LB_Surname.Text = "Фамилия";
            // 
            // TB_Surname
            // 
            this.TB_Surname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Surname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Surname.Location = new System.Drawing.Point(68, 49);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.ReadOnly = true;
            this.TB_Surname.Size = new System.Drawing.Size(156, 20);
            this.TB_Surname.TabIndex = 2;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(33, 26);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(29, 13);
            this.LB_Name.TabIndex = 1;
            this.LB_Name.Text = "Имя";
            // 
            // TB_Name
            // 
            this.TB_Name.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Name.Location = new System.Drawing.Point(68, 23);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(156, 20);
            this.TB_Name.TabIndex = 0;
            // 
            // GB_DefaultStats
            // 
            this.GB_DefaultStats.BackColor = System.Drawing.Color.Black;
            this.GB_DefaultStats.Controls.Add(this.label8);
            this.GB_DefaultStats.Controls.Add(this.label5);
            this.GB_DefaultStats.Controls.Add(this.label4);
            this.GB_DefaultStats.Controls.Add(this.label7);
            this.GB_DefaultStats.Controls.Add(this.label6);
            this.GB_DefaultStats.Controls.Add(this.TB_Pulse);
            this.GB_DefaultStats.Controls.Add(this.label1);
            this.GB_DefaultStats.Controls.Add(this.TB_LPressure);
            this.GB_DefaultStats.Controls.Add(this.label2);
            this.GB_DefaultStats.Controls.Add(this.TB_HPressure);
            this.GB_DefaultStats.Controls.Add(this.label3);
            this.GB_DefaultStats.Controls.Add(this.TB_Blood);
            this.GB_DefaultStats.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_DefaultStats.Location = new System.Drawing.Point(266, 25);
            this.GB_DefaultStats.Name = "GB_DefaultStats";
            this.GB_DefaultStats.Size = new System.Drawing.Size(232, 140);
            this.GB_DefaultStats.TabIndex = 6;
            this.GB_DefaultStats.TabStop = false;
            this.GB_DefaultStats.Text = "Средние медицинские показатели за всё время";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "мл";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "уд/мин";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "мм рт.ст.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "мм рт.ст.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пульс";
            // 
            // TB_Pulse
            // 
            this.TB_Pulse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Pulse.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Pulse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pulse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Pulse.Location = new System.Drawing.Point(86, 101);
            this.TB_Pulse.Name = "TB_Pulse";
            this.TB_Pulse.ReadOnly = true;
            this.TB_Pulse.Size = new System.Drawing.Size(83, 20);
            this.TB_Pulse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Давление (Н)";
            // 
            // TB_LPressure
            // 
            this.TB_LPressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_LPressure.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_LPressure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_LPressure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_LPressure.Location = new System.Drawing.Point(86, 75);
            this.TB_LPressure.Name = "TB_LPressure";
            this.TB_LPressure.ReadOnly = true;
            this.TB_LPressure.Size = new System.Drawing.Size(83, 20);
            this.TB_LPressure.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Давление (В)";
            // 
            // TB_HPressure
            // 
            this.TB_HPressure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_HPressure.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_HPressure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_HPressure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_HPressure.Location = new System.Drawing.Point(86, 49);
            this.TB_HPressure.Name = "TB_HPressure";
            this.TB_HPressure.ReadOnly = true;
            this.TB_HPressure.Size = new System.Drawing.Size(83, 20);
            this.TB_HPressure.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кровь";
            // 
            // TB_Blood
            // 
            this.TB_Blood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Blood.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Blood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Blood.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Blood.Location = new System.Drawing.Point(86, 23);
            this.TB_Blood.Name = "TB_Blood";
            this.TB_Blood.ReadOnly = true;
            this.TB_Blood.Size = new System.Drawing.Size(83, 20);
            this.TB_Blood.TabIndex = 0;
            // 
            // BT_Exit
            // 
            this.BT_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Exit.Location = new System.Drawing.Point(573, 387);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(118, 38);
            this.BT_Exit.TabIndex = 7;
            this.BT_Exit.Text = "Выход";
            this.BT_Exit.UseVisualStyleBackColor = false;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            this.BT_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Exit.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // GB_DocNotes
            // 
            this.GB_DocNotes.BackColor = System.Drawing.Color.Black;
            this.GB_DocNotes.Controls.Add(this.RTB_DocNotes);
            this.GB_DocNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_DocNotes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_DocNotes.Location = new System.Drawing.Point(22, 176);
            this.GB_DocNotes.Name = "GB_DocNotes";
            this.GB_DocNotes.Size = new System.Drawing.Size(666, 205);
            this.GB_DocNotes.TabIndex = 6;
            this.GB_DocNotes.TabStop = false;
            this.GB_DocNotes.Text = "Заметки врача";
            // 
            // RTB_DocNotes
            // 
            this.RTB_DocNotes.BackColor = System.Drawing.SystemColors.InfoText;
            this.RTB_DocNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_DocNotes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RTB_DocNotes.Location = new System.Drawing.Point(9, 19);
            this.RTB_DocNotes.Name = "RTB_DocNotes";
            this.RTB_DocNotes.Size = new System.Drawing.Size(651, 180);
            this.RTB_DocNotes.TabIndex = 0;
            this.RTB_DocNotes.Text = "";
            // 
            // GB_State
            // 
            this.GB_State.BackColor = System.Drawing.Color.Black;
            this.GB_State.Controls.Add(this.LB_State);
            this.GB_State.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_State.Location = new System.Drawing.Point(513, 25);
            this.GB_State.Name = "GB_State";
            this.GB_State.Size = new System.Drawing.Size(178, 69);
            this.GB_State.TabIndex = 6;
            this.GB_State.TabStop = false;
            this.GB_State.Text = "Состояние";
            // 
            // LB_State
            // 
            this.LB_State.AutoSize = true;
            this.LB_State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_State.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_State.ForeColor = System.Drawing.Color.SkyBlue;
            this.LB_State.Location = new System.Drawing.Point(17, 21);
            this.LB_State.Name = "LB_State";
            this.LB_State.Size = new System.Drawing.Size(144, 32);
            this.LB_State.TabIndex = 0;
            this.LB_State.Text = "В СТАЗИСЕ";
            this.LB_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_Criofreeze
            // 
            this.BT_Criofreeze.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Criofreeze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Criofreeze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BT_Criofreeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Criofreeze.Location = new System.Drawing.Point(513, 100);
            this.BT_Criofreeze.Name = "BT_Criofreeze";
            this.BT_Criofreeze.Size = new System.Drawing.Size(178, 28);
            this.BT_Criofreeze.TabIndex = 8;
            this.BT_Criofreeze.Text = "Разморозить";
            this.BT_Criofreeze.UseVisualStyleBackColor = false;
            this.BT_Criofreeze.Click += new System.EventHandler(this.BT_Criofreeze_Click);
            this.BT_Criofreeze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Criofreeze.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.BT_Criofreeze);
            this.Controls.Add(this.GB_State);
            this.Controls.Add(this.GB_DocNotes);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.GB_DefaultStats);
            this.Controls.Add(this.GB_Person);
            this.Controls.Add(this.BT_ToOperation);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientInfo";
            this.GB_Person.ResumeLayout(false);
            this.GB_Person.PerformLayout();
            this.GB_DefaultStats.ResumeLayout(false);
            this.GB_DefaultStats.PerformLayout();
            this.GB_DocNotes.ResumeLayout(false);
            this.GB_State.ResumeLayout(false);
            this.GB_State.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ToOperation;
        private System.Windows.Forms.GroupBox GB_Person;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label LB_Surname;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.GroupBox GB_DefaultStats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Pulse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_LPressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_HPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Blood;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.GroupBox GB_DocNotes;
        private System.Windows.Forms.RichTextBox RTB_DocNotes;
        private System.Windows.Forms.GroupBox GB_State;
        private System.Windows.Forms.Label LB_State;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Button BT_Criofreeze;
    }
}