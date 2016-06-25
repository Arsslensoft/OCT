using System;
using System.Collections.Generic;
using System.Text;

namespace Verification
{
   public class ErrorMessages
   {
       public static string MD5Error = "APKI001: MD5 Signature Algorithm is weak. Use a more secure strong algorithm";
       public static string SHA1Error = "APKI002: SHA1 Signature Algorithm is good. we suggest to use SHA-256, SHA-384 or SHA-512 or Elliptic Curve using NIST P-256, P-384, or P-521.";
       public static string KEYSIZEError = "APKI003: {0} Key Size is too weak .Use a Strong Key Size 2048+";
       public static string KeyAlgorithm ="APKI004: {0} it could not work. Recommanded 2048+ bits RSA.";


       public static string CACriticalError = "APKI005: basicConstraints must be set as critical when the CA field is set to true.";
       public static string KeyUsageCriticalError = "APKI006: keyusage must be set as critical when the CA field is set to true.";
       public static string KeyUError = "APKI007: Key Usage must include keyCertSign, cRLSign when the CA field is set to true.";
       public static string OCSPError = "APKI008: Key Usage must include digitalSignature when the OCSP Signing is enabled.";


       // EV Validator
     

       /*
       // POLICY / AIA / CRL
       public static string PolicyError = "APKI010: certificatePolicies extension should not be marked as critical.";
       public static string PolicyOIDRequired = "APKI010: certificatePolicies extension must be present. A Policy Identifier, defined by the issuing CA, that indicates a Certificate Policy asserting the issuing CA’s adherence to and compliance with these Requirements.The following extensions MAY be present: certificatePolicies:policyQualifiers:policyQualifierId (Recommended)";
       public static string CPSURINote = "APKI011: HTTP URL for the Subordinate CA’s Certification Practice Statement, Relying Party Agreement or other pointer to online information provided by the CA.";
       public static string CRLCriticalError = "APKI012: cRLDistributionPoints extension MUST NOT be marked critical, and it MUST contain the HTTP URL of the CA’s CRL service.  See Section 13.2.1 for details";
       public static string AIAError = "APKI013: authorityInformationAccess (AIA) Extension MUST BE present";
       public static string AIACriticalError = "APKI014: AIA MUST NOT be marked critical";
       public static string AIAOCSPError = "APKI015: AIA MUST contain the HTTP URL of the Issuing CA’s OCSP responder (accessMethod = 1.3.6.1.5.5.7.48.1).";
       public static string AIAISSUERError = "APKI016: AIA SHOULD also contain the HTTP URL of the Issuing CA’s certificate (accessMethod = 1.3.6.1.5.5.7.48.2).";


       // SUBJECT ALT NAME
       public static string SANError = "APKI021: Subject Alt Name is required.";
      
       
       public static string SANote = "APKI022: MUST contain at least one entry. Each entry MUST be either a dNSName containing the Fully-Qualified Domain Name or an iPAddress containing the IP address of a server. The CA MUST confirm that Forum Guideline CA / Browser Forum Baseline Requirements, v. 1.1.9 (as of 4 August 2014) 10 the Applicant controls the Fully-Qualified Domain Name or IP address or has been granted the right to use it by the Domain Name Registrant or IP address assignee, as appropriate. Wildcard FQDNs are permitted. As of the Effective Date of these Requirements, prior to the issuance of a Certificate with a subjectAlternativeName extension or Subject commonName field containing a Reserved IP Address or Internal Name, the CA SHALL notify the Applicant that the use of such Certificates has been deprecated by the CA / Browser Forum and that the practice will be eliminated by October 2016. Also as of the Effective Date, the CA SHALL NOT issue a certificate with an Expiry Date later than 1 November 2015 with a subjectAlternativeName extension or Subject commonName field containing a Reserved IP Address or Internal Name. Effective 1 October 2016, CAs SHALL revoke all unexpired Certificates whose subjectAlternativeName extension or Subject commonName field contains a Reserved IP Address or Internal Name. ";
       public static string AIANote = "APKI017: See Section 13.2.1 for details. The HTTP URL of the Issuing CA’s OCSP responder MAY be omitted provided that the Subscriber “staples” OCSP responses for the Certificate in its TLS handshakes [RFC4366].";
       public static string AllCertNote = "APKI009: CA shall not issue Certificates containing a keyUsage flag, extendedKeyUsage value, Certificate extension, or other data not specified unless the CA is aware of a reason for including the data in the Certificate. CAs SHALL NOT issue a Certificate with: (a)     Extensions that do not apply in the context of the public Internet (such as an extendedKeyUsage value for a service that is only valid in the context of a privately managed network), unless: i. such value falls within an OID arc for which the Applicant demonstrates ownership, or ii. the Applicant can otherwise demonstrate the right to assert the data in a public context; or (b)     semantics that, if included, will mislead a Relying Party about the certificate information verified by the CA (such as including extendedKeyUsage value for a smart card, where the CA is not able to verify that the corresponding Private Key is confined to such hardware due to remote issuance).";
       public static string[] IssuerNotes = new string[]
       {
           "APKI018: Issuer Common Name field MUST include a name that accurately identifies the Issuing CA.",
           "APKI019: Issuer Domain Component Field MUST include all components of the Issuing CA’s Registered Domain Name in ordered sequence, with the most significant component, closest to the root of the namespace, written last. ",
         // required
           "APKI020: Issuer Organization Name Field MUST contain the name (or abbreviation thereof), trademark, or other meaningful identifier for the CA, provided that they accurately identify the CA. The field MUST NOT contain a generic designation such as “Root” or “CA1”.",
           "APKI021: "

       };*/

    }
}
