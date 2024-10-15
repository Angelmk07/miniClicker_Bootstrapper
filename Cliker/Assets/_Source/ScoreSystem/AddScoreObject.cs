using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScoreSystem
{
    public class AddScoreObject : MonoBehaviour
    {
        [SerializeField] private int _addVal = 1;
        public static Action<int> AddObjClick;
        private void OnMouseDown()
        {
            AddObjClick?.Invoke(Math.Abs(_addVal));
        }
    }
}

