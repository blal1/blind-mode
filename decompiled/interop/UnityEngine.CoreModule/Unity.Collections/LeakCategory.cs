namespace Unity.Collections;

public enum LeakCategory
{
	Invalid,
	Malloc,
	TempJob,
	Persistent,
	LightProbesQuery,
	NativeTest,
	MeshDataArray,
	TransformAccessArray,
	NavMeshQuery
}
