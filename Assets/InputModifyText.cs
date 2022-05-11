
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class InputModifyText : MonoBehaviour
{
    
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
    GameObject backButton;
    GameObject nextButton;
    GameObject inputButton;
    GameObject yesButton;
    GameObject noButton;
    GameObject mainCanvas;
    GameObject categories;
    GameObject headerText;




    private string[] headers = {"FIRST NAME", "MIDDLE NAME", "LAST NAME", "DATE OF BIRTH (YR-MM-DD)", "SOCIAL SIN NUMBER (XXX-XX-XXXX)", "SEX", "LANGUAGE", "REPORTED SYMPTOMS", "CURRENT MEDICATION","CONFIRM?"};
    private int i = 0;
    
    public TouchScreenKeyboard keyboard;

    private void Start()
    {
        backButton = GameObject.Find("BackButton");
        nextButton = GameObject.Find("NextButton");
        inputButton = GameObject.Find("InputButton");
        yesButton = GameObject.Find("YesButton");
        noButton = GameObject.Find("NoButton");
        mainCanvas = GameObject.Find("MainCanvas");
        categories = GameObject.Find("Categories");
        headerText = GameObject.Find("Header");
        yesButton.SetActive(false);
        noButton.SetActive(false);
    }

    public void Back()
    {
        if (i > 0)
        {
            i--;
            header.text = headers[i];
        }
    }

    public void Next()
    {
        if (i < headers.Length-1)
        {
            i++;
            header.text = headers[i];

        }
        if (i == headers.Length - 1)
        {
            backButton.SetActive(false);
            nextButton.SetActive(false);
            inputButton.SetActive(false);
            yesButton.SetActive(true);
            noButton.SetActive(true);
        }

    }

    public void Yes()
    {
        registration.text = "VITALITI CVSM DEVICES AVAILABLE";
        message.text = "Make sure the device is turned on and close to the Hololens.";
        device1.text = "UG678";
        device2.text = "SA035";
        device3.text = "KM654";
        mainCanvas.SetActive(false);
        categories.SetActive(false);
        headerText.SetActive(false);
    }

    public void No()
    {
        i = 8;
        header.text = headers[i];
        backButton.SetActive(true);
        nextButton.SetActive(true);
        inputButton.SetActive(true);
        yesButton.SetActive(false);
        noButton.SetActive(false);
    }

    public void Open()
    {
        keyboard = TouchScreenKeyboard.Open("");
                    
    }

    void Update()
    {
        if (keyboard != null && keyboard.active == true)
        {
            next.enabled = false;
            back.enabled = false;
            if (keyboard.text != null)
            {
                buttonText.text = keyboard.text;
            }
        }
        if (keyboard != null && keyboard.done == true)
        {
            next.enabled = true;
            back.enabled = true;
            buttonText.text = "Enter here...";
            switch (i)
            {
                case 0:
                    i++;
                    firstName.text = keyboard.text;
                    keyboard = null;
                    break;
                case 1:
                    i++;
                    middleName.text = keyboard.text;
                    keyboard = null;
                    break;
                case 2:
                    i++;
                    middleName.text = keyboard.text;
                    keyboard = null;
                    break;
                case 3:
                    i++;
                    dob.text = "DOB: " + keyboard.text;
                    keyboard = null;
                    break;
                case 4:
                    i++;
                    ssn.text = "SSN: " + keyboard.text;
                    keyboard = null;
                    break;
                case 5:
                    i++;
                    sex.text = "SEX: " + keyboard.text;
                    keyboard = null;
                    break;
                case 6:
                    i++;
                    language.text = "LANGUAGE: " + keyboard.text;
                    keyboard = null;
                    break;
                case 7:
                    i++;
                    symptoms.text = "REPORTED SYMPTOMS: \n" + keyboard.text;
                    keyboard = null;
                    break;
                case 8:
                    i++;
                    currentMedication.text = "CURRENT MEDICATION: \n" + keyboard.text;
                    backButton.SetActive(false);
                    nextButton.SetActive(false);
                    inputButton.SetActive(false);
                    yesButton.SetActive(true);
                    noButton.SetActive(true);
                    keyboard = null;
                    break;
            }
            header.text = headers[i];



        }
    }   
    
}
