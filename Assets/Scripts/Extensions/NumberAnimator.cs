using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Extensions
{
    public class NumberAnimator : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private float _duration = 1f;

        public void AnimateNumber(int additive)
        {
            StartCoroutine(Animate(additive));
        }

        private IEnumerator Animate(int additive)
        {
            var elapsed = 0f;
            var from = Convert.ToInt32(_text.text);
            var to = from + additive;

            while (elapsed < _duration)
            {
                elapsed += Time.deltaTime;
                var t = Mathf.Clamp01(elapsed / _duration);
                var value = Mathf.RoundToInt(Mathf.Lerp(from, to, t));
                _text.text = value.ToString();
                
                yield return null;
            }
        }
    }
}