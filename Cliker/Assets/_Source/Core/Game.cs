using ScoreSystem;
using ShowForPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Game
    {
        private const int _startScoreValue = 5;
        private const int _exitScoreValue = 0;
        private readonly Score score;
        private readonly ShowScore _scoreShow;

        public Game(Score score,ShowScore showScore)
        {
            this.score = score;
            _scoreShow =showScore;
        }
        
        public void StartGame()
        {
            _scoreShow.Bind();
            score.ReplayceScore(_startScoreValue);
            Debug.Log("start");
        }
        public void FinishGame()
        {
            Debug.Log("End");
            score.ReplayceScore(_exitScoreValue);
            _scoreShow.Expose();
        }
    }

}
