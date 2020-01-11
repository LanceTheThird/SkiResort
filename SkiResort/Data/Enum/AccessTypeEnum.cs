using System.ComponentModel.DataAnnotations;

namespace Data.Enum
{
    public enum AccessTypeEnum
    {
        [Display(Name = "NoAccess")]
        NoAccess = 0,
        [Display(Name = "ReadOnly")]
        ReadOnly = 1,
        [Display(Name = "FullAccess")]
        FullAccess = 2
    }
}
