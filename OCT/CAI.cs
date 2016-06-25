using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace OCT
{
    /*
 name
 oid
 ocaid
 path
    */
  
   public class CAI
    {
       public string CAName { get; set; }
       public string CAOid { get; set; }
       public string OCAID { get; set; }
       public string DevPath { get; set; }

     
       public void Load(string file)
       {
           try
           {
               string[] lines = File.ReadAllLines(file);
               CAName = lines[0];
               CAOid = lines[1];
               OCAID = lines[2];
               DevPath = lines[3];


           } 
           catch
           {

           }
       }

       public void Save(string file)
       {
           using (StreamWriter str = new StreamWriter(file, false))
           {
               str.WriteLine(CAName);
               str.WriteLine(CAOid);
               str.WriteLine(OCAID);
               str.WriteLine(DevPath);
           }
       }

    }
}
