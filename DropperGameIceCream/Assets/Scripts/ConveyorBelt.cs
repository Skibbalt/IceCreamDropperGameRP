using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [Header ("Conveyor Belt Speed Variables")]
    [SerializeField]
    private float startingSpeed = 2.0f;
    [SerializeField]
    private float mediumSpeed = 5.0f;
    [SerializeField]
    private float maxSpeed = 10.0f;

    private SurfaceEffector2D conveyorsurfaceEffector;

    private float timeBeforeSpeedUp = 5.0f; //Time before the conveyor belt speeds up
    private float finalTimeBeforeMaxSpeed = 10.0f; //Time before the conveyor belt goes to its max speed

    void Awake()
    {
        conveyorsurfaceEffector = GetComponent<SurfaceEffector2D>();
        conveyorsurfaceEffector.speed = startingSpeed;
    }

    void Update()
    {
        timeBeforeSpeedUp -= Time.smoothDeltaTime; //Counting down the seconds of "timeBeforeSpeedUp"
        finalTimeBeforeMaxSpeed -= Time.smoothDeltaTime; //Counting down the seconds of "timeBeforeSpeedUp"

        if(timeBeforeSpeedUp <= 0) //To speed up the conveyor belt when "timeBeforeSpeedUp" reaches its set value.
            conveyorsurfaceEffector.speed = mediumSpeed;

        if(finalTimeBeforeMaxSpeed <= 0) //To speed up the conveyor belt when "finalTimeBeforeMaxSpeed" reaches its set value.
            conveyorsurfaceEffector.speed = maxSpeed;
    }
}