using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    static float timer = 60;
    TimeSpan timerSpan = TimeSpan.FromSeconds(timer);
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject conclusionPainel;

    public PuzzleActivator puzzleAct;
    public FirstPersonController firstPersonController;

    void Update()
    {
        timer -= Time.deltaTime;
        timerSpan = TimeSpan.FromSeconds(timer);
        if (timer <= 0 || KillerCount.hasKilledAll)
        {
            conclusionPainel.SetActive(true);
            Time.timeScale = 0;
            PlayerStats.instance.SetUIingMode();
        }
        textMeshProUGUI.text = timerSpan.ToString(@"ss");
    }
    public void TryAgainBTN()
    {
        timer = 60;
        conclusionPainel.SetActive(false);
        puzzleAct.SummonObjects();
        puzzleAct.TeleportPlayer();
    }
    public void Goback()
    {
        PlayerStats.instance.SetWalkingMode();
        conclusionPainel.SetActive(false);
    }
}
// https://stackoverflow.com/questions/463642/how-can-i-convert-seconds-into-hourminutessecondsmilliseconds-time
// https://stackoverflow.com/questions/6356351/formatting-a-float-to-2-decimal-places
//textMeshProUGUI.text = timerSpan.ToString(@"mm\:ss\:ff");