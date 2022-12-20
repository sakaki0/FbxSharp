using System;
using System.Linq;
using System.Collections.Generic;

namespace FbxSharp
{
    public class FbxLayerElementVisibility : FbxLayerElementTemplate<bool>
	{
        public FbxLayerElementVisibility()
            : base(EType.eVisibility)
        {
        }
	}
}

