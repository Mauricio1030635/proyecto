#pragma checksum "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9121a36b427655c2e68a563bef3c066adb930b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Docentes_Index), @"mvc.1.0.view", @"/Views/Docentes/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\_ViewImports.cshtml"
using educationProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\_ViewImports.cshtml"
using educationProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9121a36b427655c2e68a563bef3c066adb930b58", @"/Views/Docentes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef70eba77717bfafccd24799daa5d7c42f69df2", @"/Views/_ViewImports.cshtml")]
    public class Views_Docentes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<educationProject.Models.Docente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" text-warning icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger icon "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .icon {\r\n        font-size: 25px;\r\n        outline: none;\r\n        text-decoration: none;\r\n    }\r\n\r\n</style >\r\n\r\n    <p >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9121a36b427655c2e68a563bef3c066adb930b586197", async() => {
                WriteLiteral(" <i class=\"fas fa-plus-circle\" > </i > Agregar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p >\r\n");
#nullable restore
#line 19 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
     if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"alert alert-danger\" role=\"alert\" >\r\n    <h4 class=\"alert-heading\" > No hay informacion en la base de datos</h4 >\r\n    <hr >\r\n    <p class=\"mb-0\" > Valide la informaci??n</p >\r\n    </div >\r\n");
#nullable restore
#line 26 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"

}
else { 


#line default
#line hidden
#nullable disable
            WriteLiteral(" <table class=\"table\">\r\n    <thead   class=\"table table-primary\">\r\n    <tr >\r\n    <th >\r\n    ");
#nullable restore
#line 34 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.CedulaDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th >\r\n    ");
#nullable restore
#line 37 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.NombreDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th >\r\n    ");
#nullable restore
#line 40 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.ApellidoDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th >\r\n    ");
#nullable restore
#line 43 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.TelefonoDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th >\r\n    ");
#nullable restore
#line 46 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.DireccionDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th >\r\n    ");
#nullable restore
#line 49 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayNameFor(model => model.NivelEducativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th >\r\n    <th > Acciones</th >\r\n    </tr >\r\n    </thead >\r\n    <tbody  class=\"table-active\">\r\n");
#nullable restore
#line 55 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr >\r\n    <td >\r\n    ");
#nullable restore
#line 59 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.CedulaDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td >\r\n    ");
#nullable restore
#line 62 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.NombreDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td >\r\n    ");
#nullable restore
#line 65 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.ApellidoDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td >\r\n    ");
#nullable restore
#line 68 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.TelefonoDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td >\r\n    ");
#nullable restore
#line 71 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.DireccionDocente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td >\r\n    ");
#nullable restore
#line 74 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.NivelEducativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td >\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9121a36b427655c2e68a563bef3c066adb930b5812244", async() => {
                WriteLiteral(" <i class=\"far fa-edit\"> </i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
                               WriteLiteral(item.IdDocente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        &nbsp;\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9121a36b427655c2e68a563bef3c066adb930b5814541", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-clipboard-list\"> </i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
                                                         WriteLiteral(item.IdDocente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        &nbsp;\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9121a36b427655c2e68a563bef3c066adb930b5816900", async() => {
                WriteLiteral(" <i class=\"fas fa-trash\"> </i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
                                                           WriteLiteral(item.IdDocente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n    </tr >\r\n");
#nullable restore
#line 86 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody >\r\n    </table >\r\n");
#nullable restore
#line 89 "C:\Users\Mauricio\source\repos\educationProject\educationProject\Views\Docentes\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<educationProject.Models.Docente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
