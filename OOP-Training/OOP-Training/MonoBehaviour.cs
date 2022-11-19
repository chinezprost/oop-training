using System.Collections.Generic;
using System.Numerics;

namespace OOP_Training
{
    public class MonoBehaviour : Components
    {
        public List<Components> components = new List<Components>();
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public bool IsActive { get; set; }


        public void AddComponent<T>() where T : new()
        {
            var t = new T();
            components.Add(T);
        }
        
        
    }
    
    
}