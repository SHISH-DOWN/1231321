namespace Solar
{
    partial class DBEdit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonForceUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(74, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonForceUpdate
            // 
            this.buttonForceUpdate.Location = new System.Drawing.Point(208, 281);
            this.buttonForceUpdate.Name = "buttonForceUpdate";
            this.buttonForceUpdate.Size = new System.Drawing.Size(107, 23);
            this.buttonForceUpdate.TabIndex = 2;
            this.buttonForceUpdate.Text = "buttonForceUpdate";
            this.buttonForceUpdate.UseVisualStyleBackColor = true;
            this.buttonForceUpdate.Click += new System.EventHandler(this.buttonForceUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(344, 281);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(123, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(74, 333);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Text = "Name";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(180, 333);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(100, 22);
            this.textBoxMass.TabIndex = 5;
            this.textBoxMass.Text = "Mass";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(286, 333);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxRadius.TabIndex = 6;
            this.textBoxRadius.Text = "Radius";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Использовать только латинскую е и точку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK, send data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonForceUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBEdit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DBEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonForceUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}