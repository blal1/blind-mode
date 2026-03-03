using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Events;

[System.Serializable]
public class PersistentCallGroup : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Calls;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0;

	public unsafe List<PersistentCall> m_Calls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Calls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PersistentCall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Calls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public int Count => m_Calls.Count;

	static PersistentCallGroup()
	{
		Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCallGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr);
		NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, "m_Calls");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100667164);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222832, XrefRangeEnd = 1222840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PersistentCallGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1222859, RefRangeEnd = 1222862, XrefRangeStart = 1222840, XrefRangeEnd = 1222859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)invokableList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEventBase);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PersistentCallGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PersistentCall GetListener(int index)
	{
		return m_Calls[index];
	}

	public IEnumerable<PersistentCall> GetListeners()
	{
		return (IEnumerable<PersistentCall>)(object)m_Calls;
	}

	public void AddListener()
	{
		m_Calls.Add(new PersistentCall());
	}

	public void AddListener(PersistentCall call)
	{
		m_Calls.Add(call);
	}

	public void RemoveListener(int index)
	{
		m_Calls.RemoveAt(index);
	}

	public void Clear()
	{
		m_Calls.Clear();
	}

	public void RegisterEventPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.EventDefined;
	}

	public void RegisterVoidPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.Void;
	}

	public void RegisterObjectPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, Object argument, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.Object;
		listener.arguments.unityObjectArgument = argument;
	}

	public void RegisterIntPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, int argument, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.Int;
		listener.arguments.intArgument = argument;
	}

	public void RegisterFloatPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, float argument, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.Float;
		listener.arguments.floatArgument = argument;
	}

	public void RegisterStringPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, string argument, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.String;
		listener.arguments.stringArgument = argument;
	}

	public void RegisterBoolPersistentListener(int index, Object targetObj, Il2CppSystem.Type targetObjType, bool argument, string methodName)
	{
		PersistentCall listener = GetListener(index);
		listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
		listener.mode = PersistentListenerMode.Bool;
		listener.arguments.boolArgument = argument;
	}

	public void UnregisterPersistentListener(int index)
	{
		PersistentCall listener = GetListener(index);
		listener.UnregisterPersistentListener();
	}

	public unsafe void RemoveListeners(Object target, string methodName)
	{
		List<PersistentCall> list = new List<PersistentCall>();
		for (int i = 0; i < m_Calls.Count; i++)
		{
			if (m_Calls[i].target == target && m_Calls[i].methodName == methodName)
			{
				list.Add(m_Calls[i]);
			}
		}
		m_Calls.RemoveAll(new Il2CppSystem.Predicate<PersistentCall>(list, (nint)__ldvirtftn(List<PersistentCall>.Contains)));
	}
}
