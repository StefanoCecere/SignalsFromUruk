using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SignalsFromUruk
{
    public class ObjectClick : MonoBehaviour
    {

        public Flowchart flowchart;

        public string onMouseDownMessage;

        void OnMouseDown()
        {
            if (!string.IsNullOrEmpty(onMouseDownMessage)) {
                flowchart.SendFungusMessage(onMouseDownMessage);
            }
        }
    }
}