﻿using System.Net;

namespace WebApplication.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessage { get; internal set; }

        public object Result { get; set; }

       

    }
}
