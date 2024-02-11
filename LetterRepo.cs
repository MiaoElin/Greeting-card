using System.Collections.Generic;
using System;
public class LetterRepo
{
    List<LetterEntity> all;
    public LetterRepo()
    {
        all = new List<LetterEntity>();
    }
    public void Add(LetterEntity letter)
    {
        all.Add(letter);
    }
    public void Forech(Action<LetterEntity> action)
    {
        all.ForEach(action);
    }
}