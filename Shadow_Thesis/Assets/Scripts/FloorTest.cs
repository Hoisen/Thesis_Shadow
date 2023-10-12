using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTest : MonoBehaviour
{
    
    private SpriteRenderer sprite;

    private Collider floorBox;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        floorBox = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void secFloorT()
    {
        sprite.color = new Color(1f, 1f, 1f, .2f);
    }

    public void secFloorF()
    {
        sprite.color = new Color(1f, 1f, 1f, .4f);
    }

    public void secFloorFull()
    {
        sprite.color = new Color(1f, 1f, 1f, 1f);
    }

    public void colliderOn()
    {
        floorBox.enabled = true;
    }

    public void colliderOFF()
    {
        floorBox.enabled = false;
    }
}
