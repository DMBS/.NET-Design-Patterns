using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTSexam
{
    public class General : IELTS
    {
        protected override void Reading()
        {
            Console.WriteLine("Start reading <General> part");
            _readingScore = GetFakeScore();
        }

        protected override void Writing()
        {
            Console.WriteLine("Start writing <General> part");
            _writingScore = GetFakeScore();
        }
    }
}
