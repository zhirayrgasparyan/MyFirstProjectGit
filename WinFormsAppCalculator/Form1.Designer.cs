namespace WinFormsAppCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonDivide = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonMultiply = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonMinus = new Button();
            buttonTree = new Button();
            buttonTwo = new Button();
            button14 = new Button();
            buttonEcual = new Button();
            buttonPlus = new Button();
            buttonPoint = new Button();
            buttonZeero = new Button();
            textBox_Result = new TextBox();
            labelCurrent_Operation = new Label();
            MenuButton = new Button();
            SuspendLayout();
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSeven.Location = new Point(23, 129);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(67, 67);
            buttonSeven.TabIndex = 0;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += button_click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEight.Location = new Point(96, 129);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(67, 67);
            buttonEight.TabIndex = 1;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += button_click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNine.Location = new Point(169, 129);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(67, 67);
            buttonNine.TabIndex = 2;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += button_click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDivide.Location = new Point(242, 129);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(67, 67);
            buttonDivide.TabIndex = 3;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCE.Location = new Point(315, 129);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(78, 67);
            buttonCE.TabIndex = 4;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonC.Location = new Point(315, 202);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(78, 67);
            buttonC.TabIndex = 9;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMultiply.Location = new Point(242, 202);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(67, 67);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSix.Location = new Point(169, 202);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(67, 67);
            buttonSix.TabIndex = 7;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button_click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFive.Location = new Point(96, 202);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(67, 67);
            buttonFive.TabIndex = 6;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += button_click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFour.Location = new Point(23, 202);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(67, 67);
            buttonFour.TabIndex = 5;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += button_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMinus.Location = new Point(242, 275);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(67, 67);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += operator_click;
            // 
            // buttonTree
            // 
            buttonTree.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTree.Location = new Point(169, 275);
            buttonTree.Name = "buttonTree";
            buttonTree.Size = new Size(67, 67);
            buttonTree.TabIndex = 12;
            buttonTree.Text = "3";
            buttonTree.UseVisualStyleBackColor = true;
            buttonTree.Click += button_click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTwo.Location = new Point(96, 275);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(67, 67);
            buttonTwo.TabIndex = 11;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += button_click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button14.Location = new Point(23, 275);
            button14.Name = "button14";
            button14.Size = new Size(67, 67);
            button14.TabIndex = 10;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // buttonEcual
            // 
            buttonEcual.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEcual.Location = new Point(315, 275);
            buttonEcual.Name = "buttonEcual";
            buttonEcual.Size = new Size(78, 140);
            buttonEcual.TabIndex = 19;
            buttonEcual.Text = "=";
            buttonEcual.UseVisualStyleBackColor = true;
            buttonEcual.Click += buttonEcual_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(242, 348);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(67, 67);
            buttonPlus.TabIndex = 18;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += operator_click;
            // 
            // buttonPoint
            // 
            buttonPoint.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPoint.Location = new Point(169, 348);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(67, 67);
            buttonPoint.TabIndex = 17;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += button_click;
            // 
            // buttonZeero
            // 
            buttonZeero.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonZeero.Location = new Point(23, 348);
            buttonZeero.Name = "buttonZeero";
            buttonZeero.Size = new Size(140, 67);
            buttonZeero.TabIndex = 15;
            buttonZeero.Text = "0";
            buttonZeero.UseVisualStyleBackColor = true;
            buttonZeero.Click += button_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox_Result.Location = new Point(23, 85);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(370, 38);
            textBox_Result.TabIndex = 20;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            textBox_Result.TextChanged += textBox_Result_TextChanged;
            // 
            // labelCurrent_Operation
            // 
            labelCurrent_Operation.AutoSize = true;
            labelCurrent_Operation.BackColor = SystemColors.Window;
            labelCurrent_Operation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            labelCurrent_Operation.ForeColor = SystemColors.AppWorkspace;
            labelCurrent_Operation.Location = new Point(23, 51);
            labelCurrent_Operation.Name = "labelCurrent_Operation";
            labelCurrent_Operation.Size = new Size(0, 31);
            labelCurrent_Operation.TabIndex = 21;
            labelCurrent_Operation.Click += label1_Click;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = SystemColors.ActiveCaptionText;
            MenuButton.ForeColor = SystemColors.ActiveCaptionText;
            MenuButton.Image = Properties.Resources.Menu;
            MenuButton.Location = new Point(23, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(34, 36);
            MenuButton.TabIndex = 22;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += Menu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(MenuButton);
            Controls.Add(labelCurrent_Operation);
            Controls.Add(textBox_Result);
            Controls.Add(buttonEcual);
            Controls.Add(buttonPlus);
            Controls.Add(buttonPoint);
            Controls.Add(buttonZeero);
            Controls.Add(buttonMinus);
            Controls.Add(buttonTree);
            Controls.Add(buttonTwo);
            Controls.Add(button14);
            Controls.Add(buttonC);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonCE);
            Controls.Add(buttonDivide);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonDivide;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonMultiply;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonMinus;
        private Button buttonTree;
        private Button buttonTwo;
        private Button button14;
        private Button buttonEcual;
        private Button buttonPlus;
        private Button buttonPoint;
        private Button buttonZeero;
        private TextBox textBox_Result;
        private Label labelCurrent_Operation;
        private Button MenuButton;
    }
}
