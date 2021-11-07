using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataSourceAPI.Models
{
    public partial class AeroWizContext : DbContext
    {
        public AeroWizContext()
        {
        }

        public AeroWizContext(DbContextOptions<AeroWizContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aerodynamic> Aerodynamics { get; set; }
        public virtual DbSet<AerodynamicsConceptualAnswer> AerodynamicsConceptualAnswers { get; set; }
        public virtual DbSet<AerodynamicsConceptualQuestion> AerodynamicsConceptualQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=AeroWiz;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Aerodynamic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aerodynamics");

                entity.Property(e => e.QuestionDatabaseQuestions).HasColumnName("QuestionDatabase_Questions");

                entity.Property(e => e.QuestionDatabaseQuestionsAnswers).HasColumnName("QuestionDatabase_Questions_Answers");

                entity.Property(e => e.QuestionDatabaseQuestionsAnswersChoices)
                    .HasMaxLength(170)
                    .HasColumnName("QuestionDatabase_Questions_Answers_Choices");

                entity.Property(e => e.QuestionDatabaseQuestionsAnswersChoicesCorrect)
                    .HasMaxLength(5)
                    .HasColumnName("QuestionDatabase_Questions_Answers_Choices_correct");

                entity.Property(e => e.QuestionDatabaseQuestionsExplanation)
                    .HasMaxLength(838)
                    .HasColumnName("QuestionDatabase_Questions_Explanation");

                entity.Property(e => e.QuestionDatabaseQuestionsExplanationImage)
                    .HasMaxLength(17)
                    .HasColumnName("QuestionDatabase_Questions_ExplanationImage");

                entity.Property(e => e.QuestionDatabaseQuestionsImage)
                    .HasMaxLength(20)
                    .HasColumnName("QuestionDatabase_Questions_Image");

                entity.Property(e => e.QuestionDatabaseQuestionsQuestion)
                    .HasMaxLength(244)
                    .HasColumnName("QuestionDatabase_Questions_Question");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany()
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_aerodynamics_Aerodynamics_Conceptual_Questions");
            });

            modelBuilder.Entity<AerodynamicsConceptualAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK__Aerodyna__D48250246F1421C7");

                entity.ToTable("Aerodynamics_Conceptual_Answers");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerText).IsUnicode(false);

                entity.Property(e => e.IsCorrect).HasMaxLength(5);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.AerodynamicsConceptualAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Aerodynam__Quest__29572725");
            });

            modelBuilder.Entity<AerodynamicsConceptualQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK__Aerodyna__0DC06F8C3E2109DC");

                entity.ToTable("Aerodynamics_Conceptual_Questions");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionText).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
