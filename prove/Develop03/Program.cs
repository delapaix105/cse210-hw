using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load scriptures from a file
            List<Scripture> scriptures = LoadScriptures("scriptures.txt");
            
            Random random = new Random();
            while (scriptures.Count > 0)
            {
                // Select a random scripture
                int index = random.Next(scriptures.Count);
                Scripture scripture = scriptures[index];
                scriptures.RemoveAt(index);

                Console.Clear();
                scripture.Display();
                
                while (true)
                {
                    Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        return;
                    }

                    scripture.HideWords();
                    Console.Clear();
                    scripture.Display();

                    if (scripture.AllWordsHidden())
                    {
                        Console.WriteLine("\nAll words are hidden! Moving to the next scripture.");
                        break;
                    }
                }
            }

            Console.WriteLine("All scriptures are done!");
        }

        static List<Scripture> LoadScriptures(string filePath)
        {
            List<Scripture> scriptures = new List<Scripture>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    scriptures.Add(new Scripture(new Reference(parts[0]), parts[1]));
                }
            }
            return scriptures;
        }
    }

    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void Display()
        {
            Console.WriteLine($"{_reference}\n");
            foreach (var word in _words)
            {
                Console.Write(word.Display() + " ");
            }
            Console.WriteLine();
        }

        public void HideWords()
        {
            Random random = new Random();
            int count = _words.Count(w => !w.IsHidden);
            if (count > 0)
            {
                int toHide = random.Next(1, Math.Min(4, count + 1));
                for (int i = 0; i < toHide; i++)
                {
                    List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();
                    if (visibleWords.Count == 0) break;
                    visibleWords[random.Next(visibleWords.Count)].Hide();
                }
            }
        }

        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }
    }

    class Reference
    {
        private string _book;
        private string _chapterVerse;

        public Reference(string reference)
        {
            var parts = reference.Split(' ');
            _book = parts[0];
            _chapterVerse = parts[1];
        }

        public override string ToString()
        {
            return $"{_book} {_chapterVerse}";
        }
    }

    class Word
    {
        private string _text;
        private bool _isHidden;

        public bool IsHidden => _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public string Display()
        {
            return _isHidden ? "_____" : _text;
        }
    }
}
