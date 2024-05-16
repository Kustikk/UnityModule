using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class character : MonoBehaviour
{
    [SerializeField]
    protected float health = 100;
  
    protected float healthmax = 100;

    public Action<float, float> isDamage;

    public void SetDamage(float value)
    {
        health -= value;

        isDamage?.Invoke(health, healthmax);
    }
}
