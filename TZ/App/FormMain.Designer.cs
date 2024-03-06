namespace App
{
    partial class FormMain
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
            this.lblCircle = new System.Windows.Forms.Label();
            this.txtCircleRadius = new System.Windows.Forms.TextBox();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.btnSquareForCircle = new System.Windows.Forms.Button();
            this.txtFirstTriangleSide = new System.Windows.Forms.TextBox();
            this.txtSecondTriangleSide = new System.Windows.Forms.TextBox();
            this.txtThirdTriangleSide = new System.Windows.Forms.TextBox();
            this.btnTriangleForSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCircle.Location = new System.Drawing.Point(12, 9);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(99, 44);
            this.lblCircle.TabIndex = 0;
            this.lblCircle.Text = "Круг";
            // 
            // txtCircleRadius
            // 
            this.txtCircleRadius.Location = new System.Drawing.Point(20, 66);
            this.txtCircleRadius.Name = "txtCircleRadius";
            this.txtCircleRadius.Size = new System.Drawing.Size(330, 31);
            this.txtCircleRadius.TabIndex = 1;
            // 
            // lblTriangle
            // 
            this.lblTriangle.AutoSize = true;
            this.lblTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTriangle.Location = new System.Drawing.Point(12, 186);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(242, 44);
            this.lblTriangle.TabIndex = 2;
            this.lblTriangle.Text = "Треугольник";
            // 
            // btnSquareForCircle
            // 
            this.btnSquareForCircle.Location = new System.Drawing.Point(20, 107);
            this.btnSquareForCircle.Name = "btnSquareForCircle";
            this.btnSquareForCircle.Size = new System.Drawing.Size(330, 54);
            this.btnSquareForCircle.TabIndex = 3;
            this.btnSquareForCircle.Text = "Рассчитать площадь";
            this.btnSquareForCircle.UseVisualStyleBackColor = true;
            this.btnSquareForCircle.Click += new System.EventHandler(this.BtnSquareForCircleOnClick);
            // 
            // txtFirstTriangleSide
            // 
            this.txtFirstTriangleSide.Location = new System.Drawing.Point(20, 246);
            this.txtFirstTriangleSide.Name = "txtFirstTriangleSide";
            this.txtFirstTriangleSide.Size = new System.Drawing.Size(330, 31);
            this.txtFirstTriangleSide.TabIndex = 4;
            // 
            // txtSecondTriangleSide
            // 
            this.txtSecondTriangleSide.Location = new System.Drawing.Point(20, 293);
            this.txtSecondTriangleSide.Name = "txtSecondTriangleSide";
            this.txtSecondTriangleSide.Size = new System.Drawing.Size(330, 31);
            this.txtSecondTriangleSide.TabIndex = 5;
            // 
            // txtThirdTriangleSide
            // 
            this.txtThirdTriangleSide.Location = new System.Drawing.Point(20, 343);
            this.txtThirdTriangleSide.Name = "txtThirdTriangleSide";
            this.txtThirdTriangleSide.Size = new System.Drawing.Size(330, 31);
            this.txtThirdTriangleSide.TabIndex = 6;
            // 
            // btnTriangleForSquare
            // 
            this.btnTriangleForSquare.Location = new System.Drawing.Point(20, 384);
            this.btnTriangleForSquare.Name = "btnTriangleForSquare";
            this.btnTriangleForSquare.Size = new System.Drawing.Size(330, 54);
            this.btnTriangleForSquare.TabIndex = 7;
            this.btnTriangleForSquare.Text = "Рассчитать площадь";
            this.btnTriangleForSquare.UseVisualStyleBackColor = true;
            this.btnTriangleForSquare.Click += new System.EventHandler(this.BtnTriangleForSquareOnClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.btnTriangleForSquare);
            this.Controls.Add(this.txtThirdTriangleSide);
            this.Controls.Add(this.txtSecondTriangleSide);
            this.Controls.Add(this.txtFirstTriangleSide);
            this.Controls.Add(this.btnSquareForCircle);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.txtCircleRadius);
            this.Controls.Add(this.lblCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.Label lblTriangle;
        private System.Windows.Forms.Button btnSquareForCircle;
        private System.Windows.Forms.TextBox txtFirstTriangleSide;
        private System.Windows.Forms.TextBox txtSecondTriangleSide;
        private System.Windows.Forms.TextBox txtThirdTriangleSide;
        private System.Windows.Forms.Button btnTriangleForSquare;
    }
}

