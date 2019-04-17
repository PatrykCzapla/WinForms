namespace lab7
{
    partial class MemoryGame
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
            this.outTable = new System.Windows.Forms.TableLayoutPanel();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.StartPauseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.topTable = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.outTable.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.topTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // outTable
            // 
            this.outTable.ColumnCount = 1;
            this.outTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outTable.Controls.Add(this.bottomTable, 0, 1);
            this.outTable.Controls.Add(this.topTable, 0, 0);
            this.outTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outTable.Location = new System.Drawing.Point(0, 0);
            this.outTable.Name = "outTable";
            this.outTable.RowCount = 2;
            this.outTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.outTable.Size = new System.Drawing.Size(484, 362);
            this.outTable.TabIndex = 0;
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 3;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomTable.Controls.Add(this.StartPauseButton, 0, 0);
            this.bottomTable.Controls.Add(this.ResetButton, 1, 0);
            this.bottomTable.Controls.Add(this.timeLabel, 2, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.Location = new System.Drawing.Point(3, 325);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(478, 34);
            this.bottomTable.TabIndex = 0;
            // 
            // StartPauseButton
            // 
            this.StartPauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartPauseButton.Location = new System.Drawing.Point(29, 3);
            this.StartPauseButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.StartPauseButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.StartPauseButton.Name = "StartPauseButton";
            this.StartPauseButton.Size = new System.Drawing.Size(100, 30);
            this.StartPauseButton.TabIndex = 0;
            this.StartPauseButton.Text = "Start";
            this.StartPauseButton.UseVisualStyleBackColor = true;
            this.StartPauseButton.Click += new System.EventHandler(this.Start_Pause_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetButton.Location = new System.Drawing.Point(188, 3);
            this.ResetButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.ResetButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 30);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(321, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(154, 34);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "0s";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topTable
            // 
            this.topTable.ColumnCount = 4;
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.Controls.Add(this.button3, 0, 0);
            this.topTable.Controls.Add(this.button4, 1, 0);
            this.topTable.Controls.Add(this.button5, 2, 0);
            this.topTable.Controls.Add(this.button6, 3, 0);
            this.topTable.Controls.Add(this.button7, 0, 1);
            this.topTable.Controls.Add(this.button8, 1, 1);
            this.topTable.Controls.Add(this.button9, 2, 1);
            this.topTable.Controls.Add(this.button10, 3, 1);
            this.topTable.Controls.Add(this.button11, 0, 2);
            this.topTable.Controls.Add(this.button12, 1, 2);
            this.topTable.Controls.Add(this.button13, 2, 2);
            this.topTable.Controls.Add(this.button14, 3, 2);
            this.topTable.Controls.Add(this.button15, 0, 3);
            this.topTable.Controls.Add(this.button16, 1, 3);
            this.topTable.Controls.Add(this.button17, 2, 3);
            this.topTable.Controls.Add(this.button18, 3, 3);
            this.topTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTable.Location = new System.Drawing.Point(3, 3);
            this.topTable.Name = "topTable";
            this.topTable.RowCount = 4;
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.Size = new System.Drawing.Size(478, 316);
            this.topTable.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 73);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Card_Click);
            this.button3.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button3.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(122, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 73);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Card_Click);
            this.button4.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button4.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(241, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 73);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Card_Click);
            this.button5.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button5.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.Location = new System.Drawing.Point(360, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 73);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Card_Click);
            this.button6.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button6.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button7.Location = new System.Drawing.Point(3, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 73);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Card_Click);
            this.button7.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button7.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button8.Location = new System.Drawing.Point(122, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 73);
            this.button8.TabIndex = 5;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Card_Click);
            this.button8.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button8.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button9.Location = new System.Drawing.Point(241, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 73);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Card_Click);
            this.button9.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button9.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.AliceBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button10.Location = new System.Drawing.Point(360, 82);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 73);
            this.button10.TabIndex = 7;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Card_Click);
            this.button10.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button10.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.AliceBlue;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button11.Location = new System.Drawing.Point(3, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 73);
            this.button11.TabIndex = 8;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Card_Click);
            this.button11.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button11.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.AliceBlue;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button12.Location = new System.Drawing.Point(122, 161);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(113, 73);
            this.button12.TabIndex = 9;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Card_Click);
            this.button12.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button12.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.AliceBlue;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button13.Location = new System.Drawing.Point(241, 161);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 73);
            this.button13.TabIndex = 10;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Card_Click);
            this.button13.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button13.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.AliceBlue;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button14.Location = new System.Drawing.Point(360, 161);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(115, 73);
            this.button14.TabIndex = 11;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Card_Click);
            this.button14.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button14.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.AliceBlue;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button15.Location = new System.Drawing.Point(3, 240);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(113, 73);
            this.button15.TabIndex = 12;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Card_Click);
            this.button15.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button15.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.AliceBlue;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button16.Location = new System.Drawing.Point(122, 240);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(113, 73);
            this.button16.TabIndex = 13;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Card_Click);
            this.button16.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button16.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.AliceBlue;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button17.Location = new System.Drawing.Point(241, 240);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(113, 73);
            this.button17.TabIndex = 14;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Card_Click);
            this.button17.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button17.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.AliceBlue;
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button18.Location = new System.Drawing.Point(360, 240);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(115, 73);
            this.button18.TabIndex = 15;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Card_Click);
            this.button18.MouseEnter += new System.EventHandler(this.Card_MouseEnters);
            this.button18.MouseLeave += new System.EventHandler(this.Card_MouseLeaves);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.outTable);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MemoryGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.outTable.ResumeLayout(false);
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.topTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel outTable;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.TableLayoutPanel topTable;
        private System.Windows.Forms.Button StartPauseButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
    }
}

