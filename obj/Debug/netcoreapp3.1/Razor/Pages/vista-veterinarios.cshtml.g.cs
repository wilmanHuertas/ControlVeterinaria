#pragma checksum "C:\controlVeterinaria\Pages\vista-veterinarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a7380f35ee57edb4e05bec7ee17824129e9fce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(paginaprueba1.app.Pages.Pages_vista_veterinarios), @"mvc.1.0.razor-page", @"/Pages/vista-veterinarios.cshtml")]
namespace paginaprueba1.app.Pages
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
#line 1 "C:\controlVeterinaria\Pages\_ViewImports.cshtml"
using paginaprueba1.app;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a7380f35ee57edb4e05bec7ee17824129e9fce", @"/Pages/vista-veterinarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf43d797714de7cc4d7455f247579f620c049e6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_vista_veterinarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<main>
    <div class=""text-center"">
        <br>
        <h1>MODULO VETERINARIO</h1>
        <br><br><br><br>
    </div>
    <div class=""container"">
        <table class=""table table-hover"">
            <thead class=""bg-primary"">
                <tr>
                    <th scope=""col"">DOCUMENTO</th>
                    <th scope=""col"">NOMBRE</th>
                    <th scope=""col"">No. MATRICULA</th>
                    <th scope=""col"">TELEFONO</th>
                    <th scope=""col"">EMAIL</th>
                    <th scope=""col"">OPCIONES</th>
                </tr>
            </thead>
            <tbody class=""bg-light"">
                <tr class=""active"">
                    <th scope=""row"">1035162498</th>
                    <td>Wil Amaya Porras</td>
                    <td>756423</td>
                    <td>3194461326</td>
                </tr>
                <tr>
                    <th scope=""row"">79546321</th>
                    <td>Mariana Gonzales Cabrera</td>
      ");
            WriteLiteral(@"              <td>731526</td>
                    <td>3005641235</td>
                </tr>
            </tbody>
        </table><br><br><br>
        <!-- boton que abre el formulario RegistrarVeterinario -->
        <button class=""btn btn-primary"" type=""button"" data-toggle=""modal"" data-target=""#registrarV"">REGISTRAR NUEVO VETERINARIO</button>
    </div>
    <!-- Modal -->
    <div id=""registrarV"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""registrarV-title""
        aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""registrarV-title"">REGISTRO DE VETERINARIO</h5>
                    <button class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
 ");
            WriteLiteral("                   <div class=\"center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a7380f35ee57edb4e05bec7ee17824129e9fce5313", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group row\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 2283, "\"", 2289, 0);
                EndWriteAttribute();
                WriteLiteral(">Documento</label>\r\n                                <input type=\"number\" placeholder=\"Numero de Cedula\" required>\r\n                            </div>\r\n                            <div class=\"form-group row\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 2537, "\"", 2543, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombre</label>\r\n                                <input type=\"text\" placeholder=\"Nombre Completo\" required>\r\n                            </div>\r\n                            <div class=\"form-group row\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 2785, "\"", 2791, 0);
                EndWriteAttribute();
                WriteLiteral(@">Numero de matricula Profesional</label>
                                <input type=""number"" placeholder=""Numero de Matricula"" required>
                            </div>
                            <div class=""form-group row"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 3064, "\"", 3070, 0);
                EndWriteAttribute();
                WriteLiteral(@">Telefono</label>
                                <input type=""number"" placeholder=""Numero Telefonico"" required>
                            </div>
                            <div class=""form-group row"">
                                <label for=""email"">Correo Electronico</label>
                                <input type=""email"" placeholder=""Correo Electronico"" required>
                            </div>
                            <div class=""form-group row"">
                                <label for=""password"">Contraseña</label>
                                <input type=""password"" placeholder=""contraseña"" required>
                            </div>
                            <div class=""form-group row"">
                                <label for=""password"">Confirme la Contraseña</label>
                                <input type=""password"" placeholder=""Validar Contraseña"" required>
                            </div>
                            <br>
                            <div");
                WriteLiteral(" class=\"form-group row\">\r\n                                <input type=\"button\" class=\"btn btn-primary\" value=\"Registrar\" />\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                </div>
            </div>
        </div>
    </div><br><br><br><br><br><br><br><br><br><br><br><br>
</main>
<footer>
    <!-- place footer here -->
</footer>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<paginaprueba1.app.vista_veterinariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<paginaprueba1.app.vista_veterinariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<paginaprueba1.app.vista_veterinariosModel>)PageContext?.ViewData;
        public paginaprueba1.app.vista_veterinariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
