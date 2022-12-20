using System;

namespace FbxSharp
{
    public abstract class FbxLayerElementTemplate<T> : FbxLayerElement
    {
        protected FbxLayerElementTemplate(EType type)
            : base(type)
        {
        }

        readonly LayerElementArrayT<T> direct = new LayerElementArrayT<T>();
        public LayerElementArrayT<T> GetDirectArray()
        {
            return direct;
        }

        readonly LayerElementArrayT<int> indexes = new LayerElementArrayT<int>();
        public LayerElementArrayT<int> GetIndexArray()
        {
            return indexes;
        }

        readonly LayerElementArrayT<double> wpomponent = new LayerElementArrayT<double>();
        public LayerElementArrayT<double> GetWComponentArray()
        {
            return wpomponent;
        }

        public override bool Clear()
        {
            direct.List.Clear();
            indexes.List.Clear();
            return true;
        }

        public int RemapIndexTo(FbxLayerElement.EMappingMode pNewMapping)
        {
            throw new NotImplementedException();
        }
    }
}

