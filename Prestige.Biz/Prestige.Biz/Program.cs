using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
  class Program
  {
    public const int ConstantNumber = 100;
    public static readonly int ReadOnlyNumber = 0;

    static Program()
    {
      ReadOnlyNumber = 009;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(ConstantNumber);
      Console.WriteLine(ReadOnlyNumber);
    }
  }
}
