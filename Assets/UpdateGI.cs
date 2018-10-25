using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGI : MonoBehaviour {

    Renderer rend;
    bool updateGI = true;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {
        if (updateGI)
            rend.UpdateGIMaterials();
	}
}
