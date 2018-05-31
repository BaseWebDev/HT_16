using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models {
    /// <summary>
    /// Справочник сотрудников
    /// </summary>
    public class Employee {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [DisplayName("Фамилия")]
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        [Required]
        [DisplayName("Имя")]
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        [DisplayName("Отчество")]
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
        [DisplayName("Домашний телефон")]
        /// <summary>
        /// Домашний телефон, обычно личный номер, по которому сотрудника возможно найти в нерабочее время
        /// </summary>
        public string NumberHomePhone { get; set; }
        [DisplayName("Должность")]
        [Required]
        public virtual Position Position { get; set; }
        [DisplayName("Внутренний телефон")]
        [Required]
        public virtual ExtensionPhone ExtensionPhone { get; set; }
    }
}