using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFrameWork : MonoBehaviour
{

    public List<String> timeOptions;
    public int index;
    public String currentTime;
    public bool timeCheck;

    //calls Time Manager Script
    TimeManager timeManage = new TimeManager();

    // Start is called before the first frame update
    void Start()
    {
        //adds day and nigt options to list
        timeOptions.Add("day");
        timeOptions.Add("night");
     
        currentTime = timeOptions[index];
        
    }

    private void FixedUpdate()
    {
        //calls indexKeepInBounds method
        indexKeepInBounds();
        
        //updates time
        currentTime = timeOptions[index];

        //changes time when TimeButton is pressed
        if (timeManage.timeButtonChecker() == true)
        {
            indexSetter();
        }

    }

    //returns time of day
    public String timeGetter()
    {
        return currentTime;
    }

    //sets time of day
    public void indexSetter()
    {
        index++; 
    }
    
    //makes sure index stays in bounds of List
    public void indexKeepInBounds()
    {

        if(index >= timeOptions.Count)
        {
            index = 0;
        }
    }
}
