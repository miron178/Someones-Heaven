using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPopup : MonoBehaviour
{

    public float delay = 4;
    // Start is called before the first frame update
    IEnumerator Start()
    {


        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
        Debug.Log("start up disabled");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
