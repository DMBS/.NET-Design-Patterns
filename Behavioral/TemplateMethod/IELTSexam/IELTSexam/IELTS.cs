using System;

namespace IELTSexam
{
    public abstract class IELTS
    {

        protected decimal _readingScore, _listeningScore, _speakingScore, _writingScore;

        /// <summary>
        /// Ctor
        /// </summary>
        public IELTS() { }

        protected abstract void Reading();
        protected abstract void Writing();

        protected void Listening()
        {
            Console.WriteLine("Start listening part");
            Console.WriteLine("It is a common part");
            _listeningScore = GetFakeScore();
        }
        protected void Speaking()
        {
            Console.WriteLine("Start speaking part");
            Console.WriteLine("It is a common part");
            _speakingScore = GetFakeScore();
        }

        public void StartTest()
        {
            Reading();
            Listening();
            Writing();
            Speaking();
        }

        public void GetFinalOverallBand()
        {
            var overallBand = (_readingScore + _listeningScore + _speakingScore + _writingScore) / 4;
            var result = Math.Round(overallBand * 2, MidpointRounding.AwayFromZero) / 2;
            Console.WriteLine("Your overall score is: {0}", result);
        }

        protected decimal GetFakeScore()
        {
            var rand = new Random();
            var score = rand.Next(1, 9) + 0.5M;
            return score;
        }
    }
}
