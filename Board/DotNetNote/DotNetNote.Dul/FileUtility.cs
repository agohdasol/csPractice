﻿using System.IO;

namespace DotNetNote.Dul
{
  public class FileUtility
  {
    public static string GetFileNameWithNumbering(string dir, string name)
    {
      string strName = Path.GetFileNameWithoutExtension(name);
      string strExt = Path.GetExtension(name);
      bool blnExists = true;
      int i = 0;
      while (blnExists)
      {
        if (File.Exists(Path.Combine(dir, name)))
          name = strName + "(" + ++i + ")" + strExt;
        else
          blnExists = false;
      }
      return name;
    }
  }
}