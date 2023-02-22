using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScript : MonoBehaviour
{
    public float BBQBottles = 0;
    public TMP_Text bbqCount;
    public ParticleSystem party;
    public GameObject markZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("bbq"))
        {
            ParticleSystem partay = Instantiate(party, other.gameObject.transform.position, transform.rotation);
            Destroy(other.gameObject);
            BBQBottles = BBQBottles + 1;
            bbqCount.text = BBQBottles.ToString() + " / 7 BBQ Bottles";

        }
        if (other.CompareTag("doom"))
        {
            if (BBQBottles>= 7){
                Destroy(other.gameObject);
                bbqCount.text = "You Escaped!";

            }
            else{
                markZ.transform.position = new Vector3(5, 4, 41);
                Rigidbody rb = markZ.AddComponent<Rigidbody>();
                rb.AddForce(markZ.transform.forward * 500);
                Debug.Log(markZ);
                bbqCount.text = "THE ZUCK HUNGERS";
            }
        }
    }
    }
