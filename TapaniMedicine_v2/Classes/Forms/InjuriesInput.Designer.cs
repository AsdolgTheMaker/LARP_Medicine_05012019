namespace TapaniMedicine_v2.Classes.Forms
{
    partial class InjuriesInput
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
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Next = new System.Windows.Forms.Button();
            this.LB_PossibleInj = new System.Windows.Forms.ListBox();
            this.GB_Possible = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_ActualInj = new System.Windows.Forms.ListBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Remove = new System.Windows.Forms.Button();
            this.GB_Possible.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Exit
            // 
            this.BT_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Exit.Location = new System.Drawing.Point(618, 399);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(75, 29);
            this.BT_Exit.TabIndex = 4;
            this.BT_Exit.Text = "Выход";
            this.BT_Exit.UseVisualStyleBackColor = false;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            this.BT_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Exit.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // BT_Next
            // 
            this.BT_Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Next.Location = new System.Drawing.Point(23, 399);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(119, 29);
            this.BT_Next.TabIndex = 5;
            this.BT_Next.Text = "Продолжить";
            this.BT_Next.UseVisualStyleBackColor = false;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            this.BT_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Next.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // LB_PossibleInj
            // 
            this.LB_PossibleInj.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LB_PossibleInj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_PossibleInj.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_PossibleInj.FormattingEnabled = true;
            this.LB_PossibleInj.Location = new System.Drawing.Point(5, 19);
            this.LB_PossibleInj.Name = "LB_PossibleInj";
            this.LB_PossibleInj.Size = new System.Drawing.Size(288, 325);
            this.LB_PossibleInj.TabIndex = 6;
            // 
            // GB_Possible
            // 
            this.GB_Possible.BackColor = System.Drawing.Color.Black;
            this.GB_Possible.Controls.Add(this.LB_PossibleInj);
            this.GB_Possible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Possible.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GB_Possible.Location = new System.Drawing.Point(19, 14);
            this.GB_Possible.Name = "GB_Possible";
            this.GB_Possible.Size = new System.Drawing.Size(303, 361);
            this.GB_Possible.TabIndex = 8;
            this.GB_Possible.TabStop = false;
            this.GB_Possible.Text = "Возможные ранения";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.LB_ActualInj);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(390, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 361);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Полученные ранения";
            // 
            // LB_ActualInj
            // 
            this.LB_ActualInj.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LB_ActualInj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_ActualInj.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_ActualInj.FormattingEnabled = true;
            this.LB_ActualInj.Location = new System.Drawing.Point(5, 19);
            this.LB_ActualInj.Name = "LB_ActualInj";
            this.LB_ActualInj.Size = new System.Drawing.Size(288, 325);
            this.LB_ActualInj.TabIndex = 6;
            // 
            // BT_Add
            // 
            this.BT_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add.Location = new System.Drawing.Point(339, 71);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(36, 29);
            this.BT_Add.TabIndex = 10;
            this.BT_Add.Text = "-->";
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            this.BT_Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Add.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // BT_Remove
            // 
            this.BT_Remove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Remove.Location = new System.Drawing.Point(339, 143);
            this.BT_Remove.Name = "BT_Remove";
            this.BT_Remove.Size = new System.Drawing.Size(36, 29);
            this.BT_Remove.TabIndex = 11;
            this.BT_Remove.Text = "<--";
            this.BT_Remove.UseVisualStyleBackColor = false;
            this.BT_Remove.Click += new System.EventHandler(this.BT_Remove_Click);
            this.BT_Remove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Remove.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // InjuriesInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.BT_Remove);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Possible);
            this.Controls.Add(this.BT_Next);
            this.Controls.Add(this.BT_Exit);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InjuriesInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InjuriesInput";
            this.GB_Possible.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Next;
        private System.Windows.Forms.ListBox LB_PossibleInj;
        private System.Windows.Forms.GroupBox GB_Possible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_ActualInj;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Remove;
    }
}