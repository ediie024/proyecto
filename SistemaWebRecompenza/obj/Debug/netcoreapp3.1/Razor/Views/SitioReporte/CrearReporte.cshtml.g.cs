#pragma checksum "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c436e262ca0f6367a5f00711bb6b87258e800985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SitioReporte_CrearReporte), @"mvc.1.0.view", @"/Views/SitioReporte/CrearReporte.cshtml")]
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
#line 1 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\_ViewImports.cshtml"
using SistemaWebRecompenza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\_ViewImports.cshtml"
using SistemaWebRecompenza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c436e262ca0f6367a5f00711bb6b87258e800985", @"/Views/SitioReporte/CrearReporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95162269e948e14ed32d8bb696d464108d6d3669", @"/Views/_ViewImports.cshtml")]
    public class Views_SitioReporte_CrearReporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SitioReporte/CrearReporteA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml"
  
    ViewData["Title"] = "Crear";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c436e262ca0f6367a5f00711bb6b87258e8009855406", async() => {
                WriteLiteral("\r\n    <title>Lista de Reportes</title>\r\n    <style>\r\n        \r\n        .lean-overlay {\r\n          z-index: 99!important;\r\n        }\r\n        \r\n        #modal1 {\r\n              z-index: 100!important;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c436e262ca0f6367a5f00711bb6b87258e8009856618", async() => {
                WriteLiteral("\r\n<h1>Crear Reporte</h1>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c436e262ca0f6367a5f00711bb6b87258e8009856902", async() => {
                    WriteLiteral("\r\n    <label>Nombre</label>\r\n    <input name=\"Nombre\"");
                    BeginWriteAttribute("required", " required=\"", 462, "\"", 473, 0);
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n    <label>Fecha de la perdida</label>\r\n    <input name=\"Fecha\"");
                    BeginWriteAttribute("required", " required=\"", 541, "\"", 552, 0);
                    EndWriteAttribute();
                    WriteLiteral(" type=\"date\"/>\r\n    \r\n\r\n    <!-- Modal Structure -->\r\n\r\n    <label>Tipo</label>\r\n    <select name=\"Tipo\">\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c436e262ca0f6367a5f00711bb6b87258e8009857769", async() => {
                        WriteLiteral("--Elija la categoria--");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml"
         foreach (var item in ViewBag.tipo)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c436e262ca0f6367a5f00711bb6b87258e8009859254", async() => {
                        WriteLiteral(" ");
#nullable restore
#line 34 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml"
                                 Write(item.Nombre);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml"
               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\Upn 2020-2\Calidad\gitgub\BitBucket\SistemaWebRecompenza\SistemaWebRecompenza\Views\SitioReporte\CrearReporte.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("    </select>\r\n\r\n    <label>Descripcion</label>\r\n    <textarea name=\"Descripcion\"></textarea>\r\n    \r\n    <label>Nombre del objeto</label>\r\n    <input name=\"NombreObjeto\"");
                    BeginWriteAttribute("required", " required=\"", 1014, "\"", 1025, 0);
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n    <label>Recompenza</label>\r\n    <input name=\"Recompenza\"");
                    BeginWriteAttribute("required", " required=\"", 1089, "\"", 1100, 0);
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n    <div class=\"form-group\">\r\n        Imagen\r\n        <input type=\"file\" name=\"Imagen\"/>\r\n\r\n    </div>\r\n\r\n    <button>Guardar</button>\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<input type=""text"" id=""event-address-val"" style=""width: 300px"" />
    
    
    <a class=""waves-effect waves-light btn modal-trigger"" href=""#modal1"">Ubicacion</a>
<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Modal Header</h4>

        <input type=""text"" id=""event-address"" style=""width: 300px""/>

        <div id=""location-picker-map"" style=""width: 500px; height: 400px;""></div>

        <input class=""hide"" type=""text"" id=""event-lat""/><input class=""hide"" type=""text"" id=""event-lon""/>


    </div>
    <div class=""modal-footer"">
        <a href=""#!"" class="" modal-action modal-close waves-effect waves-green btn-flat"">Agree</a>
    </div>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>



$('.modal-trigger').leanModal({
  ready: function() {
    $('#location-picker-map').locationpicker('autosize');
  }
});



$('#location-picker-map').locationpicker({
enableAutocomplete: true,
    enableReverseGeocode: true,
  radius: 0,
  inputBinding: {
    latitudeInput: $('#event-lat'),
    longitudeInput: $('#event-lon'),
    locationNameInput: $('#event-address')
  },
  onchanged: function (currentLocation, radius, isMarkerDropped) {
        var addressComponents = $(this).locationpicker('map').location.addressComponents;
    console.log($(this).locationpicker('map').location);  //latlon  
    updateControls(addressComponents); //Data
    }
});

function updateControls(addressComponents) {
  $('#event-address-val').val(addressComponents.formattedAddress);
  console.log(addressComponents);
}
</script>
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
