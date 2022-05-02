using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public float speed;
    private WayPoint Wpoint;
    private int waypointindex;

    private void Awake()
    {
        enemis.enemies.Add(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

        Wpoint = GameObject.FindGameObjectWithTag("WayPoint").GetComponent<WayPoint>();
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, Wpoint.waypoints[waypointindex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoint.waypoints[waypointindex].position) < 0.1f)
        {
            if(transform.position.x > Wpoint.waypoints[waypointindex].position.x)
            {
                this.transform.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                this.transform.GetComponent<SpriteRenderer>().flipX = false;
            }
        }

            /* Vector3 dir = Wpoint.waypoints[waypointindex].position - transform.position;
             float angle = Mathf.Atan2( dir.y, dir.x) * Mathf.Rad2Deg;
             transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);*/

            if (Vector2.Distance(transform.position, Wpoint.waypoints[waypointindex].position) < 0.1f)
        {
            if (waypointindex < Wpoint.waypoints.Length - 1)
            {
                waypointindex++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void die()
    {
        enemis.enemies.Remove(gameObject);
    }

}
