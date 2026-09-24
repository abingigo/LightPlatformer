using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.Universal;
/// Only controls the light's visual on/off state -- does NOT touch the
/// BoxCollider2D. LightWithCollider reads IsOn from here and is the single
/// script responsible for the collider, so the two never fight over it.
public class BlinkingLight : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Light2D light2D;
    public bool IsOn { get; private set; } = true;

    void Start()
    {
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            if (IsOn)
            {
                sprite.enabled = false;
                light2D.enabled = false;
                IsOn = false;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                sprite.enabled = true;
                light2D.enabled = true;
                IsOn = true;
                yield return new WaitForSeconds(2f);
            }
        }
    }
}