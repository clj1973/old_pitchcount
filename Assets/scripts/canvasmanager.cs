using UnityEngine;


public class canvasmanager : MonoBehaviour {

    public CanvasGroup batcan;
    public CanvasGroup outcan;
    public CanvasGroup statcan;
    public CanvasGroup backcan;

    //private void Awake()
    //{
    //    batcan.alpha = 0;
    //    batcan.interactable = false;
    //    batcan.blocksRaycasts = false;
    //    outcan.alpha = 0;
    //    outcan.interactable = false;
    //    outcan.blocksRaycasts = false;
    //    statcan.alpha = 0;
    //    statcan.interactable = false;
    //    statcan.blocksRaycasts = false;
    //    backcan.alpha = 1;
    //    backcan.interactable = true;
    //    backcan.blocksRaycasts = true;
    //}

    public void showbatcan()
    {
        batcan.alpha = 1;
        batcan.interactable = true;
        batcan.blocksRaycasts = true;
        outcan.alpha = 0;
        outcan.interactable = false;
        outcan.blocksRaycasts = false;
        statcan.alpha = 0;
        statcan.interactable = false;
        statcan.blocksRaycasts = false;
        backcan.alpha = 0;
        backcan.interactable = false;
        backcan.blocksRaycasts = false;

        addpitch();
    }
    
    public void showoutcan()
    {
        batcan.alpha = 0;
        batcan.interactable = false;
        batcan.blocksRaycasts = false;
        outcan.alpha = 1;
        outcan.interactable = true;
        outcan.blocksRaycasts = true;
        statcan.alpha = 0;
        statcan.interactable = false;
        statcan.blocksRaycasts = false;
        backcan.alpha = 0;
        backcan.interactable = false;
        backcan.blocksRaycasts = false;

        addpitch();
    }

    public void showstatcan()
    {
        batcan.alpha = 0;
        batcan.interactable = false;
        batcan.blocksRaycasts = false;
        outcan.alpha = 0;
        outcan.interactable = false;
        outcan.blocksRaycasts = false;
        statcan.alpha = 1;
        statcan.interactable = true;
        statcan.blocksRaycasts = true;
        backcan.alpha = 0;
        backcan.interactable = false;
        backcan.blocksRaycasts = false;
    }

    public void showbackcan()
    {
        batcan.alpha = 0;
        batcan.interactable = false;
        batcan.blocksRaycasts = false;
        outcan.alpha = 0;
        outcan.interactable = false;
        outcan.blocksRaycasts = false;
        statcan.alpha = 0;
        statcan.interactable = false;
        statcan.blocksRaycasts = false;
        backcan.alpha = 1;
        backcan.interactable = true;
        backcan.blocksRaycasts = true;
    }

    public void addpitch()
    {
        GameObject addpitch = GameObject.Find("GoPitchButtons");
        Counter pitchScript = addpitch.GetComponent<Counter>();
        pitchScript.totalpitchcounter++;
        pitchScript.totalpitchtxt.text = pitchScript.totalpitchcounter.ToString();
    }
}
