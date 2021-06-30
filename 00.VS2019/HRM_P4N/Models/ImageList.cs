using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class ImageList
    {
        public ImageList()
        {
            EmployeePictures = new HashSet<EmployeePicture>();
        }

        public int ImageId { get; set; }
        public int ImageTypeId { get; set; }
        public string ImageText { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefImageType ImageType { get; set; }
        public virtual ICollection<EmployeePicture> EmployeePictures { get; set; }
    }
}
