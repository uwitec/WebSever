﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WebServer.HttpServer;

namespace WebServer.HttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer test = new HttpServer(80, IPAddress.Any);
            HttpServer.baes_path = "Resources";
            HttpServer.HTTP_PROTOCOL_VERSION = "HTTP/1.1";

            Console.WriteLine(
                "Web Server 工作在 本地: {0}端口",
                HttpServer.server_port);
            test.Listen();
        }
    }
}
