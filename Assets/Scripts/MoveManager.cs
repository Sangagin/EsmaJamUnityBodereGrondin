using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    
    public int posXSelect,posYSelect;
    public GameObject emoteSelected;
    public GameObject moveSelected;


    private void Start()
    {
        posXSelect = -1; 
        posYSelect = -1;
    }

    public void move()
    {
        
    }

    public int getPosXSelect() { return posXSelect; }
    public int getPosYSelect() {  return posYSelect; }
    public void setPosXSelect(int newPosXSelect) { posXSelect= newPosXSelect; }
    public void setPosYSelect(int newPosYSelect) { posYSelect = newPosYSelect; }

    public GameObject getEmoteSelected() {  return emoteSelected; }
    public void setEmoteSelected(GameObject newEmoteSelected) {  emoteSelected = newEmoteSelected; }
    public GameObject getMoveSelected() { return moveSelected; }
    public void setMoveSelected(GameObject newMoveSelected) { moveSelected = newMoveSelected; }
}
