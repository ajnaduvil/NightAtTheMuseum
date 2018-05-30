using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{

    public static AppManager Instance;

    public GameObject player;
    [HideInInspector]
    public StationHandler currentStation;
  

    public Animator faderAC;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public IEnumerator CoroutineSwitchStation(StationHandler currentStation, StationHandler destinationStation)
    {
        faderAC.SetBool("fade", true);
        yield return new WaitForSeconds(.2f);
        currentStation.StopNarration();
        player.transform.position = destinationStation.playerPositionTransform.position;
        player.transform.LookAt(destinationStation.gameObject.transform);
        faderAC.SetBool("fade", false);
        destinationStation.StartNarration();
        this.currentStation = destinationStation;
    }
    public void SwitchStation(StationHandler currentStation, StationHandler destinationStation)
    {
        StartCoroutine(CoroutineSwitchStation(currentStation, destinationStation));


    }
}
