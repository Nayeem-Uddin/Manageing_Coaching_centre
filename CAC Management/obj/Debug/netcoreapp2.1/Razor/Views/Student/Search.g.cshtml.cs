#pragma checksum "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012c23ad48529499d66eb3b9ac9c8cc30264a6e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Search), @"mvc.1.0.view", @"/Views/Student/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Search.cshtml", typeof(AspNetCore.Views_Student_Search))]
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
#line 1 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management;

#line default
#line hidden
#line 2 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012c23ad48529499d66eb3b9ac9c8cc30264a6e3", @"/Views/Student/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d480e88fc2ea1a4d87350da6cf5607cfa8fe1ad9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAC_Management.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
  
    ViewData["Title"] = "Student Details";

#line default
#line hidden
            BeginContext(89, 1452, true);
            WriteLiteral(@"
<h1 style=""text-align:center"">Student Information Details</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Student Id</td>
                <td style=""text-align:center; font-weight: bold;"">Student Name</td>
                <td style=""text-align:center; font-weight: bold;"">Father Name</td>
                <td style=""text-align:center; font-weight: bold;"">Mother Name</td>
                <td style=""text-align:center; font-weight: bold;"">DOB</td>
                <td style=""text-align:center; font-weight: bold;"">Gender</td>
                <td style=""text-align:center; font-weight: bold;"">Address</td>
                <td style=""text-align:center; font-weight: bold;"">Contact</td>
                <td style=""text-align:center; font-weight: bold;"">Email</td>
                <td style=""text-align:center; font-weight: bold;"">Password</td>
 ");
            WriteLiteral(@"               <td style=""text-align:center; font-weight: bold;"">Tution Fee</td>
                <td style=""text-align:center; font-weight: bold;"">Pay Amount</td>
                <td style=""text-align:center; font-weight: bold;"">Due Amount</td>
                <td style=""text-align:center; font-weight: bold;"">Payment Status</td>
            </tr>
        </thead>
        <tr>
            <td style=""text-align:center"">");
            EndContext();
            BeginContext(1542, 15, false);
#line 29 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1607, 17, false);
#line 30 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1674, 16, false);
#line 31 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(1690, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1740, 16, false);
#line 32 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.MotherName);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1806, 9, false);
#line 33 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(1815, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1865, 12, false);
#line 34 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1877, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1927, 13, false);
#line 35 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1940, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1990, 13, false);
#line 36 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.Contact);

#line default
#line hidden
            EndContext();
            BeginContext(2003, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2053, 11, false);
#line 37 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2064, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2114, 14, false);
#line 38 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.Password);

#line default
#line hidden
            EndContext();
            BeginContext(2128, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2178, 16, false);
#line 39 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.TuitionFee);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2244, 15, false);
#line 40 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.PayAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(2309, 15, false);
#line 41 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                     Write(Model.DueAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2324, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
             if (Model.PaymentStatus == 0)
             {

#line default
#line hidden
            BeginContext(2391, 57, true);
            WriteLiteral("                <td style=\"text-align:center\">Paid</td>\r\n");
            EndContext();
#line 45 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
             }
             else
             {

#line default
#line hidden
            BeginContext(2499, 56, true);
            WriteLiteral("                <td style=\"text-align:center\">Due</td>\r\n");
            EndContext();
#line 49 "C:\Users\Akash\Desktop\CAC Management\CAC Management\Views\Student\Search.cshtml"
             }

#line default
#line hidden
            BeginContext(2571, 35, true);
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAC_Management.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
