using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.ServicesImplementation;

namespace KnockService.Controllers
{
    /// <summary>
    /// Implementation of Knock Knock Service
    /// </summary>
    [RoutePrefix("api")]
    public class ServiceController : ApiController
    {
        /// <summary>
        /// Gives you the nth number in Fibonacci series
        /// </summary>
        /// <param name="n">required nth number in Fibonacci series</param>
        /// <returns>nth number of Fibonacci series</returns>
        [HttpGet]
        [Route("Fibonacci/{n=n}")]
        public HttpResponseMessage Fibbonaci(long n)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, Implementation.CalculateFibonacci(n));
            }
            catch(OverflowException ovf)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "no content");
            }
        }

        /// <summary>
        /// Gives the type of triangle based on the sides
        /// </summary>
        /// <param name="a">side1</param>
        /// <param name="b">side2</param>
        /// <param name="c">side3</param>
        /// <returns>Type of the triangle</returns>
        [HttpGet]
        [Route("TriangleType/{a=a}/{b=b}/{c=c}")]
        public HttpResponseMessage TriangleType(int a, int b, int c)
        {
            return Request.CreateResponse(HttpStatusCode.OK, Implementation.GetTypeOfTriangle(a, b, c));
        }

        /// <summary>
        /// Gives the candidate's unique id
        /// </summary>
        /// <returns>Candidate's assigned unique ID</returns>
        [HttpGet]
        [Route("Token")]
        public HttpResponseMessage Token()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Implementation.GetToken());
        }

        /// <summary>
        /// Gives the reversed words in the sentence
        /// </summary>
        /// <param name="sentence">Sentence to reverese words</param>
        /// <returns>Reversed words in the sentence</returns>
        [HttpGet]
        [Route("ReverseWords/{sentence?}")]
        public HttpResponseMessage ReverseWords(string sentence = "")
        {
            return Request.CreateResponse(HttpStatusCode.OK, Implementation.GetReversedWords(sentence));
        }
    }
}
