#pragma checksum "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6546f40a7d1aeb5278b5737c145b959677794fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_OrderDetails), @"mvc.1.0.view", @"/Views/Administration/OrderDetails.cshtml")]
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
using Craft_beer_backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6546f40a7d1aeb5278b5737c145b959677794fed", @"/Views/Administration/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eea05f266d792f71b60ad9ba9142c1cc89c4555", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""card mb-4"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h5 class=""card-title"">Деталі замовлення</h5>
                    <p><strong>Унікальний код:</strong> ");
#nullable restore
#line 9 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                                   Write(Model.UniqueCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>Статус:</strong> ");
#nullable restore
#line 10 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                           Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>Дата:</strong> ");
#nullable restore
#line 11 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                         Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <p><strong>Загальна вартість:</strong> <span id=""total-price""></span></p>
                </div>
                <div class=""col-md-6"">
                    <h5 class=""card-title"">Інформація про клієнта</h5>
                    <p><strong>Ім'я:</strong> ");
#nullable restore
#line 16 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                         Write(Model.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                                                   Write(Model.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><strong>Телефон:</strong> ");
#nullable restore
#line 17 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                            Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card mt-4\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Інформація про доставку</h5>\r\n            <p><strong>Місто:</strong> ");
#nullable restore
#line 26 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                  Write(Model.Delivery.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Адреса:</strong> ");
#nullable restore
#line 27 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                   Write(Model.Delivery.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Компанія:</strong> ");
#nullable restore
#line 28 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                     Write(Model.Delivery.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 32 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
     if (Model.Statuses.Count() > 1 && Model.Status != "Скасоване" && Model.Status != "Відхилене")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mt-4\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Статус</h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6546f40a7d1aeb5278b5737c145b959677794fed9479", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6546f40a7d1aeb5278b5737c145b959677794fed9757", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                         foreach (var item in Model.Statuses)
                        {
                            if (Model.Status == item)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6546f40a7d1aeb5278b5737c145b959677794fed10452", async() => {
                        WriteLiteral("\r\n                                    ");
#nullable restore
#line 44 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
                        WriteLiteral("\r\n                                ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6546f40a7d1aeb5278b5737c145b959677794fed12543", async() => {
                        WriteLiteral("\r\n                                    ");
#nullable restore
#line 50 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
                        WriteLiteral("\r\n                                ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6546f40a7d1aeb5278b5737c145b959677794fed15647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 55 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UniqueCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                                        WriteLiteral(Model.UniqueCode);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary mt-2\">Змінити статус</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card mt-4"">
        <div class=""card-body"">
            <h5 class=""card-title"">Товари у замовленні</h5>
            <table class=""table table-bordered table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Найменування</th>
                        <th>Об'єм</th>
                        <th>Кількість</th>
                        <th>Ціна</th>
                        <th>Зображення</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 77 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 80 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 81 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                           Write(item.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"item-count\">");
#nullable restore
#line 82 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                              Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"item-price\">");
#nullable restore
#line 83 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 3523, "\"", 3540, 1);
#nullable restore
#line 84 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
WriteAttributeValue("", 3529, item.Image, 3529, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Зображення пива\" width=\"100\" height=\"100\"></td>\r\n                        </tr>\r\n");
#nullable restore
#line 86 "D:\vodnik\3 курс\Менеджмент\Craft-beer\Craft-beer-backend\Views\Administration\OrderDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>


</div>

<script>
    function calculateTotalPrice() {
        var total = 0;
        var priceElements = document.querySelectorAll('.item-price');
        var countElements = document.querySelectorAll('.item-count');
        console.log(priceElements)
        console.log(countElements)

        for (var i = 0; i < priceElements.length; i++) {
            var price = parseFloat(priceElements[i].textContent);
            var count = parseInt(countElements[i].textContent);
            total += price * count;
        }
        console.log(total)
        document.getElementById('total-price').textContent = total.toFixed(2);
    }

    calculateTotalPrice();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
