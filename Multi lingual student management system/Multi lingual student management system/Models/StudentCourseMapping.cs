﻿using System.ComponentModel.DataAnnotations;

namespace Multi_lingual_student_management_system.Models
{
    public class StudentCourseMapping
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
    }
}