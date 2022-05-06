using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DevExtremeAsp.Models
{
    public partial class TPerson
    {
        public int PerId { get; set; }

        [Display(Name="DNI")]
        [Required(ErrorMessage="mDNI"),StringLength(10)]
        public string PerDni { get; set; }

        [Display(Name="BirdDate")]
        [Required(ErrorMessage="mBirD"),DataType(DataType.Date)]         
        public DateTime? PerBird { get; set; }

        [Display(Name="CityOrigin")]
        [Required(ErrorMessage="mCitB"),StringLength(100)]
        public string PerBiCity { get; set; }

        [Display(Name="CountryOrigin")]
        [Required(ErrorMessage="mCtrOr"),StringLength(4)]
        public string PerBiCtry { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage="mName"),StringLength(100)]
        public string PerName { get; set; }

        [Display(Name="Surname")]
        [Required(ErrorMessage="mSname"),StringLength(100)]
        public string PerName1 { get; set; }

        [Display(Name="Adress")]
        [Required(ErrorMessage="mAdr"),StringLength(255)]
        public string PerAddr { get; set; }

        [Display(Name="AdressAd")]
        [Required(ErrorMessage="mAdr"),StringLength(255)]
        public string PerAddr1 { get; set; }

        [Display(Name="CountryRes")]
        [Required(ErrorMessage="mCtrOr"),StringLength(4)]
        public string PerAddCtry { get; set; }

        [Display(Name="ContractDate")]
        [Required(ErrorMessage="mConD"),DataType(DataType.Date)]         
        public DateTime? PerContDate { get; set; }

        [Display(Name="EntryDate")]
        [Required(ErrorMessage="mEntD"),DataType(DataType.Date)]         
        public DateTime? PerEntDate { get; set; }

        [Display(Name="ExitDate")]
        [DataType(DataType.Date)]         
        public DateTime? PerExiDate { get; set; }
    }
}
