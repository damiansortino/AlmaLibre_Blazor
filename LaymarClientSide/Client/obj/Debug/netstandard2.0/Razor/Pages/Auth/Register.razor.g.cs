#pragma checksum "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a20d81104e9bf2e6b1de003a912abe856408444a"
// <auto-generated/>
#pragma warning disable 1591
namespace LaymarClientSide.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 8 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 9 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 12 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 9 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
using LaymarClientSide.Client.Auth;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Registro</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 11 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                 userInfo

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 11 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                          CrearUsuario

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-field");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label>Username:</label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 16 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                                          userInfo.username

#line default
#line hidden
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.username = __value, userInfo.username))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.LaymarClientSide.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#line 17 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                      () => userInfo.username

#line default
#line hidden
                );
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-field");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Email:</label>\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Class", "form-control");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 23 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                                          userInfo.Email

#line default
#line hidden
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.Email = __value, userInfo.Email))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.LaymarClientSide.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#line 24 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                      () => userInfo.Email

#line default
#line hidden
                );
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-field");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label>Password:</label>\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<LaymarClientSide.Client.Shared.InputPassword>(48);
                __builder2.AddAttribute(49, "Class", "form-control");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                                              userInfo.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.Password = __value, userInfo.Password))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __Blazor.LaymarClientSide.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#line 31 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                      () => userInfo.Password

#line default
#line hidden
                );
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n    ");
                __builder2.AddMarkupContent(59, "<button type=\"submit\" class=\"btn btn-primary\">Registrar</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
#line 38 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
 if (roles != null)
{

#line default
#line hidden
            __builder.AddContent(61, "    ");
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "class", "table");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<thead>\r\n            <tr>\r\n                <td>Roles</td>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(66, "tbody");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "tr");
            __builder.AddMarkupContent(69, "\r\n");
#line 48 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                 foreach(Roles r in userInfo.roles)
                {



#line default
#line hidden
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "class", true);
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "checkbox");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                                                    ()=> AgregarRol(r)

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddContent(76, 
#line 52 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                                                                                            r.rol

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#line 53 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"

                }

#line default
#line hidden
            __builder.AddContent(78, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#line 59 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(82, " ");
            __builder.AddMarkupContent(83, "<p>Cargado roles..</p>");
#line 61 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
                        }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 62 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Register.razor"
       
    List<string> rolesseleccionados = new List<string>();
    string[] roles;
    private UserInfo userInfo = new UserInfo();

    protected async override Task OnInitializedAsync()
    {

        roles = await http.GetJsonAsync<string[]>("api/cuentas/roles");
        Console.WriteLine(roles.Length);
    }
    private async Task CrearUsuario()
    {

        Console.WriteLine(userInfo);
        var result = await http.PostJsonAsync<UserToken>("api/cuentas/crear", userInfo);
        await loginService.Login(result.Token);
        uriHelper.NavigateTo("");
    }

    public void AgregarRol(Roles rol)
    {

        if (userInfo.roles.Where(x => x.id.Contains(rol.id)).ToList().Count > 0)
        {
            userInfo.roles.Remove(rol);
            Console.WriteLine($"se quito el rol {rol}");
            foreach (var r in userInfo.roles)
            {
                Console.WriteLine(r);
            }
        }
        else
        {
            userInfo.roles.Add(rol);
            Console.WriteLine($"se agrego el rol {rol}");
            foreach (var r in userInfo.roles)
            {
                Console.WriteLine(r);
            }
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.LaymarClientSide.Client.Pages.Auth.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
