#pragma checksum "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474d08c0115cb873576e2c63df8190ec7573e42b"
// <auto-generated/>
#pragma warning disable 1591
namespace AeroWiz.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using AeroWiz.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using AeroWiz.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Personal Projects\AeroWiz\AeroWiz\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"" integrity=""sha512-1ycn6IcaQQ40/MKBW2W4Rhis/DbILU74C1vSrLJxCq57o941Ym01SwNsOMqvEBFlcgUa6xLiPY/NS5R+E6ztJQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" b-4ottzdhptb>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "wrapper");
            __builder.AddAttribute(3, "b-4ottzdhptb");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "b-4ottzdhptb");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfToolbar>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarEvents>(8);
                __builder2.AddAttribute(9, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 8 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                     Toggle

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarItems>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarItem>(13);
                    __builder3.AddAttribute(14, "PrefixIcon", "fas fa-bars");
                    __builder3.AddAttribute(15, "TooltipText", "Menu");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.ToolbarItem>(17);
                    __builder3.AddAttribute(18, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "<div class=\"e-folder\" b-4ottzdhptb><div class=\"e-folder-name\" b-4ottzdhptb>Navigation Pane</div></div>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    \r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"main-content\" b-4ottzdhptb><div class=\"content\" b-4ottzdhptb><div b-4ottzdhptb>\r\n                Hello world\r\n            </div></div></div>\r\n    \r\n    \r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfSidebar>(22);
            __builder.AddAttribute(23, "HtmlAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 31 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                HtmlAttribute

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Target", ".main-content");
            __builder.AddAttribute(25, "Width", "200px");
            __builder.AddAttribute(26, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarType>(
#nullable restore
#line 31 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                                                                                                                        SidebarType.Auto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                                                                                                  SidebarToggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SidebarToggle = __value, SidebarToggle))));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "main-menu");
                __builder2.AddAttribute(32, "b-4ottzdhptb");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "b-4ottzdhptb");
                __Blazor.AeroWiz.Client.Shared.MainLayout.TypeInference.CreateSfMenu_0(__builder2, 35, 36, "dock-menu", 37, 
#nullable restore
#line 35 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                                         MainMenuItems

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 35 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                                                                      VerOrientation

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 31 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
                                                                                           Sidebar = (Syncfusion.Blazor.Navigations.SfSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(41, @"<style b-4ottzdhptb>
    .main-content {
        height: 100vh
    }


    .scroller {
        height: calc(100vh - 160px) !important;
        overflow-y: auto;
        width: 287px;
    }

        .scroller::-webkit-scrollbar, scrollbar-thumb
        .scroller::-webkit-scrollbar-thumb {
            width: 8px;
            height: 110px;
            border-radius: 4px;
            position: center;
        }

        .scroller::-webkit-scrollbar-thumb {
            box-shadow: inset 0 0 0 10px #313C75;
            border-radius: 4px;
        }

        .scroller::-webkit-scrollbar-track {
            width: 28px;
        }

    .separator {
        border: 1px solid #FFFFFF;
        opacity: 0.14;
        width: 247px;
        margin: 1rem;
        margin-top: 0px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\Personal Projects\AeroWiz\AeroWiz\Client\Shared\MainLayout.razor"
       
    SfSidebar Sidebar;
    public Orientation Orientation = Orientation.Horizontal;
    public Orientation VerOrientation = Orientation.Vertical;
    public bool SidebarToggle = false;
    Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
{
        {"class", "sidebar-menu" }
    };
    public List<MenuItem> AccountMenuItems = new List<MenuItem> {
        new MenuItem {
            Text = "Account",
            Items = new List<MenuItem> {
                new MenuItem { Text = "Profile" },
                new MenuItem { Text = "Sign out" }
            }
        }
    };
    public List<MenuItem> MainMenuItems = new List<MenuItem>{
         new MenuItem {
            Text = "Conceptual Mode",
            Items = new List<MenuItem> {
                new MenuItem { Text = "Aerodynamics" },
                new MenuItem { Text = "AC Construction & Repair" },
                 new MenuItem { Text = "Aircraft Powerplant" },
                new MenuItem { Text = "Engineering Economics" },
                new MenuItem { Text = "Aircraft Design & Structures" },
                new MenuItem { Text = "Airlaws" }
            }
        },
        new MenuItem {
            Text = "Computational Mode", 
                Items = new List<MenuItem> {
                    new MenuItem{ Text = "Aerodynamics" },
                    new MenuItem{ Text = "Engineering Economics" },
                    new MenuItem{ Text = "Mathematics" }
                }
            },
        new MenuItem {
            Text = "True or False",
        },
        new MenuItem {
            Text = "Trivia",
        }

    };
    public void Toggle(ClickEventArgs args)
    {
        if (args.Item.TooltipText == "Menu")
        {
            SidebarToggle = !SidebarToggle;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AeroWiz.Client.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfMenu_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.List<TValue> __arg1, int __seq2, global::Syncfusion.Blazor.Navigations.Orientation __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Navigations.SfMenu<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Orientation", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591