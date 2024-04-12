using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public Camera mainCamera; // Référence à la caméra principale
    public Camera playerCamera; // Référence à la caméra du joueur

    private bool isFollowingPlayer = false; // État de suivi du joueur

    // Initialisation
    void Start()
    {
        // Assurez-vous que la caméra du joueur est désactivée au départ
        playerCamera.gameObject.SetActive(false);
    }

    // Update est appelée à chaque frame
    void Update()
    {
        // Détecter si la touche "C" a été pressée
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCamera();
        }
    }

    // Méthode pour commuter les caméras
    void ToggleCamera()
    {
        isFollowingPlayer = !isFollowingPlayer; // Inverser l'état de suivi

        // Activer/désactiver les caméras en fonction de l'état de suivi
        playerCamera.gameObject.SetActive(isFollowingPlayer);
        mainCamera.gameObject.SetActive(!isFollowingPlayer);
    }
}
