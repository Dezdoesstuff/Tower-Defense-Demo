using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")] 
    public float movementSpeed = 10f;
    
    // Stores the data instead to make zero garbage data
    private const string XAxis = "Horizontal";
    private const string ZAxis = "Vertical";
    
    private void Start()
    {
        // Set current position to start at origin (0)
        transform.position = new Vector3(0, 0, 0);
    }
    
    private void Update()
    {
        // Retrieve both horizonal and vertical input
        var inputX =+ Input.GetAxisRaw(XAxis);
        var inputZ =+ Input.GetAxisRaw(ZAxis);

        // Change position based on horizontal and vertical input
        transform.position = transform.position + new Vector3(inputX * movementSpeed * Time.deltaTime, 0, inputZ * movementSpeed * Time.deltaTime);
    }
}