using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private new Camera camera;

    [SerializeField]
    private GameObject carPrefab;

    [SerializeField]
    private int totalCars = 10;

    private void Start()
    {
        InstantiateCars();
    }

    private void InstantiateCars()
    {
        Rect area = camera.GetOrthographicCameraBounds();
        int extraCarsForVisibility = 2;
        float increment = area.height / (totalCars + extraCarsForVisibility);

        Vector3 position = area.position;
        position.x += area.width * 0.1f;

        for (int i = 0; i < totalCars; i++)
        {
            position.y += increment;
            Instantiate(carPrefab, position, Quaternion.identity);
        }
    }
}
