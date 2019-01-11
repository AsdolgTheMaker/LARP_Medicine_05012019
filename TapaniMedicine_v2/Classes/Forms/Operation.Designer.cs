namespace TapaniMedicine_v2.Classes.Forms
{
    partial class Operation
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
            this.TB_Exit = new System.Windows.Forms.Button();
            this.LB_Damages = new System.Windows.Forms.ListBox();
            this.BT_Heal = new System.Windows.Forms.Button();
            this.GB_DefaultStats = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Pain = new System.Windows.Forms.TextBox();
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
            this.TMR_StatsRandomize = new System.Windows.Forms.Timer(this.components);
            this.GB_Person = new System.Windows.Forms.GroupBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.LB_Title = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.LB_Surname = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Critical = new System.Windows.Forms.Label();
            this.TMR_CritFlickering = new System.Windows.Forms.Timer(this.components);
            this.GB_State = new System.Windows.Forms.GroupBox();
            this.RTB_Journal = new System.Windows.Forms.RichTextBox();
            this.TMR_Pulse = new System.Windows.Forms.Timer(this.components);
            this.GB_DefaultStats.SuspendLayout();
            this.GB_Person.SuspendLayout();
            this.GB_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Exit
            // 
            this.TB_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.TB_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.TB_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_Exit.Location = new System.Drawing.Point(584, 340);
            this.TB_Exit.Name = "TB_Exit";
            this.TB_Exit.Size = new System.Drawing.Size(136, 32);
            this.TB_Exit.TabIndex = 4;
            this.TB_Exit.Text = "Отменить операцию";
            this.TB_Exit.UseVisualStyleBackColor = false;
            this.TB_Exit.Click += new System.EventHandler(this.TB_Exit_Click);
            // 
            // LB_Damages
            // 
            this.LB_Damages.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LB_Damages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Damages.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_Damages.FormattingEnabled = true;
            this.LB_Damages.Location = new System.Drawing.Point(265, 26);
            this.LB_Damages.Name = "LB_Damages";
            this.LB_Damages.Size = new System.Drawing.Size(245, 210);
            this.LB_Damages.TabIndex = 5;
            // 
            // BT_Heal
            // 
            this.BT_Heal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Heal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Heal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Heal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Heal.Location = new System.Drawing.Point(288, 242);
            this.BT_Heal.Name = "BT_Heal";
            this.BT_Heal.Size = new System.Drawing.Size(198, 34);
            this.BT_Heal.TabIndex = 6;
            this.BT_Heal.Text = "Лечить выбранное повреждение";
            this.BT_Heal.UseVisualStyleBackColor = false;
            this.BT_Heal.Click += new System.EventHandler(this.BT_Heal_Click);
            // 
            // GB_DefaultStats
            // 
            this.GB_DefaultStats.BackColor = System.Drawing.Color.Black;
            this.GB_DefaultStats.Controls.Add(this.label9);
            this.GB_DefaultStats.Controls.Add(this.label10);
            this.GB_DefaultStats.Controls.Add(this.TB_Pain);
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
            this.GB_DefaultStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GB_DefaultStats.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_DefaultStats.Location = new System.Drawing.Point(516, 20);
            this.GB_DefaultStats.Name = "GB_DefaultStats";
            this.GB_DefaultStats.Size = new System.Drawing.Size(204, 165);
            this.GB_DefaultStats.TabIndex = 7;
            this.GB_DefaultStats.TabStop = false;
            this.GB_DefaultStats.Text = "Состояние пациента";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(145, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Болевой шок";
            // 
            // TB_Pain
            // 
            this.TB_Pain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Pain.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Pain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Pain.Location = new System.Drawing.Point(86, 130);
            this.TB_Pain.Name = "TB_Pain";
            this.TB_Pain.ReadOnly = true;
            this.TB_Pain.Size = new System.Drawing.Size(53, 20);
            this.TB_Pain.TabIndex = 15;
            this.TB_Pain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "мл";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "уд/мин";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "мм рт.ст.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 52);
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
            this.TB_Pulse.Size = new System.Drawing.Size(53, 20);
            this.TB_Pulse.TabIndex = 6;
            this.TB_Pulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.TB_LPressure.Size = new System.Drawing.Size(53, 20);
            this.TB_LPressure.TabIndex = 4;
            this.TB_LPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.TB_HPressure.Size = new System.Drawing.Size(53, 20);
            this.TB_HPressure.TabIndex = 2;
            this.TB_HPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.TB_Blood.Size = new System.Drawing.Size(53, 20);
            this.TB_Blood.TabIndex = 0;
            this.TB_Blood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TMR_StatsRandomize
            // 
            this.TMR_StatsRandomize.Enabled = true;
            this.TMR_StatsRandomize.Tick += new System.EventHandler(this.OnTimer);
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
            this.GB_Person.Location = new System.Drawing.Point(21, 20);
            this.GB_Person.Name = "GB_Person";
            this.GB_Person.Size = new System.Drawing.Size(238, 140);
            this.GB_Person.TabIndex = 18;
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
            // LB_Critical
            // 
            this.LB_Critical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Critical.AutoSize = true;
            this.LB_Critical.BackColor = System.Drawing.Color.Transparent;
            this.LB_Critical.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Critical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_Critical.Location = new System.Drawing.Point(287, 288);
            this.LB_Critical.Name = "LB_Critical";
            this.LB_Critical.Size = new System.Drawing.Size(395, 37);
            this.LB_Critical.TabIndex = 21;
            this.LB_Critical.Text = "КРИТИЧЕСКОЕ СОСТОЯНИЕ";
            // 
            // TMR_CritFlickering
            // 
            this.TMR_CritFlickering.Enabled = true;
            this.TMR_CritFlickering.Interval = 500;
            this.TMR_CritFlickering.Tick += new System.EventHandler(this.OnTimerCrit);
            // 
            // GB_State
            // 
            this.GB_State.BackColor = System.Drawing.Color.Black;
            this.GB_State.Controls.Add(this.RTB_Journal);
            this.GB_State.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_State.Location = new System.Drawing.Point(21, 178);
            this.GB_State.Name = "GB_State";
            this.GB_State.Size = new System.Drawing.Size(238, 194);
            this.GB_State.TabIndex = 19;
            this.GB_State.TabStop = false;
            this.GB_State.Text = "Журнал";
            // 
            // RTB_Journal
            // 
            this.RTB_Journal.BackColor = System.Drawing.Color.Black;
            this.RTB_Journal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Journal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RTB_Journal.Location = new System.Drawing.Point(9, 19);
            this.RTB_Journal.Name = "RTB_Journal";
            this.RTB_Journal.Size = new System.Drawing.Size(223, 162);
            this.RTB_Journal.TabIndex = 0;
            this.RTB_Journal.Text = "";
            // 
            // TMR_Pulse
            // 
            this.TMR_Pulse.Enabled = true;
            this.TMR_Pulse.Interval = 1000;
            this.TMR_Pulse.Tick += new System.EventHandler(this.OnTimerPulse);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 390);
            this.Controls.Add(this.GB_State);
            this.Controls.Add(this.LB_Critical);
            this.Controls.Add(this.GB_Person);
            this.Controls.Add(this.GB_DefaultStats);
            this.Controls.Add(this.BT_Heal);
            this.Controls.Add(this.LB_Damages);
            this.Controls.Add(this.TB_Exit);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseCalled);
            this.Load += new System.EventHandler(this.Operation_Load);
            this.GB_DefaultStats.ResumeLayout(false);
            this.GB_DefaultStats.PerformLayout();
            this.GB_Person.ResumeLayout(false);
            this.GB_Person.PerformLayout();
            this.GB_State.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TB_Exit;
        private System.Windows.Forms.ListBox LB_Damages;
        private System.Windows.Forms.Button BT_Heal;
        private System.Windows.Forms.GroupBox GB_DefaultStats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Pain;
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
        private System.Windows.Forms.Timer TMR_StatsRandomize;
        private System.Windows.Forms.GroupBox GB_Person;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label LB_Surname;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Critical;
        private System.Windows.Forms.Timer TMR_CritFlickering;
        private System.Windows.Forms.GroupBox GB_State;
        private System.Windows.Forms.RichTextBox RTB_Journal;
        private System.Windows.Forms.Timer TMR_Pulse;
    }
}