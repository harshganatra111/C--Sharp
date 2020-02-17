using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class books
    {
        private int book_id;
        private string book_name;
        private int no_of_pages=250;

        public void SetId(int Id)
        {
            if(Id<0)
            {
                throw new Exception("Id is not vaild ...!!!!");
            }
            this.book_id = Id;
        }
        public int GetId()
        {
            return this.book_id;
        }
        public void SetBookName(string bookname)
        {
            if(string.IsNullOrEmpty(bookname))
            {
                throw new Exception("Invalid book name...!!!");
            }
            this.book_name = bookname;
        }
        public string GetBookName()
        {
            return this.book_name;
        }
        public int GetNoPages()
        {
            return this.no_of_pages;
        }
            
    }
    class GetterSetter
    {
        static void Main(string[] args)
        {
            books obj = new books();
            obj.SetId(10);
            Console.WriteLine("Book Id :{0}", obj.GetId());
            obj.SetBookName("Black Book");
            Console.WriteLine("Book name : {0}", obj.GetBookName());
            Console.WriteLine("Book Pages : {0}", obj.GetNoPages());
            Console.ReadKey();
        }
    }
}
