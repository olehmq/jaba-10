using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    public interface IWordGame
    {
        bool GuessWord(string word);
        string GetHint();
    }
    public class WordGame : IWordGame
    {
        private readonly string _secretWord;
        private readonly string[] _hints;

        public WordGame(string secretWord, string[] hints)
        {
            _secretWord = secretWord;
            _hints = hints;
        }

        public bool GuessWord(string word)
        {
            return string.Equals(word, _secretWord, StringComparison.OrdinalIgnoreCase);
        }

        public string GetHint()
        {
            return _hints[new Random().Next(0, _hints.Length)];
        }
    }
    public class WordGameProxy : IWordGame
    {
        private readonly IWordGame _wordGame;

        public WordGameProxy(IWordGame wordGame)
        {
            _wordGame = wordGame;
        }
        public bool GuessWord(string word)
        {
            return _wordGame.GuessWord(word);
        }
        public string GetHint()
        {
            return _wordGame.GetHint();
        }
    }
}

