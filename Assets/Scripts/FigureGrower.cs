using UnityEngine;

public class FigureGrower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = Vector3.one;

        transform.localScale += direction * _speed * Time.deltaTime;
    }
}
