namespace bookstore
{
    partial class Form2
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
            this.lbl_book_id_search = new System.Windows.Forms.Label();
            this.lbl_book_name_search = new System.Windows.Forms.Label();
            this.txtBook_ID_search = new System.Windows.Forms.TextBox();
            this.txtBook_name_search = new System.Windows.Forms.TextBox();
            this.lbl_search_result = new System.Windows.Forms.Label();
            this.btn_Search_books_frm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_book_id_search
            // 
            this.lbl_book_id_search.AutoSize = true;
            this.lbl_book_id_search.Location = new System.Drawing.Point(340, 93);
            this.lbl_book_id_search.Name = "lbl_book_id_search";
            this.lbl_book_id_search.Size = new System.Drawing.Size(61, 17);
            this.lbl_book_id_search.TabIndex = 8;
            this.lbl_book_id_search.Text = "شناسه کتاب";
            // 
            // lbl_book_name_search
            // 
            this.lbl_book_name_search.AutoSize = true;
            this.lbl_book_name_search.Location = new System.Drawing.Point(340, 45);
            this.lbl_book_name_search.Name = "lbl_book_name_search";
            this.lbl_book_name_search.Size = new System.Drawing.Size(49, 17);
            this.lbl_book_name_search.TabIndex = 7;
            this.lbl_book_name_search.Text = "نام کتاب ";
            // 
            // txtBook_ID_search
            // 
            this.txtBook_ID_search.Location = new System.Drawing.Point(153, 88);
            this.txtBook_ID_search.Name = "txtBook_ID_search";
            this.txtBook_ID_search.Size = new System.Drawing.Size(167, 22);
            this.txtBook_ID_search.TabIndex = 6;
            // 
            // txtBook_name_search
            // 
            this.txtBook_name_search.Location = new System.Drawing.Point(153, 41);
            this.txtBook_name_search.Name = "txtBook_name_search";
            this.txtBook_name_search.Size = new System.Drawing.Size(167, 22);
            this.txtBook_name_search.TabIndex = 5;
            // 
            // lbl_search_result
            // 
            this.lbl_search_result.AutoSize = true;
            this.lbl_search_result.Location = new System.Drawing.Point(204, 132);
            this.lbl_search_result.Name = "lbl_search_result";
            this.lbl_search_result.Size = new System.Drawing.Size(0, 17);
            this.lbl_search_result.TabIndex = 9;
            // 
            // btn_Search_books_frm2
            // 
            this.btn_Search_books_frm2.Location = new System.Drawing.Point(181, 264);
            this.btn_Search_books_frm2.Name = "btn_Search_books_frm2";
            this.btn_Search_books_frm2.Size = new System.Drawing.Size(123, 40);
            this.btn_Search_books_frm2.TabIndex = 13;
            this.btn_Search_books_frm2.Text = "جستجو کتاب";
            this.btn_Search_books_frm2.UseVisualStyleBackColor = true;
            this.btn_Search_books_frm2.Click += new System.EventHandler(this.btn_Search_books_frm2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 396);
            this.Controls.Add(this.btn_Search_books_frm2);
            this.Controls.Add(this.lbl_search_result);
            this.Controls.Add(this.lbl_book_id_search);
            this.Controls.Add(this.lbl_book_name_search);
            this.Controls.Add(this.txtBook_ID_search);
            this.Controls.Add(this.txtBook_name_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book_id_search;
        private System.Windows.Forms.Label lbl_book_name_search;
        private System.Windows.Forms.TextBox txtBook_ID_search;
        private System.Windows.Forms.TextBox txtBook_name_search;
        private System.Windows.Forms.Label lbl_search_result;
        private System.Windows.Forms.Button btn_Search_books_frm2;
    }
}