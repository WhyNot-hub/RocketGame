using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    public static bool Thrusting;
    public static bool Right;
    public static bool Left;

    public static int ScreenWidth;
    public static int ScreenHeight;

    private void Start()
    {
        ScreenHeight = Display.main.systemHeight;
        ScreenWidth = Display.main.systemWidth;
        Screen.SetResolution(ScreenWidth, ScreenHeight, true);
    }

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
