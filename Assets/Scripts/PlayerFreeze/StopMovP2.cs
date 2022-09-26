using UnityEngine;

public class StopMovP2 : MonoBehaviour
{
    public void Onclick()
    {
        Rigidbody2D rbP2 = GetComponent<Rigidbody2D>();
        
        rbP2.constraints = RigidbodyConstraints2D.FreezePosition;
        
    }
}
