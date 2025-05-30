using UnityEngine;

public static class CameraExtension
{
    public static Rect GetOrthographicCameraBounds(this Camera camera)
    {
        if (!camera.orthographic)
        {
            Debug.LogError("Camera is not orthographic!");
            return Rect.zero;
        }

        float height = camera.orthographicSize * 2.0f;
        float width = height * camera.aspect;

        Vector3 worldPosition = camera.transform.position;
        Vector2 bottomLeft = new(worldPosition.x - width * 0.5f, worldPosition.y - height * 0.5f);

        return new(bottomLeft, new(width, height));
    }
}
