namespace MultiLanguageMarkDownGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbKR = new System.Windows.Forms.RadioButton();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.rbJp = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbFr = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 12);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(776, 212);
            this.tbResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // rbKR
            // 
            this.rbKR.AutoSize = true;
            this.rbKR.Checked = true;
            this.rbKR.Location = new System.Drawing.Point(3, 3);
            this.rbKR.Name = "rbKR";
            this.rbKR.Size = new System.Drawing.Size(59, 16);
            this.rbKR.TabIndex = 3;
            this.rbKR.TabStop = true;
            this.rbKR.Text = "한국어";
            this.rbKR.UseVisualStyleBackColor = true;
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Location = new System.Drawing.Point(115, 3);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(65, 16);
            this.rbEn.TabIndex = 4;
            this.rbEn.Text = "English";
            this.rbEn.UseVisualStyleBackColor = true;
            // 
            // rbJp
            // 
            this.rbJp.AutoSize = true;
            this.rbJp.Location = new System.Drawing.Point(227, 3);
            this.rbJp.Name = "rbJp";
            this.rbJp.Size = new System.Drawing.Size(59, 16);
            this.rbJp.TabIndex = 5;
            this.rbJp.Text = "日本語";
            this.rbJp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.rbFr, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbKR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbJp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbEn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 347);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // rbFr
            // 
            this.rbFr.AutoSize = true;
            this.rbFr.Location = new System.Drawing.Point(339, 3);
            this.rbFr.Name = "rbFr";
            this.rbFr.Size = new System.Drawing.Size(72, 16);
            this.rbFr.TabIndex = 6;
            this.rbFr.Text = "Français";
            this.rbFr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbKR;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.RadioButton rbJp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbFr;
    }
}

