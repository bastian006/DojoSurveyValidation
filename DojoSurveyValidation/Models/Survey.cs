using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Survey
        {
            public string Name { get; set; }

            public string DojoLocation { get; set; }
  
            public string FaveLanguage { get; set; }

            public string Comment { get; set; }

        }

}