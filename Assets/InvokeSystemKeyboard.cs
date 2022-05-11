using UnityEngine;
using TMPro;

public class InvokeSystemKeyboard : MonoBehaviour
{
    public TMP_Text Output;
    public TouchScreenKeyboard keyboard;

    public void InvokeKeyboard()
    {
        TouchScreenKeyboard.hideInput = false;
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false, "", 15);

    }

    void Update()
    {

        if (keyboard != null)
        {
            if (keyboard.status == TouchScreenKeyboard.Status.Done)
            {
                Output.text = keyboard.text;
                
            }
        }
    }



}