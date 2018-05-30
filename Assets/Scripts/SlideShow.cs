using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideShow : MonoBehaviour
{
    public float changeTime = 3f;
    public Sprite[] images;
    public Image targetImage;

    private int currentIndex = 0;

    public void NextPic()
    {
        currentIndex = (currentIndex + 1) % images.Length;
        targetImage.sprite = images[currentIndex];
    }

    // Use this for initialization
    void Start()
    {
        if (images != null && images.Length > 0)
        {

            targetImage.sprite = images[0];
            InvokeRepeating("NextPic", changeTime, changeTime);
        }
    }
}
