using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCT
{
  public  class Log
    {
      static bool Debug = true;
      public static void LogEx(Exception ex)
      {

      }
      public static void ShowInfo(string text, string title)
      {
          MessageBoxEx.Show(text, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
      }
      public static void ShowError(string text, string title)
      {
          MessageBoxEx.Show(text, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
      }
      public static void ShowWarn(string text, string title)
      {
          MessageBoxEx.Show(text, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
      }
      public static void ShowOperationFailed(Exception ex, string title)
      {
          if(Debug)
          MessageBoxEx.Show(ex.Message + Environment.NewLine + ex.StackTrace, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
          else
              MessageBoxEx.Show(ex.Message, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

          LogEx(ex);
      }
    }
}
