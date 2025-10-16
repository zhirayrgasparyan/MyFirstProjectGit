namespace WinFormsAppCalculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            buttonEcual = new Button();
            buttonSquaring = new Button();
            buttonPoint = new Button();
            buttonZeero = new Button();
            buttonRootExtraction = new Button();
            buttonTree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonC = new Button();
            buttonExponentiation = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonCE = new Button();
            buttonDivide = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            textBox_Result = new TextBox();
            labelCurrent_Operation = new Label();
            SuspendLayout();
            // 
            // buttonEcual
            // 
            buttonEcual.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEcual.Location = new Point(313, 299);
            buttonEcual.Name = "buttonEcual";
            buttonEcual.Size = new Size(78, 140);
            buttonEcual.TabIndex = 37;
            buttonEcual.Text = "=";
            buttonEcual.UseVisualStyleBackColor = true;
            buttonEcual.Click += buttonEcual_Click;
            // 
            // buttonSquaring
            // 
            buttonSquaring.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSquaring.Location = new Point(240, 372);
            buttonSquaring.Name = "buttonSquaring";
            buttonSquaring.Size = new Size(67, 67);
            buttonSquaring.TabIndex = 36;
            buttonSquaring.Text = "x²";
            buttonSquaring.UseVisualStyleBackColor = true;
            buttonSquaring.Click += operator_click;
            // 
            // buttonPoint
            // 
            buttonPoint.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPoint.Location = new Point(167, 372);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(67, 67);
            buttonPoint.TabIndex = 35;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            // 
            // buttonZeero
            // 
            buttonZeero.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonZeero.Location = new Point(21, 372);
            buttonZeero.Name = "buttonZeero";
            buttonZeero.Size = new Size(140, 67);
            buttonZeero.TabIndex = 34;
            buttonZeero.Text = "0";
            buttonZeero.UseVisualStyleBackColor = true;
            // 
            // buttonRootExtraction
            // 
            buttonRootExtraction.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRootExtraction.Location = new Point(240, 299);
            buttonRootExtraction.Name = "buttonRootExtraction";
            buttonRootExtraction.Size = new Size(67, 67);
            buttonRootExtraction.TabIndex = 33;
            buttonRootExtraction.Text = "√x";
            buttonRootExtraction.UseVisualStyleBackColor = true;
            buttonRootExtraction.Click += operator_click;
            // 
            // buttonTree
            // 
            buttonTree.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTree.Location = new Point(167, 299);
            buttonTree.Name = "buttonTree";
            buttonTree.Size = new Size(67, 67);
            buttonTree.TabIndex = 32;
            buttonTree.Text = "3";
            buttonTree.UseVisualStyleBackColor = true;
            buttonTree.Click += button_click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTwo.Location = new Point(94, 299);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(67, 67);
            buttonTwo.TabIndex = 31;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += button_click;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOne.Location = new Point(21, 299);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(67, 67);
            buttonOne.TabIndex = 30;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += button_click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonC.Location = new Point(313, 226);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(78, 67);
            buttonC.TabIndex = 29;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonExponentiation
            // 
            buttonExponentiation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExponentiation.Location = new Point(240, 226);
            buttonExponentiation.Name = "buttonExponentiation";
            buttonExponentiation.Size = new Size(67, 67);
            buttonExponentiation.TabIndex = 28;
            buttonExponentiation.Text = "x^y";
            buttonExponentiation.UseVisualStyleBackColor = true;
            buttonExponentiation.Click += operator_click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSix.Location = new Point(167, 226);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(67, 67);
            buttonSix.TabIndex = 27;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button_click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFive.Location = new Point(94, 226);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(67, 67);
            buttonFive.TabIndex = 26;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += button_click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFour.Location = new Point(21, 226);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(67, 67);
            buttonFour.TabIndex = 25;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += button_click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCE.Location = new Point(313, 153);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(78, 67);
            buttonCE.TabIndex = 24;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDivide.Location = new Point(240, 153);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(73, 67);
            buttonDivide.TabIndex = 23;
            buttonDivide.Text = "logx";
            buttonDivide.TextAlign = ContentAlignment.MiddleLeft;
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNine.Location = new Point(167, 153);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(67, 67);
            buttonNine.TabIndex = 22;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += button_click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEight.Location = new Point(94, 153);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(67, 67);
            buttonEight.TabIndex = 21;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += button_click;
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSeven.Location = new Point(21, 153);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(67, 67);
            buttonSeven.TabIndex = 20;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += button_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox_Result.Location = new Point(21, 90);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(370, 38);
            textBox_Result.TabIndex = 38;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrent_Operation
            // 
            labelCurrent_Operation.AutoSize = true;
            labelCurrent_Operation.BackColor = SystemColors.Window;
            labelCurrent_Operation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            labelCurrent_Operation.ForeColor = SystemColors.AppWorkspace;
            labelCurrent_Operation.Location = new Point(21, 56);
            labelCurrent_Operation.Name = "labelCurrent_Operation";
            labelCurrent_Operation.Size = new Size(0, 31);
            labelCurrent_Operation.TabIndex = 39;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 457);
            Controls.Add(labelCurrent_Operation);
            Controls.Add(textBox_Result);
            Controls.Add(buttonEcual);
            Controls.Add(buttonSquaring);
            Controls.Add(buttonPoint);
            Controls.Add(buttonZeero);
            Controls.Add(buttonRootExtraction);
            Controls.Add(buttonTree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonC);
            Controls.Add(buttonExponentiation);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonCE);
            Controls.Add(buttonDivide);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEcual;
        private Button buttonSquaring;
        private Button buttonPoint;
        private Button buttonZeero;
        private Button buttonRootExtraction;
        private Button buttonTree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonC;
        private Button buttonExponentiation;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonCE;
        private Button buttonDivide;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private TextBox textBox_Result;
        private Label labelCurrent_Operation;
    }
}