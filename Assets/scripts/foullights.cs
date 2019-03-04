using UnityEngine;
using UnityEngine.UI;

public class foullights : MonoBehaviour
{
    public Sprite lightsoff;
    public Sprite lightsone;
    public Sprite lightstwo;
    public Sprite lightsthree;
    public Image lightholdernew;
    int AccesingX;

    // Start is called before the first frame update
    void Start()
    {
        lightholdernew = GetComponent<Image>();
    }

    //Update is called once per frame
    void Update()
    {
        if (Counter.setlight == 1)
        {

            lightholdernew.sprite = lightsone;
            Debug.Log(lightholdernew.sprite.name);
        }
        else if (Counter.setlight == 2)
        {

            lightholdernew.sprite = lightstwo;
            Debug.Log(lightholdernew.sprite.name);
        }

        else if (Counter.setlight == 3)
        {

            lightholdernew.sprite = lightsthree;
            Debug.Log(lightholdernew.sprite.name);
        }

        else if (Counter.setlight == 4)
        {

            lightholdernew.sprite = lightsoff;
            Counter.setlight = 0;
            Debug.Log(lightholdernew.sprite.name);
        }
        else
        {
            //Debug.Log(lightholdernew.sprite.name);
        }

    }

}