using System;
using System.Collections.Generic;

#nullable disable

namespace DataSourceAPI.Models
{
    public partial class AerodynamicsConceptualAnswer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public int? QuestionId { get; set; }
        public string IsCorrect { get; set; }

        public virtual AerodynamicsConceptualQuestion Question { get; set; }
    }
}
