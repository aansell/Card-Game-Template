using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card_data> player_deck = new List<Card_data>();
    public List<Card_data> ai_deck = new List<Card_data>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> player_discard_pile = new List<Card>();
    public List<Card> ai_discard_pile = new List<Card>();
    public Canvas canvas;
    public GameObject blank_card;
    public Vector3 player_hand_location;
    public Vector3 ai_hand_location;
    

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        canvas = FindAnyObjectByType<Canvas>();
        ai_hand_location = player_hand_location + new Vector3 (0,350,0);

        //create a new_card that is a clone of blank_card, place it at player_hand_location, default rotation, child to canvas
        GameObject new_card = Instantiate(blank_card, player_hand_location, Quaternion.identity, canvas.transform);
        new_card.GetComponent<Card>().data = player_deck[0];

        //create a new_ai_card that is a clone of blank_card, place it at ai_hand_location, default rotation, child to canvas
        GameObject new_ai_card = Instantiate(blank_card, ai_hand_location, Quaternion.identity, canvas.transform);
        new_ai_card.GetComponent<Card>().data = ai_deck[0];
        new_card.GetComponent<DraggableUI>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Deal()
    {

    }

    void Shuffle()
    {

    }

    void AI_Turn()
    {

    }



    
}
