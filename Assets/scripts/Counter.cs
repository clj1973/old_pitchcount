using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public videomanager _videomanager;
    private float max_pitches = 10f;
    private float pitches_left = 10f;
    public GameObject pitchcountbar;

    [SerializeField]
    private Text overlimittxt;

    //walk
    public Text walkcountertxt;
    int walkcounter = 0;

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

    public Text totalstriketxt;
    int totalstrikecounter = 0;

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
        totalpitchcounter++;
        striketxt.text = strikecounter.ToString();
        totalstrikecounter++;
        totalstriketxt.text = totalstrikecounter.ToString();
        totalpitchtxt.text = totalpitchcounter.ToString();
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

    public void funhit()
    {
        strikecounter++;
        striketxt.text = strikecounter.ToString();
    }

    public void fundecreasepitch()
    {
        double currentpcent = (double)strikecounter / totalpitchcounter;
        pcentstriketxt.text = currentpcent.ToString("F2") + "%";
        float calc_pitch = pitches_left - (totalballscounter + totalstrikecounter);
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
                imgprogress.GetComponent<Image>().color = Color.green;

                if (mypitchcount <= 0.40f)
                {
                    pitchcountbar.transform.localScale = new Vector3(mypitchcount, 1, 1);
                    imgprogress.GetComponent<Image>().color = Color.yellow;

                    if (mypitchcount <= 0.20f)
                    {
                        pitchcountbar.transform.localScale = new Vector3(mypitchcount, 1, 1);
                        imgprogress.GetComponent<Image>().color = Color.red;


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