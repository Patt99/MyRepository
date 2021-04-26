using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session2
{
    public partial class product_item : UserControl
    {


        private bool isActive;
        private Color textColor;
        private Color isActiveColor = Color.White;
        private Color isNotActiveColor = Color.FromArgb(239, 239, 239);

        public string Price
        {
            get
            {
                return price.Text;
            }
            set
            {
                price.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }

        public bool IsActive {
            set
            {
                this.isActive = value;
                if (!isActive)
                {
                    text_container.BackColor = isNotActiveColor;
                    container.BackColor = isNotActiveColor;
                    isNotActiveTitle.Visible = true;
                }
                if (isActive)
                {
                    text_container.BackColor = isActiveColor;
                    container.BackColor = isActiveColor;
                    isNotActiveTitle.Visible = false;
                }
            }
            get
            {
                return isActive;
            }
        }

        public Color TextColor
        {
            set
            {
                this.textColor = value;
                price.ForeColor = this.textColor;
                title.ForeColor = this.textColor;
                isNotActiveTitle.ForeColor = this.textColor;
            }
            get
            {
                return textColor;
            }
        }

        public Color BorderColor
        {
            get
            {
                return BackColor;
            }
            set
            {
               BackColor = value;
            }
        }



        public product_item()
        {
            InitializeComponent();

            text_container.Controls.Add(price);
            text_container.Controls.Add(title);
            text_container.Controls.Add(isNotActiveTitle);

            this.price.Width = text_container.Width;
            this.title.Width = text_container.Width;
            this.isNotActiveTitle.Width = text_container.Width;


            this.title.AutoSize = false;
            this.price.AutoSize = false;
            this.isNotActiveTitle.AutoSize = false;

            IsActive = true;
            BorderColor = Color.FromArgb(204, 204, 204);
            TextColor = Color.FromArgb(120, 130, 150);
            
        }

        private void product_item_Load(object sender, EventArgs e)
        {
            
        }
    }
}
