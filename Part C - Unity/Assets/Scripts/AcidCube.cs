using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidCube : MonoBehaviour {

    Material material;
    public Vector3 rotationSpeed;
    public Color color;

    private void Awake() {
        material = gameObject.GetComponent<Material>();
    }

    IEnumerator UpdateCube(object[] data) {
        yield return new WaitForSeconds(1.0f); // Wait 1s
        rotationSpeed = (Vector3)data[0];
        material.color = (Color)data[1];
    }

    
    private void Update() {
       transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
