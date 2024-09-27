namespace DemoLambdaObjects
{
    partial class FormLambda
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
            buttonLambda = new Button();
            SuspendLayout();
            // 
            // buttonLambda
            // 
            buttonLambda.Location = new Point(226, 270);
            buttonLambda.Name = "buttonLambda";
            buttonLambda.RightToLeft = RightToLeft.Yes;
            buttonLambda.Size = new Size(170, 56);
            buttonLambda.TabIndex = 0;
            buttonLambda.Text = "kör Lambda";
            buttonLambda.UseVisualStyleBackColor = true;
            buttonLambda.Click += buttonLambda_Click;
            // 
            // FormLambda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(buttonLambda);
            Name = "FormLambda";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLambda;
    }
}
