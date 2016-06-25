using Al.Security.CA;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Verification
{
    public enum MessageType
    {
       Error,
       Warning,
       Information
    }
    public struct VerifierMessage
    {
        string _msg;
        public string Message { get { return _msg; } }
        MessageType _msgtype;
        public MessageType MessageType { get { return _msgtype; } }

        string _src;
        public string Source { get { return _src; } }

        public VerifierMessage(string msg, string src, MessageType msgt)
        {
            _src = src;
            _msg = msg;
            _msgtype = msgt;
        }
    }
    public interface IVerifier
    {
        List<VerifierMessage> Messages { get; }

    }
}
