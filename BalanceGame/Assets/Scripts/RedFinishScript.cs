using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedFallScript : MonoBehaviour
{
    public Transform resp;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitSometimeCor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //WaitSometimeCor();
        if(other.tag=="Player")
        {
            obj.GetComponent<Animation>().Play();
        }
        //other.transform.position = resp.transform.position;
        //SceneManager.LoadScene("Level1")
        //Destroy(gameObject, .5f);
    }
    private IEnumerator WaitSometimeCor()
    {     
        yield return new WaitForSeconds(1);      
    }
}
