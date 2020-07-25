using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spekter_MVC.Models
{
    public class Product
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string UrlSecondary { get; set; }
        public int Price { get; set; }
        public List<string> Color { get; set; }
        public List<string> Size { get; set; }
    }
}