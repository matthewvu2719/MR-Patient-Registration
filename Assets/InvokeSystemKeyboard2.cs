using UnityEngine;
using TMPro;

public class InvokeSystemKeyboard2 : MonoBehaviour
{
    public TMP_Text Output;
    public TouchScreenKeyboard keyboard;
    public void InvokeKeyboard()
    {
        keyboard = new TouchScreenKeyboard("", TouchScreenKeyboardType.Default, false, false, false, false,"",30);
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