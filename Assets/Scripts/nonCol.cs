using UnityEngine;
using System.Collections;

public class nonCol : MonoBehaviour {
    static public bool isDamage;
    static public GameObject colMe;
    void Start() {
        isDamage = false;
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "stage"){
            colMe = this.gameObject;
            isDamage = true;
        }
    }
}
