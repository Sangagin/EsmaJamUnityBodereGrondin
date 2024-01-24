using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emote : MonoBehaviour
{

    public MoveManager moveManager;
    public int posX, posY, id;
    private EmmoteTypes type;
    public EmoteManager emoteManager;
    public SpriteRenderer look;
    public SpaceManager spaceManager;

    private List<emote> emoteListTempPlacement;
    private List<emote> emoteListTempPlacementToMove;
    private List<emote> emoteListTempCheckDestroy1, emoteListTempCheckDestroy2, emoteListTempCheckDestroy3, emoteListTempCheckDestroy4, emoteListTempCheckDestroy5;
    // Start is called before the first frame update
    void Start()
    {
        type = emoteManager.giveRandomEmote();
        look.sprite = type.sprite;
        id = type.id;
    }

    // Update is called once per frame
    void Update()
    {




        List<List<emote>> rows = new List<List<emote>>();
        rows.Add(spaceManager.getRow1());
        rows.Add(spaceManager.getRow2());
        rows.Add(spaceManager.getRow3());
        rows.Add(spaceManager.getRow4());
        rows.Add(spaceManager.getRow5());



        var actual = rows[posY][posX].id;

        if (posY != 0 && posY != 4)
        {
            if (posX != 0 && posX != 4)
            {
                if (actual != (rows[posY][posX - 1].id) && actual != (rows[posY][posX + 1].id))
                {
                    if (actual != (rows[posY - 1][posX].id) && actual != (rows[posY + 1][posX].id))
                    {

                        //TO DO -> small anim
                        //spaceManager.partSys.Play();
                        var particules = Instantiate(spaceManager.partSys, this.gameObject.transform.position, this.gameObject.transform.rotation);
                        particules.Play();






                        var newType = emoteManager.giveRandomEmote();

                        while (type == newType)
                        {
                            newType = emoteManager.giveRandomEmote();
                            Debug.Log("pop");
                        }

                        type = newType;
                        look.sprite = type.sprite;
                        id = type.id;

                        var score = spaceManager.getScoreActual();
                        score += 10;
                        spaceManager.setScoreActual(score);



                    }
                }
            }
        }







    }


    public void pop()
    {
        
    }



    public void OnMouseDown()
    {
        var posXcurrent = moveManager.getPosXSelect();
        var posYcurrent = moveManager.getPosYSelect();
        if (posX == posXcurrent && posY == posYcurrent)
        {
            //reclick on already selected -> unselect
            moveManager.setPosXSelect(-1);
            moveManager.setPosYSelect(-1);
            moveManager.setEmoteSelected(null);
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;

        }
        else
        {




            if (posXcurrent == -1 && posYcurrent == -1)
            {

                this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                moveManager.setPosXSelect(posX);
                moveManager.setPosYSelect(posY);
                moveManager.setEmoteSelected(this.gameObject);
            }
            else
            {

                var moves = spaceManager.getMoves();
                moves--;
                spaceManager.setMoves(moves);

                GameObject selectedBefore = moveManager.getEmoteSelected();
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                selectedBefore.GetComponent<SpriteRenderer>().color = Color.white;
                //update pos in grid


                int posXBefore = moveManager.getPosXSelect();
                int posYBefore = moveManager.getPosYSelect();
                int posXActual = posX;
                int posYActual = posY;


                switch (posYBefore)
                {
                    case 0:
                        emoteListTempPlacement = spaceManager.getRow1();
                        break;
                    case 1:
                        emoteListTempPlacement = spaceManager.getRow2();
                        break;
                    case 2:
                        emoteListTempPlacement = spaceManager.getRow3();
                        break;
                    case 3:
                        emoteListTempPlacement = spaceManager.getRow4();
                        break;
                    case 4:
                        emoteListTempPlacement = spaceManager.getRow5();
                        break;

                }

                switch (posYActual)
                {
                    case 0:
                        emoteListTempPlacementToMove = spaceManager.getRow1();
                        break;
                    case 1:
                        emoteListTempPlacementToMove = spaceManager.getRow2();
                        break;
                    case 2:
                        emoteListTempPlacementToMove = spaceManager.getRow3();
                        break;
                    case 3:
                        emoteListTempPlacementToMove = spaceManager.getRow4();
                        break;
                    case 4:
                        emoteListTempPlacementToMove = spaceManager.getRow5();
                        break;

                }

                var toMove = emoteListTempPlacement[posXBefore];
                var toMove2 = emoteListTempPlacementToMove[posXActual];

                emoteListTempPlacement[posXBefore] = toMove2;

                switch (posYBefore)
                {
                    case 0:
                        spaceManager.setR1(emoteListTempPlacement);
                        break;
                    case 1:
                        spaceManager.setR2(emoteListTempPlacement);
                        break;
                    case 2:
                        spaceManager.setR3(emoteListTempPlacement);
                        break;
                    case 3:
                        spaceManager.setR4(emoteListTempPlacement);
                        break;
                    case 4:
                        spaceManager.setR5(emoteListTempPlacement);
                        break;

                }
                switch (posYActual)
                {
                    case 0:
                        emoteListTempPlacementToMove = spaceManager.getRow1();
                        break;
                    case 1:
                        emoteListTempPlacementToMove = spaceManager.getRow2();
                        break;
                    case 2:
                        emoteListTempPlacementToMove = spaceManager.getRow3();
                        break;
                    case 3:
                        emoteListTempPlacementToMove = spaceManager.getRow4();
                        break;
                    case 4:
                        emoteListTempPlacementToMove = spaceManager.getRow5();
                        break;

                }


                emoteListTempPlacementToMove[posXActual] = toMove;

                switch (posYActual)
                {
                    case 0:
                        spaceManager.setR1(emoteListTempPlacementToMove);
                        break;
                    case 1:
                        spaceManager.setR2(emoteListTempPlacementToMove);
                        break;
                    case 2:
                        spaceManager.setR3(emoteListTempPlacementToMove);
                        break;
                    case 3:
                        spaceManager.setR4(emoteListTempPlacementToMove);
                        break;
                    case 4:
                        spaceManager.setR5(emoteListTempPlacementToMove);
                        break;

                }


                posX = posXBefore;
                posY = posYBefore;

                var scriptBefore = selectedBefore.GetComponent<emote>();
                scriptBefore.posX = posXActual;
                scriptBefore.posY = posYActual;




                //move objects
                Vector3 posBefore = selectedBefore.transform.position;
                Vector3 posActual = this.transform.position;



                selectedBefore.transform.position = posActual;
                //selectedBefore.transform.position = Vector3.MoveTowards(selectedBefore.transform.position, posActual, 1 * Time.deltaTime);
                this.transform.position = posBefore;

                //reset select
                moveManager.setPosXSelect(-1);
                moveManager.setPosYSelect(-1);
                moveManager.setEmoteSelected(null);
            }

        }



    }






}
