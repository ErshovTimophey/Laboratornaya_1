using UnityEngine;

namespace Presentation
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Core.ResourceBank recouceBank;
        private void Awake()
        {
            recouceBank.resourcesMap.Add(Core.GameResource.Humans, new Core.ObservableInt(10));
            recouceBank.resourcesMap.Add(Core.GameResource.Food, new Core.ObservableInt(5));
            recouceBank.resourcesMap.Add(Core.GameResource.Wood, new Core.ObservableInt(5));
            recouceBank.resourcesMap.Add(Core.GameResource.Stone, new Core.ObservableInt(0));
            recouceBank.resourcesMap.Add(Core.GameResource.Gold, new Core.ObservableInt(0));
            recouceBank.resourcesMap.Add(Core.GameResource.HumansProdLvl, new Core.ObservableInt(1));
            recouceBank.resourcesMap.Add(Core.GameResource.FoodProdLvl, new Core.ObservableInt(1));
            recouceBank.resourcesMap.Add(Core.GameResource.WoodProdLvl, new Core.ObservableInt(1));
            recouceBank.resourcesMap.Add(Core.GameResource.StoneProdLvl, new Core.ObservableInt(1));
            recouceBank.resourcesMap.Add(Core.GameResource.GoldProdLvl, new Core.ObservableInt(1));
        }
    }
}