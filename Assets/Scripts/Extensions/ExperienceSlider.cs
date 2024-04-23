using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _experience;

    public void SetValue(int value)
    {
        _slider.value = value;
        _experience.text = _slider.value + "/" + _slider.maxValue;
    }
}
