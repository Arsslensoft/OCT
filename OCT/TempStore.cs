using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OCT
{
  public  class TempStore
    {
      public static string StoreLocation = Application.StartupPath + @"\STORE\";
      public static string CALocation = StoreLocation + @"CA\";
      public static string CSRLocation = StoreLocation + @"CSR\";
      public static string UserLocation = StoreLocation + @"USER\";
      public static string StoreFile = Application.StartupPath + @"\STORE.odat";

      public static void AddCertificate(string file)
      {
          try
          {
              using (StreamWriter str = new StreamWriter(StoreFile, true))
                  str.WriteLine(file);
          }
          catch (Exception ex)
          {
              Log.LogEx(ex);
          }
      }


    }
}
