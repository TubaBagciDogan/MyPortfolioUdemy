﻿using System.ComponentModel.DataAnnotations;
namespace MyPortfolioUdemy.DAL.Entities
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
