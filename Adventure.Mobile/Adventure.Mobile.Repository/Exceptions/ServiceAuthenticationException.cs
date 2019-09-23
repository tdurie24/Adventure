using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Mobile.Repository.Exceptions
{
    public class ServiceAuthenticationException : Exception
    {
        public string Content { get; set; }
        public ServiceAuthenticationException(string content)
        {
            Content = content;
        }
    }
}
