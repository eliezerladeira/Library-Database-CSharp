using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelBook
    {
        public ModelBook()
        {
            this.Book_Id = 0;
            this.Book_Code = 0;
            this.Book_Title = "";
            this.Book_Author = "";
            this.Book_Publisher = "";
            this.Book_Purchase_Date = Convert.ToDateTime("");
            this.Book_My_Rating = "";
            this.Book_Categories = "";
            this.Book_ISBN = "";
            this.Book_Description = "";
            this.Book_Tags = "";
            this.Book_Copies = 0;
            this.Book_Retail_Price = 0.00;
            this.Book_Edition = 0;
            this.Book_Pages = 0;
        }

        public ModelBook(int id, int code, String title, String author, String publisher, DateTime purchaseDate, String myRating, String cover, 
            String categories, String isbn, String description, String tags, int copies, Double retailPrice, int edition, int pages)
        {
            this.Book_Id = id;
            this.Book_Code = code;
            this.Book_Title = title;
            this.Book_Author = author;
            this.Book_Publisher = publisher;
            this.Book_Purchase_Date = purchaseDate;
            this.Book_My_Rating = myRating;
            this.Book_Categories = categories;
            this.Book_ISBN = isbn;
            this.Book_Description = description;
            this.Book_Tags = tags;
            this.Book_Copies = copies;
            this.Book_Retail_Price = retailPrice;
            this.Book_Edition = edition;
            this.UploadImage(cover);
        }

        public ModelBook(int id, int code, String title, String author, String publisher, DateTime purchaseDate, String myRating, Byte[] cover,
            String categories, String isbn, String description, String tags, int copies, Double retailPrice, int edition, int pages)
        {
            this.Book_Id = id;
            this.Book_Code = code;
            this.Book_Title = title;
            this.Book_Author = author;
            this.Book_Publisher = publisher;
            this.Book_Purchase_Date = purchaseDate;
            this.Book_My_Rating = myRating;
            this.Book_Categories = categories;
            this.Book_ISBN = isbn;
            this.Book_Description = description;
            this.Book_Tags = tags;
            this.Book_Copies = copies;
            this.Book_Retail_Price = retailPrice;
            this.Book_Edition = edition;
            this.Book_Cover = cover;
        }

        private int _bookid;
        private int _code;
        private String _title;
        private String _author;
        private String _publisher;
        private DateTime _purchaseDate;
        private String _myRating;
        private String _categories;
        private String _isbn;
        private String _description;
        private String _tags;
        private int _copies;
        private Double _retailPrice;
        private int _edition;
        private int _pages;
        private byte[] _cover;

        public int Book_Id
        {
            get { return this._bookid; }
            set { this._bookid = value; }
        }

        public int Book_Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String Book_Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public String Book_Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        public String Book_Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        public DateTime Book_Purchase_Date
        {
            get { return this._purchaseDate; }
            set { this._purchaseDate = value; }
        }

        public String Book_My_Rating
        {
            get { return this._myRating; }
            set { this._myRating = value; }
        }

        public String Book_Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        public String Book_ISBN
        {
            get { return this._isbn; }
            set { this._isbn = value; }
        }

        public String Book_Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public String Book_Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        public int Book_Copies
        {
            get { return this._copies; }
            set { this._copies = value; }
        }

        public Double Book_Retail_Price
        {
            get { return this._retailPrice; }
            set { this._retailPrice = value; }
        }

        public int Book_Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        public int Book_Pages
        {
            get { return this._pages; }
            set { this._pages = value; }
        }

        public byte[] Book_Cover
        {
            get { return this._cover; }
            set { this._cover = value; }
        }

        public void UploadImage(String imgDirectory)
        {
            try
            {
                if (String.IsNullOrEmpty(imgDirectory))
                    return;
                
                //provides instance properties and methods for creating, copying,
                // delete, move, and open files, and help with creating FileStream objects
                FileInfo imageFile = new FileInfo(imgDirectory);

                //Exposes a Stream around a support file
                //synchronous and asynchronous read and write operations.
                FileStream fs = new FileStream(imgDirectory, FileMode.Open, FileAccess.Read, FileShare.Read);

                //allocates memory for the vector
                this.Book_Cover = new byte[Convert.ToInt32(imageFile.Length)];

                //Reads a block of bytes from the stream and writes the data to a provided buffer.
                int iBytesRead = fs.Read(this.Book_Cover, 0, Convert.ToInt32(imageFile.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}