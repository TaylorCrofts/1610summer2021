using UnityEngine;

public class EulinerRotation : MonoBehaviour
{
    private float x =2f;
    void Update()
    {
        x = +Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(x,0,0);
    }
}
