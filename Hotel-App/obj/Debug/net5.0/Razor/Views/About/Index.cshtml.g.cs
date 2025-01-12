#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55921fe5f1701a9f3f8fdb34770cdd3f828530c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55921fe5f1701a9f3f8fdb34770cdd3f828530c4", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c0919da7705681ff1011bc12c1c1670520f654", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- preloader -->
<div class=""hotel-preloader-frame"">
    <div class=""hotel-preloader"">
        <img src=""img/hotellogo.png"" alt=""logo"">
        <div class=""hotel-preloader-progress"">
            <div class=""hotel-preloader-bar""></div>
        </div>
        <div><span class=""hotel-preloader-number"" data-count=""101"">0</span>%</div>
    </div>
</div>
<!-- preloader end -->
<!-- datepicker frame -->
<div class=""hotel-datepicker-place""></div>

<!-- top bar -->
<div class=""hotel-top-bar"">
    <div class=""container"">
        <div class=""hotel-left-side"">
            <!-- logo -->
            <a href=""index.html"" class=""hotel-logo-frame"" style=""width: 50px;"">
                <img src=""img/hotellogo.png"" alt=""logo"">
            </a>
            <!-- logo end -->
        </div>
        <div class=""hotel-right-side"">
            <!-- menu -->
            <div class=""hotel-menu"">
                <nav>
                    <ul>
                        <li>
                            <a h");
            WriteLiteral(@"ref=""index.html"">Ana Səhifə</a>
                        </li>
                        <li class=""current-item"">
                            <a href=""about.html"">Haqqımızda</a>
                        </li>
                        <li>
                            <a href=""rooms.html"">Hotellər</a>
                        </li>
                        <li>
                            <a href=""menu.html"">Otaqlar</a>
                        </li>
                        <li>
                            <a href=""service.html"">Xidmətlərimiz</a>
                        </li>
                        <li>
                            <a href=""contact.html"">Əlaqə</a>
                        </li>
                    </ul>
                </nav>
            </div>
            <!-- menu end -->
            <!-- action button -->
            <a href=""login.html"" class=""hotel-btn""><img src=""img/icons/bookmark.svg"" alt=""icon"">Giriş</a>
            <!-- action button end -->
        </div>
        <!--");
            WriteLiteral(@" menu button -->
        <div class=""hotel-menu-btn""><span></span></div>
        <!-- menu button end -->
    </div>
</div>
<!-- top bar end -->
<!-- banner -->
<section class=""hotel-banner-simple hotel-transition-bottom about"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame"">
                    <h1 class=""hotel-mb-20 hotel-h1-inner"">Saytimiz Haqqında</h1>
                    <p class=""hotel-mb-30 "">Saytimiz Butun otellerin arasinda qiymeti muqayise ederek size en uygun oteli tapmaqda komeklik edir.</p>
                    <ul class=""hotel-breadcrumbs"">
                        <li><a href=""index.html"">Ana Səhifə</a></li>
                        <li><span>Haqqımızda</span></li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- banner end -->
<!-- quote -->
<section class=""hotel-p-100-100"">

    <div class=""container"">
");
            WriteLiteral(@"        <div class=""row"">

            <div class=""col-lg-12"">

                <div class=""hotel-quote-with-author"">

                    <div class=""row align-items-center "">
                        <div class=""col-lg-4 "">
                            <div class=""hotel-photo-frame imgLoad"">
                                <img class=""lozad"" data-src=""img/faces/admin.jpg"" alt=""Author"">
                            </div>
                        </div>
                        <div class=""col-lg-8"">
                            <blockquote");
            BeginWriteAttribute("class", " class=\"", 3669, "\"", 3677, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate voluptatem nemo nisi perspiciatis, laborum error minima obcaecati facilis quaerat ipsam veritatis? Sint, quam consequatur. Perspiciatis dolores aut id nisi nihil.
                            </blockquote>
                            <div class=""hotel-quote-bottom imgLoad"">
                                <div>
                                    <h4");
            BeginWriteAttribute("class", " class=\"", 4136, "\"", 4144, 0);
            EndWriteAttribute();
            WriteLiteral(@">Rahid Mahmudov</h4>
                                    <p>CEO</p>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

</section>
<!-- quote end -->
<!-- features -->
<section class=""hotel-p-0-90"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame hotel-mb-100"">
                    <h2 class=""hotel-mb-20"">Sizin Üçün Təklif Etdiklərimiz</h2>
                    <p class=""hotel-mb-30"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellat illum explicabo impedit exercitationem, voluptate adipisci optio odit, consequatur, quidem in quasi qui? Iusto aliquam ipsum laboriosam, temporibus vero architecto voluptate.</p>
                    <a href=""service.html"" class=""hotel-btn hotel-btn-md"">Xidmətlərimiz</a>
                </di");
            WriteLiteral(@"v>

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/1.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Havayolu transferi</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/2.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Hər şey daxildir</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div cl");
            WriteLiteral(@"ass=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/3.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Kondisioner</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/4.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Təhlükəsizlik</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3 "" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/5.svg"" alt=""icon"" class=""hotel-mb-10"">
                   ");
            WriteLiteral(@" <h5>Hovuz</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/6.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Wi-fi</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

                <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/7.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Smart TV</h5>
                </div>
                <!-- icon box end -->

            </div>
            <div class=""col-lg-3"" data-aos=""zoom-in"" data-aos-duration=""3000"">

   ");
            WriteLiteral(@"             <!-- icon box -->
                <div class=""hotel-icon-box hotel-scroll-animation imgLoad"">
                    <img class=""lozad"" data-src=""img/features/8.svg"" alt=""icon"" class=""hotel-mb-10"">
                    <h5>Çamaşırxana</h5>
                </div>
                <!-- icon box end -->

            </div>
        </div>
    </div>
</section>
<!-- features end -->
<!-- video -->
<section class=""hotel-p-0-100"">

    <div class=""container"">

        <div class=""hotel-about-card"">
            <div class=""row g-0"">
                <div class=""col-lg-6"">
                    <div class=""hotel-about-text"">
                        <div class=""hotel-title-frame imgLoad"" data-aos=""fade-right"" data-aos-duration=""3000"">
                            <h2 class=""hotel-mb-20"">İnanılmaz macəranıza başlayın!</h2>
                            <p class=""hotel-mb-30"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Culpa, obcaecati consequuntur. Cum, asperiores? Quia, cupiditate.");
            WriteLiteral(@" Laudantium pariatur ab nostrum repudiandae.</p>
                            <a data-fancybox href=""https://www.youtube.com/watch?v=wsq-r8lMMsk"" class=""hotel-btn hotel-btn-md""><img class=""lozad"" data-src=""img/icons/play.svg"" alt=""icon"" class=""hotel-zoom"">İzlə</a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""hotel-video-frame imgLoad"" data-aos=""fade-left"" data-aos-duration=""3000"">
                        <img class=""lozad"" data-src=""img/about/8.jpg"" alt=""cover"">
                        <a data-fancybox href=""https://www.youtube.com/watch?v=wsq-r8lMMsk"" class=""hotel-play-btn"">
                            <i class=""fas fa-play""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>

</section>
<!-- video end -->
<!-- team -->
<section class=""hotel-p-0-80"">
    <div class=""container"">
        <div class=""row"">
  ");
            WriteLiteral(@"          <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame hotel-mb-100"" data-aos=""fade-down"" data-aos-easing=""linear"" data-aos-duration=""1500"">
                    <h2 class=""hotel-mb-20"">Komandamız</h2>
                    <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Suscipit voluptatem excepturi exercitationem libero velit labore eligendi eaque delectus mollitia magni.</p>
                </div>

            </div>
            <div class=""col-12 col-md-6 col-lg-3"">

                <div class=""hotel-team-card"" data-aos=""fade-up"" data-aos-anchor-placement=""top-bottom"" data-aos-duration=""1500"">
                    <div class=""hotel-photo-frame imgLoad"">
                        <img class=""lozad"" data-src=""img/team/1.jpg"" alt=""face"">
                    </div>
                    <div class=""hotel-team-member-descr"">
                        <h3 class=""hotel-mb-10"">Elnur İsamyilov</h3>
                        <div>Baş Rəhbər</div>
            ");
            WriteLiteral(@"            <ul class=""hotel-member-social"">
                            <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                        </ul>
                    </div>
                </div>

            </div>
            <div class=""col-12 col-md-6 col-lg-3"">

                <div class=""hotel-team-card"" data-aos=""fade-up"" data-aos-anchor-placement=""top-bottom"" data-aos-duration=""1800"">
                    <div class=""hotel-photo-frame imgLoad"">
                        <img class=""lozad"" data-src=""img/team/2.jpg"" alt=""face"">
                    </div>
                    <div class=""hotel-team-member-descr"">
                        <h3 class=""hotel-mb-10"">Aydın Kazımov</h3>
                        <div>Müdür</div>
    ");
            WriteLiteral(@"                    <ul class=""hotel-member-social"">
                            <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                        </ul>
                    </div>
                </div>

            </div>
            <div class=""col-12 col-md-6 col-lg-3"">

                <div class=""hotel-team-card"" data-aos=""fade-up"" data-aos-anchor-placement=""top-bottom"" data-aos-duration=""2100"">
                    <div class=""hotel-photo-frame imgLoad"">
                        <img class=""lozad"" data-src=""img/team/3.jpg"" alt=""face"">
                    </div>
                    <div class=""hotel-team-member-descr"">
                        <h3 class=""hotel-mb-10"">Aylin Rəhimova</h3>
                        <div>Administ");
            WriteLiteral(@"rator</div>
                        <ul class=""hotel-member-social"">
                            <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                        </ul>
                    </div>
                </div>

            </div>
            <div class=""col-12 col-md-6 col-lg-3"">

                <div class=""hotel-team-card"" data-aos=""fade-up"" data-aos-anchor-placement=""top-bottom"" data-aos-duration=""2400"">
                    <div class=""hotel-photo-frame imgLoad"">
                        <img class=""lozad"" data-src=""img/team/4.jpg"" alt=""face"">
                    </div>
                    <div class=""hotel-team-member-descr"">
                        <h3 class=""hotel-mb-10"">Fuad Ələkbərov</h3>
                    ");
            WriteLiteral(@"    <div>Tur Rəhbəri</div>
                        <ul class=""hotel-member-social"">
                            <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                        </ul>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- team end -->
");
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
