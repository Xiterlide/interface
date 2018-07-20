using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace @interface
{
    public partial class Schnittstelle : Form
    {
        public Schnittstelle()
        {
            InitializeComponent();
        }

        Point start = new Point(0, 0); //startovní bod okna
        Size rect = new Size(180, 200); //okno
        int kniha; Random k = new Random(); //dočasné

        List<Book> books = new List<Book>(); //seznam prvních 15 knih
        

        private void start_add() //kreslí okna, aby nepřesáhla hranici panelu
        {
            if(start.X+180<900)
            start.X += 180;

            else
            {
                start.Y += 200;
                start.X = 0;
            }
          
        }

        private void Info(Graphics gr, Book book) //obsah okna
        {
            //textová pole pro název a popis
            Rectangle text_field_name = new Rectangle(start.X+40,start.Y+125,100,15);
            Rectangle text_field_desc = new Rectangle(start.X + 40, start.Y + 140, 100,50);

            //formát textu v okně
            StringFormat text = new StringFormat();
            text.Alignment = StringAlignment.Center;
            text.LineAlignment = StringAlignment.Center;
            Font name = new Font("Arial", 14);
            Font desc = new Font("Arial", 11);
      
            gr.DrawRectangle(Pens.Black, new Rectangle(start, rect)); //hranice okna

            gr.DrawImage(ikony.Images[k.Next(0,4)], start.X+40,start.Y+20); //titulní stránka
            gr.DrawString(book.title, name , Brushes.Black, text_field_name, text); //název
            gr.DrawString(book.description, desc , Brushes.Black, text_field_desc, text); //popis     

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;


           for(int i=0;i<15;i++)
            {
                Info(gr, books[i]);
                start_add();
            }  

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                books.Add(new Book("kniha " + kniha, "autor", "žánry", "popis", "ID", 5));
                kniha = i + 1;
            }

        }
      

        //ukáže detail knihy
        private void show_detail(Book book)
        {
            detail detail = new detail(book.title, book.author, book.genres, book.description);
            detail.Show();
        }
     
    }
}
