#pragma checksum "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ccd4cee4aea36f089b2f8b627627cdbb0b9a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_proniaadmin_Views_Slider_Detail), @"mvc.1.0.view", @"/Areas/proniaadmin/Views/Slider/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\_ViewImports.cshtml"
using AP204_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\_ViewImports.cshtml"
using AP204_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ccd4cee4aea36f089b2f8b627627cdbb0b9a42", @"/Areas/proniaadmin/Views/Slider/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b9109567c1dc3986dd74402b28ac3a0f68a1d3", @"/Areas/proniaadmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_proniaadmin_Views_Slider_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Slider>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Inner Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
 <table class=""table table-dark"" style=""height:150px;"">
                      <thead>
                        <tr>
                          <th>
                            Id
                          </th>
                          <th>
                              Image
                          </th>
                          <th>
                              Title
                          </th>
                          <th>
                              Subtitile
                          </th>
                          <th>
                              Discount
                          </th>
                          <th>
                              Discoverurl
                          </th>
                        </tr>
                      </thead>
                      <tbody>
                           <tr>
                               <td>
                                   ");
#nullable restore
#line 72 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                               <td>\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12ccd4cee4aea36f089b2f8b627627cdbb0b9a425666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1819, "~/assets/images/website-images/", 1819, 31, true);
#nullable restore
#line 75 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
AddHtmlAttributeValue("", 1850, Model.Image, 1850, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                   \r\n                               </td>\r\n                               <td>\r\n                                   ");
#nullable restore
#line 79 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                                  <td>\r\n                                   ");
#nullable restore
#line 82 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
                              Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                                  <td>\r\n                                   ");
#nullable restore
#line 85 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
                              Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                                  <td>\r\n                                   ");
#nullable restore
#line 88 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Slider\Detail.cshtml"
                              Write(Model.DiscoverUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               </td>\r\n                           </tr>\r\n                      </tbody>\r\n                    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slider> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
