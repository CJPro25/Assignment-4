using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public GameObject fractured;
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            BreakTheWall();
        }
    }

    public void BreakTheWall()
    {
        Instantiate(fractured, transform.position, transform.rotation);
        //Destroy(gameObject);
    }
}
