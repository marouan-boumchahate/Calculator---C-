namespace Calculator
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
            this.Result = new System.Windows.Forms.TextBox();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.ClosePar = new System.Windows.Forms.Button();
            this.OpenPar = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.NumberNine = new System.Windows.Forms.Button();
            this.NumberSeven = new System.Windows.Forms.Button();
            this.NumberEight = new System.Windows.Forms.Button();
            this.NumberSix = new System.Windows.Forms.Button();
            this.NumberFour = new System.Windows.Forms.Button();
            this.NumberFive = new System.Windows.Forms.Button();
            this.NumberThree = new System.Windows.Forms.Button();
            this.NumberOne = new System.Windows.Forms.Button();
            this.NumberTwo = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Remainder = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Result.Enabled = false;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.HideSelection = false;
            this.Result.Location = new System.Drawing.Point(595, 148);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ShortcutsEnabled = false;
            this.Result.Size = new System.Drawing.Size(324, 44);
            this.Result.TabIndex = 0;
            // 
            // SquareRoot
            // 
            this.SquareRoot.BackColor = System.Drawing.Color.Black;
            this.SquareRoot.BackgroundImage = global::Calculator.Properties.Resources.Square_Root;
            this.SquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SquareRoot.Location = new System.Drawing.Point(691, 291);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(51, 45);
            this.SquareRoot.TabIndex = 25;
            this.SquareRoot.Tag = "sqrt";
            this.SquareRoot.UseVisualStyleBackColor = false;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // ClosePar
            // 
            this.ClosePar.BackColor = System.Drawing.Color.Black;
            this.ClosePar.BackgroundImage = global::Calculator.Properties.Resources.Close_Par;
            this.ClosePar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClosePar.Location = new System.Drawing.Point(771, 291);
            this.ClosePar.Name = "ClosePar";
            this.ClosePar.Size = new System.Drawing.Size(51, 45);
            this.ClosePar.TabIndex = 24;
            this.ClosePar.Tag = ")";
            this.ClosePar.UseVisualStyleBackColor = false;
            this.ClosePar.Click += new System.EventHandler(this.ClosePar_Click);
            // 
            // OpenPar
            // 
            this.OpenPar.BackColor = System.Drawing.Color.Black;
            this.OpenPar.BackgroundImage = global::Calculator.Properties.Resources.Open_Par;
            this.OpenPar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenPar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenPar.Location = new System.Drawing.Point(611, 291);
            this.OpenPar.Name = "OpenPar";
            this.OpenPar.Size = new System.Drawing.Size(51, 45);
            this.OpenPar.TabIndex = 23;
            this.OpenPar.Tag = "(";
            this.OpenPar.UseVisualStyleBackColor = false;
            this.OpenPar.Click += new System.EventHandler(this.OpenPar_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.Black;
            this.Dot.BackgroundImage = global::Calculator.Properties.Resources.Dot;
            this.Dot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dot.Location = new System.Drawing.Point(771, 562);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(24, 24);
            this.Dot.TabIndex = 22;
            this.Dot.Tag = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.Black;
            this.Zero.BackgroundImage = global::Calculator.Properties.Resources.Zero;
            this.Zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zero.Location = new System.Drawing.Point(691, 552);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(36, 45);
            this.Zero.TabIndex = 21;
            this.Zero.Tag = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberNine
            // 
            this.NumberNine.BackColor = System.Drawing.Color.Black;
            this.NumberNine.BackgroundImage = global::Calculator.Properties.Resources.Nine;
            this.NumberNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberNine.Location = new System.Drawing.Point(176, 147);
            this.NumberNine.Name = "NumberNine";
            this.NumberNine.Size = new System.Drawing.Size(36, 45);
            this.NumberNine.TabIndex = 20;
            this.NumberNine.Tag = "9";
            this.NumberNine.UseVisualStyleBackColor = false;
            this.NumberNine.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberSeven
            // 
            this.NumberSeven.BackColor = System.Drawing.Color.Black;
            this.NumberSeven.BackgroundImage = global::Calculator.Properties.Resources.Seven;
            this.NumberSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberSeven.Location = new System.Drawing.Point(16, 147);
            this.NumberSeven.Name = "NumberSeven";
            this.NumberSeven.Size = new System.Drawing.Size(36, 45);
            this.NumberSeven.TabIndex = 19;
            this.NumberSeven.Tag = "7";
            this.NumberSeven.UseVisualStyleBackColor = false;
            this.NumberSeven.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberEight
            // 
            this.NumberEight.BackColor = System.Drawing.Color.Black;
            this.NumberEight.BackgroundImage = global::Calculator.Properties.Resources.Eight;
            this.NumberEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberEight.Location = new System.Drawing.Point(96, 147);
            this.NumberEight.Name = "NumberEight";
            this.NumberEight.Size = new System.Drawing.Size(36, 45);
            this.NumberEight.TabIndex = 18;
            this.NumberEight.Tag = "8";
            this.NumberEight.UseVisualStyleBackColor = false;
            this.NumberEight.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberSix
            // 
            this.NumberSix.BackColor = System.Drawing.Color.Black;
            this.NumberSix.BackgroundImage = global::Calculator.Properties.Resources.Six;
            this.NumberSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberSix.Location = new System.Drawing.Point(771, 423);
            this.NumberSix.Name = "NumberSix";
            this.NumberSix.Size = new System.Drawing.Size(36, 45);
            this.NumberSix.TabIndex = 17;
            this.NumberSix.Tag = "6";
            this.NumberSix.UseVisualStyleBackColor = false;
            this.NumberSix.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberFour
            // 
            this.NumberFour.BackColor = System.Drawing.Color.Black;
            this.NumberFour.BackgroundImage = global::Calculator.Properties.Resources.Four;
            this.NumberFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberFour.Location = new System.Drawing.Point(611, 423);
            this.NumberFour.Name = "NumberFour";
            this.NumberFour.Size = new System.Drawing.Size(36, 45);
            this.NumberFour.TabIndex = 16;
            this.NumberFour.Tag = "4";
            this.NumberFour.UseVisualStyleBackColor = false;
            this.NumberFour.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberFive
            // 
            this.NumberFive.BackColor = System.Drawing.Color.Black;
            this.NumberFive.BackgroundImage = global::Calculator.Properties.Resources.Five;
            this.NumberFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberFive.Location = new System.Drawing.Point(691, 423);
            this.NumberFive.Name = "NumberFive";
            this.NumberFive.Size = new System.Drawing.Size(36, 45);
            this.NumberFive.TabIndex = 15;
            this.NumberFive.Tag = "5";
            this.NumberFive.UseVisualStyleBackColor = false;
            this.NumberFive.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberThree
            // 
            this.NumberThree.BackColor = System.Drawing.Color.Black;
            this.NumberThree.BackgroundImage = global::Calculator.Properties.Resources.Three;
            this.NumberThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberThree.Location = new System.Drawing.Point(771, 489);
            this.NumberThree.Name = "NumberThree";
            this.NumberThree.Size = new System.Drawing.Size(36, 45);
            this.NumberThree.TabIndex = 14;
            this.NumberThree.Tag = "3";
            this.NumberThree.UseVisualStyleBackColor = false;
            this.NumberThree.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberOne
            // 
            this.NumberOne.BackColor = System.Drawing.Color.Black;
            this.NumberOne.BackgroundImage = global::Calculator.Properties.Resources.One;
            this.NumberOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberOne.Location = new System.Drawing.Point(611, 489);
            this.NumberOne.Name = "NumberOne";
            this.NumberOne.Size = new System.Drawing.Size(36, 45);
            this.NumberOne.TabIndex = 13;
            this.NumberOne.Tag = "1";
            this.NumberOne.UseVisualStyleBackColor = false;
            this.NumberOne.Click += new System.EventHandler(this.Number_Click);
            // 
            // NumberTwo
            // 
            this.NumberTwo.BackColor = System.Drawing.Color.Black;
            this.NumberTwo.BackgroundImage = global::Calculator.Properties.Resources.Two;
            this.NumberTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberTwo.Location = new System.Drawing.Point(691, 489);
            this.NumberTwo.Name = "NumberTwo";
            this.NumberTwo.Size = new System.Drawing.Size(36, 45);
            this.NumberTwo.TabIndex = 12;
            this.NumberTwo.Tag = "2";
            this.NumberTwo.UseVisualStyleBackColor = false;
            this.NumberTwo.Click += new System.EventHandler(this.Number_Click);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.Color.Black;
            this.Power.BackgroundImage = global::Calculator.Properties.Resources.Power;
            this.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Power.Location = new System.Drawing.Point(611, 225);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(51, 45);
            this.Power.TabIndex = 10;
            this.Power.Tag = "^";
            this.Power.UseVisualStyleBackColor = false;
            this.Power.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Remainder
            // 
            this.Remainder.BackColor = System.Drawing.Color.Black;
            this.Remainder.BackgroundImage = global::Calculator.Properties.Resources.Mod;
            this.Remainder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remainder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remainder.Location = new System.Drawing.Point(691, 225);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(51, 45);
            this.Remainder.TabIndex = 9;
            this.Remainder.Tag = "%";
            this.Remainder.UseVisualStyleBackColor = false;
            this.Remainder.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.Black;
            this.Equal.BackgroundImage = global::Calculator.Properties.Resources.Equal;
            this.Equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equal.Location = new System.Drawing.Point(853, 552);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(51, 45);
            this.Equal.TabIndex = 8;
            this.Equal.Tag = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.BackgroundImage = global::Calculator.Properties.Resources.C;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Location = new System.Drawing.Point(771, 225);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(51, 45);
            this.Clear.TabIndex = 7;
            this.Clear.Tag = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Black;
            this.Plus.BackgroundImage = global::Calculator.Properties.Resources.plus;
            this.Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Plus.Location = new System.Drawing.Point(853, 489);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(51, 45);
            this.Plus.TabIndex = 6;
            this.Plus.Tag = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Black;
            this.Minus.BackgroundImage = global::Calculator.Properties.Resources.Minus;
            this.Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus.Location = new System.Drawing.Point(853, 423);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(51, 45);
            this.Minus.TabIndex = 5;
            this.Minus.Tag = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.Color.Black;
            this.Times.BackgroundImage = global::Calculator.Properties.Resources.Cross;
            this.Times.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Times.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Times.Location = new System.Drawing.Point(853, 357);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(51, 45);
            this.Times.TabIndex = 4;
            this.Times.Tag = "x";
            this.Times.UseVisualStyleBackColor = false;
            this.Times.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Black;
            this.Division.BackgroundImage = global::Calculator.Properties.Resources.Slash;
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Location = new System.Drawing.Point(853, 291);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(51, 45);
            this.Division.TabIndex = 3;
            this.Division.Tag = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.Black;
            this.Undo.BackgroundImage = global::Calculator.Properties.Resources.Undo;
            this.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Undo.Location = new System.Drawing.Point(851, 225);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(51, 45);
            this.Undo.TabIndex = 1;
            this.Undo.Tag = "U";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Black;
            this.btnHistory.BackgroundImage = global::Calculator.Properties.Resources.HST;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Location = new System.Drawing.Point(611, 557);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(51, 34);
            this.btnHistory.TabIndex = 26;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.History_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NumberNine);
            this.panel1.Controls.Add(this.NumberEight);
            this.panel1.Controls.Add(this.NumberSeven);
            this.panel1.Location = new System.Drawing.Point(595, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 402);
            this.panel1.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Ravie", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(555, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(413, 108);
            this.Title.TabIndex = 28;
            this.Title.Text = "Calculator\r\nFrom Morocco";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "NOTES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(29, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "+ SQUARE ROOT will be executed directly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(29, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "+ HST for checking the previous operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(31, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "+ C for cleaning the screen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(31, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "+ LEFT ARROW for remove the last item in your operation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1145, 669);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.ClosePar);
            this.Controls.Add(this.OpenPar);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.NumberSix);
            this.Controls.Add(this.NumberFour);
            this.Controls.Add(this.NumberFive);
            this.Controls.Add(this.NumberThree);
            this.Controls.Add(this.NumberOne);
            this.Controls.Add(this.NumberTwo);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button NumberTwo;
        private System.Windows.Forms.Button NumberOne;
        private System.Windows.Forms.Button NumberThree;
        private System.Windows.Forms.Button NumberSix;
        private System.Windows.Forms.Button NumberFour;
        private System.Windows.Forms.Button NumberFive;
        private System.Windows.Forms.Button NumberNine;
        private System.Windows.Forms.Button NumberSeven;
        private System.Windows.Forms.Button NumberEight;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button OpenPar;
        private System.Windows.Forms.Button ClosePar;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

