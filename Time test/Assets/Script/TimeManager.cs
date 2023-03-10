using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public KeyCode timeButton;

    //the amount of time before player can use time spell again
    public float timeDelay = 0.5f;

    //a boolean to see if the button is pressed or not
    public bool timeButtonPress;

    // Start is called before the first frame update
    void Start()
    {
        timeButtonPress = false;
    }

    private void FixedUpdate()
    {
        //checks if button is pressed
        if (Input.GetKey(timeButton))
        {
            StartCoroutine(timeDelayMethod());
        }
    }

    //method for delaying the time spell
    private IEnumerator timeDelayMethod()
    {
        timeButtonPressed();
 
        yield return new WaitForSeconds(timeDelay);

        timeButtonNoPressed();
    }

    //when time Button is pressed
    private void timeButtonPressed()
    {
        timeButtonPress = true;
    }

    //when time Button is let go
    private void timeButtonNoPressed()
    {
        timeButtonPress = false;
    }

    //checks if timebutton is pressed
    public bool timeButtonChecker()
    {
        return timeButtonPress;
    }
}
