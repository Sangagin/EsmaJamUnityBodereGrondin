using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{

    public List<EmmoteTypes> emotes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public EmmoteTypes giveRandomEmote()
    {
        var randomEmote = Random.Range(0, 10000);
        return emotes[randomEmote/1000];
    }
}
