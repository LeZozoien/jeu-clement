using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public Gradient gradient;
    public Image fill;

    // reinitialiser la vie a chaque lancement de jeu //
    public void SetMaxHeath(int heath)
    {
        slider.maxValue = heath;
        slider.value = heath;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int heath)
    {
        slider.value = heath;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
