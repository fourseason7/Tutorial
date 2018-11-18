using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetNote.Models
{
    public class Note
    {
        /// <summary>
        /// Note No
        /// </summary>
        [Key]
        public int NoteNo { get; set; }
        /// <summary>
        /// Note Title
        /// </summary>
        [Required] // Not null setting
        public string NoteTitle { get; set; }
        /// <summary>
        /// Note Contents
        /// </summary>
        [Required] // Not null setting
        public string NoteContents { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        [Required] // Not null setting
        public int UserNo { get; set; }

        [ForeignKey("UserNo")]
        public virtual User user { get; set; }
    }
}
