namespace Vektorel.RealLifeInterfaceSample1.Interfaces
{
    interface ITrackable : ITimeAuditable, IUserAuditable
    {
    }

    interface ITimeAuditable : ICreatedAt, IModifiedAt
    {

    }

    interface IUserAuditable : ICreatedBy, IModifiedBy
    {

    }

    interface ICreatedBy
    {
        public string CreatedBy { get; set; }
    }

    interface IModifiedBy
    {
        public string ModifiedBy { get; set; }
    }

    interface ICreatedAt 
    {
        public DateTime CreatedAt { get; set; }
    }

    interface IModifiedAt 
    {
        public DateTime ModifiedAt { get; set; }
    }
}
