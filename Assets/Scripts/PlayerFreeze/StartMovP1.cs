using UnityEngine;

public class StartMovP1 : MonoBehaviour
{
    

    public void Oncliclick()
    {
        Rigidbody2D p1Rb = GetComponent<Rigidbody2D>();
        p1Rb.constraints = ~RigidbodyConstraints2D.FreezePosition;
    }
}
