#pragma checksum "C:\Users\DungPC\source\repos\WebApplication9_FlowerShop\WebApplication9_FlowerShop\Views\Shared\_UserLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c640b2ac118e01d5747ebc5b87cf67896da60e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLayout), @"mvc.1.0.view", @"/Views/Shared/_UserLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c640b2ac118e01d5747ebc5b87cf67896da60e8", @"/Views/Shared/_UserLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/_ViewImports.cshtml")]
    public class Views_Shared__UserLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c640b2ac118e01d5747ebc5b87cf67896da60e84143", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c640b2ac118e01d5747ebc5b87cf67896da60e84470", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <title>");
#nullable restore
#line 8 "C:\Users\DungPC\source\repos\WebApplication9_FlowerShop\WebApplication9_FlowerShop\Views\Shared\_UserLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c640b2ac118e01d5747ebc5b87cf67896da60e86725", async() => {
                WriteLiteral("\r\n    \r\n    <div id=\"wrap\">\r\n\r\n        <div class=\"header\">\r\n            <div class=\"logo\">\r\n                <a href=\"index.html\">\r\n                    <img src=\"images/logo.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 394, "\"", 400, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 401, "\"", 409, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                         border=""0"" />
                </a>
            </div>
            <div id=""menu"">
                <ul>
                    <li class=""selected""><a href=""index.html"">home</a></li>
                    <li><a href=""about.html"">about us</a></li>
                    <li><a href=""category.html"">flowers</a></li>
                    <li><a href=""specials.html"">specials gifts</a></li>
                    <li><a href=""myaccount.html"">my accout</a></li>
                    <li><a href=""register.html"">register</a></li>
                    <li><a href=""details.html"">prices</a></li>
                    <li><a href=""contact.html"">contact</a></li>
                </ul>
            </div>


        </div>


        <div class=""center_content"">
            <div class=""left_content"">
                ");
#nullable restore
#line 40 "C:\Users\DungPC\source\repos\WebApplication9_FlowerShop\WebApplication9_FlowerShop\Views\Shared\_UserLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                <div class=""clear""></div>
            </div>
            <!--end of left content-->

            <div class=""right_content"">
                <div class=""languages_box"">
                    <span class=""red"">Languages:</span> <a href=""#"" class=""selected"">
                        <img src=""images/gb.gif""");
                BeginWriteAttribute("alt", " alt=\"", 1594, "\"", 1600, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1601, "\"", 1609, 0);
                EndWriteAttribute();
                WriteLiteral(" border=\"0\" />\r\n                    </a> <a href=\"#\">\r\n                        <img src=\"images/fr.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 1713, "\"", 1719, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1720, "\"", 1728, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                             border=\"0\" />\r\n                    </a> <a href=\"#\">\r\n                        <img src=\"images/de.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 1862, "\"", 1868, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                             title=\"", 1869, "\"", 1907, 0);
                EndWriteAttribute();
                WriteLiteral(@" border=""0"" />
                    </a>
                </div>
                <div class=""currency"">
                    <span class=""red"">Currency: </span> <a href=""#"">GBP</a> <a href=""#"">EUR</a>
                    <a href=""#"" class=""selected"">USD</a>
                </div>


                <div class=""cart"">
                    <div class=""title"">
                        <span class=""title_icon"">
                            <img src=""images/cart.gif""");
                BeginWriteAttribute("alt", " alt=\"", 2379, "\"", 2385, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                                 title=\"", 2386, "\"", 2428, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </span>My cart
                    </div>
                    <div class=""home_cart_content"">
                        3 x items | <span class=""red"">TOTAL: 100$</span>
                    </div>
                    <a href=""cart.html"" class=""view_cart"">view cart</a>

                </div>




                <div class=""title"">
                    <span class=""title_icon"">
                        <img src=""images/bullet3.gif""");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 2901, "\"", 2937, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2938, "\"", 2946, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </span>About Our Shop\r\n                </div>\r\n                <div class=\"about\">\r\n                    <p>\r\n                        <img src=\"images/about.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 3132, "\"", 3138, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3139, "\"", 3147, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""right"" />
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                        eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                        enim ad minim veniam, quis nostrud.

                    </p>

                </div>

                <div class=""right_box"">

                    <div class=""title"">
                        <span class=""title_icon"">
                            <img src=""images/bullet4.gif""");
                BeginWriteAttribute("alt", "\r\n                                 alt=\"", 3654, "\"", 3694, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3695, "\"", 3703, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </span>Promotions
                    </div>
                    <div class=""new_prod_box"">
                        <a href=""details.html"">product name</a>
                        <div class=""new_prod_bg"">
                            <span class=""new_icon"">
                                <img src=""images/promo_icon.gif""");
                BeginWriteAttribute("alt", "\r\n                                     alt=\"", 4061, "\"", 4105, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4106, "\"", 4114, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </span> <a href=\"details.html\">\r\n                                <img src=\"images/thumb1.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 4241, "\"", 4247, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4248, "\"", 4256, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""thumb"" border=""0"" />
                            </a>
                        </div>
                    </div>

                    <div class=""new_prod_box"">
                        <a href=""details.html"">product name</a>
                        <div class=""new_prod_bg"">
                            <span class=""new_icon"">
                                <img src=""images/promo_icon.gif""");
                BeginWriteAttribute("alt", "\r\n                                     alt=\"", 4664, "\"", 4708, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4709, "\"", 4717, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </span> <a href=\"details.html\">\r\n                                <img src=\"images/thumb2.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 4844, "\"", 4850, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4851, "\"", 4859, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""thumb"" border=""0"" />
                            </a>
                        </div>
                    </div>

                    <div class=""new_prod_box"">
                        <a href=""details.html"">product name</a>
                        <div class=""new_prod_bg"">
                            <span class=""new_icon"">
                                <img src=""images/promo_icon.gif""");
                BeginWriteAttribute("alt", "\r\n                                     alt=\"", 5267, "\"", 5311, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5312, "\"", 5320, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </span> <a href=\"details.html\">\r\n                                <img src=\"images/thumb3.gif\"");
                BeginWriteAttribute("alt", " alt=\"", 5447, "\"", 5453, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5454, "\"", 5462, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""thumb"" border=""0"" />
                            </a>
                        </div>
                    </div>

                </div>

                <div class=""right_box"">

                    <div class=""title"">
                        <span class=""title_icon"">
                            <img src=""images/bullet5.gif""");
                BeginWriteAttribute("alt", "\r\n                                 alt=\"", 5807, "\"", 5847, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5848, "\"", 5856, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </span>Categories\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 153 "C:\Users\DungPC\source\repos\WebApplication9_FlowerShop\WebApplication9_FlowerShop\Views\Shared\_UserLayout.cshtml"
               Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <div class=\"title\">\r\n                        <span class=\"title_icon\">\r\n                            <img src=\"images/bullet6.gif\"");
                BeginWriteAttribute("alt", "\r\n                                 alt=\"", 6148, "\"", 6188, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 6189, "\"", 6197, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </span>Partners
                    </div>

                    <ul class=""list"">
                        <li><a href=""#"">accesories</a></li>
                        <li><a href=""#"">flower gifts</a></li>
                        <li><a href=""#"">specials</a></li>
                        <li><a href=""#"">hollidays gifts</a></li>
                        <li><a href=""#"">accesories</a></li>
                        <li><a href=""#"">flower gifts</a></li>
                        <li><a href=""#"">specials</a></li>
                        <li><a href=""#"">hollidays gifts</a></li>
                        <li><a href=""#"">accesories</a></li>
                    </ul>

                </div>


            </div>
            <!--end of right content-->

            <div class=""clear""></div>
        </div>
        <!--end of center content-->


        <div class=""footer"">
            <div class=""left_footer"">
                <img src=""images/footer_logo.gif""");
                BeginWriteAttribute("alt", " alt=\"", 7207, "\"", 7213, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 7214, "\"", 7222, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><br /> <a href=""http://csscreme.com/freecsstemplates/"" title=""free templates"">
                    <img src=""images/csscreme.gif"" alt=""free templates""
                         title=""free templates"" border=""0"" />
                </a>
            </div>
            <div class=""right_footer"">
                <a href=""#"">home</a> <a href=""#"">about us</a> <a href=""#"">services</a>
                <a href=""#"">privacy policy</a> <a href=""#"">contact us</a>

            </div>


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
            WriteLiteral("\r\n</html>\r\n");
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