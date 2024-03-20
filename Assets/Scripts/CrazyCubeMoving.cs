using UnityEngine;

public class CrazyCubeMoving : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime, Space.World);

        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);

        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
