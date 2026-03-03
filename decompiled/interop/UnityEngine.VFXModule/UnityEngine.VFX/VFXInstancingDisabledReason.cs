namespace UnityEngine.VFX;

public enum VFXInstancingDisabledReason
{
	None = 0,
	IndirectDraw = 1,
	OutputEvent = 2,
	GPUEvent = 4,
	AutomaticBounds = 8,
	MeshOutput = 16,
	ExposedObject = 32,
	ShaderKeyword = 64,
	Unknown = -1
}
