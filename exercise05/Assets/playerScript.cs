using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScript : MonoBehaviour
{
    public float BBQBottles = 0;
    public TMP_Text bbqCount;
    public ParticleSystem party;
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
            bbqCount.text = BBQBottles.ToString();

        }
    }
    }
