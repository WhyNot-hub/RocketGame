using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileController : MonoBehaviour
{
    public static bool Thrusting;
    public static bool Right;
    public static bool Left;

    public static int ScreenWidth;
    public static int ScreenHeight;
    [SerializeField] Text resText;

    public static AndroidJavaObject vibrator;
    public static bool vibrCarout;
    public static bool vibrationOn;

    private void Start()
    {
        ScreenHeight = Display.main.systemHeight - (Display.main.systemHeight /3);
        ScreenWidth = Display.main.systemWidth - (Display.main.systemWidth / 3);
        Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        resText.text = "ScreenRes: " + ScreenHeight.ToString() + "X" + ScreenWidth.ToString();
    }

    public void ClickDown()
    {
        //Thrusting = true;

        if (vibrationOn && vibrCarout == false)
        {
            Thrusting = true;
            StartCoroutine(vibration());
        }
        else
        {
            Thrusting = true;
        }

    }
    public void vibrationThrust()
    {
        vibrationOn = !vibrationOn;
        Debug.Log(vibrationOn);
    }

    public void ClickUp()
    {
        StopAllCoroutines();
        Thrusting = !true;
        vibrCarout = !true;
        
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

    IEnumerator vibration()
    {
        if(Thrusting == true)
        {
           vibrCarout = true;
           yield return new WaitForSeconds(0);
           Handheld.Vibrate();
           yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            vibrCarout = !true;
        }
        else
        {
            StopCoroutine(vibration());
            vibrCarout = !true;
        }

    }
}
