namespace ArrayProgramTutorial2
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
            txtNewElement = new TextBox();
            btnAdd = new Button();
            lblArraySize = new Label();
            label2 = new Label();
            btnSort = new Button();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // txtNewElement
            // 
            txtNewElement.Font = new Font("Segoe UI", 14.25F);
            txtNewElement.Location = new Point(12, 88);
            txtNewElement.Name = "txtNewElement";
            txtNewElement.Size = new Size(128, 33);
            txtNewElement.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F);
            btnAdd.Location = new Point(12, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 65);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add to Array";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblArraySize
            // 
            lblArraySize.AutoSize = true;
            lblArraySize.Font = new Font("Segoe UI", 14.25F);
            lblArraySize.Location = new Point(118, 45);
            lblArraySize.Name = "lblArraySize";
            lblArraySize.Size = new Size(22, 25);
            lblArraySize.TabIndex = 2;
            lblArraySize.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Array Size:";
            // 
            // btnSort
            // 
            btnSort.Enabled = false;
            btnSort.Font = new Font("Segoe UI", 14.25F);
            btnSort.Location = new Point(12, 198);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(128, 65);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort Array";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI", 14.25F);
            btnDisplay.Location = new Point(12, 269);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(128, 65);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "Display Contents";
            btnDisplay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(154, 353);
            Controls.Add(btnDisplay);
            Controls.Add(btnSort);
            Controls.Add(label2);
            Controls.Add(lblArraySize);
            Controls.Add(btnAdd);
            Controls.Add(txtNewElement);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewElement;
        private Button btnAdd;
        private Label lblArraySize;
        private Label label2;
        private Button btnSort;
        private Button btnDisplay;
    }
}
