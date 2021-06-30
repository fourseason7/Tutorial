using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Question
    {
        public Question()
        {
            SurveyEmployees = new HashSet<SurveyEmployee>();
        }

        public int QuestionId { get; set; }
        public int SurveyId { get; set; }
        public int? No { get; set; }
        public string Krcontents { get; set; }
        public string Encontents { get; set; }
        public string Spcontents { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<SurveyEmployee> SurveyEmployees { get; set; }
    }
}
