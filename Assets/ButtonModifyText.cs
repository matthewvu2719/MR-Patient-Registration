using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonModifyText : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text buttonText;
    public TouchScreenKeyboard keyboard;
    
    
    //Invoke the keyboard, this method is assign to the button 
    public void SelectButton()
    {
        keyboard = TouchScreenKeyboard.Open("");

    }


    // Update is called once per frame
    public void Update()
    {   

        //Update the button's text
        if (keyboard != null && keyboard.done == true)
        {
            text.text = keyboard.text;
            keyboard = null;
        }

        //Update the TMP text
        if (keyboard != null && keyboard.active == true)
        {
            if (keyboard.text != null)
            {
                buttonText.text = keyboard.text;
            }
        }
    }
}
