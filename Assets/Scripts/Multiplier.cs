using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour {

    public Transform prefab;
    void Start(){
        for (int i = 0; i < 300; i++){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
