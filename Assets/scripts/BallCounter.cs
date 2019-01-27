using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCounter : MonoBehaviour {

    private float max_pitch = 10f;
    private float pitchesleft;
    public GameObject healthbar;

    [SerializeField]
    private Text balllefttxt;
    int leftcounter = 0;

    [SerializeField]
    private Text ballrighttxt;
    int rightcounter = 0;

    [SerializeField]
    private Text ballhightxt;
    int highcounter = 0;

    [SerializeField]
    private Text balllowtxt;
    int lowcounter = 0;

    [SerializeField]
    private Text striketxt;
    int strikecounter = 0;

    [SerializeField]
    private Text totalballstxt;
    int totalballscounter = 0;

    [SerializeField]
    private Text totalpitchtxt;
    int totalpitchcounter = 0;

    [SerializeField]
    private Text walkbattertxt;
    int walkbattercounter = 0;

    [SerializeField]
    private Text strikeouttxt;
    int strikeoutcounter = 0;

    [SerializeField]
    private Text hitbattertxt;
    int hitbattercounter = 0;

    public void funBallLeft()
    {
        leftcounter++;
        totalballscounter++;
        totalpitchcounter++;
        balllefttxt.text = leftcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
    }

    public void funBallRight()
    {
        rightcounter++;
        totalballscounter++;
        totalpitchcounter++;
        ballrighttxt.text = rightcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
    }

    public void funBallHigh()
    {
        highcounter++;
        totalballscounter++;
        totalpitchcounter++;
        ballhightxt.text = highcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
    }

    public void funBallLow()
    {
        lowcounter++;
        totalballscounter++;
        totalpitchcounter++;
        balllowtxt.text = lowcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
    }

    public void funStrike()
    {
        strikecounter++;
        totalballscounter++;
        totalpitchcounter++;
        striketxt.text = strikecounter.ToString();
    }

    public void funwalk()
    {
        walkbattercounter++;
        totalpitchcounter++;
        walkbattertxt.text = walkbattercounter.ToString();
    }

    public void funStrikeout()
    {
        strikeoutcounter++;
        strikeouttxt.text = strikecounter.ToString();
    }

    public void funhit()
    {
        strikecounter++;
        striketxt.text = strikecounter.ToString();
    }
}
