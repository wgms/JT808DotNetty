﻿using JT808.DotNetty.Core;
using JT808.DotNetty.Core.Handlers;
using JT808.DotNetty.Core.Metadata;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.DotNetty.SimpleServer.Handlers
{
    public class JT808MsgIdTcpSimpleHandler : JT808MsgIdTcpHandlerBase
    {
        public JT808MsgIdTcpSimpleHandler(
            ILoggerFactory loggerFactory,
            JT808TcpSessionManager sessionManager) : base(sessionManager)
        {
            logger = loggerFactory.CreateLogger<JT808MsgIdTcpSimpleHandler>();
        }

        private readonly ILogger<JT808MsgIdTcpSimpleHandler> logger;

        public override JT808Response Msg0x0200(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0200");
            return base.Msg0x0200(request);
        }

        public override JT808Response Msg0x0001(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0001");
            return base.Msg0x0001(request);
        }

        public override JT808Response Msg0x0002(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0002");
            return base.Msg0x0002(request);
        }

        public override JT808Response Msg0x0003(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0003");
            return base.Msg0x0003(request);
        }

        public override JT808Response Msg0x0100(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0100");
            return base.Msg0x0100(request);
        }

        public override JT808Response Msg0x0102(JT808Request request)
        {
            logger.LogDebug("Tcp_Msg0x0102");
            return base.Msg0x0102(request);
        }
    }
}
