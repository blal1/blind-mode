using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.U2D;

public struct Clipper2D
{
	public enum ClipType
	{
		ctIntersection,
		ctUnion,
		ctDifference,
		ctXor
	}

	public enum PolyType
	{
		ptSubject,
		ptClip
	}

	public enum PolyFillType
	{
		pftEvenOdd,
		pftNonZero,
		pftPositive,
		pftNegative
	}

	public enum InitOptions
	{
		ioDefault = 0,
		oReverseSolution = 1,
		ioStrictlySimple = 2,
		ioPreserveCollinear = 4
	}

	public struct Solution
	{
	}

	private delegate void Internal_Execute_CleanupDelegate(IntPtr inPoints, IntPtr inPathSizes);

	private static readonly Internal_Execute_CleanupDelegate Internal_Execute_CleanupDelegateField = IL2CPP.ResolveICall<Internal_Execute_CleanupDelegate>("UnityEngine.U2D.Clipper2D::Internal_Execute_Cleanup");

	public static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
	{
		Internal_Execute_CleanupDelegateField(inPoints, inPathSizes);
	}
}
