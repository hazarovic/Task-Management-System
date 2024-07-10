using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMS.Models;

namespace TMS.ViewModel
{
    public class TaskViewModel
    {
        public int TaskId { get; set; }
        [Required(ErrorMessage ="Please Enter Task Title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please Enter Task Description")]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ErrorMessage { get; set; }
    }
}