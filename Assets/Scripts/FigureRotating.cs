using UnityEngine;

public class FigureRotating : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 rotationAxle = Vector3.up;

        transform.Rotate(rotationAxle * _speed * Time.deltaTime);
    }
}
