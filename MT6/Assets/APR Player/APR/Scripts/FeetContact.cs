using UnityEngine;
using Photon.Pun;




public class FeetContact : MonoBehaviour
{


	public APRController APR_Player;
    [SerializeField] private PhotonView PV;

    //Alert APR player when feet colliders enter ground object layer
    void OnCollisionEnter(Collision col)
	{

        PV = GetComponent<PhotonView>();
        if (PV.IsMine)
        {
            if (!APR_Player.isJumping && APR_Player.inAir)
            {
                if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    APR_Player.PlayerLanded();
                }
            }
        }
        else
        {
            return;
        }
	}
}
