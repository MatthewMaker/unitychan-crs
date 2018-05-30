using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danceSwitch : MonoBehaviour {

    [SerializeField]
    int n, b;
    Animator anm;

    // Use this for initialization
    void Start()
    {
        anm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anm.SetBool("Next", false);
        if (n > 0)
        {
            anm.SetBool("Next", true);
            n -= 1;
        }
        anm.SetBool("Back", false);
        if (b > 0)
        {
            anm.SetBool("Back", true);

            b -= 1;
        }

    }
}
