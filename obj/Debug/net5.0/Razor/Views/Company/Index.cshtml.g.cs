#pragma checksum "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "de3173ae3a6fd341ebda9391d4a6570abef2d9355c3f2ee26dae3f58fd05271b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\_ViewImports.cshtml"
using AppointmentScheduling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\_ViewImports.cshtml"
using AppointmentScheduling.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de3173ae3a6fd341ebda9391d4a6570abef2d9355c3f2ee26dae3f58fd05271b", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b225c1b460a05d9bec3427a9dea0e6634e112cf34035546bd0f9d27994bc891c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppointmentScheduling.Models.Company>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Companies List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3173ae3a6fd341ebda9391d4a6570abef2d9355c3f2ee26dae3f58fd05271b4916", async() => {
                WriteLiteral("Create new Company");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n");
#nullable restore
#line 14 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
     if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thread>
                <tr>
                    <th>
                        Company Name
                    </th>
                    <th>
                        Address
                    </th>
                    <th>
                        Phone
                    </th>
                </tr>
            </thread>
            <tbody>
");
#nullable restore
#line 31 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
                 foreach(var company in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"30%\">");
#nullable restore
#line 34 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
                               Write(company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 35 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
                               Write(company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 36 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
                               Write(company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 41 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
    }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No company created yet</p>\r\n");
#nullable restore
#line 45 "E:\Users\shinj\Desktop\yr 3 sem 2\BIC 31704\ALL FINAL PSM PROJECT SUBMIT\3_ai180293_Poliklinik Penawar Medical System Inventory and Appointment\AppointmentScheduling\AppointmentScheduling\Views\Company\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppointmentScheduling.Models.Company>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591