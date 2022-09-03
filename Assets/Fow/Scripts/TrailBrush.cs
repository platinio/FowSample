using Unity.Mathematics;
using UnityEngine;

namespace Platinio
{
    public class TrailBrush : MonoBehaviour
    {
        [SerializeField] private Transform m_container = null;
        [SerializeField] private float m_brushDistance = 0.15f;
        [SerializeField] private GameObject m_brushPrefab = null;
        
        private Vector3 m_lastUpdatePosition = Vector3.zero;


        private void Update()
        {
            float d = Vector3.SqrMagnitude(transform.position - m_lastUpdatePosition);
            if (d > m_brushDistance * m_brushDistance)
            {
                var clone = Instantiate(m_brushPrefab, transform.position, m_brushPrefab.transform.rotation);
                clone.transform.parent = m_container;
                m_lastUpdatePosition = transform.position;
            }
        }
    }
}

