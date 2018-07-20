using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace @interface
{
    class Book
{
        public string title, author, genres, description, ID;
        int amount, borrowed, in_library;
        public Image obal;

        public Book(string title, string author, string genres, string desc, string id, int amount)
        {
            this.title = title;
            this.author = author;
            this.genres = genres;
            this.description = desc;
            this.amount = amount;
            this.ID = id;
            obal = LoadImage();
        }

        public void Borrow(int num)
        {
            borrowed++;
            in_library--;
        }

        //načte obal knihy
        private Image LoadImage()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://covers.openlibrary.org/w/id/" + ID + ".jpg");

                WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();

                Bitmap bmp = new Bitmap(responseStream);

                responseStream.Dispose();

                return bmp;
            }
            catch
            {
                return new Bitmap(100, 100);              
            }
            
        }
    }
}
