namespace TapaniMedicine_v2
{
    partial class Hub
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.BT_Next = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.IMG_ImperialLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TB_ID
            // 
            this.TB_ID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TB_ID.Location = new System.Drawing.Point(253, 404);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(127, 20);
            this.TB_ID.TabIndex = 1;
            this.TB_ID.Text = "Введите ID пациента...";
            this.TB_ID.Enter += new System.EventHandler(this.TB_ID_Focused);
            this.TB_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_ID_KeyDown);
            this.TB_ID.Leave += new System.EventHandler(this.TB_ID_Unfocused);
            // 
            // BT_Next
            // 
            this.BT_Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Next.Location = new System.Drawing.Point(21, 400);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(224, 29);
            this.BT_Next.TabIndex = 2;
            this.BT_Next.Text = "Просмотреть информацию о пациенте";
            this.BT_Next.UseVisualStyleBackColor = false;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            this.BT_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Next.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // BT_Exit
            // 
            this.BT_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BT_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Exit.Location = new System.Drawing.Point(611, 400);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(75, 29);
            this.BT_Exit.TabIndex = 3;
            this.BT_Exit.Text = "Выход";
            this.BT_Exit.UseVisualStyleBackColor = false;
            this.BT_Exit.Click += new System.EventHandler(this.TB_Exit_Click);
            this.BT_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.BT_Exit.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TapaniMedicine_v2.Properties.Resources.BG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Next);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Hub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Button BT_Next;
        private System.Windows.Forms.Button BT_Exit;
    }
}

