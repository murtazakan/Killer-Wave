using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    SOActorModel actorModel;
    GameObject playerShip;
    
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePlayer()
    {
        //CREATE PLAYER
        actorModel = Object.Instantiate(Resources.Load("Player_Default")) as SOActorModel;
        playerShip = GameObject.Instantiate(actorModel.actor) as GameObject;
        playerShip.GetComponent<Player>().ActorStats(actorModel);
        //SET PLAYER UP
        playerShip.transform.rotation = Quaternion.Euler(0,180,0);
        playerShip.transform.localScale = new Vector3(60,60,60);
        playerShip.name = "Player";
        playerShip.transform.SetParent(this.transform);
        playerShip.transform.position = Vector3.zero;
    }
}
