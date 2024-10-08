using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CheckDieLinkedin.API
{
    public class TestCheckEmail
    {
        // check lk
        // public void CheckLinked()
        //{
        //    try
        //    {
        //        var client = new HttpClient();
        //        var request = new HttpRequestMessage(HttpMethod.Get, "https://www.linkedin.com/jobs-guest/jobs/api/verifyEmailAddress?emailAddress=nguyendactaidn@gmail.com&flowType=SAVE_JOB");
        //        request.Headers.Add("Cookie", "bcookie=\"v=2&1dc56a4f-4898-49b4-8ef3-12a3596787db\"; lang=v=2&lang=en-us; lidc=\"b=TGST05:s=T:r=T:a=T:p=T:g=3130:u=1:x=1:i=1727311880:t=1727398280:v=2:sig=AQGgqXeYNC1tfQaBfxaVt9HIQurd3cW_\"; JSESSIONID=ajax:4876259437623874162; bscookie=\"v=1&20240924083108394703f7-2401-4d25-89e6-93538691341aAQEv-yUAQebmm3GV_AclZVnHYayo9Jf6\"");
        //        var response = client.SendAsync(request).Result;
        //        response.EnsureSuccessStatusCode();
        //        Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        // check die
        //public void CheckDieEmails()
        //{
        //    try
        //    {
        //        string urlcheckpointsubmit = "https://www.linkedin.com/checkpoint/lg/login-submit";
        //        var client = new HttpClient();
        //        client.DefaultRequestHeaders.Add("Accept", "*/*");
        //        client.DefaultRequestHeaders.Add("Accept", "*/*");
        //        client.DefaultRequestHeaders.Add("Pragma", "no-cache");
        //        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
        //        var response = client.PostAsync(urlcheckpointsubmit, null).Result;
        //        var responseString = response.Content.ReadAsStringAsync().Result;
        //        string csrfToken = Regex.Match(responseString, "name=\"csrfToken\" value=\"(.*?)\"").Groups[1].Value;
        //        string ac = Regex.Match(responseString, "name=\"ac\" value=\"(.*?)\"").Groups[1].Value;
        //        string loginCsrfParam = Regex.Match(responseString, "name=\"loginCsrfParam\" value=\"(.*?)\"").Groups[1].Value;
        //        string apfc = Regex.Match(responseString, "name=\"apfc\" value=\"(.*?)\"").Groups[1].Value;
        //        string _d = Regex.Match(responseString, "name=\"_d\" value=\"(.*?)\"").Groups[1].Value;
        //        //string payload = $"csrfToken={csrfToken}&session_key={options.Email}&ac={ac}&sIdString=<sIdString>&parentPageKey=d_checkpoint_lg_consumerLogin&pageInstance=urn%3Ali%3Apage%3Ad_checkpoint_lg_consumerLogin%3BH4kX%2FmdGQjaHdiYTYRYkwg%3D%3D&trk=&authUUID=&session_redirect=&loginCsrfParam={loginCsrfParam}&fp_data=default&apfc={apfc}&_d={_d}&showGoogleOneTapLogin=true&controlId=d_checkpoint_lg_consumerLogin-login_submit_button&session_password=<PASS>";
        //        List<KeyValuePair<string, string>> payload = new List<KeyValuePair<string, string>>()
        //        {
        //            new KeyValuePair<string, string>("csrfToken", csrfToken),
        //            new KeyValuePair<string, string>("session_key", "nguyendactaidn@gmail.com"),
        //            new KeyValuePair<string, string>("ac", ac),
        //            new KeyValuePair<string, string>("sIdString", "sIdString"),
        //            new KeyValuePair<string, string>("parentPageKey", "d_checkpoint_lg_consumerLogin"),
        //            new KeyValuePair<string, string>("pageInstance", "urn%3Ali%3Apage%3Ad_checkpoint_lg_consumerLogin%3BH4kX%2FmdGQjaHdiYTYRYkwg%3D%3D"),
        //            new KeyValuePair<string, string>("trk", ""),
        //            new KeyValuePair<string, string>("authUUID", ""),
        //            new KeyValuePair<string, string>("session_redirect", ""),
        //            new KeyValuePair<string, string>("loginCsrfParam", loginCsrfParam),
        //            new KeyValuePair<string, string>("fp_data", "default"),
        //            new KeyValuePair<string, string>("apfc", apfc),
        //            new KeyValuePair<string, string>("_d", _d),
        //            new KeyValuePair<string, string>("showGoogleOneTapLogin", "true"),
        //            new KeyValuePair<string, string>("controlId", "d_checkpoint_lg_consumerLogin-login_submit_button"),
        //            new KeyValuePair<string, string>("session_password", "PASS")
        //        };
        //        BuildPerfectHeaderLoginCheckpointSubmit(client, response.RequestMessage.RequestUri.ToString());
        //        response = client.PostAsync(urlcheckpointsubmit, new FormUrlEncodedContent(payload)).Result;
        //        responseString = response.Content.ReadAsStringAsync().Result;
        //        if (string.IsNullOrEmpty(responseString))
        //        {
        //            //result.StatusCode = Enums.LinkedinAPIExecuteStatusCode.Error;
        //            goto EndPoint;
        //        }
        //        if (responseString.Contains("Wrong email or password. Try again or <span data-tracking-control-name=\\\"login_error_create_account\\"))
        //        {
        //            //result.CheckpointEmailStatus = Enums.CheckpointEmailStatusCode.Success;
        //        }
        //        else if (responseString.Contains("checkpoint/challenge/funCaptchaInternal"))
        //        {
        //            //result.CheckpointEmailStatus = Enums.CheckpointEmailStatusCode.Captcha;
        //        }
        //        else
        //        {
        //            //result.StatusCode = Enums.LinkedinAPIExecuteStatusCode.Error;
        //            //result.CheckpointEmailStatus = Enums.CheckpointEmailStatusCode.Nothing;
        //        }
        //    EndPoint:;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}
        //private void BuildPerfectHeaderLoginCheckpointSubmit(HttpClient httpRequest, string referer)
        //{
        //    httpRequest.DefaultRequestHeaders.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
        //    httpRequest.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
        //    httpRequest.DefaultRequestHeaders.Add("cache-control", "max-age=0");
        //    httpRequest.DefaultRequestHeaders.Add("origin", "https://www.linkedin.com");
        //    httpRequest.DefaultRequestHeaders.Add("referer", referer);
        //    httpRequest.DefaultRequestHeaders.Add("sec-ch-ua", "\"Microsoft Edge\";v=\"93\", \" Not;A Brand\";v=\"99\", \"Chromium\";v=\"93\"");
        //    httpRequest.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
        //    httpRequest.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
        //    httpRequest.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
        //    httpRequest.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
        //    httpRequest.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
        //    httpRequest.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
        //    httpRequest.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");
        //    httpRequest.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.82 Safari/537.36 Edg/93.0.961.52");
        //}
    }
}
