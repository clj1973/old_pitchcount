﻿using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public videomanager _videomanager;
    private float max_pitches = 60f;
    private float pitches_left = 60f;
    public GameObject pitchcountbar;

    [SerializeField]
    private Text overlimittxt;

    //walk
    public Text walkcountertxt;

    int walkcounter = 0;

    public Text battewrwalkcountertxt;
    int batterwalkcounter = 0;

    public Text battetxtfoultip;
    int batterfoultipcounter = 0;

    public Text balllefttxt;
    int leftcounter = 0;

    public Text ballrighttxt;
    int rightcounter = 0;

    public Text ballhightxt;
    int highcounter = 0;

    public Text balllowtxt;
    int lowcounter = 0;

    public Text striketxt;
    int strikecounter = 0;

    public Text tempstriketxt;
    int tempstrikecounter = 0;

    public Text totalstriketxt;
    int totalstrikecounter = 0;

    public int BallStrikeCounter;
    public Text BallStrikeCountertxt;

    public Text pcentstriketxt;

    public Text totalballstxt;
    int totalballscounter = 0;

    public Text totalpitchtxt;
    public int totalpitchcounter = 0;

    public Text walkbattertxt;

    private Text strikeouttxt_see_me;
    int strikeoutcounter = 0;

    public Text hitbattertxt;
    int hitbattercounter = 0;

    public Image imgprogress;
    

  

    public static int setlight;

    void Start()
    {
        //Fetch the Image from the GameObject
        setlight = 4;
        Debug.Log(setlight);
    }

    

    public void funBallLeft()
    {
        leftcounter++;
        totalballscounter++;
        totalpitchcounter++;
        balllefttxt.text = leftcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
        fundecreasepitch();
        _videomanager.runvideo();
    }


    public void funBallRight()
    {
        rightcounter++;
        totalballscounter++;
        totalpitchcounter++;
        ballrighttxt.text = rightcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
        fundecreasepitch();
    }

    public void funBallHigh()
    {
        highcounter++;
        totalballscounter++;
        totalpitchcounter++;
        ballhightxt.text = highcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
        fundecreasepitch();
    }

    public void funBallLow()
    {
        lowcounter++;
        totalballscounter++;
        totalpitchcounter++;
        balllowtxt.text = lowcounter.ToString();
        totalballstxt.text = totalballscounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
        fundecreasepitch();
    }

    public void funStrike()
    {
        strikecounter++;
        BallStrikeCounter++;
        BallStrikeCountertxt.text = BallStrikeCounter.ToString();
        tempstrikecounter++;
        totalpitchcounter++;
        striketxt.text = strikecounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
        totalstrikecounter++;
        setlight++;
        Debug.Log(setlight);
        fundecreasepitch();
    }

    public void funclear()
    {
        striketxt.text = 0.ToString();
        balllefttxt.text = 0.ToString();
        ballrighttxt.text = 0.ToString();
        ballhightxt.text = 0.ToString();
        balllowtxt.text = 0.ToString();
    }

    public void funwalk()
    {
        walkcounter++;
        walkbattertxt.text = walkcounter.ToString();
        funclear();
    }

    public void funStrikeout()
    {
        strikeoutcounter++;
        strikeouttxt_see_me.text = strikecounter.ToString();
    }

     public void funbattetxtfoultip()
    {
        batterfoultipcounter++;
        battetxtfoultip.text = batterfoultipcounter.ToString();
        totalpitchcounter++;
        totalpitchtxt.text = totalpitchcounter.ToString();
        fundecreasepitch();
    }

    public void funhitbatter()
    {
        hitbattercounter++;
        hitbattertxt.text = hitbattercounter.ToString();
        totalpitchcounter++;
        totalpitchtxt.text = totalpitchcounter.ToString();
        setlight = 4;
        fundecreasepitch();
    }

    public void funhit()
    {
        strikecounter++;
        striketxt.text = strikecounter.ToString();
        
    }

    public void fundecreasepitch()
    {
        double currentpcent = (double)strikecounter / totalpitchcounter;
        pcentstriketxt.text = currentpcent.ToString("F2") + "%";
        float calc_pitch = pitches_left - (totalballscounter + totalstrikecounter + batterfoultipcounter + hitbattercounter);
        float reducebar = calc_pitch / max_pitches;
        overlimittxt.text = calc_pitch.ToString() + " PITCHES LEFT";
        setpitchbar(reducebar);
    }


    public void setpitchbar(float mypitchcount)
    {

        if (mypitchcount >= 0.00f)
        {
            if (mypitchcount <= 0.99f)
            {
                pitchcountbar.transform.localScale = new Vector3(mypitchcount, 1, 1);
                //imgprogress.GetComponent<Image>().color = Color.green;

                if (mypitchcount <= 0.40f)
                {
                    pitchcountbar.transform.localScale = new Vector3(mypitchcount, 1, 1);
                    //imgprogress.GetComponent<Image>().color = Color.yellow;

                    if (mypitchcount <= 0.20f)
                    {
                        pitchcountbar.transform.localScale = new Vector3(mypitchcount, 1, 1);
                        //imgprogress.GetComponent<Image>().color = Color.red;


                    }
                }

            }

        }
        else
        {
            mypitchcount = -1;
            overlimittxt.text = "OVER LIMIT";
        }

    }

    public void myclose()
    {
        Debug.Log("game quit");
        Application.Quit();
    }

}