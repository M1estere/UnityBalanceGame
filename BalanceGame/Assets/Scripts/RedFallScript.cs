using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedFinishScript : MonoBehaviour
{
    public Transform resp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        //SceneManager.LoadScene("Level1");
        StartCoroutine(DestroyPlatform(2));
    }
    IEnumerator DestroyPlatform (float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);   
    }
}
