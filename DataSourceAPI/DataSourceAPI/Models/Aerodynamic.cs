using System;
using System.Collections.Generic;

#nullable disable

namespace DataSourceAPI.Models
{
    public partial class Aerodynamic
    {
        public int? QuestionDatabase { get; set; }
        public int? QuestionDatabaseQuestions { get; set; }
        public string QuestionDatabaseQuestionsQuestion { get; set; }
        public string QuestionDatabaseQuestionsImage { get; set; }
        public string QuestionDatabaseQuestionsExplanation { get; set; }
        public string QuestionDatabaseQuestionsExplanationImage { get; set; }
        public int? QuestionDatabaseQuestionsAnswers { get; set; }
        public string QuestionDatabaseQuestionsAnswersChoices { get; set; }
        public string QuestionDatabaseQuestionsAnswersChoicesCorrect { get; set; }
        public int? QuestionId { get; set; }

        public virtual AerodynamicsConceptualQuestion Question { get; set; }
    }
}
