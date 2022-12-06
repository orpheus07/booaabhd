using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public TMP_Text storyText;
    public TMP_Text choiceText;
    public TMP_Text stateText;
    public Sprite[] imageArray;

    enum States { Hospital0, Window0, Door0, Computer0, Desk0, Door1, Code0, Death0, Correct0, Note0, Safe0, Book0, Window1, Gurney0, Explore0, Explore1, Images0, Explore2 };
    States myState;

    // Start is called before the first frame update
    //Awake will be used before the first scene is even shown
    void Awake()
    {
        myState = States.Hospital0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.Hospital0)
        {
            hospital0();
        }
        else if (myState == States.Window0)
        {
            window0();
        }
        else if (myState == States.Window1)
        {
            window1();
        }
        else if (myState == States.Gurney0)
        {
            gurney0();
        }
        else if (myState == States.Door0)
        {
            door0();
        }
        else if (myState == States.Computer0)
        {
            computer0();
        }
        else if (myState == States.Code0)
        {
            code0();
        }
        else if (myState == States.Death0)
        {
            death0();
        }
        else if (myState == States.Door1)
        {
            door1();
        }
        else if (myState == States.Correct0)
        {
            correct0();
        }
        else if (myState == States.Desk0)
        {
            desk0();
        }
        else if (myState == States.Note0)
        {
            note0();
        }
        else if (myState == States.Book0)
        {
            book0();
        }
        else if (myState == States.Safe0)
        {
            safe0();
        }
        else if (myState == States.Explore0)
        {
            explore0();
        }
        else if (myState == States.Explore1)
        {
            explore0();
        }
        else if (myState == States.Images0)
        {
            images0();
        }
        else if (myState == States.Explore2)
        {
            explore2();
        }
    }


    // Lowercase H so the methods and states are seperated when it comes to Hospital
    void hospital0()
    {
        storyText.SetText("You wake up and find yourself lying in the middle of an empty hospital room on a cold rubber gurney. There are cobwebs and ugly stains " +
            "on the walls. The air is hard and it smells sterile yet neglected, it gives you a slight headache. ");

        choiceText.SetText("Press <color=#00ff12></color> R to look out Window");

        stateText.SetText(myState.ToString());

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Window0;
        }
 

    }


    void window0()
    {
        storyText.SetText(" You notice a window above you. You stand on top of the gurney peering out at the bright light shining in your eyes through the dusty glass. The first thing you see is what looks like a dead body " +
            "lying face down on the floor outside. You imediatly get scared and sit back down.");

        choiceText.SetText("Stay sitting in Gurney Press Q / Look out window again Press W ");

        stateText.SetText(myState.ToString());

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[5];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Gurney0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(1);
        }

    }

    void window1()
    {
      
        storyText.SetText("The light outside flashes red. Your anxiety is rising and you scram to find anything that might help you. You realizes the air is" +
            " getting thinner. Some sort of gas is being emitted into the air, making it tremendously harder to breathe than before. It is too late.");

        choiceText.SetText("Go Back click Q");

        stateText.SetText(myState.ToString());

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[2];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Hospital0;
        }
      
    }
    
    void gurney0()
    {
        storyText.SetText("You are mortified by what you just saw. You lie there for a seccond trying to calm down. You look around, not planning to stay here long.");

        choiceText.SetText("Check Computer Press Q / Look at Desk Press W / Open Door Press E");

        stateText.SetText(myState.ToString());

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Computer0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Desk0;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Door0;
        }
      

    }

    void door0()
    {
        storyText.SetText("You go to open the door. It is locked.");

        choiceText.SetText("Press Q to go Back / Press W to Try Again");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[3];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Explore0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Door1;
        }

    }

    void door1()
    {
        storyText.SetText("The door is locked.");

        choiceText.SetText("Press Q to go Back");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[3];


        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Explore0;
        }
    }

    void explore0()
    {
        storyText.SetText("Where would you like to go?");

        choiceText.SetText("Check Computer Press Q / Look at Desk Press W / Open Door Press E");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Computer0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Desk0;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Door0;
        }


    }

    void computer0()
    {
        storyText.SetText("She makes her way to the computer. There are glass shards all over the keyboard. There is a lock screen shown on the screen. A three digit code is required. ");

        choiceText.SetText("Press Q to Enter Code / Press W to Go Back");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Code0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Explore0;
        }

    }


    void code0()
    {
        storyText.SetText("Select Correct Code");

        choiceText.SetText("398 Press Q / 814 Press W / 652 Press E / 373 Press R");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Death0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Death0;

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Death0;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Correct0;
        }

    }

    void correct0()
    {
        storyText.SetText("CORRECT");

        choiceText.SetText("Press Q to Contunue");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Images0;
        }
      
    }

    void images0()
    {

        storyText.SetText("The screen flashes' green reveling a short clip. The clip shows images of the outside of a morgue.");

        choiceText.SetText("Press Q to go Back");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Explore1;
        }
    }


    void explore1()
    {
        storyText.SetText("Where would you like to go?");

        choiceText.SetText("Look at Desk Press Q / Open Door Press E");


        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Desk0;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Door0;
        }
    }

    void death0()
    {
        storyText.SetText("The screen flashes red. The anxiety is rising and as she scrams to find anything that might help her. She realizes the air is getting thinner. Some sort " +
            "of gas is being emitted into the air, making it tremendously harder to breathe than before. She continues to look around but she feels her head getting lighter. It is too late. ");

        choiceText.SetText("Press Q to Go Back");

        if(Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Hospital0;
        }
    }

    void desk0()
    {
        storyText.SetText("The desk is glass with many chips, dents, and scrapes in it.  Many random, unknown objects are laid out on the table.  On the table are a book," +
            " a note and small but sturdy safe. ");

        choiceText.SetText("Press Q to Inspect Note / Press W to Inspect Book / Press E to Inspect Safe/ Go Back Press R");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Note0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Book0;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Safe0;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Explore0;
        }
    }

    void note0()
    {

    }

    void book0()
    {
        storyText.SetText("She flips through the pages skimming through the book. It's a book on anatomy.   As she was flipping through the pages she realized page 373 was circled" +
            " in bright red sharpie at the bottom of the page.  ");

        choiceText.SetText("Press Q to go Back");

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            myState = States.Explore2;
        }
       
    

       
    }
    void safe0()
    {

    }

    void explore2()
    {
        //back options from 
        storyText.SetText("Where would you like to go?");

        choiceText.SetText("Press to look at Note / Press Q to look at Safe / Go Back Press W");

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Note0;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.Safe0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Explore0;
        }
    }   

    void explore3()
    {
        // go back options from notw
    }

        void explore4()
    {
        // Back options from safe
    }
    





    // make sure to add each void in the == states area thingy 

}