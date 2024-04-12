using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public Camera mainCamera; // R�f�rence � la cam�ra principale
    public Camera playerCamera; // R�f�rence � la cam�ra du joueur

    private bool isFollowingPlayer = false; // �tat de suivi du joueur

    // Initialisation
    void Start()
    {
        // Assurez-vous que la cam�ra du joueur est d�sactiv�e au d�part
        playerCamera.gameObject.SetActive(false);
    }

    // Update est appel�e � chaque frame
    void Update()
    {
        // D�tecter si la touche "C" a �t� press�e
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCamera();
        }
    }

    // M�thode pour commuter les cam�ras
    void ToggleCamera()
    {
        isFollowingPlayer = !isFollowingPlayer; // Inverser l'�tat de suivi

        // Activer/d�sactiver les cam�ras en fonction de l'�tat de suivi
        playerCamera.gameObject.SetActive(isFollowingPlayer);
        mainCamera.gameObject.SetActive(!isFollowingPlayer);
    }
}
