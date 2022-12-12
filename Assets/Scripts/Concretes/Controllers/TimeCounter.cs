using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UdemyCourse2.UIs
{
    public class TimeCounter : MonoBehaviour
    {
        TMP_Text _textMesh;
        float _currentTime;
        private void Awake()
        {
            _textMesh= GetComponent<TMP_Text>();
            _currentTime = 0f;
        }
        void Update()
        {
            _currentTime += Time.deltaTime;
            _textMesh.text = _currentTime.ToString("0");
        }
    }

}
