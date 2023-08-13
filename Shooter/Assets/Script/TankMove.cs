using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public Allper allper;
    public GameObject tank_Start;
    private GameObject tank;
    private Vector3 transform_tank = new Vector3(0f,3f,0f);

    private float movement;
    private float rotation;
    private float speed_movement = 15f;
    private float speed_rotation = 100f;

    private void Start()
    {
        tank = Instantiate(tank_Start) as GameObject;
        tank.transform.position = transform_tank;
    }
    private void Update()
    {
        Tank_Per();
    }
    private void Tank_Per()
    {
        movement = 0;
        rotation = 0;
        if (allper.TurnUp)
        {
            movement = 1;
        }
        if (allper.TurnDown)
        {
            movement = -1;
        }
        if (allper.TurnRight)
        {
            if (rotation == -1)
            {
                rotation = -1;
            }
            else
            {
                rotation = 1;
            }
        }
        if (allper.TurnLeft)
        {
            if (rotation == 1)
            {
                rotation = 1;
            }
            else
            {
                rotation = -1;
            }
        }
        tank.transform.Translate(0, 0, movement * speed_movement * Time.deltaTime, Space.Self);
        tank.transform.Rotate(0, rotation * speed_rotation * Time.deltaTime, 0, Space.Self);
    }
}
