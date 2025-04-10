using AutoMapper;

namespace Notes.Application.Common.Mappings
{
    public interface IMapWith<T>
    {
        void Mappin(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
