using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Kretanje : MonoBehaviour
{
    public Text countText;
    public float speed;
    private int zbroj;
    private Rigidbody rb;
    private int count;

    void Start()
    {
        //dohvaćanje komponente 
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    void FixedUpdate ()
    {
        float kretanjeHorizontal = Input.GetAxis("Horizontal");
        float kretanjeVertical = Input.GetAxis ("Vertical");

        Vector3 kretanje = new Vector3 (kretanjeHorizontal,0.0f,
            kretanjeVertical);

       
        rb.AddForce(speed*movement);
    }   

         void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);

            zbroj += 1;

            SetCountText ();
        }
    }
    //postavlja tekst objekta Text 

    void SetCountText ()
    {

        countText.text = "Rezultat: " + zbroj.ToString ();
    }
}