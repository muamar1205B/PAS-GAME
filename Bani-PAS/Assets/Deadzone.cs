using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Deadzone : MonoBehaviour
{

    public GameObject mesh;
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
        Destroy(mesh);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
