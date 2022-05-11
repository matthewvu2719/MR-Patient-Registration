
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ModifyText : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text registration;
    public TMP_Text header;
    public TMP_Text firstName;
    public TMP_Text middleName;
    public TMP_Text lastName;
    public TMP_Text dob;
    public TMP_Text ssn;
    public TMP_Text sex;
    public TMP_Text language;
    public TMP_Text symptoms;
    public TMP_Text currentMedication;
    public TMP_Text message;
    public TMP_Text device1;
    public TMP_Text device2;
    public TMP_Text device3;
    public Button next;
    public Button back;
    public TMP_Text buttonText;
   // public Button button;


    
    private string[] headers = {"FIRST NAME", "MIDDLE NAME", "LAST NAME", "DATE OF BIRTH (YR-MM-DD)", "SOCIAL SIN NUMBER (XXX-XX-XXXX)", "SEX", "LANGUAGE", "REPORTED SYMPTOMS", "CURRENT MEDICATION"};
    private int i = 0;
    
    public TouchScreenKeyboard keyboard;

    public void OnSelectInput()
    {
        keyboard = TouchScreenKeyboard.Open("");
        if (keyboard.active == false)
        {
            keyboard.active = true;
        }
    }
    public void ChangeText()
    {
        switch (header.text)
        {   
            case "FIRST NAME":
                i = 1;
                firstName.text = keyboard.text;
                break;
            case "MIDDLE NAME":
                i = 2;
                middleName.text = keyboard.text;
                break;
            case "LAST NAME":
                i = 3;
                middleName.text = keyboard.text;
                break;
            case "DATE OF BIRTH (YR-MM-DD)":
                i = 4;
                dob.text = "DOB: " + keyboard.text;
                break;
            case "SOCIAL SIN NUMBER (XXX-XX-XXXX)":
                i = 5;
                ssn.text = "SSN: " + keyboard.text;
                break;
            case "SEX":
                i = 6;
                sex.text = "SEX: " + keyboard.text;
                break;
            case "LANGUAGE":
                i = 7;
                language.text = "LANGUAGE: " + keyboard.text;
                break;
            case "REPORTED SYMPTOMS":
                i = 8;
                symptoms.text = "REPORTED SYMPTOMS: \n" + keyboard.text;
                break;
            case "CURRENT MEDICATION":
                i = 9;
                currentMedication.text = "CURRENT MEDICATION: \n" + keyboard.text;
                break;


        }

        if (i> headers.Length - 1)
        {
            header.text = "";
            registration.text = "VITALITI CVSM DEVICES AVAILABLE";
            message.text = "Make sure the device is turned on and close to the Hololens.";
            device1.text = "UG678";
            device2.text = "SA035";
            device3.text = "KM654";
            GameObject.Find("FirstName").SetActive(false);
            GameObject.Find("MiddleName").SetActive(false);
            GameObject.Find("LastName").SetActive(false);
            GameObject.Find("Dob").SetActive(false);
            GameObject.Find("Ssn").SetActive(false);
            GameObject.Find("Sex").SetActive(false);
            GameObject.Find("Symptoms").SetActive(false);
            GameObject.Find("CurrentMedication").SetActive(false);
            GameObject.Find("Language").SetActive(false);
            GameObject.Find("Input").SetActive(false);
            GameObject.Find("Next").SetActive(false);
            GameObject.Find("Back").SetActive(false);

        }
        else
        {
            header.text = headers[i];
        }
        
        keyboard.text = "";
    }


    public void Back()
    {
        if (i > 0)
        {
            i--;
            header.text = headers[i];
            //button.Select();
        }
    }

    public void Next()
    {
        if (i < headers.Length - 1)
        {
            i++;
            header.text = headers[i];
            //button.Select();
        }
    }

    public void SelectInput()
    {
        input.Select();
    }

    public void Open()
    {
        keyboard = TouchScreenKeyboard.Open("");
        
    }

    public void Update()
    {   
        
            if (keyboard.text != null)
            {
                buttonText.text = keyboard.text;
                if (keyboard.status == TouchScreenKeyboard.Status.Done)
                {
                    ChangeText();
                }
            }
                /*switch (header.text)
                {
                    case "FIRST NAME":
                        i = 1;
                        firstName.text = keyboard.text;
                        break;
                    case "MIDDLE NAME":
                        i = 2;
                        middleName.text = keyboard.text;
                        break;
                    case "LAST NAME":
                        i = 3;
                        middleName.text = keyboard.text;
                        break;
                    case "DATE OF BIRTH (YR-MM-DD)":
                        i = 4;
                        dob.text = "DOB: " + keyboard.text;
                        break;
                    case "SOCIAL SIN NUMBER (XXX-XX-XXXX)":
                        i = 5;
                        ssn.text = "SSN: " + keyboard.text;
                        break;
                    case "SEX":
                        i = 6;
                        sex.text = "SEX: " + keyboard.text;
                        break;
                    case "LANGUAGE":
                        i = 7;
                        language.text = "LANGUAGE: " + keyboard.text;
                        break;
                    case "REPORTED SYMPTOMS":
                        i = 8;
                        symptoms.text = "REPORTED SYMPTOMS: \n" + keyboard.text;
                        break;
                    case "CURRENT MEDICATION":
                        i = 9;
                        currentMedication.text = "CURRENT MEDICATION: \n" + keyboard.text;
                        break;


                }

                if (i > headers.Length - 1)
                {
                    header.text = "";
                    registration.text = "VITALITI CVSM DEVICES AVAILABLE";
                    message.text = "Make sure the device is turned on and close to the Hololens.";
                    device1.text = "UG678";
                    device2.text = "SA035";
                    device3.text = "KM654";
                    GameObject.Find("FirstName").SetActive(false);
                    GameObject.Find("MiddleName").SetActive(false);
                    GameObject.Find("LastName").SetActive(false);
                    GameObject.Find("Dob").SetActive(false);
                    GameObject.Find("Ssn").SetActive(false);
                    GameObject.Find("Sex").SetActive(false);
                    GameObject.Find("Symptoms").SetActive(false);
                    GameObject.Find("CurrentMedication").SetActive(false);
                    GameObject.Find("Language").SetActive(false);
                    GameObject.Find("Input").SetActive(false);
                    GameObject.Find("Next").SetActive(false);
                    GameObject.Find("Back").SetActive(false);

                }
                else
                {
                    header.text = headers[i];
                }

                keyboard.text = "";*/
            
        }
    
}
