using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DenemeApp.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository()
        {
            _bootcamp = new List<Bootcamp>(){
                new(){Id = 1, Title = "Backend Bootcamp", Description = "ASP.Net Mvc Dersleri başlıyor", Instructor = " Caner Dedeoğlu", Image = "1.jpeg",tag= new string[]{"Web Geliştirme", "asp.net"}, isActive = true, isHome= false},
                new(){Id = 2, Title = "Frontend Bootcamp", Description = "Frontend Dersleri başlıyor", Instructor = " Caner Dedeoğlu", Image = "3.jpeg",tag= new string[]{"Web Geliştirme", "html","css"}, isActive = true, isHome= true},
                new(){Id = 3, Title = "Kotlin Bootcamp", Description = "Kotlin Dersleri başlıyor", Instructor = " Caner Dedeoğlu", Image = "2.jpeg",tag= new string[]{"Mobil Geliştirme", "kotlin"}, isActive = true, isHome= true}

            };
        }
        public static List<Bootcamp> Bootcamps{get{return _bootcamp;}}
        
        public static Bootcamp? GetById(int id)
        {
            return _bootcamp.FirstOrDefault(b => b.Id == id);
        }
    }
}