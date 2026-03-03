using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.TerrainTools;

public class PaintContext
{
	public interface ITerrainInfo
	{
	}

	public class TerrainTile
	{
	}

	public class SplatmapUserData
	{
	}

	public enum ToolAction
	{
		None = 0,
		PaintHeightmap = 1,
		PaintTexture = 2,
		PaintHoles = 4,
		AddTerrainLayer = 8
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	public sealed class _003C_003Ec__DisplayClass53_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass60_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass61_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass63_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass66_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass67_0
	{
	}

	public const int k_MinimumResolution = 1;

	public const int k_MaximumResolution = 8192;

	public Terrain originTerrain
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public RectInt pixelRect
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int targetTextureWidth
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int targetTextureHeight
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Vector2 pixelSize
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public RenderTexture sourceRenderTexture
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public RenderTexture destinationRenderTexture
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public RenderTexture oldRenderTexture
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int terrainCount
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float heightWorldSpaceMin
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public float heightWorldSpaceSize
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static float kNormalizedHeightScale => 0.4999771f;

	public Terrain GetTerrain(int terrainIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_onTerrainTileBeforePaint(Il2CppSystem.Action<ITerrainInfo, ToolAction, string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_onTerrainTileBeforePaint(Il2CppSystem.Action<ITerrainInfo, ToolAction, string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int ClampContextResolution(int resolution)
	{
		return Mathf.Clamp(resolution, 1, 8192);
	}

	public static PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, [Optional] int extraBorderPixels, [Optional] bool sharedBoundaryTexel, [Optional] bool fillOutsideTerrain)
	{
		return new PaintContext(terrain, TerrainPaintUtility.CalcPixelRectFromBounds(terrain, boundsInTerrainSpace, inputTextureWidth, inputTextureHeight, extraBorderPixels, sharedBoundaryTexel), inputTextureWidth, inputTextureHeight, sharedBoundaryTexel, fillOutsideTerrain);
	}

	public void FindTerrainTilesUnlimited(bool sharedBoundaryTexel, bool fillOutsideTerrain)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void CreateRenderTargets(RenderTextureFormat colorFormat)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Cleanup([Optional] bool restoreRenderTexture)
	{
		if (restoreRenderTexture)
		{
			RenderTexture.active = oldRenderTexture;
		}
		RenderTexture.ReleaseTemporary(sourceRenderTexture);
		RenderTexture.ReleaseTemporary(destinationRenderTexture);
		sourceRenderTexture = null;
		destinationRenderTexture = null;
		oldRenderTexture = null;
	}

	public void GatherInternal(Il2CppSystem.Func<ITerrainInfo, Texture> terrainToTexture, Color defaultColor, string operationName, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Il2CppSystem.Action<ITerrainInfo> beforeBlit, [Optional] Il2CppSystem.Action<ITerrainInfo> afterBlit)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ScatterInternal(Il2CppSystem.Func<ITerrainInfo, RenderTexture> terrainToRT, string operationName, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Il2CppSystem.Action<ITerrainInfo> beforeBlit, [Optional] Il2CppSystem.Action<ITerrainInfo> afterBlit)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Gather(Il2CppSystem.Func<ITerrainInfo, Texture> terrainSource, Color defaultColor, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Il2CppSystem.Action<ITerrainInfo> beforeBlit, [Optional] Il2CppSystem.Action<ITerrainInfo> afterBlit)
	{
		if ((object)terrainSource != null)
		{
			GatherInternal(terrainSource, defaultColor, "PaintContext.Gather", blitMaterial, blitPass, beforeBlit, afterBlit);
		}
	}

	public void Scatter(Il2CppSystem.Func<ITerrainInfo, RenderTexture> terrainDest, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Il2CppSystem.Action<ITerrainInfo> beforeBlit, [Optional] Il2CppSystem.Action<ITerrainInfo> afterBlit)
	{
		if ((object)terrainDest != null)
		{
			ScatterInternal(terrainDest, "PaintContext.Scatter", blitMaterial, blitPass, beforeBlit, afterBlit);
		}
	}

	public void GatherHeightmap()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ScatterHeightmap(string editorUndoName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void GatherHoles()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ScatterHoles(string editorUndoName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void GatherNormals()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public SplatmapUserData GetTerrainLayerUserData(ITerrainInfo context, [Optional] TerrainLayer terrainLayer, [Optional] bool addLayerIfDoesntExist)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void GatherAlphamap(TerrainLayer inputLayer, [Optional] bool addLayerIfDoesntExist)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ScatterAlphamap(string editorUndoName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void OnTerrainPainted(ITerrainInfo tile, ToolAction action)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ApplyDelayedActions()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
