using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathFollower : MonoBehaviour {

    /*Node[] PathNode;
    public GameObject player;
    public float moveSpeed;
    float timer;
    int currentNode;
    static Vector3 currentPositionHolder;*/

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private GameObject[] myWaypoints;
    private int myWaypointId = 0;

    // Use this for initialization
    void Start () {
        //PathNode = GetComponentsInChildren<Node>();
        //CheckNode();
	}

    /*void CheckNode()
    {
        if(currentNode < PathNode.Length - 1)
        {
            timer = 0;
            currentPositionHolder = PathNode[currentNode].transform.position;
        }
    }*/


    void EnemyMovement()
    {
        // если точки есть
        if (myWaypoints.Length != 0)
        {
            // если мы уже достигли назначенной точки, то переходим к следующей
            if (Vector3.Distance(myWaypoints[myWaypointId].transform.position, transform.position) <= 0)
            {
                myWaypointId++;
            }

            //если точки исчерпаны то переходим к началу массива точек
            if (myWaypointId >= myWaypoints.Length)
            {
                myWaypointId = 0;
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            //движемся в назначенную точку
            // move towards waypoint
            transform.position = Vector3.MoveTowards(transform.position, myWaypoints[myWaypointId].transform.position, moveSpeed * Time.deltaTime);
            //transform.rotation = Quaternion.Lerp(transform.rotation, myWaypoints[myWaypointId].transform.rotation, moveSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update () {
        /*Debug.Log(currentNode);
        timer += Time.deltaTime * moveSpeed;
        if(player.transform.position != currentPositionHolder)
        {
            player.transform.position = Vector3.Lerp(player.transform.position, currentPositionHolder, timer);
        }
        else
        {
            if(currentNode < PathNode.Length - 1)
            {
                currentNode++;
                CheckNode();
            }
        }*/

        EnemyMovement();
    }
}
