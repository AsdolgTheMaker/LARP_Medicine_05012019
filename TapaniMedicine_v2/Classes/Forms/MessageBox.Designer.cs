namespace TapaniMedicine_v2.Classes.Forms
{
    partial class GUIMessageBox
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
            this.BT_Next = new System.Windows.Forms.Button();
            this.TB_Msg = new System.Windows.Forms.TextBox();
            this.BT_Yes = new System.Windows.Forms.Button();
            this.BT_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Next
            // 
            this.BT_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BT_Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Next.Location = new System.Drawing.Point(122, 78);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(75, 23);
            this.BT_Next.TabIndex = 3;
            this.BT_Next.Text = "ОК";
            this.BT_Next.UseVisualStyleBackColor = false;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            // 
            // TB_Msg
            // 
            this.TB_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Msg.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Msg.Enabled = false;
            this.TB_Msg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_Msg.Location = new System.Drawing.Point(12, 12);
            this.TB_Msg.Multiline = true;
            this.TB_Msg.Name = "TB_Msg";
            this.TB_Msg.ReadOnly = true;
            this.TB_Msg.Size = new System.Drawing.Size(288, 60);
            this.TB_Msg.TabIndex = 4;
            this.TB_Msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Yes
            // 
            this.BT_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Yes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Yes.Location = new System.Drawing.Point(42, 78);
            this.BT_Yes.Name = "BT_Yes";
            this.BT_Yes.Size = new System.Drawing.Size(75, 23);
            this.BT_Yes.TabIndex = 5;
            this.BT_Yes.Text = "Да";
            this.BT_Yes.UseVisualStyleBackColor = false;
            this.BT_Yes.Visible = false;
            this.BT_Yes.Click += new System.EventHandler(this.BT_Yes_Click);
            // 
            // BT_No
            // 
            this.BT_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_No.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_No.Location = new System.Drawing.Point(200, 78);
            this.BT_No.Name = "BT_No";
            this.BT_No.Size = new System.Drawing.Size(75, 23);
            this.BT_No.TabIndex = 6;
            this.BT_No.Text = "Нет";
            this.BT_No.UseVisualStyleBackColor = false;
            this.BT_No.Visible = false;
            this.BT_No.Click += new System.EventHandler(this.BT_No_Click);
            // 
            // GUIMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 113);
            this.Controls.Add(this.BT_No);
            this.Controls.Add(this.BT_Yes);
            this.Controls.Add(this.TB_Msg);
            this.Controls.Add(this.BT_Next);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Next;
        private System.Windows.Forms.TextBox TB_Msg;
        private System.Windows.Forms.Button BT_Yes;
        private System.Windows.Forms.Button BT_No;
    }
}