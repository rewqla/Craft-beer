#pragma checksum "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e41f7a11af1e75d8e1cd6818727614208f2ba00e"
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
#line 2 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\_ViewImports.cshtml"
using Craft_beer_backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
using Craft_beer_backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41f7a11af1e75d8e1cd6818727614208f2ba00e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0009f7aae7e2e840bf077c3eeb4b20414a49d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FullProductViewModel>>
    {
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
            WriteLiteral("                <li class=\"item\" ><a");
            BeginWriteAttribute("href", " href=\"", 1930, "\"", 1962, 2);
            WriteAttributeValue("", 1937, "Home/ItemPreview/", 1937, 17, true);
#nullable restore
#line 68 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 1954, item.Id, 1954, 8, false);

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
            WriteLiteral("</div></a></li>\r\n");
#nullable restore
#line 69 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</div>





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
                setVolTextValue(volslider.val())");
            WriteLiteral(@"
                volslider.css(""background-color"", ""#a3610a"");
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
                if (elements[i].querySelector("".volume"").textContent == document.getElementById(");
            WriteLiteral(@"""volumesliderValue"").textContent) {
                    if (mismaches.textContent != ""1"")
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
                if (misma");
            WriteLiteral(@"ches.textContent % 3 == 0) {
                    mismaches.textContent = (mismaches.textContent / 3);
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
       ");
            WriteLiteral(@"     if (Number(min.value) < Number(max.value)) {
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
                                elements[i].classList.remove(""un");
            WriteLiteral(@"selected"");
                        }
                }
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
  ");
            WriteLiteral(@"              abvslider.css(""background-color"", ""#a3610a"");
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
 ");
            WriteLiteral(@"                       elements[i].classList.add(""unselected"");
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
