using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GetUrl : MonoBehaviour
{
    public static GetUrl instance;

    public InputField url;
    public VideoPlayer videoPlayer;
    public Image playImage;
    public Image pauseImage;
    public Image resateImage;

    bool isPlaying;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        isPlaying = true;
    }
    //https://player.vimeo.com/progressive_redirect/download/51986343/container/9c290fe8-3053-4124-bfab-f5e0f6c54b03/67787827/need_for_speed:_most_wanted_-_in-game%20%28720p%29.mp4?expires=1653571114&loc=external&signature=86bfdbb2d9de3cd65abc50ed6fee1b0daddb69fe68f7f46b1e969aa8af602f17
    // Start is called before the first frame update
    public void OnClick()
    {
       videoPlayer.url = url.text;
        //Debug.Log(url.text);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayPause();
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            videoPlayer.Stop();
        }

    }

    public void Play()
    {
        videoPlayer.Play();
        isPlaying = true;
        playImage.gameObject.SetActive(false);
        pauseImage.gameObject.SetActive(true);
        
    }
    public void Pause()
    {
        videoPlayer.Pause();
        isPlaying = false;
        playImage.gameObject.SetActive(true);
        pauseImage.gameObject.SetActive(false);

    }
    public void Resate()
    {
        videoPlayer.frame = 0;
    }



    public void PlayPause()
    {
       // Debug.Log("PlayPause run");
        if(isPlaying)
        {
            Pause();
           // Debug.Log("is playing was true");
        }
        else
        {
            Play();
           // Debug.Log("isPlaying was false");
        }
        
    }
}
