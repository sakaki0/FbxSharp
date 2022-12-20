using System;
using System.Collections.Generic;

namespace FbxSharp
{
    public class FbxLayerElementUV : FbxLayerElementTemplate<FbxVector2>
    {
        public FbxLayerElementUV()
            : base(EType.eUV)
        {
        }
    }
}

