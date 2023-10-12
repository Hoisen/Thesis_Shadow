using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairTest : MonoBehaviour
{
    private SpriteRenderer sprite;

    private Collider stairBox;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        stairBox = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void stairT()
    {
        sprite.color = new Color(1f, 1f, 1f, .2f);
    }

    public void stairF()
    {
        sprite.color = new Color(1f, 1f, 1f, .4f);
    }

    public void stairFull()
    {
        sprite.color = new Color(1f, 1f, 1f, 1f);
    }

    public void colliderON()
    {
        stairBox.enabled = true;
    }

    public void colliderOFF()
    {
        stairBox.enabled = false;
    }
}
