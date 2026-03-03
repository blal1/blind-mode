using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine;

public struct OverlapBoxCommand
{
	private delegate void ScheduleOverlapBoxBatch_InjectedDelegate(IntPtr parameters, IntPtr commands, int commandLen, IntPtr result, int resultLen, int minCommandsPerJob, int maxHits, [Out] IntPtr ret);

	public Vector3 _003Ccenter_003Ek__BackingField;

	public Vector3 _003ChalfExtents_003Ek__BackingField;

	public Quaternion _003Corientation_003Ek__BackingField;

	public PhysicsScene _003CphysicsScene_003Ek__BackingField;

	private static readonly ScheduleOverlapBoxBatch_InjectedDelegate ScheduleOverlapBoxBatch_InjectedDelegateField = IL2CPP.ResolveICall<ScheduleOverlapBoxBatch_InjectedDelegate>("UnityEngine.OverlapBoxCommand::ScheduleOverlapBoxBatch_Injected");

	public Vector3 center
	{
		get
		{
			return _003Ccenter_003Ek__BackingField;
		}
		set
		{
			_003Ccenter_003Ek__BackingField = value;
		}
	}

	public Vector3 halfExtents
	{
		get
		{
			return _003ChalfExtents_003Ek__BackingField;
		}
		set
		{
			_003ChalfExtents_003Ek__BackingField = value;
		}
	}

	public Quaternion orientation
	{
		get
		{
			return _003Corientation_003Ek__BackingField;
		}
		set
		{
			_003Corientation_003Ek__BackingField = value;
		}
	}

	public PhysicsScene physicsScene
	{
		get
		{
			return _003CphysicsScene_003Ek__BackingField;
		}
		set
		{
			_003CphysicsScene_003Ek__BackingField = value;
		}
	}

	public unsafe static JobHandle ScheduleOverlapBoxBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
	{
		ScheduleOverlapBoxBatch_Injected(ref parameters, commands, commandLen, result, resultLen, minCommandsPerJob, maxHits, out var ret);
		return ret;
	}

	public unsafe static void ScheduleOverlapBoxBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret)
	{
		ScheduleOverlapBoxBatch_InjectedDelegateField((nint)Unsafe.AsPointer(ref parameters), (nint)commands, commandLen, (nint)result, resultLen, minCommandsPerJob, maxHits, (nint)Unsafe.AsPointer(ref ret));
	}
}
