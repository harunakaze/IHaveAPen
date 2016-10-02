using UnityEngine;
using Fungus;

public class Talk : MonoBehaviour {
    public GameObject bubbleTalk;
    public Flowchart flowchart;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            flowchart.ExecuteBlock("Oh wow");
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        bubbleTalk.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other) {
        bubbleTalk.SetActive(false);
    }
}
