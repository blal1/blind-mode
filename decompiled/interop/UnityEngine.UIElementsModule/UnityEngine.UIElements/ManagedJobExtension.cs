using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000275")]
internal static class ManagedJobExtension
{
	[Token(Token = "0x6001125")]
	public static JobHandle ScheduleOrRunJob<T>(this T jobData, int arrayLength, int innerloopBatchCount, [Optional] JobHandle dependsOn) where T : struct, IJobParallelFor
	{
		return default(JobHandle);
	}
}
