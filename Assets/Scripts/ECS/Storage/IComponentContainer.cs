using EntityID = System.UInt16;

namespace ECS.Storage
{
	public interface IComponentContainer 
	{

	}

	public interface IComponentContainer<T> : IComponentContainer
		where T : struct, IDataComponent
	{
		T[] Data { get; }

		T Get(EntityID entity);
		void Set(EntityID entity, T dataEntry);
	}
}