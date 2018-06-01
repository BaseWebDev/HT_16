using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models {
    /// <summary>
    /// Подразделение компании
    /// </summary>
    public class Divison {
        [HiddenInput]
        public int Id { get; set; }
        [DisplayName("Подразделение")]
        [Required]
        /// <summary>
        /// Название подразделения
        /// </summary>
        public string Name { get; set; }
    }
}