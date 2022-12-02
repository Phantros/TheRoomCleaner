using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBehaviour : MonoBehaviour
{
    [Header("References")]
    public Transform m_camera;
    public Transform m_target;
    public List<GameObject> throwables;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    private bool readyToThrow;

    [HideInInspector]
    public int colorPickUp;
    public int amountOfPickups;

    private void Start()
    {
        readyToThrow = false;
        colorPickUp = -1;
    }

    private void Update()
    {
        if(Input.GetKeyDown(throwKey) && readyToThrow)
        {
            Throw();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedCollectable") && !readyToThrow)
        {
            Destroy(other.gameObject);
            colorPickUp = 0;
        }

        if (other.gameObject.CompareTag("BlueCollectable") && !readyToThrow)
        {
            Destroy(other.gameObject);
            colorPickUp = 1;
        }

        if (other.gameObject.CompareTag("GreenCollectable") && !readyToThrow)
        {
            Destroy(other.gameObject);
            colorPickUp = 2;
        }

        if (other.gameObject.CompareTag("YellowCollectable") && !readyToThrow)
        {
            Destroy(other.gameObject);
            colorPickUp = 3;
        }

        amountOfPickups++;
        readyToThrow = true;
    }

    private void Throw()
    {
        readyToThrow = false;

        GameObject projectile = Instantiate(throwables[colorPickUp], m_target.position, m_camera.rotation);

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceToAdd = m_camera.transform.forward * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        colorPickUp = -1;
    }    
}
