using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTest : MonoBehaviour
{
    private SpriteRenderer sprite;

    private Collider wallBox;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        wallBox = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wallOPF()
    {
        sprite.color = new Color(1f, 1f, 1f, .4f);
    }
    public void wallOPFull()
    {
        sprite.color = new Color(1f, 1f, 1f, 1f);
    }

    public void wallOPT()
    {
        sprite.color = new Color(1f, 1f, 1f, .2f);
    }

    public void wallColliderDisappear()
    {
        //wallBox.enabled = !wallBox.enabled;
        wallBox.enabled = false;
    }
    
    public void wallColliderAppear()
    {
        //wallBox.enabled = !wallBox.enabled;
        wallBox.enabled = true;
    }

    
}
