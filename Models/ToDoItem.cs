using System;
using System.ComponentModel.DataAnnotations;

namespace DVDeploymentDemo.Models
{
    public class ToDoItem
    {
         #region public properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       

        [Display(Name = "Completed On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CompletedOn;

        #endregion

    }


}
