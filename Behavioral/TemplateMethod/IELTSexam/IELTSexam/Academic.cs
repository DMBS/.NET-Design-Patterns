using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTSexam
{
    public class Academic : IELTS
    {
        protected override void Reading()
        {
            Console.WriteLine("Start reading <Academic> part");
            _readingScore = GetFakeScore();
        }

        protected override void Writing()
        {
            Console.WriteLine("Start writing <Academic> part");
            _writingScore = GetFakeScore();
        }
    }
}
