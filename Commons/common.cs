using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using PremiumcontactMaster.ModelData;

/// <summary>
/// Summary description for Commons
/// </summary>
public class Commons
{
    public static readonly string AdminSaft = "";
    public static readonly string EmailTo = "";//email nhận thông báo
    public static readonly string SMTPHost = "smtp.gmail.com";//smtp host mail smtp.gmail.com
    public static readonly int SMTPPort = 465;//Port 587 (TLS required)||Port 465 (SSL required)
    public static readonly string EmailFrom = "laptrinhvien2015@gmail.com";//email gui thong báo khích hoạt nguoi dùnglaptrinhvien2015@gmail.com
    public static readonly string PasswordEmailFrom = "2015@VienLapTrinh";//mật khẩu của email gửi2015@VienLapTrinh
    public static readonly string Http = "https://localhost:5001";
    public static ObjLogin Decode(string[] strToken)
    {
        HttpClientHandler handler = new HttpClientHandler()
        {
            Proxy = new WebProxy(Http),
            UseProxy = true,
        };
        ObjLogin obj = new ObjLogin();
        var handlers = new JwtSecurityTokenHandler();
        var decode = handlers.ReadToken(strToken[0]) as JwtSecurityToken;
        var arrsub = decode.Payload.Sub.Replace("[", "").Replace("]", "").Replace("\\", "").Replace("\"", "").Trim().Split(',');
        string username = arrsub[0] + "";
        string pass = arrsub[1] + "";
        obj.UserName = username;
        obj.Password = pass;
        return obj;
    }

}