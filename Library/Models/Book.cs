﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author AuthorOfBook { get; set; }
        public ICollection<BookCopy> Copies { get; set; }

        public Book()
        {
            Copies = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.BookID, this.Title);
        }
    }
}