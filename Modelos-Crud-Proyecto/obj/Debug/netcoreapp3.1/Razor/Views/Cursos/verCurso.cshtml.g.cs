#pragma checksum "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70339afca8dbf4731dcd17557b58973fa3cc72ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_verCurso), @"mvc.1.0.view", @"/Views/Cursos/verCurso.cshtml")]
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
#line 1 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\_ViewImports.cshtml"
using Modelos_Crud_Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\_ViewImports.cshtml"
using Modelos_Crud_Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70339afca8dbf4731dcd17557b58973fa3cc72ef", @"/Views/Cursos/verCurso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe54ac49df1510c33500d69770a4689184b405c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_verCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Curso>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" id=""VerCurso"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Curso</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card-body"">
                    <p><strong>");
#nullable restore
#line 13 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>&nbsp; &nbsp; ");
#nullable restore
#line 13 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                             Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 14 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>&nbsp; &nbsp;");
#nullable restore
#line 14 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 15 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Creditos));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>&nbsp; &nbsp;");
#nullable restore
#line 15 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                              Write(Html.DisplayFor(model => model.Creditos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 16 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Horas));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>&nbsp; &nbsp;");
#nullable restore
#line 16 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                           Write(Html.DisplayFor(model => model.Horas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 17 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>&nbsp; &nbsp;$");
#nullable restore
#line 17 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                            Write(Html.DisplayFor(model => model.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 18 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> &nbsp; &nbsp; ");
#nullable restore
#line 18 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                              Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>");
#nullable restore
#line 19 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                          Write(Html.DisplayNameFor(model => model.categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> &nbsp; &nbsp;");
#nullable restore
#line 19 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Cursos\verCurso.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591
