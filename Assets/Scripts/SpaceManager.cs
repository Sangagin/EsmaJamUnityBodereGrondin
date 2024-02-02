using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpaceManager : MonoBehaviour
{

    public List<GameObject> Spaces = new List<GameObject>();
    public ParticleSystem partSys;


    private int scoreActual=0;
    private int scoreExpected=1000;
    private int moves = 30;
    public TextMeshProUGUI textScoreActual;
    public TextMeshProUGUI textScoreExpected;
    public TextMeshProUGUI textMoves;


    public GameObject menu, victory, defeat,grid;



    public List<emote> r1,r2,r3,r4,r5 = new List<emote>();
   // public List<List<emote>> grid = new List<List<emote>>();  
    public bool test = true;


    // Start is called before the first frame update
    void Start()
    {


        scoreActual = 0;
        menu.SetActive(true);
        victory.SetActive(false);
        defeat.SetActive(false);
       // grid.SetActive(false);  


    }

    // Update is called once per frame
    void Update()
    {
        textScoreActual.text = ("Score : " + scoreActual);
        textScoreExpected.text = ("Objective : " + scoreExpected);
        textMoves.text = ("Moves Left : " + moves);



        if (moves <= 0)
        {
            defeat.SetActive(true);
        }
        if (scoreActual>=scoreExpected)
        {
            victory.SetActive(true);
        }

    }

    public List<emote> getRow1(){return r1;}
    public List<emote> getRow2() { return r2; }
    public List<emote> getRow3() { return r3; }
    public List<emote> getRow4() { return r4; }
    public List<emote> getRow5() { return r5; }
    public int getScoreActual() { return scoreActual; }
    public int getScoreExpected() {  return scoreExpected; }
    public int getMoves() { return moves; }

    public void setR1(List<emote> newR1)
    {
        r1 = newR1;
    }

    public void setR2(List<emote> newR2)
    {
        r2 = newR2;
    }
    public void setR3(List<emote> newR3)
    {
        r3 = newR3;
    }
    public void setR4(List<emote> newR4)
    {
        r4 = newR4;
    }
    public void setR5(List<emote> newR5)
    {
        r5 = newR5;
    }

    public void setScoreActual(int newScoreActual) { scoreActual = newScoreActual; }
    public void setScoreExppected(int newScoreExppected) { scoreExpected = newScoreExppected; }
    public void setMoves(int newMoves) {  moves = newMoves; }

}
