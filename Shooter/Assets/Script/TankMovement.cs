using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public Allper allper;
    private void Update()
    {
        TurnShoot();
    }
    private void TurnShoot()
    {
        if (Input.GetKey(KeyCode.W) & !Input.GetKey(KeyCode.S))
        {
            allper.TurnUp = true;
        }
        else
        {
            allper.TurnUp = false;
        }
        if (Input.GetKey(KeyCode.S) & !Input.GetKey(KeyCode.W))
        {
            allper.TurnDown = true;
        }
        else
        {
            allper.TurnDown = false;
        }
        if (Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
        {
            allper.TurnLeft = true;
        }
        else
        {
            allper.TurnLeft = false;
        }
        if (Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
        {
            allper.TurnRight = true;
        }
        else
        {
            allper.TurnRight = false;
        }
        if (!Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.S) & !Input.GetKey(KeyCode.W))
        {
            allper.TurnLeft = false;
            allper.TurnRight = false;
            allper.TurnUp = false;
            allper.TurnDown = false;
        }
    }
}
