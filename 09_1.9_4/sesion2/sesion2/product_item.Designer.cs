namespace session2
{
    partial class product_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.text_container = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.isNotActiveTitle = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.text_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.Controls.Add(this.text_container);
            this.container.Controls.Add(this.image);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(2, 2);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(306, 346);
            this.container.TabIndex = 0;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Moccasin;
            this.image.Location = new System.Drawing.Point(45, 15);
            this.image.Margin = new System.Windows.Forms.Padding(45, 15, 3, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(215, 215);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // text_container
            // 
            this.text_container.Controls.Add(this.isNotActiveTitle);
            this.text_container.Controls.Add(this.price);
            this.text_container.Controls.Add(this.title);
            this.text_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_container.Location = new System.Drawing.Point(0, 230);
            this.text_container.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.text_container.Name = "text_container";
            this.text_container.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.text_container.Size = new System.Drawing.Size(306, 116);
            this.text_container.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(-4, 20);
            this.title.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(51, 20);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(-4, 52);
            this.price.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(51, 20);
            this.price.TabIndex = 1;
            this.price.Text = "label1";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isNotActiveTitle
            // 
            this.isNotActiveTitle.AutoSize = true;
            this.isNotActiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isNotActiveTitle.Location = new System.Drawing.Point(-4, 83);
            this.isNotActiveTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.isNotActiveTitle.Name = "isNotActiveTitle";
            this.isNotActiveTitle.Size = new System.Drawing.Size(78, 16);
            this.isNotActiveTitle.TabIndex = 2;
            this.isNotActiveTitle.Text = "неактивен";
            this.isNotActiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.container);
            this.Name = "product_item";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(310, 350);
            this.Load += new System.EventHandler(this.product_item_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.text_container.ResumeLayout(false);
            this.text_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel text_container;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label isNotActiveTitle;
    }
}
