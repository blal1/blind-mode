using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine;

public sealed class ProceduralTexture : Texture
{
	public bool hasAlpha
	{
		get
		{
			throw new Exception("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.");
		}
	}

	public TextureFormat format
	{
		get
		{
			throw new Exception("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.");
		}
	}

	public ProceduralOutputType GetProceduralOutputType()
	{
		throw new Exception("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.");
	}

	public ProceduralMaterial GetProceduralMaterial()
	{
		throw new Exception("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.");
	}

	public Il2CppStructArray<Color32> GetPixels32(int x, int y, int blockWidth, int blockHeight)
	{
		throw new Exception("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.");
	}
}
