using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("Target References")]
    public Transform target;
    public Transform spawnPoint1;
    
    public float arcHeight = 5f;
    public float moveDuration = 3f;
    
    private void Start()
    {
        StartCoroutine(Creature1());
    }

    private IEnumerator Creature1()
    {
        float elapsedTime = 0;

        while (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            var t = elapsedTime / moveDuration;

            transform.position = QuadraticLerp(t);
            
            yield return null;
        }
    }
    
    private Vector3 QuadraticLerp(float t)
    {
        var p0 = target.position;
        var p2 = spawnPoint1.position;
                
        var p1 = (p0 + p2) * 0.5f + Vector3.up * arcHeight;
                
        var a = Vector3.Lerp(p0, p1, t);
        var b = Vector3.Lerp(p1, p2, t);
        return Vector3.Lerp(a, b, t);
    }
}