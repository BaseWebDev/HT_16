﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models {
    /// <summary>
    /// Подразделение компании
    /// </summary>
    public class Divison {
        public int Id { get; set; }
        [Required]
        /// <summary>
        /// Название подразделения
        /// </summary>
        public string Name { get; set; }
    }
}