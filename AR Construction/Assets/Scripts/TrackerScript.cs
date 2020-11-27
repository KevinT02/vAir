using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class TrackerScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioSource audio;
    public Slider audiovolume;
    
    public VideoPlayer video;
    public Button nxtbtn;

    Slider tracking;
    bool slide = false;
    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider>();
    }

    public void OnPointerDown(PointerEventData a)
    {
        slide = true;
    }

    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)tracking.value * (float)video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!slide)
        {
            tracking.value = (float)video.frame / (float)video.frameCount;
        }
    }

    public void nextbutton()
    {
        float nb = GetComponent<Slider>().value;
        if (nb > 0.99)
        {
            nxtbtn.gameObject.SetActive(true);
        }
        else
            nxtbtn.gameObject.SetActive(false);
    }

    public void volume()
    {
        audio.volume = audiovolume.value;
    }
}
