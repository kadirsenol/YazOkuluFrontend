using YazOkuluFrontend.Enums;

public class AdminRoleMiddleware
{
    private readonly RequestDelegate _next;

    public AdminRoleMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.Value;

        // 📌 1) Tüm route'lar için token kontrolü
        var token = context.Request.Cookies["Token"];

        if (string.IsNullOrEmpty(token) && path == "/Courses/MyApplications")
        {
            // Admin değilse de, normal kullanıcı değilse de hepsinde geçerli
            context.Response.Redirect("/");
            return;
        }

        // 📌 2) Admin URL'leri koru (mevcut yapı)
        if (path.StartsWith("/Admin") && path != "/Admin/Login")
        {
            try
            {
                var payload = token.Split('.')[1];
                var jsonText = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(payload));
                var payloadJson = System.Text.Json.JsonDocument.Parse(jsonText);

                var role = payloadJson.RootElement
                    .GetProperty("http://schemas.microsoft.com/ws/2008/06/identity/claims/role")
                    .GetString();

                // Admin rolü değilse yönlendir
                if (role != ((int)RoleTypeEnum.admin).ToString())
                {
                    context.Response.Redirect("/Admin/Login");
                    return;
                }
            }
            catch
            {
                context.Response.Redirect("/Admin/Login");
                return;
            }
        }

        await _next(context);
    }
}
