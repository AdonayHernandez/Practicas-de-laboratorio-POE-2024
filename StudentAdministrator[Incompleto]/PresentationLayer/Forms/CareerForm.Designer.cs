namespace PresentationLayer.Forms
{
    partial class CareerForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtDescriptionCareer = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            labelName = new Label();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(310, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(267, 355);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 19);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 1;
            label1.Text = "Administrador de Carreras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 255);
            label2.Name = "label2";
            label2.Size = new Size(194, 17);
            label2.TabIndex = 2;
            label2.Text = "Descripcion de la Carrera";
            // 
            // txtDescriptionCareer
            // 
            txtDescriptionCareer.Location = new Point(18, 289);
            txtDescriptionCareer.Multiline = true;
            txtDescriptionCareer.Name = "txtDescriptionCareer";
            txtDescriptionCareer.Size = new Size(162, 96);
            txtDescriptionCareer.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(18, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(118, 413);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(213, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelName.Location = new Point(18, 93);
            labelName.Name = "labelName";
            labelName.Size = new Size(162, 17);
            labelName.TabIndex = 7;
            labelName.Text = "Nombre de la Carrera";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 8;
            // 
            // CareerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtDescriptionCareer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CareerForm";
            Text = "CareerForm";
            Load += CareerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtDescriptionCareer;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label labelName;
        private TextBox txtName;
    }
}