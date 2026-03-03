using System;

namespace UnityEngine.Rendering.Universal;

[Flags]
public enum DebugLightingFeatureFlags
{
	None = 0,
	GlobalIllumination = 1,
	MainLight = 2,
	AdditionalLights = 4,
	VertexLighting = 8,
	Emission = 0x10,
	AmbientOcclusion = 0x20
}
