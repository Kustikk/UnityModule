using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class sliderhp : MonoBehaviour
{
    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    void Start()
    {
        Invoke("Initialization", 10f);
        Initialization();
    }

    void Initialization()
    {
        player.instance.isDamage += UpdateHealth;
    }
    void UpdateHealth(float health, float healthMax)
    {
        _slider.value = health;
        _slider.maxValue = healthMax;

        _text.text = $"HP: {health} / {(int)healthMax}";
    }
}
