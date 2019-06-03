using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using DotNetNuke.Web.Api;

// local.barnensbibliotek.nu/DesktopModules/MyServices/API/Quiz/QuizEngine?test=Nytt

namespace MyServices
{
    public class QuizController : DnnApiController
    {
        [AllowAnonymous] 
        [HttpGet]
        public HttpResponseMessage quiztest()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World!quiz");
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage QuizEngine(string test)
        {
            
            var testar = new quizInfo();
            testar.Quizid = 12;
            testar.QuizNamn = test;
            
            var resp = new HttpResponseMessage();           
            resp = Request.CreateResponse(HttpStatusCode.OK, testar);
            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return resp;
        }
    }
}
