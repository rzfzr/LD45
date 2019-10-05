using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public GameObject player;
    //[SerializeField]
    [Range (1f, 20f)]
    public float speed = 10;
    float speedBoosted = 30;
    //Rigidbody rb;

    void Start () {

    }

    // Update is called once per frame
    void Update () {

        // if (Input.GetKey (KeyCode.Space)) {
        //     player.transform.position += new Vector3 (0, .1f, 0);
        // }

        if (Input.GetKey (KeyCode.LeftControl)) { // && boostSlider.value != 0) {
            player.transform.position += new Vector3 (Input.GetAxis ("Horizontal") * speedBoosted * Time.deltaTime, Input.GetAxis ("Vertical") * speed * Time.deltaTime, 0);
            // boostSlider.value -= 25 * Time.deltaTime;
            //gameObject.GetComponent<TrailRenderer> ().enabled = true;
        } else {
            player.transform.position += new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, Input.GetAxis ("Vertical") * speed * Time.deltaTime, 0);

            // gameObject.GetComponent<TrailRenderer> ().Clear ();
            // gameObject.GetComponent<TrailRenderer> ().enabled = false;

        }
    }

}