﻿using System.Collections.Generic;
using System.Net;

namespace BookingApp.Application.Common.Responses
{
    public class OutputResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Model { get; set; }
        public List<ErrorModel> Errors { get; set; } = new();
    }
}
