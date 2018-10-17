using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new parsaspace.netcore.v1("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6InNhZWlkbWFyb3VmaTY2QGdtYWlsLmNvbSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvdXNlcmRhdGEiOiI0MDQzIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy92ZXJzaW9uIjoiMiIsIm5ld0NsYWltIjpbInJlZnJlc2hUb2tlbiIsInJlZnJlc2hUb2tlbiJdLCJpc3MiOiJodHRwOi8vYXBpLnBhcnNhc3BhY2UuY29tLyIsImF1ZCI6IkFueSIsImV4cCI6MTU3MDY5MDk4NywibmJmIjoxNTM5MTU0OTg3fQ.WlcUbj_xGVpkyEU8Xf--GzFg_FPGJyHbCgAjk8kZfX8");
             var ss = s.UploadFile("saeid1.parsaspace.com", "/", @"F:\tci.txt");

        }
    }
}
