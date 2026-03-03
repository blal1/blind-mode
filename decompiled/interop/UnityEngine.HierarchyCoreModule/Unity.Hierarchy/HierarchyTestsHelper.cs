using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace Unity.Hierarchy;

public static class HierarchyTestsHelper
{
	public enum SortOrder
	{
		Ascending,
		Descending
	}

	private delegate int GetNodeTypeDelegate(System.IntPtr type);

	private delegate int GenerateNodesTree_InjectedDelegate(System.IntPtr hierarchy, [In] System.IntPtr root, int width, int depth, int maxCount);

	private delegate void GenerateNodesCount_InjectedDelegate(System.IntPtr hierarchy, [In] System.IntPtr root, int count, int width, int depth);

	private delegate void GenerateSortIndex_InjectedDelegate(System.IntPtr hierarchy, [In] System.IntPtr root, SortOrder order);

	private delegate void SetNextHierarchyNodeId_InjectedDelegate(System.IntPtr hierarchy, int id);

	private delegate void GetRegisteredNodeTypes_InjectedDelegate(System.IntPtr hierarchy, [Out] System.IntPtr ret);

	private delegate int GetCapacity_InjectedDelegate(System.IntPtr hierarchy);

	private delegate int GetVersion_InjectedDelegate(System.IntPtr hierarchy);

	private delegate int GetChildrenCapacity_InjectedDelegate(System.IntPtr hierarchy, [In] System.IntPtr node);

	private delegate System.IntPtr GetHierarchyScriptingObject_InjectedDelegate(System.IntPtr hierarchy);

	private delegate System.IntPtr GetHierarchyFlattenedScriptingObject_InjectedDelegate(System.IntPtr hierarchyFlattened);

	private delegate System.IntPtr GetHierarchyViewModelScriptingObject_InjectedDelegate(System.IntPtr viewModel);

	private delegate System.IntPtr GetHierarchyCommandListScriptingObject_InjectedDelegate(System.IntPtr cmdList);

	private static readonly GetNodeTypeDelegate GetNodeTypeDelegateField = IL2CPP.ResolveICall<GetNodeTypeDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetNodeType");

	private static readonly GenerateNodesTree_InjectedDelegate GenerateNodesTree_InjectedDelegateField = IL2CPP.ResolveICall<GenerateNodesTree_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GenerateNodesTree_Injected");

	private static readonly GenerateNodesCount_InjectedDelegate GenerateNodesCount_InjectedDelegateField = IL2CPP.ResolveICall<GenerateNodesCount_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GenerateNodesCount_Injected");

	private static readonly GenerateSortIndex_InjectedDelegate GenerateSortIndex_InjectedDelegateField = IL2CPP.ResolveICall<GenerateSortIndex_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GenerateSortIndex_Injected");

	private static readonly SetNextHierarchyNodeId_InjectedDelegate SetNextHierarchyNodeId_InjectedDelegateField = IL2CPP.ResolveICall<SetNextHierarchyNodeId_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::SetNextHierarchyNodeId_Injected");

	private static readonly GetRegisteredNodeTypes_InjectedDelegate GetRegisteredNodeTypes_InjectedDelegateField = IL2CPP.ResolveICall<GetRegisteredNodeTypes_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetRegisteredNodeTypes_Injected");

	private static readonly GetCapacity_InjectedDelegate GetCapacity_InjectedDelegateField = IL2CPP.ResolveICall<GetCapacity_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetCapacity_Injected");

	private static readonly GetVersion_InjectedDelegate GetVersion_InjectedDelegateField = IL2CPP.ResolveICall<GetVersion_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetVersion_Injected");

	private static readonly GetChildrenCapacity_InjectedDelegate GetChildrenCapacity_InjectedDelegateField = IL2CPP.ResolveICall<GetChildrenCapacity_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetChildrenCapacity_Injected");

	private static readonly GetHierarchyScriptingObject_InjectedDelegate GetHierarchyScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetHierarchyScriptingObject_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetHierarchyScriptingObject_Injected");

	private static readonly GetHierarchyFlattenedScriptingObject_InjectedDelegate GetHierarchyFlattenedScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetHierarchyFlattenedScriptingObject_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetHierarchyFlattenedScriptingObject_Injected");

	private static readonly GetHierarchyViewModelScriptingObject_InjectedDelegate GetHierarchyViewModelScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetHierarchyViewModelScriptingObject_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetHierarchyViewModelScriptingObject_Injected");

	private static readonly GetHierarchyCommandListScriptingObject_InjectedDelegate GetHierarchyCommandListScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetHierarchyCommandListScriptingObject_InjectedDelegate>("Unity.Hierarchy.HierarchyTestsHelper::GetHierarchyCommandListScriptingObject_Injected");

	public static int GenerateNodesTree(Hierarchy hierarchy, [In] ref HierarchyNode root, int width, int depth, [Optional] int maxCount)
	{
		return GenerateNodesTree_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), ref root, width, depth, maxCount);
	}

	public static void GenerateNodesCount(Hierarchy hierarchy, [In] ref HierarchyNode root, int count, int width, int depth)
	{
		GenerateNodesCount_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), ref root, count, width, depth);
	}

	public static void GenerateSortIndex(Hierarchy hierarchy, [In] ref HierarchyNode root, SortOrder order)
	{
		GenerateSortIndex_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), ref root, order);
	}

	public static void SetNextHierarchyNodeId(Hierarchy hierarchy, int id)
	{
		SetNextHierarchyNodeId_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), id);
	}

	public static int GetNodeType<T>() where T : HierarchyNodeTypeHandlerBase
	{
		return GetNodeType(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public static int GetNodeType(Il2CppSystem.Type type)
	{
		return GetNodeTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public unsafe static Il2CppStructArray<int> GetRegisteredNodeTypes(Hierarchy hierarchy)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			GetRegisteredNodeTypes_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public static int GetCapacity(Hierarchy hierarchy)
	{
		return GetCapacity_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy));
	}

	public static int GetVersion(Hierarchy hierarchy)
	{
		return GetVersion_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy));
	}

	public static int GetChildrenCapacity(Hierarchy hierarchy, [In] ref HierarchyNode node)
	{
		return GetChildrenCapacity_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy), ref node);
	}

	public static bool SearchMatch(HierarchyViewModel model, [In] ref HierarchyNode node)
	{
		return model.Hierarchy.GetNodeTypeHandlerBase(ref node)?.Internal_SearchMatch(ref node) ?? false;
	}

	public static Il2CppSystem.Object GetHierarchyScriptingObject(Hierarchy hierarchy)
	{
		return GetHierarchyScriptingObject_Injected((hierarchy == null) ? ((System.IntPtr)0) : Hierarchy.BindingsMarshaller.ConvertToNative(hierarchy));
	}

	public static Il2CppSystem.Object GetHierarchyFlattenedScriptingObject(HierarchyFlattened hierarchyFlattened)
	{
		return GetHierarchyFlattenedScriptingObject_Injected((hierarchyFlattened == null) ? ((System.IntPtr)0) : HierarchyFlattened.BindingsMarshaller.ConvertToNative(hierarchyFlattened));
	}

	public static Il2CppSystem.Object GetHierarchyViewModelScriptingObject(HierarchyViewModel viewModel)
	{
		return GetHierarchyViewModelScriptingObject_Injected((viewModel == null) ? ((System.IntPtr)0) : HierarchyViewModel.BindingsMarshaller.ConvertToNative(viewModel));
	}

	public static Il2CppSystem.Object GetHierarchyCommandListScriptingObject(HierarchyCommandList cmdList)
	{
		return GetHierarchyCommandListScriptingObject_Injected((cmdList == null) ? ((System.IntPtr)0) : HierarchyCommandList.BindingsMarshaller.ConvertToNative(cmdList));
	}

	public unsafe static int GenerateNodesTree_Injected(System.IntPtr hierarchy, [In] ref HierarchyNode root, int width, int depth, int maxCount)
	{
		return GenerateNodesTree_InjectedDelegateField(hierarchy, (nint)Unsafe.AsPointer(ref root), width, depth, maxCount);
	}

	public unsafe static void GenerateNodesCount_Injected(System.IntPtr hierarchy, [In] ref HierarchyNode root, int count, int width, int depth)
	{
		GenerateNodesCount_InjectedDelegateField(hierarchy, (nint)Unsafe.AsPointer(ref root), count, width, depth);
	}

	public unsafe static void GenerateSortIndex_Injected(System.IntPtr hierarchy, [In] ref HierarchyNode root, SortOrder order)
	{
		GenerateSortIndex_InjectedDelegateField(hierarchy, (nint)Unsafe.AsPointer(ref root), order);
	}

	public static void SetNextHierarchyNodeId_Injected(System.IntPtr hierarchy, int id)
	{
		SetNextHierarchyNodeId_InjectedDelegateField(hierarchy, id);
	}

	public unsafe static void GetRegisteredNodeTypes_Injected(System.IntPtr hierarchy, out BlittableArrayWrapper ret)
	{
		GetRegisteredNodeTypes_InjectedDelegateField(hierarchy, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int GetCapacity_Injected(System.IntPtr hierarchy)
	{
		return GetCapacity_InjectedDelegateField(hierarchy);
	}

	public static int GetVersion_Injected(System.IntPtr hierarchy)
	{
		return GetVersion_InjectedDelegateField(hierarchy);
	}

	public unsafe static int GetChildrenCapacity_Injected(System.IntPtr hierarchy, [In] ref HierarchyNode node)
	{
		return GetChildrenCapacity_InjectedDelegateField(hierarchy, (nint)Unsafe.AsPointer(ref node));
	}

	public static Il2CppSystem.Object GetHierarchyScriptingObject_Injected(System.IntPtr hierarchy)
	{
		System.IntPtr intPtr = GetHierarchyScriptingObject_InjectedDelegateField(hierarchy);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object GetHierarchyFlattenedScriptingObject_Injected(System.IntPtr hierarchyFlattened)
	{
		System.IntPtr intPtr = GetHierarchyFlattenedScriptingObject_InjectedDelegateField(hierarchyFlattened);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object GetHierarchyViewModelScriptingObject_Injected(System.IntPtr viewModel)
	{
		System.IntPtr intPtr = GetHierarchyViewModelScriptingObject_InjectedDelegateField(viewModel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object GetHierarchyCommandListScriptingObject_Injected(System.IntPtr cmdList)
	{
		System.IntPtr intPtr = GetHierarchyCommandListScriptingObject_InjectedDelegateField(cmdList);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}
}
