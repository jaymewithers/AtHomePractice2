using UnityEngine;
using UnityEngine.Events;

public class MouseShooter : MonoBehaviour
{
    public GameObject ammo;
    public UnityEvent fireEvent;
    private Vector2 mouseLocation;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireEvent.Invoke();
        }
    }

    public void Shot()
    {
        var ammoTransform = transform;
        Instantiate(ammo, ammoTransform.position, ammoTransform.rotation);
    }

    public void AimAndShoot()
    {
        mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var instance = Instantiate(ammo, transform.position, Quaternion.identity);
        instance.transform.LookAt(mouseLocation);
    }
}