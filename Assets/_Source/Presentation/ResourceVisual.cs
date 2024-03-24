using Core;
using System.ComponentModel;
using UnityEngine;
using TMPro;

namespace Presentation
{
    public class ResourceVisual : MonoBehaviour 
    {
        [SerializeField] GameResource typeOfResource;
        [SerializeField] ResourceBank bank;
        [SerializeField] TextMeshProUGUI text;
        void Start()
        {
            if (bank != null)
            {
                ObservableInt resource = bank.GetResource(typeOfResource);
                resource.PropertyChanged += UpdateTextEvent;
                UpdateText(resource.Value);
            }
        }

        void UpdateTextEvent(object observableIntObject, PropertyChangedEventArgs example)
        {
            UpdateText(((ObservableInt)observableIntObject).Value);
        }

        void UpdateText(int value)
        {
            text.text = $"{value}";
        }
    }
}
