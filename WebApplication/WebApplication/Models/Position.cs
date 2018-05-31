using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models {
    /// <summary>
    /// Должность сотрудника
    /// </summary>
    public class Position {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [DisplayName("Должность")]
        /// <summary>
        /// Название должности
        /// </summary>
        public string Name { get; set; }
        [Required]
        public virtual Subdivison Subdivison { get; set; }
    }
}