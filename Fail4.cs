using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision GameObjectInformation)
    {
        if (GameObjectInformation.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Fail3");
        }

    }

}
