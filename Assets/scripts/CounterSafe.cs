using UnityEngine;
using UnityEngine.UI;


public class CounterSafe : MonoBehaviour {

    //counters
    public int totsincounter = 0;
    public int totdubcounter = 0;
    public int tottricounter = 0;
    public int tothrcounter = 0;
    public int totwalkcounter = 0;
   
    public Text sincountertxt;
    int sincounter = 0;

    public Text sinovercountertxt;
    int sinovercounter = 0;

    public Text sindropcountertxt;
    int sindropcounter = 0;

    public Text sintotcountertxt;
    //int sintotcounter = 0;

    //doub

    public Text dubcountertxt;
    int dubcounter = 0;

    public Text dubovercountertxt;
    int dubovercounter = 0;

    public Text dubdropcountertxt;
    int dubdropcounter = 0;

    public Text dubtotcountertxt;
    //int dubtotcounter = 0;

    //trip

    public Text tricountertxt;
    int tricounter = 0;

    public Text triovercountertxt;
    int triovercounter = 0;

    public Text tridropcountertxt;
    int tridropcounter = 0;

    public Text tritotcountertxt;
    //int tritotcounter = 0;


    //hr
    public Text hrcountertxt;
    int hrcounter = 0;

    public Text hrovercountertxt;
    int hrovercounter = 0;

    public Text hrdropcountertxt;
    int hrdropcounter = 0;

   // public Text hrtotcountertxt;
   // int hrtotcounter = 0;


    //fun single

        public void funsin()
    {
        totsincounter++;
        sincounter++;
        sincountertxt.text = sincounter.ToString();
    }

    public void funsinover()
    {
        totsincounter++;
        sinovercounter++;
        sinovercountertxt.text = sinovercounter.ToString();
    }

    public void funsindrop()
    {
        totsincounter++;
        sindropcounter++;
        sindropcountertxt.text = sindropcounter.ToString();
    }

    //fun double

    public void fundub()
    {
        totdubcounter++;
        dubcounter++;
        dubcountertxt.text = dubcounter.ToString();
    }

    public void fundubover()
    {
        totdubcounter++;
        dubovercounter++;
        dubovercountertxt.text = dubovercounter.ToString();
    }

    public void fundubdrop()
    {
        totdubcounter++;
        dubdropcounter++;
        dubdropcountertxt.text = dubdropcounter.ToString();
    }

    //fun triple

    public void funtri()
    {
        tottricounter++;
        tricounter++;
        tricountertxt.text = tricounter.ToString();
    }

    public void funtriover()
    {
        tottricounter++;
        triovercounter++;
        triovercountertxt.text = triovercounter.ToString();
    }

    public void funtridrop()
    {
        tottricounter++;
        tridropcounter++;
        tridropcountertxt.text = tridropcounter.ToString();
    }

    //fun hr

    public void funhr()
    {
        tothrcounter++;
        hrcounter++;
        hrcountertxt.text = hrcounter.ToString();
    }

    public void funhrover()
    {
        tothrcounter++;
        hrovercounter++;
        hrovercountertxt.text = sinovercounter.ToString();
    }

    public void funhrdrop()
    {
        tothrcounter++;
        hrdropcounter++;
        hrdropcountertxt.text = hrdropcounter.ToString();
    }


}
