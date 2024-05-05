namespace spotifyTask
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
            Add = new Button();
            dataGridView1 = new DataGridView();
            surnameInput = new TextBox();
            nameInput = new TextBox();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Location = new Point(423, 15);
            Add.Name = "Add";
            Add.Size = new Size(95, 37);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(487, 259);
            dataGridView1.TabIndex = 1;
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(185, 23);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(167, 23);
            surnameInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 23);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(145, 23);
            nameInput.TabIndex = 3;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(423, 63);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(95, 36);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 397);
            Controls.Add(deleteBtn);
            Controls.Add(nameInput);
            Controls.Add(surnameInput);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private DataGridView dataGridView1;
        private TextBox surnameInput;
        private TextBox nameInput;
        private Button deleteBtn;
    }
}
