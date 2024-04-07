using System;
using UnityEngine;
using Lean.Transition;
using Unity.VisualScripting;

namespace UI
{
    public class MainMenuController : MonoBehaviour
    {

        [SerializeField] private Canvas mainMenuCanvas;

        [SerializeField] private Canvas exerciseListCanvas;
        
        private void Start()
        {
            exerciseListCanvas.GameObject().SetActive(false);
        }

        public void OpenExerciseList()
        {
            mainMenuCanvas.GameObject().SetActive(false);
            exerciseListCanvas.GameObject().SetActive(true);
        }

        public void OpenMainMenu()
        {
            mainMenuCanvas.GameObject().SetActive(true);
            exerciseListCanvas.GameObject().SetActive(false);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}