#pragma checksum "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ce947231ec4242f213c3b5156ed5fac5e1d6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscripciones_Index), @"mvc.1.0.view", @"/Views/Inscripciones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce947231ec4242f213c3b5156ed5fac5e1d6dc", @"/Views/Inscripciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe54ac49df1510c33500d69770a4689184b405c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscripciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginacion<Modelos_Crud_Proyecto.Models.Inscripcion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
  
    ViewData["Title"] = "Inscripciones";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Inscripciones</h1>\r\n<div id=\"mostarModalAqui\"></div>\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal\" data-target=\"#nuevaInscripcion\" data-url=\"");
#nullable restore
#line 10 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                                                Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Nueva Inscripcion</button>\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc5347", async() => {
                WriteLiteral("\r\n    <p>\r\n        Filtro : <input type=\"text\" name=\"buscarTexto\"");
                BeginWriteAttribute("value", " value=\"", 455, "\"", 482, 1);
#nullable restore
#line 14 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
WriteAttributeValue("", 463, ViewData["Filtro"], 463, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Buscar\" class=\"btn btn-default\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc6179", async() => {
                    WriteLiteral("Todos los Registros ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" | Registros mostrados : ");
#nullable restore
#line 16 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                          Write(Model.TotalR);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc9238", async() => {
                WriteLiteral("Grado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                             WriteLiteral(ViewData["GradoInscripcion"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                               WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Fecha\r\n            </th>\r\n            <th>\r\n                Pago\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc12460", async() => {
                WriteLiteral("Curso");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                             WriteLiteral(ViewData["CursoNombre"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                          WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc15542", async() => {
                WriteLiteral("Estudiante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                             WriteLiteral(ViewData["EstudianteInscrito"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                                 WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.curso.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.estudiante.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-success\" data-toggle=\"ajax-modal\" data-target=\"#editarInscripcion\" data-url=\"");
#nullable restore
#line 60 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                                                                 Write(Url.Action($"Edit/{item.InscripcionID}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Editar</button> |\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-toggle=\"ajax-modal\" data-target=\"#VerInscripcion\" data-url=\"");
#nullable restore
#line 61 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                                                                Write(Url.Action($"Details/{item.InscripcionID}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Detalles</button> |\r\n                    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-target=\"#QuitarInscripcion\" data-url=\"");
#nullable restore
#line 62 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
                                                                                                                                Write(Url.Action($"Delete/{item.InscripcionID}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Eliminar</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 68 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
  
    var prevDesabilitado = !Model.PreviaPag ? "disabled" : "";
    var nextDesabilitado = !Model.SiguientePag ? "disabled" : "";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc23153", async() => {
                WriteLiteral("\r\n    Anterior\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
          WriteLiteral(ViewData["ordenarFiltro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
       WriteLiteral(Model.Indice -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
          WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3059, "btn", 3059, 3, true);
            AddHtmlAttributeValue(" ", 3062, "btn-default", 3063, 12, true);
#nullable restore
#line 76 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
AddHtmlAttributeValue(" ", 3074, prevDesabilitado, 3075, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
 for (int i = 1; i <= Model.TotalP; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc27700", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 86 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
              WriteLiteral(ViewData["ordenarFiltro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
          WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
              WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ce947231ec4242f213c3b5156ed5fac5e1d6dc31847", async() => {
                WriteLiteral("\r\n    Siguiente\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ordenar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
          WriteLiteral(ViewData["ordenarFiltro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ordenar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ordenar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
       WriteLiteral(Model.Indice +1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
          WriteLiteral(ViewData["Filtro"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtrar", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtrar"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3543, "btn", 3543, 3, true);
            AddHtmlAttributeValue(" ", 3546, "btn-default", 3547, 12, true);
#nullable restore
#line 93 "F:\C# ejercicicios y paginas web\Modelos-Crud-Proyecto\Modelos-Crud-Proyecto\Views\Inscripciones\Index.cshtml"
AddHtmlAttributeValue(" ", 3558, nextDesabilitado, 3559, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginacion<Modelos_Crud_Proyecto.Models.Inscripcion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
