using Il2CppInterop.Runtime;

namespace UnityEngine.U2D;

public static class PixelPerfectRendering
{
	private delegate float get_pixelSnapSpacingDelegate();

	private delegate void set_pixelSnapSpacingDelegate(float value);

	private static readonly get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");

	private static readonly set_pixelSnapSpacingDelegate set_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<set_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing");

	public static float pixelSnapSpacing
	{
		get
		{
			return get_pixelSnapSpacingDelegateField();
		}
		set
		{
			set_pixelSnapSpacingDelegateField(value);
		}
	}
}
