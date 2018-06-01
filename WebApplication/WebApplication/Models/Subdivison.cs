using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models {
    /// <summary>
    /// Отдел компании
    /// </summary>
    public class Subdivison {
        [HiddenInput]
        public int Id { get; set; }
        [DisplayName("Отдел")]
        [Required]
        /// <summary>
        /// Название отдела
        /// </summary>
        public string Name { get; set; }
        [Required]
        public virtual Divison Divison { get; set; }
    }
}