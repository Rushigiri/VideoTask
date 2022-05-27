using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class track : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    
   

    public VideoPlayer videoPlayer;
    Slider tracking;
    bool slide = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        slide = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        float frame = (float)tracking.value * (float)videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        slide = false;
    }

    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!slide)
        {

            tracking.value = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }

       
    }

   
}
