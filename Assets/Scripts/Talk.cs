using UnityEngine;
using Fungus;

public class Talk : MonoBehaviour {
    public GameObject bubbleTalk;
    public Flowchart flowchart;

    private bool isInside = false;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && isInside) {
            flowchart.ExecuteBlock("Oh wow");
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        isInside = true;
        bubbleTalk.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) {
        isInside = false;
        bubbleTalk.SetActive(false);
    }
}
