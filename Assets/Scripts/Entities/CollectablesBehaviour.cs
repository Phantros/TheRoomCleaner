using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesBehaviour : MonoBehaviour
{
    private float maxY;
    private float minY;

    private Vector3 moveSpeed = new Vector3(0, 0.5f, 0);

    private int throwablesLayer = 3;

    private void Awake()
    {
        maxY = this.transform.position.y + 0.25f;
        minY = this.transform.position.y - 0.25f;
    }

    void Update()
    {
        //Thrown projectiles will ignore the collectables in the scene. 
        Physics.IgnoreLayerCollision(throwablesLayer, throwablesLayer, true);

        //Move the collectable up and down for polish
        this.transform.position += moveSpeed * Time.deltaTime;

        if (this.transform.position.y > maxY || this.transform.position.y < minY)
        {
            moveSpeed = -moveSpeed;
        }
    }
}
