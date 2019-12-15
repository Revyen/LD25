using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public int playerCount = 4;
    private List<GameObject> players = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < playerCount; i++)
        {
            GameObject player = Instantiate(playerPrefab);
            PlayerMovement movement = player.GetComponent<PlayerMovement>();
            movement.horAxis = "Horizontal" + i;
            movement.vertAxis = "Vertical" + i;
            players.Add(player);   
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
