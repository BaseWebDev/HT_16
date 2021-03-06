﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models {
    /// <summary>
    /// Внутренние номера телефонов
    /// </summary>
    public class ExtensionPhone {
        [HiddenInput]
        public int Id { get; set; }
        /// <summary>
        /// Внутренний номер
        /// </summary>
        [DisplayName("Внутренний номер")]
        [Required]
        public string Number { get; set; }
        [DisplayName("Место установки")]
        /// <summary>
        /// Место установки
        /// </summary>
        public string InstallationSite { get; set; }
    }
}