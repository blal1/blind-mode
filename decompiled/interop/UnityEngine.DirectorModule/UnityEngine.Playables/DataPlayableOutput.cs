using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct DataPlayableOutput
{
	private delegate System.IntPtr InternalGetTypeDelegate(System.IntPtr handle);

	private delegate void InternalSetStreamDelegate(System.IntPtr handle, System.IntPtr stream);

	private delegate System.IntPtr InternalGetStreamDelegate(System.IntPtr handle);

	private delegate bool InternalGetConnectionChangedDelegate(System.IntPtr handle);

	private delegate void InternalClearConnectionChangedDelegate(System.IntPtr handle);

	private delegate System.IntPtr InternalGetPlayer_InjectedDelegate(System.IntPtr handle);

	private delegate void InternalSetPlayer_InjectedDelegate(System.IntPtr handle, System.IntPtr player);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallOnPlayerChanged_Private_Static_Void_PlayableOutputHandle_Object_Object_0;

	[FieldOffset(0)]
	public PlayableOutputHandle m_Handle;

	private static readonly InternalGetTypeDelegate InternalGetTypeDelegateField;

	private static readonly InternalSetStreamDelegate InternalSetStreamDelegateField;

	private static readonly InternalGetStreamDelegate InternalGetStreamDelegateField;

	private static readonly InternalGetConnectionChangedDelegate InternalGetConnectionChangedDelegateField;

	private static readonly InternalClearConnectionChangedDelegate InternalClearConnectionChangedDelegateField;

	private static readonly InternalGetPlayer_InjectedDelegate InternalGetPlayer_InjectedDelegateField;

	private static readonly InternalSetPlayer_InjectedDelegate InternalSetPlayer_InjectedDelegateField;

	public static DataPlayableOutput Null => new DataPlayableOutput(PlayableOutputHandle.Null);

	static DataPlayableOutput()
	{
		Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "DataPlayableOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_Internal_CallOnPlayerChanged_Private_Static_Void_PlayableOutputHandle_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr, 100663299);
		InternalGetTypeDelegateField = IL2CPP.ResolveICall<InternalGetTypeDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalGetType");
		InternalSetStreamDelegateField = IL2CPP.ResolveICall<InternalSetStreamDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalSetStream");
		InternalGetStreamDelegateField = IL2CPP.ResolveICall<InternalGetStreamDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalGetStream");
		InternalGetConnectionChangedDelegateField = IL2CPP.ResolveICall<InternalGetConnectionChangedDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalGetConnectionChanged");
		InternalClearConnectionChangedDelegateField = IL2CPP.ResolveICall<InternalClearConnectionChangedDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalClearConnectionChanged");
		InternalGetPlayer_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetPlayer_InjectedDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalGetPlayer_Injected");
		InternalSetPlayer_InjectedDelegateField = IL2CPP.ResolveICall<InternalSetPlayer_InjectedDelegate>("UnityEngine.Playables.DataPlayableOutput::InternalSetPlayer_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241866, RefRangeEnd = 1241868, XrefRangeStart = 1241857, XrefRangeEnd = 1241866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataPlayableOutput(PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableOutputHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241868, XrefRangeEnd = 1241886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, Il2CppSystem.Object previousPlayer, Il2CppSystem.Object currentPlayer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentPlayer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallOnPlayerChanged_Private_Static_Void_PlayableOutputHandle_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataPlayableOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public Il2CppSystem.Type GetStreamType()
	{
		return InternalGetType(ref m_Handle);
	}

	public bool GetConnectionChanged()
	{
		return InternalGetConnectionChanged(ref m_Handle);
	}

	public void ClearConnectionChanged()
	{
		InternalClearConnectionChanged(ref m_Handle);
	}

	public TDataStream GetDataStream<TDataStream>() where TDataStream : new()
	{
		Il2CppSystem.Object @object = InternalGetStream(ref m_Handle);
		if (((Il2CppObjectBase)@object).TryCast<TDataStream>() != null)
		{
			return ((Il2CppObjectBase)@object).Cast<TDataStream>();
		}
		return default(TDataStream);
	}

	public void SetDataStream<TDataStream>(TDataStream stream) where TDataStream : new()
	{
		Il2CppSystem.Type streamType = GetStreamType();
		if (!streamType.IsAssignableFrom(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TDataStream>())))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} is of the wrong type. This output only accepts streams with type {1} or inheriting from type {2}", "stream", streamType, streamType), "stream");
		}
		InternalSetStream(ref m_Handle, (Il2CppSystem.Object)(object)stream);
	}

	public static DataPlayableOutput Create<TDataStream>(PlayableGraph graph, string name) where TDataStream : new()
	{
		if (!DataPlayableOutputExtensions.InternalCreateDataOutput(ref graph, name, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TDataStream>()), out var handle))
		{
			return Null;
		}
		return new DataPlayableOutput(handle);
	}

	public static implicit operator PlayableOutput(DataPlayableOutput output)
	{
		return new PlayableOutput(output.GetHandle());
	}

	public static explicit operator DataPlayableOutput(PlayableOutput output)
	{
		return new DataPlayableOutput(output.GetHandle());
	}

	public IDataPlayer GetPlayer()
	{
		return ((Il2CppObjectBase)InternalGetPlayer(ref m_Handle)).TryCast<IDataPlayer>();
	}

	public void SetPlayer<TPlayer>(TPlayer player) where TPlayer : Object
	{
		InternalSetPlayer(ref m_Handle, player);
	}

	public static Object InternalGetPlayer(ref PlayableOutputHandle handle)
	{
		return Unmarshal.UnmarshalUnityObject<Object>(InternalGetPlayer_Injected(ref handle));
	}

	public static void InternalSetPlayer(ref PlayableOutputHandle handle, Object player)
	{
		InternalSetPlayer_Injected(ref handle, Object.MarshalledUnityObject.Marshal(player));
	}

	public unsafe static Il2CppSystem.Type InternalGetType(ref PlayableOutputHandle handle)
	{
		System.IntPtr intPtr = InternalGetTypeDelegateField((nint)Unsafe.AsPointer(ref handle));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	public unsafe static void InternalSetStream(ref PlayableOutputHandle handle, Il2CppSystem.Object stream)
	{
		InternalSetStreamDelegateField((nint)Unsafe.AsPointer(ref handle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream));
	}

	public unsafe static Il2CppSystem.Object InternalGetStream(ref PlayableOutputHandle handle)
	{
		System.IntPtr intPtr = InternalGetStreamDelegateField((nint)Unsafe.AsPointer(ref handle));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public unsafe static bool InternalGetConnectionChanged(ref PlayableOutputHandle handle)
	{
		return InternalGetConnectionChangedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static void InternalClearConnectionChanged(ref PlayableOutputHandle handle)
	{
		InternalClearConnectionChangedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static System.IntPtr InternalGetPlayer_Injected(ref PlayableOutputHandle handle)
	{
		return InternalGetPlayer_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static void InternalSetPlayer_Injected(ref PlayableOutputHandle handle, System.IntPtr player)
	{
		InternalSetPlayer_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle), player);
	}
}
