using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using OOP_Training;

namespace OOP_Training
{
    public class MonoBehaviour : Components
    {
        public List<Components> components = new List<Components>();
        
        
        
        public void AddComponent<T>(T component) where T : Components
        {
            try
            {
                if (this.components.Find(x => x == component) == null)
                {
                    components.Add(component);
                    Console.WriteLine("Component added.");
                }
            }
            catch (Exception _Ex)
            {
                Console.WriteLine($"Couldn't add component: {_Ex}");
            }
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


        public bool TransformCollider(GameObject gameObject_1, GameObject gameObject_2)
        {
            var distanceBetweenObjects =
                Vector3.Distance(gameObject_1.GetComponent<Transform>().Position, gameObject_2.GetComponent<Transform>().Position);
            
            
        }

        








    }
    
    
}

public class GameObject : MonoBehaviour
{
    
}
