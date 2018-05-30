using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationHandler : MonoBehaviour {


    public StationHandler nextStation;
    public StationHandler previousStation;

    public AudioSource narrationAudioSource;
    public Transform playerPositionTransform;

    public void GotoNextStation()
    {
        AppManager.Instance.SwitchStation(this, nextStation);
    }
    
    public void GotoPreviousStation()
    {
        AppManager.Instance.SwitchStation(this, previousStation);

    }

    public void StartNarration()
    {
        if (narrationAudioSource != null)
        {
            narrationAudioSource.Play();
        }
    }

    public void StopNarration()
    {
        if (narrationAudioSource != null)
        {
            narrationAudioSource.Stop();
        }

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
