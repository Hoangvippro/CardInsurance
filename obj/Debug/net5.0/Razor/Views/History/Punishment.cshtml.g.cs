#pragma checksum "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b619b4cc87c6a83184c39c70cc5a3536a166ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_History_Punishment), @"mvc.1.0.view", @"/Views/History/Punishment.cshtml")]
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
#line 6 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
using InsuranceCard1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b619b4cc87c6a83184c39c70cc5a3536a166ce", @"/Views/History/Punishment.cshtml")]
    public class Views_History_Punishment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Punishmenthistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b619b4cc87c6a83184c39c70cc5a3536a166ce4177", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400|Source+Code+Pro:700,900&display=swap""
          rel=""stylesheet"">
    <link rel=""shortcut icon"" href=""img/logo.png"" type=""image/x-icon"" />
    <!-- CSS Libraries -->
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42b619b4cc87c6a83184c39c70cc5a3536a166ce5202", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Home</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b619b4cc87c6a83184c39c70cc5a3536a166ce7116", async() => {
                WriteLiteral(@"
    <section class=""top"">
        <div class=""contenner"">
            <script type=""text/javascript"">
                $(function () {
                    $("".li-acc>a"").click(function (e) {
                        e.stopPropagation();
                        $("".panel-acc"").stop().slideToggle();
                        return false;
                    });
                });
            </script>

            <nav class=""nav-top nav-top1"">
                <li><a");
                BeginWriteAttribute("alt", " alt=\"", 1549, "\"", 1555, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">Giới thiệu</a></li>\r\n                <li><a");
                BeginWriteAttribute("alt", " alt=\"", 1609, "\"", 1615, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">Khuyến mại</a></li>\r\n                <li><a");
                BeginWriteAttribute("alt", " alt=\"", 1669, "\"", 1675, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""#"">Liên hệ</a><br /></li>
            </nav>
        </div>
    </section>


    <section class=""header shadow "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-1 col-md-12 col-sm-12 col-xs-12 leftbaner"">
                    <div class=""logo"">
                        <a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42b619b4cc87c6a83184c39c70cc5a3536a166ce8792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-11 col-md-6 col-sm-6 col-xs-6 hide-pad\">\r\n                    <div class=\"menubar\">\r\n                        <ul class=\"nav\">\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 2303, "\"", 2311, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 2324, "\"", 2332, 0);
                EndWriteAttribute();
                WriteLiteral(">Bảo hiểm ô tô</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 2389, "\"", 2397, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 2410, "\"", 2418, 0);
                EndWriteAttribute();
                WriteLiteral(">Bảo hiểm sức khoẻ</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 2479, "\"", 2487, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 2500, "\"", 2508, 0);
                EndWriteAttribute();
                WriteLiteral(@">Bảo hiểm tai nạn</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <section>
            <div class=""app-content content"">
                <div class=""content-overlay""></div>
                <div class=""content-wrapper"">
                    <div class=""content-header row"">
                        <div class=""content-header-left col-md-6 col-12 mb-2 breadcrumb-new"">
                            <h3 class=""content-header-title mb-0 d-inline-block""></h3>
                            <div class=""row breadcrumbs-top d-inline-block"">
                                <div class=""breadcrumb-wrapper col-12"">
                                    <ol class=""breadcrumb"">
                                        <li class=""breadcrumb-item"">
                                            <a href=""trang chủ"">Home</a>
                                        </li>
                                        <li class=""breadcrumb-item"">
 ");
                WriteLiteral(@"                                           <a href=""#"">Thông tin lịch sử/ Lịch sử phạt hợp đồng</a>
                                        </li>
                                    </ol>
                                </div>
                            </div>
                        </div>
                        <div class=""container"">
                            <div class=""table-responsive"">
                                <table id=""invoices-list""
                                       class=""table table-white-space table-bordered row-grouping display no-wrap icheck table-middle"">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Tên khách hàng</th>
                                            <th>Tên tài khoản</th>
                                            <th>Số điện thoại</th>
                                            <th>Tổng tiền</th>
   ");
                WriteLiteral(@"                                         <th>Ngày thanh toán</th>
                                            <th>Thông tin phạt</th>
                                            <th>Tình trạng</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 104 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                         foreach (Punishmenthistory a in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 107 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 108 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 109 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 110 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.UserPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 111 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 112 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 113 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.PunishmentInfo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 114 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                               Write(a.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 116 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\History\Punishment.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
        </section>




        <section class=""line-gray"">
            <div class=""container"">
                <h2 class=""title-pro text-center""><a");
                BeginWriteAttribute("href", " href=\"", 6034, "\"", 6041, 0);
                EndWriteAttribute();
                WriteLiteral(@">Trung tâm hỗ trợ khách hàng</a></h2>
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6 col-sm-12"">
                        <div class=""box-bottom shadow hvr-float item-height"">
                            <h3 class=""hd-box-bottom hd-box-sup"">
                                <a href=""#"">
                                    <b>
                                        Các câu hỏi thường
                                        gặp
                                    </b>
                                </a>
                            </h3>
                            <div class=""inner-box item-height"">
                                <div class=""intro-box-bottom"">
                                    Giải đáp các thắc mắc của khách hàng về sản phẩm & dịch vụ
                                </div>
                                <a href=""#"" class=""btn-box-bottom"">
                                    Xem ngay <i class=""fa fa-angle-right""
                         ");
                WriteLiteral(@"                       aria-hidden=""true""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12"">
                        <div class=""box-bottom shadow hvr-float item-height"">
                            <h3 class=""hd-box-bottom hd-box-truvan"">
                                <a href=""#"">
                                    <b>
                                        Truy vấn bồi thường
                                        online
                                    </b>
                                </a>
                            </h3>
                            <div class=""inner-box item-height"">
                                <div class=""intro-box-bottom"">
                                    Hỗ trợ Khách hàng tra cứu thông tin/theo dõi tình trạng hồ sơ bồi thường
                                    24/7
                                </div>");
                WriteLiteral(@"
                                <a href=""#"" class=""btn-box-bottom"">
                                    Xem ngay <i class=""fa fa-angle-right""
                                                aria-hidden=""true""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-12 col-sm-12"">
                        <div class=""box-bottom shadow hvr-float item-height"">
                            <h3 class=""hd-box-bottom hd-box-hot"">
                                <a href=""#"">
                                    <i class=""fa fa-phone""
                                       aria-hidden=""true""></i><b> Liên hệ hỗ trợ</b>
                                </a>
                            </h3>
                            <div class=""inner-box item-height"" style=""font-size:19px"">
                                <a class=""hotline-box"" href=""#""></a><br />
                                ");
                WriteLiteral(@"<a class=""hotline-box"" href=""#"">190010jqk</a>
                                <div>Email: #</div><br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-10 col-md-12"">
                        <ul class=""nav-footer"">

                            <li><a href=""dieu-khoan-su-dung-website"">Điều khoản sử dụng</a></li>
                            <li>
                                <a href=""bao-mat-va-quyen-rieng-tu-cua-khach-hang"">
                                    Bảo mật & quyền riêng
                                    tư
                                </a>
                            </li>
                            <li>
                                <a href=""huong-dan-huy-hop-dong-bao-hiem"">Chính sách đổi và trả hàng</a>
               ");
                WriteLiteral(@"             </li>
                            <li>
                                <a href=""cac-buoc-dat-mua-bao-hiem-truc-tuyen"">
                                    Hình thức thanh toán và giao
                                    hàng
                                </a>
                            </li>
                            <li><a href=""lien-he-voi-website-ban-bao-hiem-truc-tuyen"">Liên hệ</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-2 col-md-12"">
                        <div class=""linksmo"">
                            <a href=""#"" rel=""nofollow"" target=""_blank"" class=""hvr-float shadow"">
                                <i class=""fa fa-facebook facebook""></i>
                            </a>

                        </div>
                    </div>
                </div>
                <div class=""info-footer"">
                    <strong>Tổng Công ty Cổ phần Bảo hiểm </strong><br />
                    ĐC: thành phố H");
                WriteLiteral(@"à Nội <br />
                    ĐT:190010jqk <br />
                </div>
        </section>


        <!-- JavaScript Libraries -->
        <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
        <script src=""lib/easing/easing.min.js""></script>
        <script src=""lib/slick/slick.min.js""></script>

        <!-- Template Javascript -->
        <script src=""js/myjs.js""></script>
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Punishmenthistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
