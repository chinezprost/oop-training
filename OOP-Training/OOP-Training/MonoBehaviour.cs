using System.Collections.Generic;
using System.Numerics;

namespace OOP_Training
{
    public class MonoBehaviour : Components
    {
        public List<Components> components = new List<Components>();
        
        
        
        public void AddComponent<T>(T component) where T : Components
        {
            components.Add(component);
        }

        public void RemoveComponent<T>(T component) where T : Components
        {
            components.Remove(component);
        }
        
        public T GetComponent<T>() where T : Components
        {
            foreach (var component in components)
            {
                if (component is T)
                {
                    return (T) component;
                }
            }

            return null;
        }








    }
    
    
}