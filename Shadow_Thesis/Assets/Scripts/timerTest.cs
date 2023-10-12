using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.UI;

public class timerTest : MonoBehaviour
{
    //Call Function
    private TransparencyTest transparenctSprite;
    private WallTest wallSprite;
    private FloorTest floorSprite;
    private stairTest stairSprite;
    
    //Fill the timer
    private float timer = 0;

    private float maxTimer = 100;

    public Image shadowTimer;
    public float minTimer = 0;
    public float currentTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        transparenctSprite = GameObject.FindGameObjectWithTag("Player").GetComponent<TransparencyTest>();
        wallSprite = GameObject.FindGameObjectWithTag("Wall").GetComponent<WallTest>();
        floorSprite = GameObject.FindGameObjectWithTag("Sec").GetComponent<FloorTest>();
        stairSprite = GameObject.FindGameObjectWithTag("stair").GetComponent<stairTest>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.01f;//0.001f
        timer.ToString("N0");
        Debug.Log("Timer: " + timer);

        plusTimer();
        playerShapes();
    }

    public void playerShapes()
    {
        if (timer <= 20)
        {
            transparenctSprite.spriteT();
            wallSprite.wallOPFull();
            
            //secFloorON
            floorSprite.secFloorT();
            floorSprite.colliderOn();

        }

        if (timer > 20 && timer <= 40.05f)
        {
            //pass through the wall
            transparenctSprite.spriteF();
            wallSprite.wallOPF();
            
            //secFloorON
            floorSprite.secFloorFull();
            floorSprite.colliderOn();
            
            //stairOFF
            stairSprite.stairT();
            stairSprite.colliderOFF();
            
            //for testing!!! WALL off
            wallSprite.wallColliderDisappear();
        }

        if (timer > 40.05f && timer <= 60.2f)
        {
            
            transparenctSprite.spriteFull();
            wallSprite.wallOPT();
            
            //secFloorOFF
            floorSprite.secFloorF();
            floorSprite.colliderOFF();
            
            //stairON
            stairSprite.stairFull();
            stairSprite.colliderON();
            
            //Wall ON
            wallSprite.wallColliderAppear();
        }

        if (timer > 60.2f && timer <= 80.05f)
        {
            transparenctSprite.spriteFull();
            wallSprite.wallColliderDisappear();
            //secFloorON
            floorSprite.secFloorFull();
            floorSprite.colliderOFF();
            
            //stairOFF
            stairSprite.stairT();
            stairSprite.colliderOFF();
        }

        if (timer > 80.05f && timer <= 99)
        {
            
            wallSprite.wallColliderAppear();
            //secFloorOn
            floorSprite.secFloorFull();
            floorSprite.colliderOn();
        }

        if (timer >= 100)
        {
            timer = 0;
        }
        
    }
    void plusTimer()
    {
        currentTimer = timer/maxTimer;
        shadowTimer.fillAmount = currentTimer;
    }
    
}
