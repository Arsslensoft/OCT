using System;
using System.Collections.Generic;
using System.Text;

namespace OCAID
{
    public enum IssuerType : byte
    { 
        Unknown = 0,
        Individual = 1,
        Foundation = 2,
        Organisation = 3,
        Corporation = 4,
        Enterprise = 5,
        NonProfit = 6,
        Research = 7,
        Other = 8
    }
    public enum ApplicationType : byte
    {
        Unknown = 0,
        FreeIssuer = 1,
        PaidIssuer = 2,
        MixedIssuer = 3,
        PersonalIssuer = 4,
        Other = 5
    }
    public enum ISOCountryCode
    {
        AF,
        AX,
        AL,
        DZ,
        AS,
        AD,
        AO,
        AI,
        AQ,
        AG,
        AR,
        AM,
        AW,
        AU,
        AT,
        AZ,
        BS,
        BH,
        BD,
        BB,
        BY,
        BE,
        BZ,
        BJ,
        BM,
        BT,
        BO,
        BA,
        BW,
        BV,
        BR,
        IO,
        BN,
        BG,
        BF,
        BI,
        KH,
        CM,
        CA,
        CV,
        KY,
        CF,
        TD,
        CL,
        CN,
        CX,
        CC,
        CO,
        KM,
        CG,
        CD,
        CK,
        CR,
        CI,
        HR,
        CU,
        CY,
        CZ,
        DK,
        DJ,
        DM,
        DO,
        EC,
        EG,
        SV,
        GQ,
        ER,
        EE,
        ET,
        FK,
        FO,
        FJ,
        FI,
        FR,
        GF,
        PF,
        TF,
        GA,
        GM,
        GE,
        DE,
        GH,
        GI,
        GR,
        GL,
        GD,
        GP,
        GU,
        GT,
        GG,
        GN,
        GW,
        GY,
        HT,
        HM,
        VA,
        HN,
        HK,
        HU,
        IS,
        IN,
        ID,
        IR,
        IQ,
        IE,
        IM,
        IL,
        IT,
        JM,
        JP,
        JE,
        JO,
        KZ,
        KE,
        KI,
        KP,
        KR,
        KW,
        KG,
        LA,
        LV,
        LB,
        LS,
        LR,
        LY,
        LI,
        LT,
        LU,
        MO,
        MK,
        MG,
        MW,
        MY,
        MV,
        ML,
        MT,
        MH,
        MQ,
        MR,
        MU,
        YT,
        MX,
        FM,
        MD,
        MC,
        MN,
        ME,
        MS,
        MA,
        MZ,
        MM,
        NA,
        NR,
        NP,
        NL,
        AN,
        NC,
        NZ,
        NI,
        NE,
        NG,
        NU,
        NF,
        MP,
        NO,
        OM,
        PK,
        PW,
        PS,
        PA,
        PG,
        PY,
        PE,
        PH,
        PN,
        PL,
        PT,
        PR,
        QA,
        RE,
        RO,
        RU,
        RW,
        SH,
        KN,
        LC,
        PM,
        VC,
        WS,
        SM,
        ST,
        SA,
        SN,
        RS,
        SC,
        SL,
        SG,
        SK,
        SI,
        SB,
        SO,
        ZA,
        GS,
        ES,
        LK,
        SD,
        SR,
        SJ,
        SZ,
        SE,
        CH,
        SY,
        TW,
        TJ,
        TZ,
        TH,
        TL,
        TG,
        TK,
        TO,
        TT,
        TN,
        TR,
        TM,
        TC,
        TV,
        UG,
        UA,
        AE,
        GB,
        US,
        UM,
        UY,
        UZ,
        VU,
        VE,
        VN,
        VG,
        VI,
        WF,
        EH,
        YE,
        ZM,
        ZW,
        Unknown
    }
    /// <summary>
    /// Origisign Certificate Issuance Authority Identifier AS-OD-CA01  (Arsslensoft-Official Document CA01)
    /// </summary>
  public class OCIAID
    {

      public OCIAID(bool asid, IssuerType isstype, ApplicationType apptype, ISOCountryCode country, ulong id)
      {
          ArsslensoftAssigned = asid;
          IssuanceType = isstype;
          Application = apptype;
          Country = country;
          Identifier = id;
      }

      public bool ArsslensoftAssigned { get; set; }
      public IssuerType IssuanceType { get; set; }
      public ApplicationType Application { get; set; }
      public ISOCountryCode Country {get;set;}
      public ulong Identifier { get; set; }
      public static OCIAID Parse(string ociaid)
      {
          string[] oid = ociaid.Split('-');
          string org = oid[0];
          bool asid = false;
          if (org == "AS-OCIAID")
              asid = true;

          IssuerType it =  IssuerType.Unknown;
          if (Enum.IsDefined(typeof(IssuerType), oid[1]))
              it = (IssuerType)Enum.Parse(typeof(IssuerType), oid[1]);

          ApplicationType app = ApplicationType.Unknown;
          if (Enum.IsDefined(typeof(ApplicationType), oid[2]))
              app = (ApplicationType)Enum.Parse(typeof(ApplicationType), oid[2]);

          ISOCountryCode country = ISOCountryCode.Unknown;
          if (Enum.IsDefined(typeof(ISOCountryCode), oid[3]))
              country = (ISOCountryCode)Enum.Parse(typeof(ISOCountryCode), oid[3]);

          ulong id = ulong.Parse(oid[4]);
          return new OCIAID(asid, it, app, country, id);
      }

      public override string ToString()
      {
          string id = "AS-OCIAID";
          if (ArsslensoftAssigned)
              id = "AS-Origisign";

          int it = (int)IssuanceType;
          int app = (int)Application;
          string cc = Country.ToString();
          if (Country == ISOCountryCode.Unknown)
              cc = "UN";
              
         return id +"-"+it.ToString()+"-"+app.ToString()+"-"+cc+"-"+Identifier.ToString();
      }

    }
}
