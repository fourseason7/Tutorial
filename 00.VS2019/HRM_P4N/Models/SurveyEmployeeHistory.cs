using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class SurveyEmployeeHistory
    {
        public string EmployeeId { get; set; }
        public int QuestionId { get; set; }
        public string Year { get; set; }
        public int? ChoiceAnswer1 { get; set; }
        public string EssayAnswer1 { get; set; }
        public int? ChoiceAnswer2 { get; set; }
        public string EssayAnswer2 { get; set; }
        public int? ChoiceAnswer3 { get; set; }
        public string EssayAnswer3 { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
