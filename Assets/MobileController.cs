using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    public static bool Thrusting;
    public static bool Right;
    public static bool Left;

    public void ClickDown()
    {
        Thrusting = true;
    }
    public void ClickUp()
    {
        Thrusting = !true;
    }
    public void ClickDownLeft()
    {
        Left = true;
    }
    public void ClickUpLeft()
    {
        Left = !true;
    }
    public void ClickDownRight()
    {
        Right = true;
    }
    public void ClickUpRight()
    {
        Right = !true;
    }
}
