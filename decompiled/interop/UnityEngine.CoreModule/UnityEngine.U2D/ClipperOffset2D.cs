using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Collections;

namespace UnityEngine.U2D;

public struct ClipperOffset2D
{
	public enum JoinType
	{
		jtSquare,
		jtRound,
		jtMiter
	}

	public enum EndType
	{
		etClosedPolygon,
		etClosedLine,
		etOpenButt,
		etOpenSquare,
		etOpenRound
	}

	public struct PathArguments
	{
	}

	public struct Solution
	{
	}

	private delegate void Internal_ExecuteDelegate([Out] IntPtr outClippedPoints, [Out] IntPtr outClippedPointsCount, [Out] IntPtr outClippedPathSizes, [Out] IntPtr outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, double inDelta, double inMiterLimit, double inRoundPrecision, double inArcTolerance, double inIntScale, bool useRounding);

	private delegate void Internal_Execute_CleanupDelegate(IntPtr inPoints, IntPtr inPathSizes);

	private static readonly Internal_ExecuteDelegate Internal_ExecuteDelegateField = IL2CPP.ResolveICall<Internal_ExecuteDelegate>("UnityEngine.U2D.ClipperOffset2D::Internal_Execute");

	private static readonly Internal_Execute_CleanupDelegate Internal_Execute_CleanupDelegateField = IL2CPP.ResolveICall<Internal_Execute_CleanupDelegate>("UnityEngine.U2D.ClipperOffset2D::Internal_Execute_Cleanup");

	public static void Execute(ref Solution solution, NativeArray<Vector2> inPoints, NativeArray<int> inPathSizes, NativeArray<PathArguments> inPathArguments, Allocator inSolutionAllocator, [Optional] double inDelta, [Optional] double inMiterLimit, [Optional] double inRoundPrecision, [Optional] double inArcTolerance, [Optional] double inIntScale, [Optional] bool useRounding)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static void Internal_Execute(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, double inDelta, double inMiterLimit, double inRoundPrecision, double inArcTolerance, double inIntScale, bool useRounding)
	{
		Internal_ExecuteDelegateField((nint)Unsafe.AsPointer(ref outClippedPoints), (nint)Unsafe.AsPointer(ref outClippedPointsCount), (nint)Unsafe.AsPointer(ref outClippedPathSizes), (nint)Unsafe.AsPointer(ref outClippedPathCount), inPoints, inPointCount, inPathSizes, inPathArguments, inPathCount, inDelta, inMiterLimit, inRoundPrecision, inArcTolerance, inIntScale, useRounding);
	}

	public static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
	{
		Internal_Execute_CleanupDelegateField(inPoints, inPathSizes);
	}
}
