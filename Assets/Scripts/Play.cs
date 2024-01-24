using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject intro;
    public SpaceManager spaceManager;
    public GameObject grid;

public void play()
    {
        intro.SetActive(false);
        //grid.SetActive(true);
        spaceManager.setScoreActual(0);
    }
}
