using UnityEngine;
using System;
using System.Collections;

public class BlinkingLight : MonoBehaviour
{

    public BoxCollider2D box;
    public SpriteRenderer sprite;

    private IEnumerator coroutine;

    public void Start()
    {
        StartCoroutine(Blink());
    }

    bool on = true;

    IEnumerator Blink()
    {
        while(true)
        {
            if(on)
            {
                box.enabled = false;
                sprite.enabled = false;
                on = false;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                box.enabled = true;
                sprite.enabled = true;
                on = true;
                yield return new WaitForSeconds(2f);
            }
        }
    }
}
