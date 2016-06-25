using Al.Security.CA;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Verification.Verify
{
public class KeyVerifier : IVerifier
    {
    List<VerifierMessage> _msg = new List<VerifierMessage>();
    public List<VerifierMessage> Messages
    {
        get { return _msg; }
    }
    public bool Verify(int keysize, string sigalg, string keyalg)
    {
        _msg.Clear();
      

        if (sigalg.ToLower().Contains("md5"))
            _msg.Add(new VerifierMessage(ErrorMessages.MD5Error, "Key Verification", MessageType.Warning));


        if (sigalg.ToLower().Contains("sha1"))
            _msg.Add(new VerifierMessage(ErrorMessages.SHA1Error, "Key Verification", MessageType.Warning));

        if(keysize < 2048)
            _msg.Add(new VerifierMessage(string.Format(ErrorMessages.KEYSIZEError, keysize), "Key Verification", MessageType.Warning));

        if (!keyalg.ToLower().Contains("rsa"))
            _msg.Add(new VerifierMessage(string.Format(ErrorMessages.KeyAlgorithm,keyalg), "Key Verification", MessageType.Warning));

        return (_msg.Count == 0);
    }


    }
}
