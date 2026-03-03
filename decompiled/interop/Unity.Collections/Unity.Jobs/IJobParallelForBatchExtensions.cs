using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs;

[Token(Token = "0x2000007")]
public static class IJobParallelForBatchExtensions
{
	[Token(Token = "0x2000008")]
	internal struct JobParallelForBatchProducer<T> where T : struct, IJobParallelForBatch
	{
		[Token(Token = "0x2000009")]
		internal delegate void ExecuteJobFunction(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData;

		[Token(Token = "0x600000D")]
		[BurstDiscard]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x600000E")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
		}
	}

	[Token(Token = "0x6000009")]
	public static void EarlyJobInit<T>() where T : struct, IJobParallelForBatch
	{
	}

	[Token(Token = "0x600000A")]
	private static IntPtr GetReflectionData<T>() where T : struct, IJobParallelForBatch
	{
		return default(IntPtr);
	}

	[Token(Token = "0x600000B")]
	public static JobHandle ScheduleParallel<T>(this T jobData, int arrayLength, int indicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct, IJobParallelForBatch
	{
		return default(JobHandle);
	}

	[Token(Token = "0x600000C")]
	public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int indicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct, IJobParallelForBatch
	{
		return default(JobHandle);
	}
}
