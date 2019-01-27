using System.Collections;
using UnityEngine;

public class videomanager : MonoBehaviour {

    private int number;
    private string movie;

public void runvideo()
    {
        number = Random.Range(1, 11);
        movie = number.ToString() + ".mp4";
        StartCoroutine(Startplay(movie));
    }

    IEnumerator Startplay(string video)
    {
        Handheld.PlayFullScreenMovie(video, Color.black, FullScreenMovieControlMode.Hidden, FullScreenMovieScalingMode.AspectFit);
        yield return new WaitForEndOfFrame();
    }

}
