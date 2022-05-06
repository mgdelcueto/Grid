using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DevExtremeAsp.Models
{
    public partial class TMaterial
    {
        public int MatId { get; set; }

        [Display(Name="MRefer")]
        [Required(ErrorMessage="mReq"),StringLength(125)]
        public string MatRefer { get; set; }

        [Display(Name="MType")]
        [Required(ErrorMessage="mReq"),StringLength(25)]
        public string MatType { get; set; }

        [Display(Name="MClass")]
        [Required(ErrorMessage="mReq"),StringLength(25)]
        public string MatClass { get; set; }

        [Display(Name="MStatus")]
        [Required(ErrorMessage="mReq"),StringLength(125)]
        public string MatStatus { get; set; }
        [Display(Name="MStatusDate")]
        [Required(ErrorMessage="mReq"),DataType(DataType.Date)]         
        public DateTime? MatStDate { get; set; }

        [Display(Name="MDescr")]
        [Required(ErrorMessage="mReq"),StringLength(225)]
        public string MatDescr { get; set; }

        [Display(Name = "MDim1")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "mValDim")]
        public double? MatDim1 { get; set; }

        [Display(Name = "MDim2")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "mValDim")]
        public double? MatDim2 { get; set; }

        [Display(Name = "MDim3")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "mValDim")]
        public double? MatDim3 { get; set; }

        [Display(Name = "MWeight")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "mVaWeig")]
        public double? MatWeight { get; set; }

        [Display(Name="MUN")]
        [Required(ErrorMessage="mReq"),StringLength(25)]
        public string MatUnMed { get; set; }
    }
}
