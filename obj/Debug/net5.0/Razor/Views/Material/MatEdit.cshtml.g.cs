#pragma checksum "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a6427b7ead9ad4b6ad54ef42b5f4f5fd370ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeAsp.Models.Material.Views_Material_MatEdit), @"mvc.1.0.view", @"/Views/Material/MatEdit.cshtml")]
namespace DevExtremeAsp.Models.Material
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\_ViewImports.cshtml"
using DevExtremeAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
using DevExtremeAsp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a6427b7ead9ad4b6ad54ef42b5f4f5fd370ffa", @"/Views/Material/MatEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba13cc84d023cb50ada38a28c0d881191c9b3fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Material_MatEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMaterial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"cont-titles\">\r\n<h3>Edit Materials</h3>\r\n</div>\r\n");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
Write(Html.HiddenFor(p => p.MatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        ");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
   Write(Html.Partial("_pshowMaterials",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
Write(Html.Partial("_pmenuMat",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\DevExtremeAsp\Views\Material\MatEdit.cshtml"
            
    string isVisible(int panel){
        string retcol="";
        int opanel = (int)ViewData["panel"];
        if (opanel==panel){retcol="visible";}
        else{retcol="invisible";}
        return retcol;
    }
string assVisible(int mPanel)
{
    string retcol="invisible";
    try{
    if ((int)ViewData["Assign"]==mPanel)
    {retcol="visible";}
    }
    catch{}
    return retcol;
 }
private int VAssign(int mPanel){
    int resul = 1;
    try{
    if ((int)ViewData["Assign"]==mPanel)
    {resul=0;}
    }
    catch{}
    return resul;

}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TMaterial> Html { get; private set; }
    }
}
#pragma warning restore 1591
