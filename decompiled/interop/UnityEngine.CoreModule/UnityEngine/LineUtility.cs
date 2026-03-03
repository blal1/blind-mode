using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public sealed class LineUtility
{
	private delegate void GeneratePointsToKeep3DDelegate(System.IntPtr pointsList, float tolerance, System.IntPtr pointsToKeepList);

	private delegate void GeneratePointsToKeep2DDelegate(System.IntPtr pointsList, float tolerance, System.IntPtr pointsToKeepList);

	private delegate void GenerateSimplifiedPoints3DDelegate(System.IntPtr pointsList, float tolerance, System.IntPtr simplifiedPoints);

	private delegate void GenerateSimplifiedPoints2DDelegate(System.IntPtr pointsList, float tolerance, System.IntPtr simplifiedPoints);

	private static readonly GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");

	private static readonly GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");

	private static readonly GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");

	private static readonly GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

	public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
	{
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		if (pointsToKeep == null)
		{
			throw new Il2CppSystem.ArgumentNullException("pointsToKeep");
		}
		GeneratePointsToKeep3D(points, tolerance, pointsToKeep);
	}

	public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints)
	{
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		if (simplifiedPoints == null)
		{
			throw new Il2CppSystem.ArgumentNullException("simplifiedPoints");
		}
		GenerateSimplifiedPoints3D(points, tolerance, simplifiedPoints);
	}

	public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
	{
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		if (pointsToKeep == null)
		{
			throw new Il2CppSystem.ArgumentNullException("pointsToKeep");
		}
		GeneratePointsToKeep2D(points, tolerance, pointsToKeep);
	}

	public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints)
	{
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		if (simplifiedPoints == null)
		{
			throw new Il2CppSystem.ArgumentNullException("simplifiedPoints");
		}
		GenerateSimplifiedPoints2D(points, tolerance, simplifiedPoints);
	}

	public static void GeneratePointsToKeep3D(Il2CppSystem.Object pointsList, float tolerance, Il2CppSystem.Object pointsToKeepList)
	{
		GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsToKeepList));
	}

	public static void GeneratePointsToKeep2D(Il2CppSystem.Object pointsList, float tolerance, Il2CppSystem.Object pointsToKeepList)
	{
		GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsToKeepList));
	}

	public static void GenerateSimplifiedPoints3D(Il2CppSystem.Object pointsList, float tolerance, Il2CppSystem.Object simplifiedPoints)
	{
		GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simplifiedPoints));
	}

	public static void GenerateSimplifiedPoints2D(Il2CppSystem.Object pointsList, float tolerance, Il2CppSystem.Object simplifiedPoints)
	{
		GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simplifiedPoints));
	}
}
