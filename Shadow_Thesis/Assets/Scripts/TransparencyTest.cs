using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyTest : MonoBehaviour
{
    //timerTest timerShadow;

    private SpriteRenderer spriteOpacity;
    // Start is called before the first frame update
    void Start()
    {
        spriteOpacity = GetComponent<SpriteRenderer>();
        //timerShadow = GameObject.FindGameObjectWithTag("Timer").GetComponent<timerTest>();
        //spriteOpacity.color = new Color(1f, 1f, 1f, .2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spriteT()
    {
        this.spriteOpacity.color = new Color(1f, 1f, 1f, .2f);
    }

    public void spriteF()
    {
        spriteOpacity.color = new Color(1f, 1f, 1f, .4f);
    }

    public void spriteS()
    {
        spriteOpacity.color = new Color(1f, 1f, 1f, .6f);
    }

    public void spriteFull()
    {
        spriteOpacity.color = new Color(1f, 1f, 1f, 1f);
    }
}
