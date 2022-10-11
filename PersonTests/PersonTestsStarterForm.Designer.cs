namespace PersonTests
{
    partial class PersonTestsStarterForm
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

        private static int TestDisplay()
        {
            int returnValue = 0;
            try
            {
                new Person("Bob").Display();
            }
            catch (Exception)
            {
                MessageBox.Show("TestDisplay failed!");
                returnValue = 1;
            }
            return returnValue;
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunTestsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunTestsButton
            // 
            this.RunTestsButton.Location = new System.Drawing.Point(40, 40);
            this.RunTestsButton.Name = "RunTestsButton";
            this.RunTestsButton.Size = new System.Drawing.Size(200, 29);
            this.RunTestsButton.TabIndex = 0;
            this.RunTestsButton.Text = "Run Person Tests";
            this.RunTestsButton.UseVisualStyleBackColor = true;
            this.RunTestsButton.Click += new System.EventHandler(this.RunTestsButton_Click);
            // 
            // PersonTestsStarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 103);
            this.Controls.Add(this.RunTestsButton);
            this.Name = "PersonTestsStarterForm";
            this.Text = "Person Tests Runner";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RunTestsButton;
    }
}