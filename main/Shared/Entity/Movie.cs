using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace popcorntime.Shared.Entity
{
    public class Movie
    {
        public int IdMovie{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieName{get;set;}
         [Required (ErrorMessage ="El campo {0} es requerido")]
        public string Image{get;set;}
        public double Score{get;set;}
        public List <string> Category{get;set;}
        public string Synopsis{get;set;}
        public DateTime Premier {get;set;}
        public string Trailer{get;set;}
        public string ShortName
        {
            get{
               if (string.IsNullOrWhiteSpace(MovieName))
               {
                   return null;
               }
               if (MovieName.Length > 60){
                   return MovieName.Substring(0,60) + "...";
               }else{
                   return MovieName;
               }
            }
        }
    }
}