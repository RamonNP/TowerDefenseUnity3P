using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : Tower
{
    public Transform pivot;
    public Transform barrel;
    public GameObject arrow;

    protected override void shoot()
    {
        base.shoot();

        GameObject newArrow = Instantiate(arrow, barrel.position, pivot.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
