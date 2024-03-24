using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] public float productionTime;
        [SerializeField] GameResource resource;
        [SerializeField] ResourceBank bank;
        [SerializeField] Button button;
        [SerializeField] Slider progressSlider;
        [SerializeField] ProductionBuilding productionBuilding;
        private bool running = false;

        public void Increase()
        {
            if (!running)
            {
                running = true;
                button.interactable = false;
                StartCoroutine(ProductionBuildingCoroutine());
            }
        }
        
        IEnumerator ProductionBuildingCoroutine()
        {
            float timeWasted = 0f;
            progressSlider.value = 0f;
            progressSlider.gameObject.SetActive(true);
            while (timeWasted < productionTime)
            {
                timeWasted += Time.deltaTime;    
                progressSlider.value = timeWasted / productionTime; 
                yield return null; 
            }
            bank.ChangeRecources(resource, 1);
            running = false;
            button.interactable = true;
        }
        
        public void RiseLevel()
        {
            bank.ChangeRecources(resource, 10);
            productionBuilding.productionTime = 1f - (float)bank.resourcesMap[resource].Value / 100f;
        }
    }
}