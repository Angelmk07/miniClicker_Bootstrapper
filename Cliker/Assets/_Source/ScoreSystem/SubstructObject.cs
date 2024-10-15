using ScoreSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScoreSystem
{
    public class SubstructObject : MonoBehaviour
    {
        [SerializeField] private int _subVal = 1;
        public static Action<int> SubObjClick;
        private void OnMouseDown()
        {
            SubObjClick?.Invoke(-Math.Abs(_subVal));
        }

    }
}

