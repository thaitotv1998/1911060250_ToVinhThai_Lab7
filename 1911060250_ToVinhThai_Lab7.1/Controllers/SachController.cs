using _1911060250_ToVinhThai_Lab7._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911060250_ToVinhThai_Lab7._1.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{Id = 1, Title = "Serlock Holmes", AuthorName = "Conan Doyle", Price = 1, Content = "Hành trình phá án của Sherlock Holmes" },
            new Sach{Id = 2, Title = "Serlock Holmes 2", AuthorName = "Arthur Conan Doyle", Price = 3.75M, Content = "Hành trình phá án của Sherlock Holmes p2" },
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
