using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{

    [Range(0,1)][SerializeField]
    float velocidadFade = 0.35f;

    float alpha = 0f;
    bool fadein = true;

    Image myImage;

    void Awake()
    {
        myImage = gameObject.GetComponent<Image>();
    }

    public void FixedUpdate()
    {
        Color color = myImage.color;

        if (fadein)
        {
            _FadeIn();

        }
        else
        {
            _FadeOut();
        }
        color.a = alpha;
        myImage.color = color;
    }

    void _FadeIn()
    {
        alpha += Time.deltaTime * velocidadFade;
        if (alpha >= 1)
        {
            enabled = false;
        }
    }

    void _FadeOut()
    {
        alpha -= Time.deltaTime * velocidadFade;
        if (alpha <= 0)
        {
            enabled = false;
            gameObject.SetActive(false);
        }
    }

    public void FadeIn()
    {
        fadein = true;
        enabled = true;
        gameObject.SetActive(true);
    }

    public void FadeOut()
    {
        fadein = false;
        enabled = true;
    }

    public bool IsFading()
    {
        return enabled;
    }
}

