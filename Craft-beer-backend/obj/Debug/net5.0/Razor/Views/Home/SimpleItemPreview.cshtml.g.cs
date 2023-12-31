#pragma checksum "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5e23c814a42114032a99f1dad26ed735f4ab8a725410c57361a9c77b9b40ed65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SimpleItemPreview), @"mvc.1.0.view", @"/Views/Home/SimpleItemPreview.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\_ViewImports.cshtml"
using Craft_beer_backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\_ViewImports.cshtml"
using Craft_beer_backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5e23c814a42114032a99f1dad26ed735f4ab8a725410c57361a9c77b9b40ed65", @"/Views/Home/SimpleItemPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d7850ace5ca79a45bb8c9731595570ab1369244676ec33652fe9aa14f24d8026", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SimpleItemPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Craft_beer_backend.ViewModels.FullProductViewModel>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e23c814a42114032a99f1dad26ed735f4ab8a725410c57361a9c77b9b40ed653314", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" />\r\n    <title>My site</title>\r\n");
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
            WriteLiteral(@"
<style>
    /* ///MAIN/// */

    .greating_line {
        display: grid;
        grid-template-columns: 1fr 1fr;
    }

    .item_image {
        height: auto;
        width: 100%;
        background-color: #E6E6E6;
        margin: 20px;
        border-radius: 5px;
        margin-right: 0px;
    }

        .item_image img {
            width: 90%;
            padding: 5%;
        }

    .item_sInfo {
        white-space: nowrap;
        min-width: 100px;
        padding: 45px 0 20px 60px;
    }

    .item_name {
        width: 120%;
        white-space: normal;
    }

    .title {
        padding: 10px;
        font-size: 49px;
        text-align: inherit;
    }

    .deskription {
        font-size: 40px;
    }


    .stars {
        padding: 40px 10px;
        font-size: 38px;
        float: left;
        margin-right: 100px;
        margin-top: 50px;
        margin-left: -207px;
    }

    .icon_info {
        width: 100%;
        display: grid;
  ");
            WriteLiteral(@"      grid-template-columns: 1fr 1fr;
    }

    .price {
        font-size: 41px;
    }




    .isAvailable {
        margin-top: 53px;
        font-size: 20px;
        padding: 3px;
        width: 150px;
        text-align: center;
        background-color: #F5EBD7;
        color: #8F7A08;
        height: 25px;
    }

    .wrapper {
        width: 80%;
        margin-left: 10%;
    }

    .pay_info {
        padding-top: 20px;
        white-space: normal;
        font-size: 16px;
        width: 90%;
    }

    .item_fInfo {
        width: 80%;
        padding: 15px 5%;
        font-size: 30px;
    }

    /* ///MAIN/// */

    /* ///FULL INFO/// */
    .full_Info {
        padding-left: 15%;
        width: 70%;
    }

        .full_Info img {
            width: 100%;
        }

    .fInfo_line {
        width: 100%;
        font-size: 19px;
        font-weight: bolder;
        height: 30px;
        opacity: 0.4;
        color: black;
        display:");
            WriteLiteral(@" grid;
        padding: 10px;
        grid-template-columns: 1.2fr 0.8fr;
    }

    .gray_line {
        background-color: lightgray;
    }

    /* ///FULL INFO/// */

    /* ///RATING/// */
    .rate_background {
        position: relative;
        color: #797;
        letter-spacing: 5px;
    }

    .rate_bar {
        position: absolute;
        top: 0px;
        left: 0px;
        color: gold;
    }
    /* ///RATING/// */

    /* ///CHECKBOX/// */

    .checkbox {
        display: block;
        cursor: pointer;
        position: relative;
    }

    .checkbox_input_heart {
        position: absolute;
        -webkit-appearance: none;
    }

        .checkbox_input_heart:checked + .check_box_heart {
            background-image: url(""data:image/svg+xml,%3Csvg version='1.0' xmlns='http://www.w3.org/2000/svg' width='16.000000pt' height='16.000000pt' viewBox='0 0 16.000000 16.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,16.000000) s");
            WriteLiteral(@"cale(0.100000,-0.100000)'%0Afill='%23000000' stroke='none'%3E%3Cpath d='M12 138 c-22 -22 -12 -54 28 -93 l40 -39 40 39 c29 29 40 47 38 64%0A-4 34 -32 49 -59 33 -15 -10 -24 -11 -32 -3 -14 14 -40 14 -55 -1z'/%3E%3C/g%3E%3C/svg%3E%0A"");
        }

    .check_box_heart {
        position: absolute;
        left: 110px;
        top: 17px;
        width: 21px;
        height: 21px;
        background-image: url(""data:image/svg+xml,%3Csvg version='1.0' xmlns='http://www.w3.org/2000/svg' width='16.000000pt' height='16.000000pt' viewBox='0 0 16.000000 16.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,16.000000) scale(0.100000,-0.100000)'%0Afill='%23000000' stroke='none'%3E%3Cpath d='M12 138 c-22 -22 -12 -54 28 -93 l40 -39 40 39 c29 29 40 47 38 64%0A-4 34 -32 49 -59 33 -15 -10 -24 -11 -32 -3 -14 14 -40 14 -55 -1z m50 -15%0Ac17 -15 19 -15 39 3 20 18 21 18 35 0 15 -22 8 -39 -31 -76 l-27 -25 -34 38%0Ac-29 31 -33 41 -24 57 13 24 18 25 42 3z'/%3E%3C/g%3E%3C/svg%3E%0A"");
    }

  ");
            WriteLiteral(@"  .checkbox_input_cart:checked + .check_box_cart {
        background-image: url(""data:image/svg+xml,%3Csvg version='1.0' xmlns='http://www.w3.org/2000/svg' width='26.000000pt' height='26.000000pt' viewBox='0 0 26.000000 26.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,26.000000) scale(0.100000,-0.100000)'%0Afill='%23000000' stroke='none'%3E%3Cpath d='M0 249 c0 -6 8 -13 18 -16 13 -3 25 -25 38 -66 l19 -62 55 0 55 0 22%0A45 c29 58 28 70 -2 70 -14 0 -25 -4 -25 -10 0 -5 6 -10 14 -10 13 0 13 -4 0%0A-27 -7 -16 -14 -34 -14 -40 0 -9 -16 -13 -44 -13 l-44 0 -21 70 c-19 62 -24%0A70 -46 70 -14 0 -25 -5 -25 -11z'/%3E%3Cpath d='M140 225 c-18 -19 -26 -22 -37 -13 -22 18 -28 0 -8 -22 19 -20 19%0A-20 52 12 18 17 33 36 33 40 0 15 -16 8 -40 -17z'/%3E%3Cpath d='M60 55 c0 -8 7 -15 15 -15 8 0 15 7 15 15 0 8 -7 15 -15 15 -8 0 -15%0A-7 -15 -15z'/%3E%3Cpath d='M170 55 c0 -8 7 -15 15 -15 8 0 15 7 15 15 0 8 -7 15 -15 15 -8 0%0A-15 -7 -15 -15z'/%3E%3C/g%3E%3C/svg%3E"");
    }

    .checkbox_input_car");
            WriteLiteral(@"t {
        position: absolute;
        -webkit-appearance: none;
    }

    .check_box_cart {
        position: absolute;
        left: 49px;
        top: 15px;
        width: 35px;
        height: 35px;
        background-image: url(""data:image/svg+xml,%3Csvg version='1.0' xmlns='http://www.w3.org/2000/svg' width='26.000000pt' height='26.000000pt' viewBox='0 0 26.000000 26.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,26.000000) scale(0.100000,-0.100000)'%0Afill='%23000000' stroke='none'%3E%3Cpath d='M0 249 c0 -6 8 -13 18 -16 13 -3 25 -25 38 -66 l19 -62 55 0 55 0 22%0A45 c29 58 28 70 -2 70 -14 0 -25 -4 -25 -10 0 -5 6 -10 14 -10 13 0 13 -4 0%0A-27 -7 -16 -14 -34 -14 -40 0 -9 -16 -13 -44 -13 l-44 0 -21 70 c-19 62 -24%0A70 -46 70 -14 0 -25 -5 -25 -11z'/%3E%3Cpath d='M110 235 c0 -8 -7 -15 -15 -15 -8 0 -15 -4 -15 -10 0 -5 7 -10 15%0A-10 8 0 15 -7 15 -15 0 -8 5 -15 10 -15 6 0 10 7 10 15 0 8 7 15 15 15 8 0 15%0A5 15 10 0 6 -7 10 -15 10 -8 0 -15 7 -15 15 0 8 -4 15 -10 1");
            WriteLiteral(@"5 -5 0 -10 -7 -10%0A-15z'/%3E%3Cpath d='M60 55 c0 -8 7 -15 15 -15 8 0 15 7 15 15 0 8 -7 15 -15 15 -8 0 -15%0A-7 -15 -15z'/%3E%3Cpath d='M170 55 c0 -8 7 -15 15 -15 8 0 15 7 15 15 0 8 -7 15 -15 15 -8 0%0A-15 -7 -15 -15z'/%3E%3C/g%3E%3C/svg%3E"");
    }
    /* ///CHECKBOX/// */
</style>

<div class=""wrapper"">
    <div class=""greating_line"">
        <div class=""item_image"">
            <img");
            BeginWriteAttribute("src", " src=\"", 6672, "\"", 6693, 1);
#nullable restore
#line 195 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue("", 6678, Model.ImageUrl, 6678, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6694, "\"", 6700, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"item_sInfo\">\r\n            <div class=\"title item_name\">");
#nullable restore
#line 198 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"title deskription\"></div>\r\n\r\n            <div class=\"icon_info\">\r\n                <div class=\"price\">Ціна: ");
#nullable restore
#line 202 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
                                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" грн</div>\r\n                <div class=\"stars\">\r\n                    <div class=\"rate_background\">\r\n                        ★★★★★\r\n");
#nullable restore
#line 206 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
                          
                            var ratingStr = "";
                            for (int i = 0; i < (int)Model.Rating; i++)
                                ratingStr += "★";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"rate_bar\">");
#nullable restore
#line 211 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
                                         Write(ratingStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("style", " style=\"", 7454, "\"", 7462, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"item-icons col justify-content-center\">\r\n                        <button id=\"addToCartBtn\" name=\"craft-beer-button\" class=\"fa fa-solid fa-basket-shopping\" data-id=\"");
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
                                                                                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"color: #0f0f0f;height: 50px;width: 207px;font-size: 20px;margin-bottom: 10px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7758, "\"", 7860, 11);
            WriteAttributeValue("", 7768, "addToCart(\'", 7768, 11, true);
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue("", 7779, Model.Id, 7779, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7788, "\',\'", 7788, 3, true);
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue("", 7791, Model.Name, 7791, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7802, "\',\'", 7802, 3, true);
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue(" ", 7805, Model.Volume, 7806, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7819, "\',\'", 7819, 3, true);
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue(" ", 7822, Model.Price, 7823, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7835, "\',\'", 7835, 3, true);
#nullable restore
#line 217 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
WriteAttributeValue("", 7838, Model.ImageUrl, 7838, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7853, "\',this)", 7853, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Додати до корзини</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"pay_info\">\r\n                <h3>Опис</h3>\r\n                ");
#nullable restore
#line 223 "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\SimpleItemPreview.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>
    let shoppingCart = JSON.parse(localStorage.getItem('shopping-cart')) || [];

    function updateButtonState(button) {
        button.textContent = 'В корзині';
        button.disabled = true;
    }

    let button = document.getElementById(""addToCartBtn"");

    if (shoppingCart.some(item => item.Id === button.dataset.id)) {
        updateButtonState(button);
    }

    function addToCart(Id, Name, Volume, Price, Image, Button) {

        const newItem = { Id, Name, Volume, Price, Image };

        shoppingCart.push(newItem);

        localStorage.setItem('shopping-cart', JSON.stringify(shoppingCart));

        updateButtonState(Button);
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Craft_beer_backend.ViewModels.FullProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
