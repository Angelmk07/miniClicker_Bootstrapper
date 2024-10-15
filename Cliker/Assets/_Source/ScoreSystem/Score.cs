using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScoreSystem
{
    public class Score
    {
        public Action ScoreChange;
        public int ScoreValue { get; private set; }
        public void ReplayceScore(int val)
        {
            ScoreValue = val;
            ScoreChange?.Invoke();
        }
        public void ChangeScore(int val)
        {
            ScoreValue += val;
            ScoreChange?.Invoke();
        }
        public void Substruct(int val)
        {
            ScoreValue -= val;
            ScoreChange?.Invoke();
        }
    }
}

