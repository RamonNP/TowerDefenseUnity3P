using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField]private float range;
    [SerializeField]private float damage;
    [SerializeField]private float timeBetweenShots;

    private float nextTimeToShoot;

    private GameObject currentTarget;

    void Start()
    {
        nextTimeToShoot = Time.time;
    }

    void Update()
    {
        updateNeartestEnemy();

        if(Time.time >= nextTimeToShoot)
        {
            if(currentTarget != null)
            {
                shoot();
                nextTimeToShoot = Time.time + timeBetweenShots;
            }
        }
    }

    private void updateNeartestEnemy()
    {
        GameObject currentNearestEnemy = null;

        float distance = Mathf.Infinity;

        foreach (GameObject inimigo in enemis.enemies)
        {
            if(inimigo != null)
            {
                float _distance = (transform.position - inimigo.transform.position).magnitude;

                if (_distance < distance)
                {
                    distance = _distance;
                    currentNearestEnemy = inimigo;
                }
            }
        }

        if (distance <= range)
        {
            currentTarget = currentNearestEnemy;
        }
        else
        {
            currentTarget = null;
        }
    }

    protected virtual void shoot()
    {
        Inimigo inimigoScript = currentTarget.GetComponent<Inimigo>();
        //inimigoScript.takeDamage(damage);
    }

}
