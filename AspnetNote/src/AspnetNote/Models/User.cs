using System.ComponentModel.DataAnnotations;

namespace AspnetNote.Models
{
    public class User
    {
        /// <summary>
        /// User No
        /// </summary>
        [Key] // PK setting
        public int UserNo { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        [Required] // Not null setting
        public string UserName { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        [Required] // Not null setting
        public string UserID { get; set; }
        /// <summary>
        /// User Password
        /// </summary>
        [Required] // Not null setting
        public string UserPassword { get; set; }
    }
}
