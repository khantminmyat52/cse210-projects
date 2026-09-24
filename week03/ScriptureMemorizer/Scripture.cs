using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // မကွယ်ရသေးသော စာလုံးများကိုသာ သီးသန့် ရှာဖွေစစ်ဆေးသည် (Stretch Challenge)
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // ထပ်မကွယ်မိစေရန် စာရင်းထဲမှ ဖယ်ထုတ်သည်
        }
    }

    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} - {string.Join(" ", wordTexts)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}