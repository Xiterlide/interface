using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface 
{
    public partial class detail : Form
{
    public detail(string name, string author, string genres, string desc)
    {
        InitializeComponent_detail();
            this.name = name;
            this.author = author;
            this.genres = genres;
            this.desc = desc;
    }

    public detail()
        {
            InitializeComponent_detail();
        }

    string name = "Lorem", genres = "Sit, amet, consectetur, adipiscing, elit", author = "Ipsum Dolor", desc = "Nunc facilisis eu massa vitae scelerisque. Vivamus luctus varius est interdum pretium. Ut commodo, nulla eu fringilla elementum, dui nunc elementum neque, ut dapibus enim purus nec sapien. Cras id dolor eget erat efficitur vestibulum. In fermentum, libero a luctus feugiat, diam libero suscipit ex, ac auctor erat ante id sapien. Cras nisl ex, imperdiet id justo rutrum, convallis ultrices velit. Nunc a semper neque.";

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detail));
            this.obal = new System.Windows.Forms.PictureBox();
            this.rezervovat = new System.Windows.Forms.Button();
            this.název = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.žánry = new System.Windows.Forms.TextBox();
            this.popis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obal)).BeginInit();
            this.SuspendLayout();
            // 
            // obal
            // 
            this.obal.Image = ((System.Drawing.Image)(resources.GetObject("obal.Image")));
            this.obal.InitialImage = null;
            this.obal.Location = new System.Drawing.Point(308, 36);
            this.obal.Name = "obal";
            this.obal.Size = new System.Drawing.Size(200, 250);
            this.obal.TabIndex = 0;
            this.obal.TabStop = false;
            // 
            // rezervovat
            // 
            this.rezervovat.Location = new System.Drawing.Point(308, 7);
            this.rezervovat.Name = "rezervovat";
            this.rezervovat.Size = new System.Drawing.Size(200, 23);
            this.rezervovat.TabIndex = 2;
            this.rezervovat.Text = "Rezervovat";
            this.rezervovat.UseVisualStyleBackColor = true;
            // 
            // název
            // 
            this.název.BackColor = System.Drawing.SystemColors.MenuBar;
            this.název.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.název.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.název.Location = new System.Drawing.Point(12, 293);
            this.název.Name = "název";
            this.název.ReadOnly = true;
            this.název.Size = new System.Drawing.Size(776, 40);
            this.název.TabIndex = 3;
            this.název.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autor
            // 
            this.autor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autor.Location = new System.Drawing.Point(12, 339);
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Size = new System.Drawing.Size(776, 31);
            this.autor.TabIndex = 4;
            this.autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // žánry
            // 
            this.žánry.BackColor = System.Drawing.SystemColors.MenuBar;
            this.žánry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.žánry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.žánry.Location = new System.Drawing.Point(12, 394);
            this.žánry.Multiline = true;
            this.žánry.Name = "žánry";
            this.žánry.ReadOnly = true;
            this.žánry.Size = new System.Drawing.Size(776, 30);
            this.žánry.TabIndex = 5;
            // 
            // popis
            // 
            this.popis.BackColor = System.Drawing.SystemColors.Control;
            this.popis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.popis.Location = new System.Drawing.Point(12, 439);
            this.popis.Name = "popis";
            this.popis.ReadOnly = true;
            this.popis.Size = new System.Drawing.Size(776, 185);
            this.popis.TabIndex = 6;
            this.popis.Text = "";
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.žánry);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.název);
            this.Controls.Add(this.rezervovat);
            this.Controls.Add(this.obal);
            this.Name = "detail";
            this.Text = "detail";
            this.Load += new System.EventHandler(this.detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void detail_Load(object sender, EventArgs e)
        {
            název.Text = name; autor.Text = author; žánry.Text = genres; popis.Text = desc;
        }
    }
}
