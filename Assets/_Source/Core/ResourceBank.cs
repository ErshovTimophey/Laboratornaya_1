using System.Collections.Generic;
using UnityEngine;


namespace Core 
{
    public class ResourceBank : MonoBehaviour 
    {
        public Dictionary<GameResource, ObservableInt> resourcesMap = new();
        public void ChangeRecources(GameResource resource, int value)
        {
            resourcesMap[resource].Value += value;
        }
        
        public ObservableInt GetResource(GameResource resource)
        {
            return resourcesMap[resource];
        }  
    }
}
