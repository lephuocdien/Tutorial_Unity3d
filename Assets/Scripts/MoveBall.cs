using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rg;
    public float speed = 2;
    public float jumbspeed = 2;
    private bool istouching =false;
    public Text cointext;
    float numbercoin ;
    public AudioSource asource;
    public AudioClip aclip;
    void Start()
    {
        numbercoin = 3;
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        cointext.text = "COINS :" + numbercoin;
        {
            float HMove = Input.GetAxis("Horizontal");
            float VMove = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(HMove, 0.0f, VMove);
            rg.AddForce(move *speed);
            if((Input.GetKey(KeyCode.Space) ) && istouching )
            {
                Vector3 jumball = new Vector3(0.0f, 6.0f, 0.0f);
                rg.AddForce(jumball * jumbspeed);
                istouching = false;
            }
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        istouching = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("cointag"))
        {
            asource.PlayOneShot(aclip);
            numbercoin--;
            other.gameObject.SetActive(false);
            if (numbercoin == 0)
                SceneManager.LoadScene("endscence");
        }
    }
}
