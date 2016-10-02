using UnityEngine;

public class PictureScroll {
    public SpriteRenderer sprite;
    public Transform transform;
    public float halfImageWidth;

    private readonly float halfCamWidth;

    public PictureScroll(SpriteRenderer spriteRenderer) {
        sprite = spriteRenderer;
        transform = sprite.transform;

        var imageWidth = sprite.bounds.size.x;
        halfImageWidth = imageWidth / 2.0f;

        var cam = Camera.main;
        var camHeight = 2.0f * cam.orthographicSize;
        var camWidth = camHeight * cam.aspect;
        halfCamWidth = camWidth / 2.0f;
    }

    public bool isOutOfBounds(bool rightEdge = true) {
        float edgeX = 0.0f;

        if (rightEdge) {
            edgeX = transform.position.x + halfImageWidth;
            return (edgeX <= Camera.main.transform.position.x + halfCamWidth);
        }
        else {
            edgeX = transform.position.x - halfImageWidth;
            return (edgeX >= Camera.main.transform.position.x - halfCamWidth); ;
        }
    }
}
