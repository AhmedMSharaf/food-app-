#pragma checksum "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0a88a94186ccdfc16f4fc9649c092082c89485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyOrder), @"mvc.1.0.view", @"/Views/Home/MyOrder.cshtml")]
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
#line 1 "C:\Users\Fazairi\source\repos\food4\food4\Views\_ViewImports.cshtml"
using food4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fazairi\source\repos\food4\food4\Views\_ViewImports.cshtml"
using food4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fazairi\source\repos\food4\food4\Views\_ViewImports.cshtml"
using food4.Repository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0a88a94186ccdfc16f4fc9649c092082c89485", @"/Views/Home/MyOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fb44960d5bbf2336899ce3f9410e252f3c06815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Myorders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-gray-900 bg-gray-100 font-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0a88a94186ccdfc16f4fc9649c092082c894853975", async() => {
                WriteLiteral(@"

    <main class=""lg:col-span-4"">
        
        <div class=""mt-16 container""style=""margin-left:100px"">
            <div><span class=""font-bold text-2xl md:text-4xl"">Your past orders:</span></div>

            <div class=""mt-5 grid grid-cols-2 lg:grid-cols-1 gap-10"">

                <!--card-->
");
#nullable restore
#line 15 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""bg-white rounded-lg shadow-md lg:border-l-8 border-gray-800 text-center hover:shadow-lg order"">
                        <div class=""grid grid-cols-1 lg:grid-cols-8"">
                            <div class=""bg-custom-yellow p-4"">
                                <span class=""font-bold text-lg"">");
#nullable restore
#line 20 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
                                                           Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"p-4\">\r\n                                <span class=\"font-bold text-md\"> ");
#nullable restore
#line 23 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                         \r\n                            <div class=\"p-4\">\r\n                                <span class=\"font-bold text-md\">$");
#nullable restore
#line 27 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"p-4\">\r\n                                <a class=\"rounded-lg bg-custom-yellow px-3 py-1 font-bold\"");
                BeginWriteAttribute("href", " href=\"", 1346, "\"", 1379, 2);
                WriteAttributeValue("", 1353, "/Home/DeleteOrder/", 1353, 18, true);
#nullable restore
#line 30 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
WriteAttributeValue("", 1371, item.Id, 1371, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete Order</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Fazairi\source\repos\food4\food4\Views\Home\MyOrder.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          
                <br />
                <br />
                <br />
                <!--card end-->

            </div>

        </div>


    </main>
 
    </div>
    <!--wrapper end-->
    <script src=""js/cart.js""></script>
    <script src=""js/nav.js""></script>
    <script src=""js/orders.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Myorders>> Html { get; private set; }
    }
}
#pragma warning restore 1591