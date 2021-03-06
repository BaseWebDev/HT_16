﻿using System;
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
        /// <summary>
        /// Название отдела
        /// </summary>
        [DisplayName("Отдел")]
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual Divison Divison { get; set; }
    }
}