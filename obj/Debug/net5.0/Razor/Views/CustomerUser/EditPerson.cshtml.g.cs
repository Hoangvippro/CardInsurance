#pragma checksum "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d544a57d261c4ca19bbc55ebba66151e3b4d264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerUser_EditPerson), @"mvc.1.0.view", @"/Views/CustomerUser/EditPerson.cshtml")]
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
#line 6 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
using InsuranceCard1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d544a57d261c4ca19bbc55ebba66151e3b4d264", @"/Views/CustomerUser/EditPerson.cshtml")]
    public class Views_CustomerUser_EditPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleForm.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d544a57d261c4ca19bbc55ebba66151e3b4d2644175", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n    <title>Edit Customer_User Information Form</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d544a57d261c4ca19bbc55ebba66151e3b4d2644574", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d544a57d261c4ca19bbc55ebba66151e3b4d2646543", async() => {
                WriteLiteral("\r\n    <h2>Edit Customer_User Information</h2>\r\n    <form action=\"/CustomerUser/DoEditPerson\" method=\"post\">\r\n        <p><input type=\"hidden\" name=\"NewC.CustomerId\"");
                BeginWriteAttribute("value", " value=\"", 595, "\"", 620, 1);
#nullable restore
#line 18 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 603, Model.CustomerId, 603, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Name\"");
                BeginWriteAttribute("value", " value=\"", 676, "\"", 695, 1);
#nullable restore
#line 19 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 684, Model.Name, 684, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Gender\"");
                BeginWriteAttribute("value", " value=\"", 753, "\"", 774, 1);
#nullable restore
#line 20 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 761, Model.Gender, 761, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Dateofbirth\"");
                BeginWriteAttribute("value", " value=\"", 837, "\"", 863, 1);
#nullable restore
#line 21 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 845, Model.Dateofbirth, 845, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.IdentityNumber\"");
                BeginWriteAttribute("value", " value=\"", 929, "\"", 958, 1);
#nullable restore
#line 22 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 937, Model.IdentityNumber, 937, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Email\"");
                BeginWriteAttribute("value", " value=\"", 1015, "\"", 1035, 1);
#nullable restore
#line 23 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1023, Model.Email, 1023, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Phone\"");
                BeginWriteAttribute("value", " value=\"", 1092, "\"", 1112, 1);
#nullable restore
#line 24 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1100, Model.Phone, 1100, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Username\"");
                BeginWriteAttribute("value", " value=\"", 1172, "\"", 1195, 1);
#nullable restore
#line 25 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1180, Model.Username, 1180, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Address\"");
                BeginWriteAttribute("value", " value=\"", 1254, "\"", 1276, 1);
#nullable restore
#line 26 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1262, Model.Address, 1262, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.Password\"");
                BeginWriteAttribute("value", " value=\"", 1336, "\"", 1359, 1);
#nullable restore
#line 27 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1344, Model.Password, 1344, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"NewC.StaffID\"");
                BeginWriteAttribute("value", " value=\"", 1418, "\"", 1440, 1);
#nullable restore
#line 28 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\EditPerson.cshtml"
WriteAttributeValue("", 1426, Model.StaffId, 1426, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"submit\" value=\"Submit\" /></p>\r\n    </form>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
