namespace UnityEngine.Rendering;

public static class CameraEventUtils
{
	public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

	public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;

	public static bool IsValid(CameraEvent value)
	{
		return value >= CameraEvent.BeforeDepthTexture && value <= CameraEvent.AfterHaloAndLensFlares;
	}
}
