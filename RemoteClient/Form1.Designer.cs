
namespace RemoteClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.tb_ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_mutly = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(167, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(220, 70);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(100, 22);
            this.tb_x.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(167, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(220, 113);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(100, 22);
            this.tb_y.TabIndex = 3;
            // 
            // tb_ans
            // 
            this.tb_ans.Location = new System.Drawing.Point(220, 168);
            this.tb_ans.Name = "tb_ans";
            this.tb_ans.ReadOnly = true;
            this.tb_ans.Size = new System.Drawing.Size(100, 22);
            this.tb_ans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(167, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ans:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(156, 233);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(262, 233);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(75, 23);
            this.btn_substract.TabIndex = 7;
            this.btn_substract.Text = "Substract";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_mutly
            // 
            this.btn_mutly.Location = new System.Drawing.Point(381, 233);
            this.btn_mutly.Name = "btn_mutly";
            this.btn_mutly.Size = new System.Drawing.Size(75, 23);
            this.btn_mutly.TabIndex = 8;
            this.btn_mutly.Text = "Mutly";
            this.btn_mutly.UseVisualStyleBackColor = true;
            this.btn_mutly.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(505, 233);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 9;
            this.btn_divide.Text = "Divide";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 596);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_mutly);
            this.Controls.Add(this.btn_substract);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ans);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.TextBox tb_ans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_mutly;
        private System.Windows.Forms.Button btn_divide;
    }
}

