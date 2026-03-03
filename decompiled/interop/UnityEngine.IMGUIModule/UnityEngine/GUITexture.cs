using Il2CppSystem;

namespace UnityEngine;

public sealed class GUITexture
{
	public Color color
	{
		get
		{
			FeatureRemoved();
			return new Color(0f, 0f, 0f);
		}
		set
		{
			FeatureRemoved();
		}
	}

	public Texture texture
	{
		get
		{
			FeatureRemoved();
			return null;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public Rect pixelInset
	{
		get
		{
			FeatureRemoved();
			return default(Rect);
		}
		set
		{
			FeatureRemoved();
		}
	}

	public RectOffset border
	{
		get
		{
			FeatureRemoved();
			return null;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public static void FeatureRemoved()
	{
		throw new Exception("GUITexture has been removed from Unity. Use UI.Image instead.");
	}
}
