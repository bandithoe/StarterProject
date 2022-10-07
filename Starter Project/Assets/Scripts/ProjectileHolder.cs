using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHolder : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    public Transform shotPosition;
    public CurrentPlayerActive switchPlayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(projectilePrefab);
            newBullet.transform.position = shotPosition.position;
            newBullet.transform.rotation = gameObject.transform.rotation;
            newBullet.GetComponent<Projectile>().Initialize();
            //StartCoroutine(WaitForSwitch());

        }
        
        
    }
        private IEnumerator WaitForSwitch()
        {
            yield return new WaitForSeconds(3);
            switchPlayer.PlayerSwitch();
        }
}
