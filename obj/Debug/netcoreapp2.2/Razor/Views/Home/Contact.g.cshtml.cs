#pragma checksum "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b857410459ba27b31b9a7b7cf82cc6603bc2f046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b857410459ba27b31b9a7b7cf82cc6603bc2f046", @"/Views/Home/Contact.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
            BeginContext(45, 2759, true);
            WriteLiteral(@"
<div class=""breadcrumb-area gray-bg-7"">
    <div class=""container"">
        <div class=""breadcrumb-content"">
            <ul>
                <li><a href=""/"">Home</a></li>
                <li class=""active""> Contato </li>
            </ul>
        </div>
    </div>
</div>
<div class=""contact-us pt-60 pb-50"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""contact-page-title mb-40"">
                    <h1>
                        Hi, Howdy
                        <br>
                        Let’s Connect us
                    </h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <ul class=""contact-tab-list nav"">
                    <li><a href=""#contact-address"" data-toggle=""tab"">Contact us</a></li>
                    <li><a href=""#contact-form-tab"" data-toggle=""tab"">Leave us a message</a></li>
                    <li><a class");
            WriteLiteral(@"=""active"" href=""#store-location"" data-toggle=""tab"">Our location</a></li>
                </ul>
            </div>
            <div class=""col-lg-8"">
                <div class=""tab-content tab-content-contact"">
                    <div id=""contact-address"" class=""tab-pane fade row d-flex"">
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""contact-information"">
                                <h4>Address</h4>
                                <p>You address will be here Lorem Ipsum text</p>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""contact-information mrg-top-sm"">
                                <h4>Phone</h4>
                                <p>
                                    <a href=""tel:01234567890"">01234 567 890</a>
                                    <a href=""tel:01234567891"">01234 567 891</a>
                             ");
            WriteLiteral(@"   </p>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""contact-information mrg-top-sm"">
                                <h4>Web</h4>
                                <p>
                                    <a href=""mailto:info@example.com"">info@example.com</a>
                                    <a href=""#"">www.example.com</a>
                                </p>
                            </div>
                        </div>
                    </div>
                    <div id=""contact-form-tab"" class=""tab-pane fade row d-flex"">
                        <div class=""col"">
");
            EndContext();
#line 67 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                             if (ViewData["success"] != null)
                            {

#line default
#line hidden
            BeginContext(2898, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(2962, 19, false);
#line 69 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                                                          Write(ViewData["success"]);

#line default
#line hidden
            EndContext();
            BeginContext(2981, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 70 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                            }

#line default
#line hidden
            BeginContext(3018, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 71 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                             if (ViewData["error"] != null)
                            {

#line default
#line hidden
            BeginContext(3110, 62, true);
            WriteLiteral("                                <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(3173, 17, false);
#line 73 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                                                         Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 74 "F:\projetos visual studio\IubShop\IubShop\Views\Home\Contact.cshtml"
                            }

#line default
#line hidden
            BeginContext(3227, 8617, true);
            WriteLiteral(@"                            <form id=""contact-form"" action=""/Home/ContactAction"" method=""post"">
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""contact-form-style mb-20"">
                                            <input name=""name"" id=""name"" placeholder=""Full Name"" type=""text"" />
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""contact-form-style mb-20"">
                                            <input name=""email"" id=""email"" placeholder=""Email Address"" type=""email"" />
                                        </div>
                                    </div>
                                    <div class=""col-lg-12"">
                                        <div class=""contact-form-style mb-20"">
                                      ");
            WriteLiteral(@"      <input name=""subject"" id=""subject"" placeholder=""Subject"" type=""text"" />
                                        </div>
                                    </div>
                                    <div class=""col-lg-12"">
                                        <div class=""contact-form-style"">
                                            <textarea name=""message"" id=""message"" placeholder=""Message""></textarea>
                                            <button class=""submit"" type=""submit"">ENVIAR MENSAGEM</button>
                                        </div>
                                    </div>
                                </div>
                            </form>
                            <!--<p class=""form-messege"">-->
                            </p>
                        </div>
                    </div>
                    <div id=""store-location"" class=""tab-pane fade row d-flex active show"">
                        <div class=""col-12"">
                            <div");
            WriteLiteral(@" class=""contact-map"">
                                <div id=""map""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCxvP66_Xk1ts77oL2Z7EpDxhDD_jMg-D0""></script>
<script>
    function init() {
        var mapOptions = {
            zoom: 11,
            scrollwheel: false,
            center: new google.maps.LatLng(40.709896, -73.995481),
            styles:
            [
                {
                    ""featureType"": ""all"",
                    ""elementType"": ""labels.text.fill"",
                    ""stylers"": [
                        {
                            ""saturation"": 36
                        },
                        {
                            ""color"": ""#878787""
                        },
                        {
                            ""lightness"": 40
           ");
            WriteLiteral(@"             }
                    ]
                },
                {
                    ""featureType"": ""all"",
                    ""elementType"": ""labels.text.stroke"",
                    ""stylers"": [
                        {
                            ""visibility"": ""on""
                        },
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 16
                        }
                    ]
                },
                {
                    ""featureType"": ""all"",
                    ""elementType"": ""labels.icon"",
                    ""stylers"": [
                        {
                            ""visibility"": ""off""
                        }
                    ]
                },
                {
                    ""featureType"": ""administrative"",
                    ""elementType"": ""geometry.fill"",
                    ""stylers"": [
          ");
            WriteLiteral(@"              {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 20
                        }
                    ]
                },
                {
                    ""featureType"": ""administrative"",
                    ""elementType"": ""geometry.stroke"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 17
                        },
                        {
                            ""weight"": 1.2
                        }
                    ]
                },
                {
                    ""featureType"": ""landscape"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
    ");
            WriteLiteral(@"                        ""lightness"": 20
                        }
                    ]
                },
                {
                    ""featureType"": ""poi"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 21
                        }
                    ]
                },
                {
                    ""featureType"": ""road.highway"",
                    ""elementType"": ""geometry.fill"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 17
                        }
                    ]
                },
                {
                    ""featureType"": ""road.highway"",
                    ""elementType"": ""geometry.strok");
            WriteLiteral(@"e"",
                    ""stylers"": [
                        {
                            ""color"": ""#444444""
                        },
                        {
                            ""lightness"": 29
                        },
                        {
                            ""weight"": 0.2
                        }
                    ]
                },
                {
                    ""featureType"": ""road.arterial"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 18
                        }
                    ]
                },
                {
                    ""featureType"": ""road.local"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                 ");
            WriteLiteral(@"       },
                        {
                            ""lightness"": 16
                        }
                    ]
                },
                {
                    ""featureType"": ""transit"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#000000""
                        },
                        {
                            ""lightness"": 19
                        }
                    ]
                },
                {
                    ""featureType"": ""water"",
                    ""elementType"": ""geometry"",
                    ""stylers"": [
                        {
                            ""color"": ""#2d333c""
                        },
                        {
                            ""lightness"": 17
                        }
                    ]
                }
            ]
        };
        var mapElement = document.getElementById('map');
   ");
            WriteLiteral(@"     var map = new google.maps.Map(mapElement, mapOptions);
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(40.709896, -73.995481),
            map: map,
            icon: '/assets/img/icon-img/map.png',
            animation:google.maps.Animation.BOUNCE,
            title: 'Snazzy!'
        });
    }
    google.maps.event.addDomListener(window, 'load', init);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
