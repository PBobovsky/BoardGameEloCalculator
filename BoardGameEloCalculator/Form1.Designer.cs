namespace BoardGameEloCalculator
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LogPlayButton = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.GroupBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.addPlayerComboBox = new System.Windows.Forms.ComboBox();
            this.positionNumeric = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Recalculate = new System.Windows.Forms.Button();
            this.Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(145, 451);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // LogPlayButton
            // 
            this.LogPlayButton.Location = new System.Drawing.Point(332, 24);
            this.LogPlayButton.Name = "LogPlayButton";
            this.LogPlayButton.Size = new System.Drawing.Size(97, 26);
            this.LogPlayButton.TabIndex = 4;
            this.LogPlayButton.Text = "Log Play";
            this.LogPlayButton.UseVisualStyleBackColor = true;
            this.LogPlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player
            // 
            this.Player.Controls.Add(this.addPlayerButton);
            this.Player.Controls.Add(this.addPlayerComboBox);
            this.Player.Controls.Add(this.positionNumeric);
            this.Player.Location = new System.Drawing.Point(7, 8);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(366, 49);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            this.Player.Text = "Add Player";
            this.Player.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(285, 18);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 3;
            this.addPlayerButton.Text = "Add";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPlayerComboBox
            // 
            this.addPlayerComboBox.FormattingEnabled = true;
            this.addPlayerComboBox.Location = new System.Drawing.Point(3, 18);
            this.addPlayerComboBox.Name = "addPlayerComboBox";
            this.addPlayerComboBox.Size = new System.Drawing.Size(156, 21);
            this.addPlayerComboBox.TabIndex = 1;
            // 
            // positionNumeric
            // 
            this.positionNumeric.Location = new System.Drawing.Point(211, 19);
            this.positionNumeric.Name = "positionNumeric";
            this.positionNumeric.Size = new System.Drawing.Size(43, 20);
            this.positionNumeric.TabIndex = 2;
            this.positionNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.LogPlayButton);
            this.panel1.Location = new System.Drawing.Point(388, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 524);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.Player);
            this.groupBox1.Location = new System.Drawing.Point(4, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 346);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(439, 8);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 335);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(174, 9);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(881, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1039, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1040, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add player";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(193, 41);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(153, 451);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // Recalculate
            // 
            this.Recalculate.Location = new System.Drawing.Point(1039, 526);
            this.Recalculate.Name = "Recalculate";
            this.Recalculate.Size = new System.Drawing.Size(75, 23);
            this.Recalculate.TabIndex = 8;
            this.Recalculate.Text = "Recalculate";
            this.Recalculate.UseVisualStyleBackColor = true;
            this.Recalculate.Click += new System.EventHandler(this.Recalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 606);
            this.Controls.Add(this.Recalculate);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button LogPlayButton;
        private System.Windows.Forms.GroupBox Player;
        private System.Windows.Forms.ComboBox addPlayerComboBox;
        private System.Windows.Forms.NumericUpDown positionNumeric;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Recalculate;
    }
}

