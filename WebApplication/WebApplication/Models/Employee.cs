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
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        [DisplayName("Отчество")]
        public string MiddleName { get; set; }
        /// <summary>
        /// Домашний телефон, обычно - личный номер, по которому сотрудника возможно найти в нерабочее время
        /// </summary>
        [DisplayName("Домашний телефон")]
        public string NumberHomePhone { get; set; }
        [DisplayName("Должность")]
        [Required]
        public virtual Position Position { get; set; }
        [DisplayName("Внутренний телефон")]
        [Required]
        public virtual ExtensionPhone ExtensionPhone { get; set; }
    }
}