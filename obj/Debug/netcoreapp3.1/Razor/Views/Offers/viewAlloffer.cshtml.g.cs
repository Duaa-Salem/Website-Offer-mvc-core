#pragma checksum "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805ae1b4def150f5eb68481e73aa41dfa819dd7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers_viewAlloffer), @"mvc.1.0.view", @"/Views/Offers/viewAlloffer.cshtml")]
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
#line 1 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\_ViewImports.cshtml"
using duaaOffer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\_ViewImports.cshtml"
using duaaOffer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805ae1b4def150f5eb68481e73aa41dfa819dd7d", @"/Views/Offers/viewAlloffer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b484a8176853ecd2aea6cef35e0f61366c0ac5", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers_viewAlloffer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<duaaOffer.Models.Offer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("poster"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
  
    ViewData["Title"] = "viewAlloffer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<title>Offer.jo</title>
<link rel=""icon"" href=""https://cdn-icons-png.flaticon.com/512/7245/7245128.png""
      type=""image/x-icon"">
<style>
    button {
        color: white;
        border: none;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        background-color: #fa4251;
        margin-top: 30px;
    }

    th, td {
        padding: 15px;
        text-align: left;
    }

    #export {
        margin-left: 300px;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805ae1b4def150f5eb68481e73aa41dfa819dd7d5103", async() => {
                WriteLiteral("\r\n\r\n    <button id=\"export\" class=\"btn btn-success text-white \" style=\"background-color: #fa4251; border-color: #fa4251; color:white;\">Excel</button>\r\n");
                WriteLiteral(@"    <button class=""btn btn-danger"" onclick=""printTable();"" style=""background-color: #fa4251; border-color: #fa4251; color:white;"">Print</button>

    <div class=""card my-4"" style=""margin-left: 280px;"">
        <div class=""bg-gradient-primary shadow-primary border-radius-lg pt-4 pb-3"" style=""margin-left: 25px; margin-top: -13px; "">

            <h6 class=""text-white text-capitalize ps-3"">Report Offer</h6>
        </div>
        <div class=""row"" style=""margin-top: 30px; margin-left: 25px;"">
            <div class=""table-responsive p-0"">
                <div class=""card-block table-border-style"">
                    <div class=""table-responsive"">
                        <table id=""tableData"">
                            <thead>
                                <tr>

                                    <th class=""col-sm-2"">Name</th>
                                    <th class=""col-sm-3"">Image</th>
                                    <th class=""col-sm-2"">City</th>
                               ");
                WriteLiteral(@"     <th class=""col-sm-2"">Communication</th>
                                    <th class=""col-sm-3"">Color</th>
                                    <th class=""col-sm-3"">Startdate</th>
                                    <th class=""col-sm-3"">Enddate</th>
                                    <th class=""col-sm-3"">Text</th>
                                    <th class=""col-sm-2"">Regular</th>
                                    <th class=""col-sm-2"">Sale</th>
                                    <th class=""col-sm-2"">Company</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 66 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 69 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-3\">  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "805ae1b4def150f5eb68481e73aa41dfa819dd7d8068", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                            WriteLiteral(Url.Content("~/Image/" + item.Image));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-3\">");
#nullable restore
#line 71 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 72 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Communication);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 73 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 74 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Startdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 75 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Enddate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 76 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 77 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Regular);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 78 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Sale);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"col-sm-2\">");
#nullable restore
#line 79 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                                        Write(item.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\hp\OneDrive\Desktop\duaaOffer\duaaOffer\Views\Offers\viewAlloffer.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>






        document.getElementById('export').onclick = function () {
            var tableId = document.getElementById('tableData').id;
            htmlTableToExcel(tableId, filename = '');
        }
        var htmlTableToExcel = function (tableId, fileName = '') {
            var downloadedFileName = 'excel_table_data';
            var TableDataType = 'application/vnd.ms-excel';
            var selectTable = document.getElementById(tableId);
            var htmlTable = selectTable.outerHTML.replace(/ /g, '%20');

            filename = filename ? filename + '.xls' : downloadedFileName + '.xls';
            var downloadingURL = document.createElement(""a"");
            document.body.appendChild(downloadingURL);

            if (navigator.msSaveOrOpenBlob) {
                var blob = new Blob(['\ufeff',");
                WriteLiteral(@" htmlTable], {
                    type: TableDataType
                });
                navigator.msSaveOrOpenBlob(blob, fileName);
            } else {

                downloadingURL.href = 'data:' + TableDataType + ', ' + htmlTable;
                downloadingURL.download = fileName;
                downloadingURL.click();
            }
        }

        function printTable() {
            var el = document.getElementById(""tableData"");

            el.setAttribute('border', '5px');
            el.setAttribute('cellpadding', '5');
            el.setAttribute('color', 'green');
            newPrint = window.open("""");
            newPrint.document.write(el.outerHTML);
            newPrint.print();
            newPrint.close();
        }
        //document.getElementById('export1').onclick = function () {
        //    var tableId = document.getElementById('tableData').id;
        //    htmlTableToAdobePortableDocumentFormat(tableId, filename = '');
        //}
        //var html");
                WriteLiteral(@"TableToAdobePortableDocumentFormat = function (tableId, fileName = '') {
        //    var downloadedFileName = 'Pdf_table_data';
        //    var TableDataType = 'application/pdf';
        //    var selectTable = document.getElementById(tableId);
        //    var htmlTable = selectTable.outerHTML.replace(/ /g, '%20');

        //    filename = filename ? filename + '.pdf' : downloadedFileName + '.pdf';
        //    var downloadingURL = document.createElement(""a"");
        //    document.body.appendChild(downloadingURL);

        //    if (navigator.msSaveOrOpenBlob) {
        //        var blob = new Blob(['\ufeff', htmlTable], {
        //            type: TableDataType
        //        });
        //        navigator.msSaveOrOpenBlob(blob, fileName);
        //    } else {

        //        downloadingURL.href = 'data:' + TableDataType + ', ' + htmlTable;
        //        downloadingURL.download = fileName;
        //        downloadingURL.click();
        //    }
        //}

");
                WriteLiteral("    </script>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<duaaOffer.Models.Offer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
