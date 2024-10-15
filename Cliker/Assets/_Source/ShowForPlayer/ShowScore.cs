using ScoreSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace ShowForPlayer
{
    public class ShowScore : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        private Score score;
        public void Construct(Score score)
        {
            this.score = score;
        }

        public void Bind()
        {
            score.ScoreChange += ShowChange;
        }
        public void Expose()
        {
            score.ScoreChange -= ShowChange;
        }
        private void ShowChange()
        {
            _text.text = $"You have {score.ScoreValue}";
        }
    }

}
