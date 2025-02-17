namespace SchoolPoliApp.WinForms
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
            button1 = new Button();
            tbxNombre = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 141);
            button1.Name = "button1";
            button1.Size = new Size(219, 29);
            button1.TabIndex = 0;
            button1.Text = "Mostrar Nombre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(33, 94);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(219, 27);
            tbxNombre.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 217);
            Controls.Add(tbxNombre);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbxNombre;
    }
}
