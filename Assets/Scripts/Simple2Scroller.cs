﻿using UnityEngine;
using System.Collections;

public class Simple2Scroller : MonoBehaviour {

    public int scrollingSpeed = 1;

    [SerializeField]
    private PictureScroll scrollOne;

    [SerializeField]
    private PictureScroll scrollTwo;

    void Awake() {
        scrollOne.Init();
        scrollTwo.Init();
    }

    void Update() {
        var direction = Input.GetAxisRaw("Horizontal");

        Scroll(scrollOne, -direction);
        Scroll(scrollTwo, -direction);

        ResetPos(scrollOne, scrollTwo);
        ResetPos(scrollTwo, scrollOne);
    }

    void Scroll(PictureScroll pic, float direction) {
        var movement = new Vector3(direction, 0, 0) * scrollingSpeed * Time.deltaTime;
        var newPosition = pic.transform.position + movement;
        pic.transform.position = newPosition;
    }

    void ResetPos(PictureScroll pic, PictureScroll otherPic) {
        if (otherPic.IsOutOfBounds(false)) {
            var resetPos = otherPic.transform.position.x - otherPic.halfImageWidth - pic.halfImageWidth;
            pic.transform.position = new Vector3(resetPos, pic.transform.position.y, pic.transform.position.z);
        }
        else if (otherPic.IsOutOfBounds()) {
            var resetPos = otherPic.transform.position.x + otherPic.halfImageWidth + pic.halfImageWidth;
            pic.transform.position = new Vector3(resetPos, pic.transform.position.y, pic.transform.position.z);
        }
    }
}
