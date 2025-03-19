using Extensions;
using UnityEngine;
using Random = UnityEngine.Random;

namespace LuckySpin
{
    public class Roulette : MonoBehaviour
    {
        [SerializeField] 
        private Animator _wheelAnimator;
    
        [SerializeField]
        private Range _animationDurationRange;

        [SerializeField] 
        private Range _animationSpeedMultiplierRange;

        private float _speedMultiplier;
        private float _currentSpeedMultiplier;
        private float _animationDuration;
        private float _elapsedTime;
        private static readonly int SpeedMultiplier = Animator.StringToHash("speedMultiplier");

        public void StartRotateWheel()
        {
            _elapsedTime = 0;
            _speedMultiplier = Random.Range(_animationSpeedMultiplierRange.Min, _animationSpeedMultiplierRange.Max);
            _currentSpeedMultiplier = _speedMultiplier;
            
            _animationDuration = Random.Range(_animationDurationRange.Min, _animationDurationRange.Max);
        
            _wheelAnimator.SetFloat(SpeedMultiplier, _currentSpeedMultiplier);
        }

        private void Update()
        {
            if (_currentSpeedMultiplier <= 0)
            {
                return;
            }

            _elapsedTime += Time.deltaTime;
            _currentSpeedMultiplier = Mathf.Lerp(_speedMultiplier, 0, _elapsedTime / _animationDuration);
        
            _wheelAnimator.SetFloat(SpeedMultiplier, _currentSpeedMultiplier);
        }
    }
}