#pragma checksum "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b177434407f807117b4b729f323e42bf59f4b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\_ViewImports.cshtml"
using Craft_beer_backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
using Craft_beer_backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b177434407f807117b4b729f323e42bf59f4b97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eea05f266d792f71b60ad9ba9142c1cc89c4555", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FullProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home_index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .item {
        width: 100px;
        height: 100px;
        margin: 10px;
        float: left;
        border: solid;
    }

    .miniInp {
        width: 50px;
    }

    .slider {
        -webkit-appearance: none;
        height: 3px;
        background: #6f6f80;
        outline: none;
    }

        .slider::-webkit-slider-thumb {
            appearance: none;
            width: 11px;
            height: 11px;
            border-radius: 100%;
            background: #bfb5a6;
            cursor: pointer;
        }

    .unselected {
        display: none;
    }
</style>
");
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>
<br />
<div style=""height:400px"">
    <div style=""width: 230px; height: 100%; float: left; background-color: lightgray;"">
        <div>від<input id=""min"" value=""0"" class=""miniInp minmaxInp"" /> : до<input id=""max"" value=""9999"" class=""miniInp minmaxInp"" /></div>
        <div>
            об'єм
            <input type=""range"" min=""0"" max=""2"" step=""1"" value=""1"" class=""slider"" id=""volumeslider"">
            <span id=""volumesliderValue"">всі</span>
            <input type=""checkbox"" checked id=""volumeselectAll"">
            <label for=""volumeselectAll"">Вибрати всі</label>
        </div>
        <div>
            оберти
            <input type=""range"" min=""0"" max=""5"" step=""1"" value=""2"" class=""slider"" id=""abvslider"">
            <span id=""abvsliderValue"">всі</span>
            <input type=""checkbox"" checked id=""abvselectAll"">
            <label for=""abvselectAll"">Вибрати всі</label>
        </div>
    </div>
    <div>
      ");
            WriteLiteral("  <ul>\r\n");
#nullable restore
#line 65 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"item\"><a");
            BeginWriteAttribute("href", " href=\"", 1929, "\"", 1967, 2);
            WriteAttributeValue("", 1936, "Home/SimpleItemPreview/", 1936, 23, true);
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 1959, item.Id, 1959, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div hidden class=\"mismatches\">1</div><div class=\"volume\">");
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
                                                                                                                                          Write(item.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"price\">");
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
                                                                                                                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"abv\">");
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
                                                                                                                                                                                                                 Write(item.ABV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <button name=\"craft-beer-button\" class=\"btn btn-primary\" data-id=\"");
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2220, "\"", 2317, 11);
            WriteAttributeValue("", 2230, "addToCart(\'", 2230, 11, true);
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 2241, item.Id, 2241, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2249, "\',\'", 2249, 3, true);
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 2252, item.Name, 2252, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2262, "\',\'", 2262, 3, true);
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2265, item.Volume, 2266, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2278, "\',\'", 2278, 3, true);
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2281, item.Price, 2282, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2293, "\',\'", 2293, 3, true);
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 2296, item.ImageUrl, 2296, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2310, "\',this)", 2310, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Додати в корзину</button></li>\r\n");
#nullable restore
#line 70 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b177434407f807117b4b729f323e42bf59f4b9710253", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script>
    $(document).ready(function () {
        var min = document.getElementById(""min"");
        var max = document.getElementById(""max"");
        var volslider = $(""#volumeslider"");
        var volsliderValue = $(""#volumesliderValue"");
        var volselectAll = $(""#volumeselectAll"");
        var abvslider = $(""#abvslider"");
        var abvsliderValue = $(""#abvsliderValue"");
        var abvselectAll = $(""#abvselectAll"");
        var elements = document.querySelectorAll("".item"");
        ////////////
        // VOLUME
        ////////////
        //scripts for slider
        volselectAll.on(""change"", function () {

            if ($(this).prop(""checked"")) {
                volsliderValue.text(""Всі"");
                volslider.css(""background-color"", ""#6f6f80"");
                ViewAllItemsByVolume();
            } else {
                setVolTextValue(volslider.val())
                volslider.css(""background");
            WriteLiteral(@"-color"", ""#a3610a"");
                ViewItemsByVolume();
            }
        });

        volslider.on(""input"", function () {
            if (volselectAll.prop(""checked"")) {
                volslider.css(""background-color"", ""#a3610a"");
                volselectAll.prop(""checked"", false);
            }

            setVolTextValue(volslider.val());
            ViewItemsByVolume();
        });

        function setVolTextValue(val) {
            if (val == 0)
                volsliderValue.text(""0,33"");
            else if (val == 1)
                volsliderValue.text(""0,5"");
            else
                volsliderValue.text(""1,0"");
        }


        //scripts for viewing
        function ViewItemsByVolume() {
            for (var i = 0; i < elements.length; i++) {
                let mismaches = elements[i].querySelector("".mismatches"");
                if (elements[i].querySelector("".volume"").textContent == document.getElementById(""volumesliderValue"").textContent) {
     ");
            WriteLiteral(@"               if (mismaches.textContent != ""1"")
                        if (mismaches.textContent % 3 == 0) {
                            mismaches.textContent = (mismaches.textContent / 3);

                            if (mismaches.textContent == ""1"")
                                elements[i].classList.remove(""unselected"");
                        }
                }
                else {
                    if (mismaches.textContent == ""1"")
                        elements[i].classList.add(""unselected"");
                    if (mismaches.textContent % 3 != 0)
                        mismaches.textContent = (Number(mismaches.textContent) * 3);
                }
            }
        }

        function ViewAllItemsByVolume() {
            var elements = document.querySelectorAll("".item"");
            for (var i = 0; i < elements.length; i++) {
                let mismaches = elements[i].querySelector("".mismatches"");
                if (mismaches.textContent % 3 == 0) {
            ");
            WriteLiteral(@"        mismaches.textContent = (mismaches.textContent / 3);
                    if (mismaches.textContent == ""1"")
                        elements[i].classList.remove(""unselected"");
                }
                console.log(mismaches, 1);
            }
        }


        ////////////
        // VOLUME

        // PRICE
        ////////////


        min.addEventListener(""change"", function () {
            checkMinValid();
        });
        max.addEventListener(""change"", function () {
            checkMaxValid();
        });

        function checkMinValid() {
            if (Number(min.value) < Number(max.value)) {
                ViewItemsByPrice();
                min.style.backgroundColor = ""#ffffff"";
            }
            else {
                min.style.backgroundColor = ""#f77c88"";
                min.value = ""0"";
                ViewItemsByPrice();
            }

        }
        function checkMaxValid() {
            if (Number(min.value) < Number(max.va");
            WriteLiteral(@"lue)) {
                ViewItemsByPrice();
                max.style.backgroundColor = ""#ffffff"";
            }
            else {
                max.style.backgroundColor = ""#f77c88"";
                max.value = ""9999"";
                ViewItemsByPrice();
            }

        }


        function ViewItemsByPrice() {
            for (var i = 0; i < elements.length; i++) {
                let mismaches = elements[i].querySelector("".mismatches"");

                if (Number(elements[i].querySelector("".price"").textContent) >= Number(min.value) && Number(elements[i].querySelector("".price"").textContent) <= Number(max.value)) {
                    if (mismaches.textContent != ""1"")
                        if (mismaches.textContent % 2 == 0) {
                            mismaches.textContent = (mismaches.textContent / 2);

                            if (mismaches.textContent == ""1"")
                                elements[i].classList.remove(""unselected"");
                        }
  ");
            WriteLiteral(@"              }
                else {
                    if (mismaches.textContent == ""1"")
                        elements[i].classList.add(""unselected"");

                    if (mismaches.textContent % 2 != 0)
                        mismaches.textContent = (Number(mismaches.textContent) * 2);
                }
            }

        }


        ////////////
        // PRICE

        // ABV
        ////////////

        abvselectAll.on(""change"", function () {

            if ($(this).prop(""checked"")) {
                abvsliderValue.text(""Всі"");
                abvslider.css(""background-color"", ""#6f6f80"");
                ViewAllItemsByABV();
            } else {
                abvsliderValue.text(abvslider.val());
                abvslider.css(""background-color"", ""#a3610a"");
                ViewItemsByABV();
            }
        });

        abvslider.on(""input"", function () {
            if (abvselectAll.prop(""checked"")) {
                abvslider.css(""background-co");
            WriteLiteral(@"lor"", ""#a3610a"");
                abvselectAll.prop(""checked"", false);
            }

            abvsliderValue.text(abvslider.val());
            ViewItemsByABV();
        });

        //scripts for viewing
        function ViewItemsByABV() {
            for (var i = 0; i < elements.length; i++) {
                let mismaches = elements[i].querySelector("".mismatches"");
                if (elements[i].querySelector("".abv"").textContent == document.getElementById(""abvsliderValue"").textContent) {
                    if (mismaches.textContent != ""1"")
                        if (mismaches.textContent % 5 == 0) {
                            mismaches.textContent = (mismaches.textContent / 5);

                            if (mismaches.textContent == ""1"")
                                elements[i].classList.remove(""unselected"");
                        }
                }
                else {
                    if (mismaches.textContent == ""1"")
                        elements[i].classLi");
            WriteLiteral(@"st.add(""unselected"");
                    if (mismaches.textContent % 5 != 0)
                        mismaches.textContent = (Number(mismaches.textContent) * 5);
                }
            }
        }

        function ViewAllItemsByABV() {
            var elements = document.querySelectorAll("".item"");
            for (var i = 0; i < elements.length; i++) {
                let mismaches = elements[i].querySelector("".mismatches"");
                if (mismaches.textContent % 5 == 0) {
                    mismaches.textContent = (mismaches.textContent / 5);
                    if (mismaches.textContent == ""1"")
                        elements[i].classList.remove(""unselected"");
                }
                console.log(mismaches, 1);
            }
        }
        ////////////
        // ABV
        ////////////
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FullProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
