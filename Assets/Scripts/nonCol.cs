using UnityEngine;
using System.Collections;

public class nonCol : MonoBehaviour {
    static public bool isDamage;

    void Start() {
        isDamage = false;
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "stage"){
            isDamage = true;
        }
    }
}
