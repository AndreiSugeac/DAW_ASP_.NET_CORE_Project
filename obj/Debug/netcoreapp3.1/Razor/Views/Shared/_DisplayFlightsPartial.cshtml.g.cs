#pragma checksum "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38cba3b647b1b9ce6aaf419fa202dc586a49ee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayFlightsPartial), @"mvc.1.0.view", @"/Views/Shared/_DisplayFlightsPartial.cshtml")]
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
#line 1 "D:\Programming\DAW\TicketLine\Views\_ViewImports.cshtml"
using TicketLine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\DAW\TicketLine\Views\_ViewImports.cshtml"
using TicketLine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38cba3b647b1b9ce6aaf419fa202dc586a49ee2", @"/Views/Shared/_DisplayFlightsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46cb7173e3fc1e3caf810f00d541d8b83038275", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DisplayFlightsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flight>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
   
    var pathIndex = "../img/" + Model.Destination.City + ".jpg";
    var pathDetails = "/img/" + Model.Destination.City + ".jpg";
    var showButtons = (bool) ViewData["ShowButtons"];
    var seatNumber = (int?)ViewData["ShowSeat"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-4\">\r\n    <div class=\"card\">\r\n");
#nullable restore
#line 14 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
         if (showButtons)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 477, "\"", 493, 1);
#nullable restore
#line 16 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
WriteAttributeValue("", 483, pathIndex, 483, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
        }
        else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 564, "\"", 582, 1);
#nullable restore
#line 19 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
WriteAttributeValue("", 570, pathDetails, 570, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 20 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">");
#nullable restore
#line 22 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                          Write(Model.Boarding.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 22 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                                  Write(Model.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p class=\"card-text\">Boarding airport: ");
#nullable restore
#line 23 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                          Write(Model.Boarding.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Destination airport: ");
#nullable restore
#line 24 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                             Write(Model.Destination.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Takeoff time: ");
#nullable restore
#line 25 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                      Write(Model.TakeoffTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Arrival time: ");
#nullable restore
#line 26 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                      Write(Model.ArrivalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
         if (seatNumber != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"card-text\">Seat number: ");
#nullable restore
#line 29 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                         Write(seatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
         if (showButtons)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
             if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38cba3b647b1b9ce6aaf419fa202dc586a49ee29467", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38cba3b647b1b9ce6aaf419fa202dc586a49ee211935", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
             if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38cba3b647b1b9ce6aaf419fa202dc586a49ee214486", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Programming\DAW\TicketLine\Views\Shared\_DisplayFlightsPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591
