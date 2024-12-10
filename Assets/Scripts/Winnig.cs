using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winnnig : MonoBehaviour
{
    public GameObject BlockParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BlockParent.transform.childCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
