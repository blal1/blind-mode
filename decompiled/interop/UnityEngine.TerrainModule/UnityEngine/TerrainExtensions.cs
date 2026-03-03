using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class TerrainExtensions
{
	private delegate void UpdateGIMaterialsForTerrain_InjectedDelegate(int terrainInstanceID, [In] System.IntPtr uvBounds);

	private static readonly UpdateGIMaterialsForTerrain_InjectedDelegate UpdateGIMaterialsForTerrain_InjectedDelegateField = IL2CPP.ResolveICall<UpdateGIMaterialsForTerrain_InjectedDelegate>("UnityEngine.TerrainExtensions::UpdateGIMaterialsForTerrain_Injected");

	public static void UpdateGIMaterials(Terrain terrain)
	{
		if (terrain.terrainData == null)
		{
			throw new Il2CppSystem.ArgumentException("Invalid terrainData.");
		}
		UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect(0f, 0f, 1f, 1f));
	}

	public static void UpdateGIMaterials(Terrain terrain, int x, int y, int width, int height)
	{
		if (terrain.terrainData == null)
		{
			throw new Il2CppSystem.ArgumentException("Invalid terrainData.");
		}
		float num = terrain.terrainData.alphamapWidth;
		float num2 = terrain.terrainData.alphamapHeight;
		UpdateGIMaterialsForTerrain(terrain.GetInstanceID(), new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
	}

	public static void UpdateGIMaterialsForTerrain(int terrainInstanceID, Rect uvBounds)
	{
		UpdateGIMaterialsForTerrain_Injected(terrainInstanceID, ref uvBounds);
	}

	public unsafe static void UpdateGIMaterialsForTerrain_Injected(int terrainInstanceID, [In] ref Rect uvBounds)
	{
		UpdateGIMaterialsForTerrain_InjectedDelegateField(terrainInstanceID, (nint)Unsafe.AsPointer(ref uvBounds));
	}
}
