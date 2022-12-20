using System;

namespace FbxSharp
{
    public class FbxLayerElementBinormal : FbxLayerElementTemplate<FbxVector4>
    {
        public FbxLayerElementBinormal()
            : base(EType.eBiNormal)
        {
        }
    }
}

