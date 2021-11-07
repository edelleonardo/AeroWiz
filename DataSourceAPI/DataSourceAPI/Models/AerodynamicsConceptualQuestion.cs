using System;
using System.Collections.Generic;

#nullable disable

namespace DataSourceAPI.Models
{
    public partial class AerodynamicsConceptualQuestion
    {
        public AerodynamicsConceptualQuestion()
        {
            AerodynamicsConceptualAnswers = new HashSet<AerodynamicsConceptualAnswer>();
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionExplanation { get; set; }

        public virtual ICollection<AerodynamicsConceptualAnswer> AerodynamicsConceptualAnswers { get; set; }
    }
}
