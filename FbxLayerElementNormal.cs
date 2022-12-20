using System;

namespace FbxSharp
{
    public class FbxLayerElementNormal : FbxLayerElementTemplate<FbxVector4>
    {
        public FbxLayerElementNormal()
            : base(EType.eNormal)
        {
        }
    }
}

