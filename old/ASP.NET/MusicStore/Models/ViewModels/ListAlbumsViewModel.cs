using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.ViewModels
{
    public class ListAlbumsViewModel
    {
        public List<Album> Albums { get; set; }
        public SelectList Genres { get; set; }

        [Display(Name = "Genre")]
        public int genreID { get; set; }
        public SelectList Artists { get; set; }

        [Display(Name = "Artist")]

        public int artistID { get; set; }
        public string title { get; set; }
    }
}
