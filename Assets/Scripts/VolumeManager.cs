using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class VolumeManager : MonoBehaviour,IPointerUpHandler
{
    public Slider slider;

    public void OnPointerUp(PointerEventData eventData)
    {
        GetUrl.instance.videoPlayer.SetDirectAudioVolume(0, slider.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }



    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
