#pragma checksum "E:\yura\projects\Craft-beer\Craft-beer-backend\Views\Home\AboutUs.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5223ae68381c9de7cb67a39841b49b7c106dbe4b1f55b76da2234cbee6082744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5223ae68381c9de7cb67a39841b49b7c106dbe4b1f55b76da2234cbee6082744", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d7850ace5ca79a45bb8c9731595570ab1369244676ec33652fe9aa14f24d8026", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5223ae68381c9de7cb67a39841b49b7c106dbe4b1f55b76da2234cbee60827443361", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""../css/main.css"">
    <script src=""https://kit.fontawesome.com/b98ba76176.js"" crossorigin=""anonymous""></script>
    <title>Main Page</title>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5223ae68381c9de7cb67a39841b49b7c106dbe4b1f55b76da2234cbee60827444645", async() => {
                WriteLiteral(@"
    <ul class=""main-menu"">
        <li><a class=""main-menu-link"" href=""./index.html"">Про нас</a></li>
        <li><a class=""main-menu-link"" href=""#"">Контакти</a></li>
        <li><a class=""main-menu-link"" href=""./catalog.html"">Каталог</a></li>
    </ul>
    <div class=""head-container"">
        <p class=""head-text"">Приєднуйтесь до SipSociety<br> та отримуйте найкраще!</p>
        <img class=""head-img"" src=""../img/шапка.png""");
                BeginWriteAttribute("alt", " alt=\"", 739, "\"", 745, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"about-div\">\r\n        <h2 class=\"about-h2\">AboutUs</h2>\r\n    </div>\r\n    <div class=\"aboutUs\">\r\n        <div class=\"about-container\">\r\n            <img class=\"about-img\" src=\"../img/about us.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 971, "\"", 977, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <p class=""about-p"">
                SipSociety - це місце, де справжні поціновувачі <br> пива можуть знайти свій ідеальний смак.<br> Наш інтернет-магазин пропонує широкий<br> вибір різних сортів крафтового пива, щоб<br> кожен міг знайти щось особливе і<br> неповторне для себе.
                <br><br>
                Наш інтернет-магазин пива - це зручний і<br> надійний спосіб замовити ваші улюблені сорти<br> пива прямо до дому.
                <br><br>
                Ми горді тим, що пропонуємо вам вищу якість<br> пива від найкращих виробників.<br> Кожна пляшка або банка - це справжній<br> шедевр в світі пивоваріння. <br>
                <a class=""katal-button"" href=""#"">Перейти до каталогу</a>
            </p>
        </div>
    </div>
    <h2 class=""advantages-h2"">Переваги</h2>
    <div class=""div-icon"">
        <div class=""icon-container"">
            <img src=""../img/basket.png"" class=""icon-1"">
            <p class=""all-icon-text icon1-text"">Широкий асортимент</p>
        </");
                WriteLiteral(@"div>
        <div class=""icon-container"">
            <img src=""../img/якість.png"" class=""icon-2"">
            <p class=""all-icon-text icon2-text"">Відмінна якість</p>
        </div>
        <div class=""icon-container"">
            <img src=""../img/piggi_bank.png"" class=""icon-3"">
            <p class=""all-icon-text icon3-text"">Доступні ціни</p>
        </div>
        <div class=""icon-container"">
            <img src=""../img/delivery.png"" class=""icon-4"">
            <p class=""all-icon-text icon4-text"">Швидка доставка</p>
        </div>
    </div>
    <h2 class=""advantages-h2"">
        <br>
        <br>
        Замовляй своє улюблене пиво просто зараз, та отримуй<br> можливість насолоджуватися найкращими смаками світу<br> пива!
        <br>
        <br>
    </h2>
    <footer>
        <p class=""footer-text""><b>© 2023 SipSocieti All rights reserved.</b></p>
        <p class=""footer-icons"">
            <i class=""fa-brands fa-twitter""></i>
            <i class=""fa-brands fa-facebook""></i>
 ");
                WriteLiteral("           <i class=\"fa-brands fa-instagram\"></i>\r\n        </p>\r\n    </footer>\r\n    <script src=\"../js/main.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
