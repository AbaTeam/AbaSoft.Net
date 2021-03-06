﻿using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace AbaSoft.Net
{
    public interface IHttpRequest
    {
        string HttpMethod { get; }

        Uri Url { get; }

        Stream InputStream { get; }

        long ContentLength64 { get; }

        NameValueCollection Headers { get; }

        NameValueCollection QueryString { get; }

        void AddHeader(string a_name, string a_value);

        Guid RequestTraceIdentifier { get; }
    }
}
