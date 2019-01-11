namespace TapaniMedicine_v2.Classes.Forms
{
    partial class ActionSelect
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
            this.TB_Defibrilator = new System.Windows.Forms.Button();
            this.BT_CloseInj = new System.Windows.Forms.Button();
            this.BT_FixNerv = new System.Windows.Forms.Button();
            this.BT_FixBone = new System.Windows.Forms.Button();
            this.BT_Cut = new System.Windows.Forms.Button();
            this.BT_AddBand = new System.Windows.Forms.Button();
            this.BT_DeleteDmgdSkin = new System.Windows.Forms.Button();
            this.BT_FixVeil = new System.Windows.Forms.Button();
            this.BT_Inject = new System.Windows.Forms.Button();
            this.LB_InjSelection = new System.Windows.Forms.ListBox();
            this.GB_Injection = new System.Windows.Forms.GroupBox();
            this.PB_Process = new System.Windows.Forms.ProgressBar();
            this.LB_Process = new System.Windows.Forms.Label();
            this.BT_Return = new System.Windows.Forms.Button();
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
            this.LB_Critical = new System.Windows.Forms.Label();
            this.TMR_CriticalFlickering = new System.Windows.Forms.Timer(this.components);
            this.GB_State = new System.Windows.Forms.GroupBox();
            this.LB_Injury = new System.Windows.Forms.Label();
            this.GB_Injection.SuspendLayout();
            this.GB_DefaultStats.SuspendLayout();
            this.GB_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Defibrilator
            // 
            this.TB_Defibrilator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Defibrilator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.TB_Defibrilator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.TB_Defibrilator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_Defibrilator.Location = new System.Drawing.Point(33, 28);
            this.TB_Defibrilator.Name = "TB_Defibrilator";
            this.TB_Defibrilator.Size = new System.Drawing.Size(212, 29);
            this.TB_Defibrilator.TabIndex = 5;
            this.TB_Defibrilator.Text = "Дефибрилятор";
            this.TB_Defibrilator.UseVisualStyleBackColor = false;
            this.TB_Defibrilator.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_CloseInj
            // 
            this.BT_CloseInj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_CloseInj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_CloseInj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_CloseInj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CloseInj.Location = new System.Drawing.Point(33, 73);
            this.BT_CloseInj.Name = "BT_CloseInj";
            this.BT_CloseInj.Size = new System.Drawing.Size(212, 29);
            this.BT_CloseInj.TabIndex = 6;
            this.BT_CloseInj.Text = "Зашить рану";
            this.BT_CloseInj.UseVisualStyleBackColor = false;
            this.BT_CloseInj.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_FixNerv
            // 
            this.BT_FixNerv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_FixNerv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_FixNerv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_FixNerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FixNerv.Location = new System.Drawing.Point(33, 162);
            this.BT_FixNerv.Name = "BT_FixNerv";
            this.BT_FixNerv.Size = new System.Drawing.Size(212, 29);
            this.BT_FixNerv.TabIndex = 8;
            this.BT_FixNerv.Text = "Соединить нерв";
            this.BT_FixNerv.UseVisualStyleBackColor = false;
            this.BT_FixNerv.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_FixBone
            // 
            this.BT_FixBone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_FixBone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_FixBone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_FixBone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FixBone.Location = new System.Drawing.Point(33, 117);
            this.BT_FixBone.Name = "BT_FixBone";
            this.BT_FixBone.Size = new System.Drawing.Size(212, 29);
            this.BT_FixBone.TabIndex = 7;
            this.BT_FixBone.Text = "Вправить кость";
            this.BT_FixBone.UseVisualStyleBackColor = false;
            this.BT_FixBone.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_Cut
            // 
            this.BT_Cut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Cut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cut.Location = new System.Drawing.Point(33, 253);
            this.BT_Cut.Name = "BT_Cut";
            this.BT_Cut.Size = new System.Drawing.Size(212, 29);
            this.BT_Cut.TabIndex = 12;
            this.BT_Cut.Text = "Выполнить надрез";
            this.BT_Cut.UseVisualStyleBackColor = false;
            this.BT_Cut.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_AddBand
            // 
            this.BT_AddBand.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_AddBand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_AddBand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_AddBand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddBand.Location = new System.Drawing.Point(33, 208);
            this.BT_AddBand.Name = "BT_AddBand";
            this.BT_AddBand.Size = new System.Drawing.Size(212, 29);
            this.BT_AddBand.TabIndex = 11;
            this.BT_AddBand.Text = "Нанести фиксирующую повязку";
            this.BT_AddBand.UseVisualStyleBackColor = false;
            this.BT_AddBand.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_DeleteDmgdSkin
            // 
            this.BT_DeleteDmgdSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_DeleteDmgdSkin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_DeleteDmgdSkin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_DeleteDmgdSkin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_DeleteDmgdSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DeleteDmgdSkin.Location = new System.Drawing.Point(490, 73);
            this.BT_DeleteDmgdSkin.Name = "BT_DeleteDmgdSkin";
            this.BT_DeleteDmgdSkin.Size = new System.Drawing.Size(212, 29);
            this.BT_DeleteDmgdSkin.TabIndex = 10;
            this.BT_DeleteDmgdSkin.Text = "Удалить поражённые участки кожи";
            this.BT_DeleteDmgdSkin.UseVisualStyleBackColor = false;
            this.BT_DeleteDmgdSkin.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_FixVeil
            // 
            this.BT_FixVeil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_FixVeil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_FixVeil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_FixVeil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_FixVeil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FixVeil.Location = new System.Drawing.Point(490, 28);
            this.BT_FixVeil.Name = "BT_FixVeil";
            this.BT_FixVeil.Size = new System.Drawing.Size(212, 29);
            this.BT_FixVeil.TabIndex = 9;
            this.BT_FixVeil.Text = "Соединить сосуд";
            this.BT_FixVeil.UseVisualStyleBackColor = false;
            this.BT_FixVeil.Click += new System.EventHandler(this.ActionSelected);
            // 
            // BT_Inject
            // 
            this.BT_Inject.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Inject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Inject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Inject.Location = new System.Drawing.Point(19, 118);
            this.BT_Inject.Name = "BT_Inject";
            this.BT_Inject.Size = new System.Drawing.Size(174, 45);
            this.BT_Inject.TabIndex = 13;
            this.BT_Inject.Text = "Сделать инъекцию выбранного вещества";
            this.BT_Inject.UseVisualStyleBackColor = false;
            this.BT_Inject.Click += new System.EventHandler(this.BT_Inject_Click);
            // 
            // LB_InjSelection
            // 
            this.LB_InjSelection.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LB_InjSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_InjSelection.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_InjSelection.FormattingEnabled = true;
            this.LB_InjSelection.Items.AddRange(new object[] {
            "Бакта",
            "Фосован-соль",
            "Лечебный кожный герметик",
            "Рилл",
            "Стимулятор",
            "Физраствор"});
            this.LB_InjSelection.Location = new System.Drawing.Point(6, 19);
            this.LB_InjSelection.Name = "LB_InjSelection";
            this.LB_InjSelection.Size = new System.Drawing.Size(199, 93);
            this.LB_InjSelection.TabIndex = 14;
            // 
            // GB_Injection
            // 
            this.GB_Injection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Injection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GB_Injection.Controls.Add(this.LB_InjSelection);
            this.GB_Injection.Controls.Add(this.BT_Inject);
            this.GB_Injection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Injection.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_Injection.Location = new System.Drawing.Point(490, 117);
            this.GB_Injection.Name = "GB_Injection";
            this.GB_Injection.Size = new System.Drawing.Size(212, 174);
            this.GB_Injection.TabIndex = 15;
            this.GB_Injection.TabStop = false;
            this.GB_Injection.Text = "Выбор вещества для инъекции";
            // 
            // PB_Process
            // 
            this.PB_Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Process.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PB_Process.Location = new System.Drawing.Point(33, 307);
            this.PB_Process.Name = "PB_Process";
            this.PB_Process.Size = new System.Drawing.Size(669, 23);
            this.PB_Process.Step = 1;
            this.PB_Process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_Process.TabIndex = 16;
            // 
            // LB_Process
            // 
            this.LB_Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Process.AutoSize = true;
            this.LB_Process.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Process.Location = new System.Drawing.Point(40, 291);
            this.LB_Process.Name = "LB_Process";
            this.LB_Process.Size = new System.Drawing.Size(188, 13);
            this.LB_Process.TabIndex = 17;
            this.LB_Process.Text = "Успешность лечения повреждения:";
            // 
            // BT_Return
            // 
            this.BT_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Return.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Return.Location = new System.Drawing.Point(279, 224);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(173, 24);
            this.BT_Return.TabIndex = 18;
            this.BT_Return.Text = "Вернуться к меню операции";
            this.BT_Return.UseVisualStyleBackColor = false;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
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
            this.GB_DefaultStats.Location = new System.Drawing.Point(259, 24);
            this.GB_DefaultStats.Name = "GB_DefaultStats";
            this.GB_DefaultStats.Size = new System.Drawing.Size(219, 194);
            this.GB_DefaultStats.TabIndex = 19;
            this.GB_DefaultStats.TabStop = false;
            this.GB_DefaultStats.Text = "Состояние пациента";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(160, 133);
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
            this.TB_Pain.Size = new System.Drawing.Size(68, 20);
            this.TB_Pain.TabIndex = 15;
            this.TB_Pain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "мл";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "уд/мин";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "мм рт.ст.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 52);
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
            this.TB_Pulse.Size = new System.Drawing.Size(68, 20);
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
            this.TB_LPressure.Size = new System.Drawing.Size(68, 20);
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
            this.TB_HPressure.Size = new System.Drawing.Size(68, 20);
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
            this.TB_Blood.Size = new System.Drawing.Size(68, 20);
            this.TB_Blood.TabIndex = 0;
            this.TB_Blood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TMR_StatsRandomize
            // 
            this.TMR_StatsRandomize.Enabled = true;
            this.TMR_StatsRandomize.Tick += new System.EventHandler(this.OnTimer);
            // 
            // LB_Critical
            // 
            this.LB_Critical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Critical.AutoSize = true;
            this.LB_Critical.BackColor = System.Drawing.Color.Transparent;
            this.LB_Critical.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Critical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_Critical.Location = new System.Drawing.Point(176, 333);
            this.LB_Critical.Name = "LB_Critical";
            this.LB_Critical.Size = new System.Drawing.Size(395, 37);
            this.LB_Critical.TabIndex = 20;
            this.LB_Critical.Text = "КРИТИЧЕСКОЕ СОСТОЯНИЕ";
            // 
            // TMR_CriticalFlickering
            // 
            this.TMR_CriticalFlickering.Interval = 500;
            this.TMR_CriticalFlickering.Tick += new System.EventHandler(this.OnTimerCrit);
            // 
            // GB_State
            // 
            this.GB_State.BackColor = System.Drawing.Color.Black;
            this.GB_State.Controls.Add(this.LB_Injury);
            this.GB_State.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_State.Location = new System.Drawing.Point(257, 254);
            this.GB_State.Name = "GB_State";
            this.GB_State.Size = new System.Drawing.Size(227, 47);
            this.GB_State.TabIndex = 18;
            this.GB_State.TabStop = false;
            this.GB_State.Text = "Лечение ранения...";
            // 
            // LB_Injury
            // 
            this.LB_Injury.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Injury.AutoSize = true;
            this.LB_Injury.Font = new System.Drawing.Font("Rounded Mplus 1c Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Injury.Location = new System.Drawing.Point(24, 18);
            this.LB_Injury.Name = "LB_Injury";
            this.LB_Injury.Size = new System.Drawing.Size(70, 21);
            this.LB_Injury.TabIndex = 18;
            this.LB_Injury.Text = "Ранение";
            // 
            // ActionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 390);
            this.Controls.Add(this.GB_State);
            this.Controls.Add(this.LB_Critical);
            this.Controls.Add(this.GB_DefaultStats);
            this.Controls.Add(this.BT_Return);
            this.Controls.Add(this.LB_Process);
            this.Controls.Add(this.PB_Process);
            this.Controls.Add(this.GB_Injection);
            this.Controls.Add(this.BT_Cut);
            this.Controls.Add(this.BT_AddBand);
            this.Controls.Add(this.BT_DeleteDmgdSkin);
            this.Controls.Add(this.BT_FixVeil);
            this.Controls.Add(this.BT_FixNerv);
            this.Controls.Add(this.BT_FixBone);
            this.Controls.Add(this.BT_CloseInj);
            this.Controls.Add(this.TB_Defibrilator);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActionSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.GB_Injection.ResumeLayout(false);
            this.GB_DefaultStats.ResumeLayout(false);
            this.GB_DefaultStats.PerformLayout();
            this.GB_State.ResumeLayout(false);
            this.GB_State.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TB_Defibrilator;
        private System.Windows.Forms.Button BT_CloseInj;
        private System.Windows.Forms.Button BT_FixNerv;
        private System.Windows.Forms.Button BT_FixBone;
        private System.Windows.Forms.Button BT_Cut;
        private System.Windows.Forms.Button BT_AddBand;
        private System.Windows.Forms.Button BT_DeleteDmgdSkin;
        private System.Windows.Forms.Button BT_FixVeil;
        private System.Windows.Forms.Button BT_Inject;
        private System.Windows.Forms.ListBox LB_InjSelection;
        private System.Windows.Forms.GroupBox GB_Injection;
        private System.Windows.Forms.ProgressBar PB_Process;
        private System.Windows.Forms.Label LB_Process;
        private System.Windows.Forms.Button BT_Return;
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
        private System.Windows.Forms.Label LB_Critical;
        private System.Windows.Forms.Timer TMR_CriticalFlickering;
        private System.Windows.Forms.GroupBox GB_State;
        private System.Windows.Forms.Label LB_Injury;
    }
}