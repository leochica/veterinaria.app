#pragma checksum "C:\Users\chica\Documents\#MISION TIC 2022 - PROGRAMACION\CICLO 3\Desarrollo de Software G-85\Veterinaria\ProyectoMinTicCiclo3G26\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3625db1633e4e1ac57caaef5d2d707e498a3459b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Admin.Pages_Admin_AdminMascotas), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminMascotas.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Admin
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
#line 1 "C:\Users\chica\Documents\#MISION TIC 2022 - PROGRAMACION\CICLO 3\Desarrollo de Software G-85\Veterinaria\ProyectoMinTicCiclo3G26\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3625db1633e4e1ac57caaef5d2d707e498a3459b", @"/Pages/Admin/AdminMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_AdminMascotas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Macho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Hembra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"margin: 2% 2%; color:rgb(56, 100, 242); width: 96%\" class=\"container mascotaregistro\">\r\n    <h3 style=\"text-align: center; padding:10px; \">Gestión de Mascotas</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3625db1633e4e1ac57caaef5d2d707e498a3459b4636", async() => {
                WriteLiteral(@"
        <table>
            <tr>
                <td style=""padding: 10px;"">Nombre</td>
                <td style=""padding: 10px;""><input class=""form-control"" id=""cedula"" type=""text"" required></td>
            </tr>
            <tr>
                <td style=""padding: 10px;"">Especie</td>
                <td style=""padding: 10px;""><input class=""form-control"" id=""especie"" type=""text""></td>
            </tr>
            <tr>
                <td style=""padding: 10px;"">Raza</td>
                <td style=""padding: 10px;""><input class=""form-control"" id=""raza"" type=""text""></td>
            </tr>
            <tr>
                <td style=""padding: 10px;"">Peso</td>
                <td style=""padding: 10px;""><input class=""form-control"" id=""peso"" type=""number""></td>
            </tr>
            <tr>
                <td style=""padding: 10px;"">Edad</td>
                <td style=""padding: 10px;""><input class=""form-control"" id=""edad"" type=""number""></td>
            </tr>
            <tr>
         ");
                WriteLiteral("       <td style=\"padding: 10px;\">Sexo</td>\r\n                <td style=\"padding: 10px;\"><select name=\"sexo\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3625db1633e4e1ac57caaef5d2d707e498a3459b6144", async() => {
                    WriteLiteral("Macho");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3625db1633e4e1ac57caaef5d2d707e498a3459b7390", async() => {
                    WriteLiteral("Hembra");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select></td>
            </tr>
            <tr>
                <td style=""padding: 10px"">Identificación Cuidador</td>
                <td style=""padding: 10px""><input class=""form-control"" id=""cuidador"" type=""number""></td>
                <td style=""padding: 10px"">
                    <button class=""btn btn-info"" type=""submit""><span class=""glyphicon glyphicon-search"">
                            Buscar </span></button>
                    <button class=""btn btn-success"" type=""submit""><span class=""glyphicon glyphicon-remove"">
                            Crear </span></button>
                </td>
            </tr>
            <tr>
                <td style=""padding: 10px;"">
                    <button class=""btn btn-success"" type=""submit""><span class=""glyphicon glyphicon-save"">
                            Guardar </span></button>
                    <button class=""btn btn-primary"" type=""submit""><span class=""glyphicon glyphicon-remove"">
                            Borra");
                WriteLiteral("r </span></button>\r\n                    <a class=\"btn btn-danger\" href=\"#\"><span class=\"glyphicon glyphicon-backward\">Regresar</span> </a>\r\n                </td>\r\n            </tr>\r\n\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br><br>
    <table id=""tabla_mascotas"" class=""table table-bordered"">
        <thead style=""background-color:rgb(56, 100, 242); color:white; text-align: center"">
            <tr>
                <th>Nombre</th>
                <th>Especie</th>
                <th>Raza</th>
                <th>Sexo</th>
                <th>Cuidador</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Pelusa</td>
                <td>Perro</td>
                <td>Labrador</td>
                <td>Hembra</td>
                <td>Maria</td>
                <td style=""text-align:center"">
                    <button class=""btn btn-secondary"" type=""submit"" id=""detalle"">Detalles</button>
                    <button class=""btn btn-primary"" type=""submit"" id=""actualizar"">Actualizar</button>
                    <button class=""btn btn-danger"" type=""submit"" id=""Eliminar"">Eliminar</button>
                </td>
            </tr>
        ");
            WriteLiteral(@"    <tr>
                <td>Minino</td>
                <td>Gato</td>
                <td>Persa</td>
                <td>Macho</td>
                <td>Carlos</td>
                <td style=""text-align:center"">
                    <button class=""btn btn-secondary"" type=""submit"" id=""detalle"">Detalles</button>
                    <button class=""btn btn-primary"" type=""submit"" id=""actualizar"">Actualizar</button>
                    <button class=""btn btn-danger"" type=""submit"" id=""Eliminar"">Eliminar</button>
                </td>
            </tr>

        </tbody>
    </table>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#tabla_mascotas\').DataTable();\r\n        });\r\n    </script>\r\n    ");
            }
            );
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.AdminMascotasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminMascotasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminMascotasModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.AdminMascotasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
