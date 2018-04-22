using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace VectorFontEditor
{
  public class FontFile
  {
    private string _path = null;
    private List<CharSpecification> _characters = null;

    public FontFile(string path)
    {
      _path = path;
      Load();
    }

    public void Load()
    {
      if (File.Exists(_path))
      {
        using (StreamReader sr = File.OpenText(_path))
        {
          _characters = JsonConvert.DeserializeObject<List<CharSpecification>>(sr.ReadToEnd());
        }
      }
      else _characters = new List<CharSpecification>();
    }

    public void Save()
    {
      if (File.Exists(_path)) File.Delete(_path);

      using (StreamWriter sw = File.CreateText(_path))
      {
        sw.Write(JsonConvert.SerializeObject(_characters));
      }
    }

    public void SaveCharacter(char character, List<FontLine> lines)
    {
      CharSpecification spec = null;

      foreach (CharSpecification existing in _characters)
      {
        if (existing.Character == character)
        {
          spec = existing;
          break;
        }
      }

      if (spec == null)
      {
        spec = new CharSpecification();
        spec.Character = character;
        _characters.Add(spec);
      }

      spec.Lines = new List<FontLine>();

      foreach (FontLine line in lines)
      {
        spec.Lines.Add(line.Copy());
      }
    }

    public List<FontLine> LoadCharacter(char character)
    {
      List<FontLine> ret = new List<FontLine>();

      foreach (CharSpecification existing in _characters)
      {
        if (existing.Character == character)
        {

          foreach (FontLine line in existing.Lines)
          {
            ret.Add(line.Copy());
          }
          break;
        }
      }

      return ret;
    }

    internal class CharSpecification
    {
      public char Character;
      public List<FontLine> Lines;
    }
  }
}
