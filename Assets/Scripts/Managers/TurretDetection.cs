using UnityEngine;

public class TurretDetection : MonoBehaviour
{
    public Transform target;
    
    private void Update()
    {
        var point2 = target.transform.position - this.transform.position;
        var point1 = this.transform.forward;
        var dot = point1.x * point2.x + point1.y * point2.y * point1.z * point2.z;
        
        Debug.Log($"Dot Product {dot}");
    }
}