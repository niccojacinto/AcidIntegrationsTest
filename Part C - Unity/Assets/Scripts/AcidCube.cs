using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidCube : MonoBehaviour {

    public Vector3 rotationSpeed;
    public Color color;

    IEnumerator UpdateCube(object[] data) {
        yield return new WaitForSeconds(1.0f); // Wait 1s
        rotationSpeed = (Vector3)data[0];
        gameObject.GetComponent<Renderer>().material.color = (Color)data[1];
    }

    
    private void Update() {
       transform.Rotate(rotationSpeed * Time.deltaTime);
    }

    // Testing
    public void TestRandom() {
        float x = Random.Range(0, 100);
        float y = Random.Range(0, 100);
        float z = Random.Range(0, 100);

        /*
        float r = Random.Range(0, 1);
        float g = Random.Range(0, 1);
        float b = Random.Range(0, 1);
        */
        
        object[] data = new object[2];
        data[0] = new Vector3(x,y,z);
        // data[1] = new Color(r,g,b,1);
        data[1] = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);


        StartCoroutine(UpdateCube(data));
    }
}
