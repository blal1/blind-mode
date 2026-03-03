using Il2CppSystem;

namespace UnityEngine;

public sealed class GUIText
{
	public bool text
	{
		get
		{
			FeatureRemoved();
			return false;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public Material material
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

	public Font font
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

	public TextAlignment alignment
	{
		get
		{
			FeatureRemoved();
			return TextAlignment.Left;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public TextAnchor anchor
	{
		get
		{
			FeatureRemoved();
			return TextAnchor.UpperLeft;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public float lineSpacing
	{
		get
		{
			FeatureRemoved();
			return 0f;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public float tabSize
	{
		get
		{
			FeatureRemoved();
			return 0f;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public int fontSize
	{
		get
		{
			FeatureRemoved();
			return 0;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			FeatureRemoved();
			return FontStyle.Normal;
		}
		set
		{
			FeatureRemoved();
		}
	}

	public bool richText
	{
		get
		{
			FeatureRemoved();
			return false;
		}
		set
		{
			FeatureRemoved();
		}
	}

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

	public Vector2 pixelOffset
	{
		get
		{
			FeatureRemoved();
			return new Vector2(0f, 0f);
		}
		set
		{
			FeatureRemoved();
		}
	}

	public static void FeatureRemoved()
	{
		throw new Exception("GUIText has been removed from Unity. Use UI.Text instead.");
	}
}
