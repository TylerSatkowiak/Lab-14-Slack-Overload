#pragma checksum "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43504bdcd6062bcc2b542a5db90440e77f8e6bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReadQuestions), @"mvc.1.0.view", @"/Views/QA/ReadQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/ReadQuestions.cshtml", typeof(AspNetCore.Views_QA_ReadQuestions))]
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
#line 1 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project;

#line default
#line hidden
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43504bdcd6062bcc2b542a5db90440e77f8e6bc1", @"/Views/QA/ReadQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_ReadQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
  
    ViewData["Title"] = "ReadQuestions";

#line default
#line hidden
            BeginContext(73, 29, true);
            WriteLiteral("\r\n<h2>Read Questions</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
 foreach(Questions questions in Model)
{
    

#line default
#line hidden
            BeginContext(150, 15, false);
#line 10 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Title);

#line default
#line hidden
            EndContext();
            BeginContext(165, 7, true);
            WriteLiteral("<br/>\r\n");
            EndContext();
            BeginContext(177, 12, false);
#line 11 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.ID);

#line default
#line hidden
            EndContext();
            BeginContext(189, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(202, 16, false);
#line 12 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Posted);

#line default
#line hidden
            EndContext();
            BeginContext(218, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(231, 16, false);
#line 13 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Status);

#line default
#line hidden
            EndContext();
            BeginContext(247, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(260, 18, false);
#line 14 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Category);

#line default
#line hidden
            EndContext();
            BeginContext(278, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(291, 16, false);
#line 15 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(307, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(320, 14, false);
#line 16 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
Write(questions.Tags);

#line default
#line hidden
            EndContext();
#line 16 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                   
}

#line default
#line hidden
            BeginContext(339, 6, true);
            WriteLiteral("<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
