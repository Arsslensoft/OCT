using Al.Security.CA;

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Verification.Verify
{
  public class BasicVerifier : IVerifier
    {
        List<VerifierMessage> _msg = new List<VerifierMessage>();
       public List<VerifierMessage> Messages
        {
            get { return _msg; }
        }
        public bool Verify(bool ca, bool critca, bool critkey, List<X509KeyUsages> usages, bool ocsp)
        {
            _msg.Clear();
               // BASIC / USAGE
            if (ca && !critca)
                _msg.Add(new VerifierMessage(ErrorMessages.CACriticalError, "Basic Verifier", MessageType.Warning));
      if(!critkey && ca)
          _msg.Add(new VerifierMessage(ErrorMessages.KeyUsageCriticalError, "Basic Verifier", MessageType.Warning));

        if(!usages.Contains(X509KeyUsages.digitalSignature) && ocsp)
            _msg.Add(new VerifierMessage(ErrorMessages.OCSPError, "Basic Verifier", MessageType.Warning));

            if(!usages.Contains(X509KeyUsages.cRLSign) || !usages.Contains(X509KeyUsages.keyCertSign))
                _msg.Add(new VerifierMessage(ErrorMessages.KeyUError, "Basic Verifier", MessageType.Warning));

            return (_msg.Count == 0);
        }

    }
}
