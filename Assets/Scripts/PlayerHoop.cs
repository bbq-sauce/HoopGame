using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerHoop : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    public float bounceForce = 1f;
   //public float rotationSpeed = 50f;
    public float rotationDuration = 3f;
    public float throwForce = 10f;
    public Transform target;
    //private bool isThrowing = false;
    private Rigidbody rb;

    void Start()
    {
        audio.GetComponent<AudioSource>().loop = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mousedown");
            // Start throwing the hoop
            //isThrowing = true;
            if (audio != null && audio.clip != null)
            {
                audio.Play();
            }
            ThrowHoop();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mousereleased");
            // Stop throwing the hoop and apply a bounce force
            //isThrowing = false;
            //audio.Stop();
            StartCoroutine(RotateDuringTime());
        }
    }

    void ThrowHoop()
    {
        //int velocityDir = Random.Range(-1, 1);
        // Apply force to throw the hoop upwards
        Vector3 directionToTarget = target.position - transform.position;
        //rb.velocity = directionToTarget.normalized * throwForce;
        rb.velocity = new Vector3(directionToTarget.x, throwForce, directionToTarget.z);
    }

    IEnumerator RotateDuringTime()
    {
        
        rb.angularVelocity= new Vector3 (bounceForce, bounceForce, 0);
            // Rotate the object continuously
           // rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);

            
            yield return null; // Wait for the next frame
        

        // Optionally, you can stop rotating or perform other actions after the specified time
        //StopRotating();
    }
}
