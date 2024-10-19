using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int MoveSpeed;
    public float MaxDist;
    public float MinDist;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 EnemyPos = transform.position;
        Vector3 PlayerPos = Player.position;
        float distancia =
            Vector3.Distance(EnemyPos, PlayerPos);

        if (distancia >= MinDist && distancia <= MaxDist)
        {
            Vector3 targetPos = new Vector3(Player.position.x, this.transform.position.y);
            transform.LookAt(targetPos);
            transform.position += transform.forward *MoveSpeed*Time.deltaTime;
        }
    }
}
