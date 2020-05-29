namespace Solar
{
    partial class SpdCount
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonGD = new System.Windows.Forms.Button();
            this.buttonUpData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxVel1 = new System.Windows.Forms.TextBox();
            this.textBoxVel2 = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(110, 198);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "buttonC";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonGD
            // 
            this.buttonGD.Location = new System.Drawing.Point(43, 259);
            this.buttonGD.Name = "buttonGD";
            this.buttonGD.Size = new System.Drawing.Size(75, 23);
            this.buttonGD.TabIndex = 2;
            this.buttonGD.Text = "buttonGD";
            this.buttonGD.UseVisualStyleBackColor = true;
            this.buttonGD.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUpData
            // 
            this.buttonUpData.Location = new System.Drawing.Point(24, 329);
            this.buttonUpData.Name = "buttonUpData";
            this.buttonUpData.Size = new System.Drawing.Size(75, 23);
            this.buttonUpData.TabIndex = 3;
            this.buttonUpData.Text = "buttonUpData";
            this.buttonUpData.UseVisualStyleBackColor = true;
            this.buttonUpData.Click += new System.EventHandler(this.buttonUpData_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(542, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // textBoxVel1
            // 
            this.textBoxVel1.Location = new System.Drawing.Point(370, 198);
            this.textBoxVel1.Name = "textBoxVel1";
            this.textBoxVel1.Size = new System.Drawing.Size(100, 22);
            this.textBoxVel1.TabIndex = 6;
            // 
            // textBoxVel2
            // 
            this.textBoxVel2.Location = new System.Drawing.Point(370, 234);
            this.textBoxVel2.Name = "textBoxVel2";
            this.textBoxVel2.Size = new System.Drawing.Size(100, 22);
            this.textBoxVel2.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(403, 275);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 8;
            // 
            // SpdCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 446);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxVel2);
            this.Controls.Add(this.textBoxVel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUpData);
            this.Controls.Add(this.buttonGD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.comboBox1);
            this.Name = "SpdCount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonGD;
        private System.Windows.Forms.Button buttonUpData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxVel1;
        private System.Windows.Forms.TextBox textBoxVel2;
        private System.Windows.Forms.TextBox textBoxHeight;
    }
}

