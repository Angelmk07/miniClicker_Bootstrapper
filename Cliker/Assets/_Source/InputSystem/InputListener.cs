using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode ExitK;
        private Game game;
        public void Construct(Game game)
        {
            this.game = game;
        }
        void Update()
        {
            ListenExitApp();
        }
        private void ListenExitApp()
        {
            if (Input.GetKeyDown(ExitK))
            {
                game.FinishGame();
            }

        }
    }

}

