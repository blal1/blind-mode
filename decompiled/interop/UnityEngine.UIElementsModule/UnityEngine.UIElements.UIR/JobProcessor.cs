using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000510")]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererJobProcessor.h")]
internal static class JobProcessor
{
	[Token(Token = "0x600245F")]
	[Address(RVA = "0x2A31CE0", Offset = "0x2A30EE0", VA = "0x182A31CE0")]
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount)
	{
		return default(JobHandle);
	}

	[Token(Token = "0x6002460")]
	[Address(RVA = "0x2A31B80", Offset = "0x2A30D80", VA = "0x182A31B80")]
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount)
	{
		return default(JobHandle);
	}

	[Token(Token = "0x6002461")]
	[Address(RVA = "0x2A31C30", Offset = "0x2A30E30", VA = "0x182A31C30")]
	internal static JobHandle ScheduleCopyMeshJobs(IntPtr buffer, int jobCount)
	{
		return default(JobHandle);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6002462")]
	[Address(RVA = "0x2A31C90", Offset = "0x2A30E90", VA = "0x182A31C90")]
	private static extern void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6002463")]
	[Address(RVA = "0x2A31B30", Offset = "0x2A30D30", VA = "0x182A31B30")]
	private static extern void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6002464")]
	[Address(RVA = "0x2A31BE0", Offset = "0x2A30DE0", VA = "0x182A31BE0")]
	private static extern void ScheduleCopyMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret);
}
