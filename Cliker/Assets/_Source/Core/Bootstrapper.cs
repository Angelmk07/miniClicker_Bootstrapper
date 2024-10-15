using InputSystem;
using ScoreSystem;
using ShowForPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener Listener;
        [SerializeField] private ShowScore _ScoreShow;
        private Game _game;
        private Score _score;
        private void OnEnable()
        {
            SubstructObject.SubObjClick += _score.ChangeScore;
            AddScoreObject.AddObjClick += _score.ChangeScore;
        }
        private void OnDisable()
        {
            SubstructObject.SubObjClick -= _score.ChangeScore;
            AddScoreObject.AddObjClick -= _score.ChangeScore;
        }
        void Awake()
        {
            _score = new();
            _game = new(_score, _ScoreShow);
            Listener.Construct(_game);
            _ScoreShow.Construct(_score);

            _game.StartGame();
        }
    }
}