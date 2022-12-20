using System;

namespace FbxSharp
{
    public class FbxLayerElementTangent : FbxLayerElementTemplate<FbxVector4>
    {
        public FbxLayerElementTangent()
            : base(EType.eTangent)
        {
        }
    }
}

