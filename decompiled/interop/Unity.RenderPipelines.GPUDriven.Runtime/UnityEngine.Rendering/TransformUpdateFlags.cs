using System;

namespace UnityEngine.Rendering;

[Flags]
public enum TransformUpdateFlags : byte
{
	None = 0,
	HasLightProbeCombined = 1,
	IsPartOfStaticBatch = 2
}
