#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37883dce5101643428b495e5b7d5ecfb53acb7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37883dce5101643428b495e5b7d5ecfb53acb7cb", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 33, true);
            WriteLiteral("\r\n<h2>Client Details</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(100, 40, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(143, 36, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(179, 12, true);
            WriteLiteral("</h3>\r\n\r\n<p>");
            EndContext();
            BeginContext(192, 67, false);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Edit Client", "Edit", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(259, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(269, 71, false);
#line 12 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Delete Client", "Delete", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(340, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(350, 51, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Back to list of clients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
