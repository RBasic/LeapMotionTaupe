using UnityEngine;
using System.Collections.Generic;
using Leap;

public class t : MonoBehaviour
{
    public Controller c;

    // Use this for initialization
    void Start()
    {
        c = new Controller();
        Debug.Log("c : "+c);
    }

    // Update is called once per frame
    void Update()
    {

        if (c.IsConnected)
        { //controller is a Controller object
            Frame frame = c.Frame(); //The latest frame
            if (frame.Hands.Count > 0)
            {
                List<Hand> hands = frame.Hands;
                Hand firstHand = hands[0];
                Debug.Log(firstHand);
                Debug.Log(firstHand.GrabStrength);
                if(firstHand.GrabStrength > 0.5f)
                {
                }
                else
                {
                }
            }
        }



    }

}
